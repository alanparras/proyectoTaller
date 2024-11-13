using ProyectoTallerG8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace ProyectoTallerG8
{
    public partial class FormRecibos : Form
    {
        public FormRecibos()
        {
            InitializeComponent();
        }

        private void FormRecibos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet11.cabeceras_individuales' Puede moverla o quitarla según sea necesario.
            this.cabeceras_individualesTableAdapter.Fill(this.dataSet11.cabeceras_individuales);
            // TODO: esta línea de código carga datos en la tabla 'dataSet11.detalles_individuales' Puede moverla o quitarla según sea necesario.
            //this.detalles_individualesTableAdapter.Fill(this.dataSet11.detalles_individuales);
        }

        private void vcDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el clic fue en la columna "Seleccionar"
            if (vcDataGridView.Columns[e.ColumnIndex].Name == "select_1" && e.RowIndex >= 0)
            {
                // Obtén el ID de la Venta desde la fila seleccionada
                int ventaId = Convert.ToInt32(vcDataGridView.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);

                // Llama a la función para cargar los detalles de la venta
                CargarDetallesVenta(ventaId);
            }
        }

        private void CargarDetallesVenta(int ventaId)
        {
            // Define la conexión a la base de datos
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["pruebaLogin.Properties.Settings.db_piazza_giovanniConnectionString"].ConnectionString;
            string query = @"
            SELECT p.nombre AS nombre, vd.cantidad AS cantidad, p.descripcion AS descripcion, p.precio AS precioU
            FROM ventas_detalle vd
            JOIN productos_pc p ON p.id = vd.producto_id
            WHERE vd.venta_id = @ventaId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ventaId", ventaId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable detallesVenta = new DataTable();

                connection.Open();
                adapter.Fill(detallesVenta);
                connection.Close();

                // Asigna el DataTable a la tabla de la derecha (vdDataGridView)
                vdDataGridView.DataSource = detallesVenta;
            }
        }

        private void BVerPDF_Click(object sender, EventArgs e)
        {
            // Comprobar si se ha seleccionado alguna fila en el DataGridView
            if (vcDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una factura primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si no se seleccionó ninguna fila
            }

            // Obtener el ID de la Venta desde la fila seleccionada del DataGridView
            int ventaId = Convert.ToInt32(vcDataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);

            // Obtener la información de la cabecera de la venta
            string connectionString = ConfigurationManager.ConnectionStrings["pruebaLogin.Properties.Settings.db_piazza_giovanniConnectionString"].ConnectionString;
            string queryCabecera = @"
        SELECT v.fecha, v.total_venta, u.nombre AS nombre, u.apellido AS apellido, u.perfil_id as u_perfil_id
        FROM ventas_cabecera v
        JOIN usuarios u ON u.id = v.usuario_id
        WHERE v.id = @ventaId";

            DataTable cabeceraVenta = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryCabecera, connection);
                command.Parameters.AddWithValue("@ventaId", ventaId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(cabeceraVenta);
                connection.Close();
            }

            // Obtener los detalles de la venta
            string queryDetalles = @"
        SELECT p.nombre AS producto, vd.cantidad, vd.precio
        FROM ventas_detalle vd
        JOIN productos_pc p ON p.id = vd.producto_id
        WHERE vd.venta_id = @ventaId";

            DataTable detallesVenta = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryDetalles, connection);
                command.Parameters.AddWithValue("@ventaId", ventaId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(detallesVenta);
                connection.Close();
            }

            // Obtener la carpeta de descargas del usuario
            string downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";

            // Crear el documento PDF
            string pdfFilePath = Path.Combine(downloadsFolder, $"factura_{ventaId}.pdf"); // Ruta donde se guardará el archivo PDF

            using (FileStream fs = new FileStream(pdfFilePath, FileMode.Create))
            {
                using (PdfWriter writer = new PdfWriter(fs))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        // Se configura la página con tamaño A4
                        Document document = new Document(pdf);
                        document.SetMargins(20, 20, 20, 20); // Márgenes de la página

                        // Agregar título
                        document.Add(new Paragraph("Factura PC - Piazza Computacion").SetTextAlignment(TextAlignment.CENTER).SetFontSize(18));

                        // Agregar información de la cabecera
                        if (cabeceraVenta.Rows.Count > 0)
                        {
                            var cabecera = cabeceraVenta.Rows[0];
                            document.Add(new Paragraph("Fecha: " + cabecera["fecha"]));
                            
                            int perfilId = Convert.ToInt32(cabecera["u_perfil_id"]);

                            if (perfilId == 3)
                            {
                                document.Add(new Paragraph("Vendedor: " + cabecera["nombre"] + " " + cabecera["apellido"]));
                            }
                            else
                            {
                                document.Add(new Paragraph("Comprador: " + cabecera["nombre"] + " " + cabecera["apellido"]));
                            }

                            document.Add(new Paragraph("Total de Venta: $" + cabecera["total_venta"]));
                        }

                        // Agregar detalles de la venta
                        document.Add(new Paragraph("Detalles de la venta:").SetFontSize(12));
                        Table table = new Table(3);
                        table.AddHeaderCell("Producto");
                        table.AddHeaderCell("Cantidad");
                        table.AddHeaderCell("Precio");

                        foreach (DataRow row in detallesVenta.Rows)
                        {
                            table.AddCell(row["producto"].ToString());
                            table.AddCell(row["cantidad"].ToString());
                            table.AddCell(row["precio"].ToString());
                        }

                        document.Add(table);

                        // Agregar la totalización (Total de la venta)
                        document.Add(new Paragraph("Total a pagar: $" + cabeceraVenta.Rows[0]["total_venta"]).SetTextAlignment(TextAlignment.RIGHT));
                    }
                }
            }

            MessageBox.Show("Factura generada correctamente en tu carpeta de Descargas.", "Generar PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
