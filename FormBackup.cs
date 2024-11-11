using ProyectoTallerG8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoTallerG8
{
    public partial class FormBackup : Form
    {

        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["pruebaLogin.Properties.Settings.db_piazza_giovanniConnectionString"].ConnectionString;
        private string logFilePath = "last_backup_log.txt";
        public FormBackup()
        {
            InitializeComponent();
            LoadLastBackupInfo();
        }

        private void FormBackup_Load(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Selecciona la carpeta para realizar la copia de seguridad";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupFolder = folderBrowserDialog.SelectedPath;
                    string backupFileName = $"Backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                    string backupPath = Path.Combine(backupFolder, backupFileName);

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string backupQuery = $"BACKUP DATABASE db_piazza_giovanni TO DISK = @backupPath";
                            SqlCommand command = new SqlCommand(backupQuery, connection);
                            command.Parameters.AddWithValue("@backupPath", backupPath);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();

                            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            File.WriteAllText(logFilePath, $"Última copia de seguridad: {timestamp}\nArchivo: {backupPath}");

                            MessageBox.Show($"Copia de seguridad completada exitosamente!\nArchivo guardado en: {backupPath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblLastBackup.Text = $"Última copia de seguridad: {timestamp}";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error durante la exportación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "SQL Backup File (*.bak)|*.bak";
                openFileDialog.Title = "Seleccionar archivo de restauración";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupPath = openFileDialog.FileName;

                    DialogResult confirm = MessageBox.Show($"¿Quieres restaurar la base de datos desde este archivo?\n{backupPath}",
                                                            "Confirmar restauración",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {
                        try
                        {
                            progressBar.Visible = true;
                            lblProgress.Visible = true;

                            // Ejecutar restauración en segundo plano
                            await Task.Run(() =>
                            {
                                // Cambiar a la base de datos 'master' antes de iniciar la restauración
                                string masterConnectionString = new SqlConnectionStringBuilder(connectionString)
                                {
                                    InitialCatalog = "master"
                                }.ConnectionString;

                                using (SqlConnection connection = new SqlConnection(masterConnectionString))
                                {
                                    connection.Open();

                                    // Obtener el ID de la sesión actual
                                    int currentSessionId = 0;
                                    using (SqlCommand command = new SqlCommand("SELECT @@SPID;", connection))
                                    {
                                        object result = command.ExecuteScalar();
                                        if (result != null && int.TryParse(result.ToString(), out int spid))
                                        {
                                            currentSessionId = spid;
                                        }
                                        else
                                        {
                                            throw new InvalidOperationException("No se pudo determinar el ID de la sesión actual.");
                                        }
                                    }

                                    // Eliminar conexiones activas excepto la conexión actual
                                    string killConnectionsQuery = $@"
                                DECLARE @kill varchar(8000) = '';
                                SELECT @kill = @kill + 'KILL ' + CONVERT(varchar(5), session_id) + ';'
                                FROM sys.dm_exec_sessions
                                WHERE database_id = DB_ID('db_piazza_giovanni') AND session_id <> {currentSessionId};
                                EXEC(@kill);";
                                    SqlCommand killCommand = new SqlCommand(killConnectionsQuery, connection);
                                    killCommand.ExecuteNonQuery();

                                    // Poner la base de datos en modo de usuario único
                                    string setSingleUserQuery = "ALTER DATABASE db_piazza_giovanni SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                                    SqlCommand singleUserCommand = new SqlCommand(setSingleUserQuery, connection);
                                    singleUserCommand.ExecuteNonQuery();

                                    // Restaurar la base de datos desde el archivo de copia de seguridad
                                    string restoreQuery = @"
                                RESTORE DATABASE db_piazza_giovanni 
                                FROM DISK = @backupPath 
                                WITH REPLACE;";
                                    SqlCommand restoreCommand = new SqlCommand(restoreQuery, connection);
                                    restoreCommand.Parameters.AddWithValue("@backupPath", backupPath);
                                    restoreCommand.ExecuteNonQuery();

                                    // Volver a modo multiusuario
                                    string setMultiUserQuery = "ALTER DATABASE db_piazza_giovanni SET MULTI_USER;";
                                    SqlCommand multiUserCommand = new SqlCommand(setMultiUserQuery, connection);
                                    multiUserCommand.ExecuteNonQuery();

                                    connection.Close();
                                }

                                // Simulación de progreso (opcional)
                                for (int i = 0; i <= 100; i++)
                                {
                                    Invoke(new Action(() => progressBar.Value = i));
                                    Task.Delay(50).Wait(); // Simular retraso para la barra de progreso
                                }
                            });

                            MessageBox.Show("¡Base de datos restaurada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error durante la restauración: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            progressBar.Visible = false;
                            lblProgress.Visible = false;
                            progressBar.Value = 0;
                        }
                    }
                }
            }
        }


        private void LoadLastBackupInfo()
        {
            if (File.Exists(logFilePath))
            {
                string lastBackupInfo = File.ReadAllText(logFilePath);
                lblLastBackup.Text = lastBackupInfo;
            }
            else
            {
                lblLastBackup.Text = "No hay informacion de copia de seguridad disponible.";
            }
        }
    }
}
