using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;
using System.Windows.Media;
using CapaEntidades;
using CapaNegocio;
using ProyectoTallerG8.Utilidades;

namespace ProyectoTallerG8
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet11.perfiles' Puede moverla o quitarla según sea necesario.
            this.perfilesTableAdapter1.Fill(this.dataSet11.perfiles);

            // TODO: esta línea de código carga datos en la tabla 'dataSet11.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter1.Fill(this.dataSet11.usuarios);

            CBEstado.Items.Add(new OpcionSelectUsuario() { Valor = "NO", Texto = "Dado de Alta" });
            CBEstado.Items.Add(new OpcionSelectUsuario() { Valor = "SI", Texto = "Dado de Baja"});
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = 0;

            CBModificarEstado.Items.Add(new OpcionSelectUsuario() { Valor = "NO", Texto = "Dado de Alta" });
            CBModificarEstado.Items.Add(new OpcionSelectUsuario() { Valor = "SI", Texto = "Dado de Baja" });
            CBModificarEstado.DisplayMember = "Texto";
            CBModificarEstado.ValueMember = "Valor";

            List<Perfil> listaPerfil = new Perfil_negocio().Listar();
            foreach (Perfil item in listaPerfil)
            {
                CBperfiles.Items.Add(new OpcionSelectUsuario() { Valor = item.id_perfil, Texto = item.descripcion });
                CBModificarPerfil.Items.Add(new OpcionSelectUsuario() { Valor = item.id_perfil, Texto = item.descripcion });
            }
            CBperfiles.DisplayMember = "Texto";
            CBperfiles.ValueMember = "Valor";
            CBperfiles.SelectedIndex = 0;

            CBModificarPerfil.DisplayMember = "Texto";
            CBModificarPerfil.ValueMember = "Valor";
            CBModificarPerfil.SelectedIndex = 0;




            //Muestra todos los usuarios
            List<Usuario> listaUsuario = new Usuario_negocio().Listar();
            //Console.WriteLine($"Número de usuarios encontrados: {listaUsuario.Count}");
            foreach (Usuario item in listaUsuario)
            {
                usuariosDataGridView.Rows.Add(new object[] {
                    "", 
                    item.id_usuario, 
                    item.nombre, 
                    item.apellido,
                    item.objPerfil.id_perfil, 
                    item.objPerfil.descripcion, 
                    item.baja,
                    item.user, 
                    item.pass,
                    item.email, 
                    item.domicilio,
                    item.CP
                });
            }

        }

        private void VaciarCampos()
        {
            TID_user.Text = "-1";
            TNombre.Text = "";
            TApellido.Text = "";
            TEmail.Text = "";
            TPass.Text = "";
            TPassConf.Text = "";
            TUser.Text = "";
            CBperfiles.SelectedIndex = 0;
            CBEstado.SelectedIndex = 0;
            TDomicilio.Text = "";
            TCP.Text = "";
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textSearch.Text;
            if (!string.IsNullOrEmpty(searchTerm))
            {
                // Llama al método FillBySearch con el texto ingresado en el TextBox
                this.usuariosTableAdapter1.FillBySearch(this.dataSet11.usuarios, searchTerm);
            }
            else
            {
                // Si no hay texto, se cargan todos los registros
                this.usuariosTableAdapter1.Fill(this.dataSet11.usuarios);
            }
        }


        private void BRegisterUser_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            //MessageBox.Show("TID_user.Text: " + TID_user.Text);
            //MessageBox.Show("TCP.Text: " + TCP.Text);
            //MessageBox.Show("CBperfiles.SelectedItem: " + ((OpcionSelectUsuario)CBperfiles.SelectedItem).Valor.ToString());
            //MessageBox.Show("CBEstado.SelectedItem: " + ((OpcionSelectUsuario)CBEstado.SelectedItem).Valor.ToString());


            Usuario objUser = new Usuario()
            {
                id_usuario = Convert.ToInt32(TID_user.Text),
                nombre = TNombre.Text,
                apellido = TApellido.Text,
                objPerfil = new Perfil() { id_perfil = Convert.ToInt32(((OpcionSelectUsuario)CBperfiles.SelectedItem).Valor) },
                baja = ((OpcionSelectUsuario)CBEstado.SelectedItem).Valor.ToString(),
                user = TUser.Text,
                pass = TPass.Text,
                email = TEmail.Text,
                domicilio = TDomicilio.Text,
                CP = Convert.ToInt32(TCP.Text),
            };

            if (objUser.id_usuario == 0)
            {
                int idusuarioregistrado = new Usuario_negocio().Registrar(objUser, out mensaje);

                if(idusuarioregistrado != 0)
                {
                    usuariosDataGridView.Rows.Add(new object[] {
                        "",
                        idusuarioregistrado,
                        TNombre.Text,
                        TApellido.Text,
                        ((OpcionSelectUsuario)CBperfiles.SelectedItem).Valor.ToString(),
                        ((OpcionSelectUsuario)CBperfiles.SelectedItem).Texto.ToString(),
                        ((OpcionSelectUsuario)CBEstado.SelectedItem).Valor.ToString(),
                        TUser.Text,
                        TPass.Text,
                        TEmail.Text,
                        TDomicilio.Text,
                        TCP.Text
                    });

                    VaciarCampos();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new Usuario_negocio().Editar(objUser, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = usuariosDataGridView.Rows[Convert.ToInt32(TIndice.Text)];

                    row.Cells["id_user"].Value = TModificarID_user.Text;
                    row.Cells["nombre"].Value = TModificarNombre.Text;
                    row.Cells["apellido"].Value = TModificarAp.Text;
                    row.Cells["id_perfil"].Value = ((OpcionSelectUsuario)CBperfiles.SelectedItem).Valor.ToString();
                    row.Cells["Perfil"].Value = ((OpcionSelectUsuario)CBperfiles.SelectedItem).Texto.ToString();
                    row.Cells["baja"].Value = ((OpcionSelectUsuario)CBEstado.SelectedItem).Valor.ToString();
                    row.Cells["email"].Value = TModificarEmail.Text;
                    row.Cells["user"].Value = TModificarUser.Text;
                    row.Cells["pass"].Value = TModificarPass;
                    row.Cells["domicilio"].Value = TModificarDomicilio.Text;
                    row.Cells["CP"].Value = TModificarCP.Text;

                    VaciarCampos();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }


        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(TNombre.Text) || 
                string.IsNullOrWhiteSpace(TApellido.Text) || 
                string.IsNullOrWhiteSpace(TEmail.Text) ||
                string.IsNullOrWhiteSpace(TPass.Text) ||
                string.IsNullOrWhiteSpace(TPassConf.Text) ||
                string.IsNullOrWhiteSpace(TUser.Text) ||
                string.IsNullOrWhiteSpace(CBperfiles.Text) ||
                string.IsNullOrWhiteSpace(CBEstado.Text) ||
                string.IsNullOrWhiteSpace(TDomicilio.Text) ||
                string.IsNullOrWhiteSpace(TCP.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void CBEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void usuariosDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = pruebaLogin.Properties.Resources.checkbox.Width;
                var h = pruebaLogin.Properties.Resources.checkbox.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - w) / 2;

                e.Graphics.DrawImage(pruebaLogin.Properties.Resources.checkbox, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void usuariosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (usuariosDataGridView.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    TCUsuarios.SelectedIndex = 1;

                    TBModificarIndice.Text = indice.ToString();

                    TModificarID_user.Text = usuariosDataGridView.Rows[indice].Cells["id_user"].Value.ToString();
                    TModificarNombre.Text = usuariosDataGridView.Rows[indice].Cells["nombre"].Value.ToString();
                    TModificarAp.Text = usuariosDataGridView.Rows[indice].Cells["apellido"].Value.ToString();
                    TModificarEmail.Text = usuariosDataGridView.Rows[indice].Cells["email"].Value.ToString();
                    TModificarUser.Text = usuariosDataGridView.Rows[indice].Cells["user"].Value.ToString();
                    TModificarPass.Text = usuariosDataGridView.Rows[indice].Cells["pass"].Value.ToString();
                    TModificarPassConfirm.Text = usuariosDataGridView.Rows[indice].Cells["pass"].Value.ToString();
                    TModificarDomicilio.Text = usuariosDataGridView.Rows[indice].Cells["domicilio"].Value.ToString();
                    TModificarCP.Text = usuariosDataGridView.Rows[indice].Cells["CP"].Value.ToString();

                    foreach (OpcionSelectUsuario opcionSelect in CBModificarPerfil.Items)
                    {
                        if (Convert.ToInt32(opcionSelect.Valor) == Convert.ToInt32(usuariosDataGridView.Rows[indice].Cells["id_perfil"].Value))
                        {
                            int indice_select = CBModificarPerfil.Items.IndexOf(opcionSelect);
                            CBModificarPerfil.SelectedIndex = indice_select;
                            break;
                        }   
                    }

                    foreach (OpcionSelectUsuario opcionSelect in CBModificarEstado.Items)
                    {
                        if (opcionSelect.Valor.ToString() == usuariosDataGridView.Rows[indice].Cells["baja"].Value.ToString())
                        {
                            int indice_select = CBModificarEstado.Items.IndexOf(opcionSelect);
                            CBModificarEstado.SelectedIndex = indice_select;
                            break;
                        }
                    }


                }
            }
        }

        private void PanelModificarUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CBModificarPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TID_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TModificarID_user.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        id_usuario = Convert.ToInt32(TModificarID_user.Text)
                    };

                    bool respuesta = new Usuario_negocio().Eliminar(objusuario, out mensaje);

                    if (respuesta)
                    {
                        usuariosDataGridView.Rows.RemoveAt(Convert.ToInt32(TBModificarIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario objUser = new Usuario()
            {
                id_usuario = Convert.ToInt32(TModificarID_user.Text),
                nombre = TModificarNombre.Text,
                apellido = TModificarAp.Text,
                objPerfil = new Perfil() { id_perfil = Convert.ToInt32(((OpcionSelectUsuario)CBModificarPerfil.SelectedItem).Valor) },
                baja = ((OpcionSelectUsuario)CBModificarEstado.SelectedItem).Valor.ToString(),
                user = TModificarUser.Text,
                pass = TModificarPass.Text,
                email = TModificarEmail.Text,
                domicilio = TModificarDomicilio.Text,
                CP = Convert.ToInt32(TModificarCP.Text),
            };

            bool resultado = new Usuario_negocio().Editar(objUser, out mensaje);

            if (resultado)
            {
                DataGridViewRow row = usuariosDataGridView.Rows[Convert.ToInt32(TBModificarIndice.Text)];

                row.Cells["id_user"].Value = TModificarID_user.Text;
                row.Cells["nombre"].Value = TModificarNombre.Text;
                row.Cells["apellido"].Value = TModificarAp.Text;
                row.Cells["id_perfil"].Value = ((OpcionSelectUsuario)CBperfiles.SelectedItem).Valor.ToString();
                row.Cells["Perfil"].Value = ((OpcionSelectUsuario)CBperfiles.SelectedItem).Texto.ToString();
                row.Cells["baja"].Value = ((OpcionSelectUsuario)CBEstado.SelectedItem).Valor.ToString();
                row.Cells["email"].Value = TModificarEmail.Text;
                row.Cells["user"].Value = TModificarUser.Text;
                row.Cells["pass"].Value = TModificarPass;
                row.Cells["domicilio"].Value = TModificarDomicilio.Text;
                row.Cells["CP"].Value = TModificarCP.Text;

                VaciarCampos();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }
    }
}
