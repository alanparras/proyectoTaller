using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;
using System.Windows.Media;
using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using FontAwesome.Sharp;
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
            usuariosDataGridView.AutoGenerateColumns = false;


            // TODO: esta línea de código carga datos en la tabla 'dataSet11.usuarios' Puede moverla o quitarla según sea necesario.
            //this.usuariosTableAdapter1.Fill(this.dataSet11.usuarios);

            CBEstado.Items.Add(new OpcionSelectUsuario() { Valor = 0, Texto = "Dado de Alta" });
            CBEstado.Items.Add(new OpcionSelectUsuario() { Valor = 1, Texto = "Dado de Baja"});
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = 0;

            CBModificarEstado.Items.Add(new OpcionSelectUsuario() { Valor = 0, Texto = "Dado de Alta" });
            CBModificarEstado.Items.Add(new OpcionSelectUsuario() { Valor = 1, Texto = "Dado de Baja" });
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

            CargarUsuariosEnDataGridView(listaUsuario);
            //Console.WriteLine($"Número de usuarios encontrados: {listaUsuario.Count}");

        }

        private void CargarUsuariosEnDataGridView(List<Usuario> listaUsuario)
        {
            // Limpia las filas del DataGridView antes de agregar datos nuevos
            usuariosDataGridView.Rows.Clear();

            foreach (Usuario item in listaUsuario)
            {
                usuariosDataGridView.Rows.Add(new object[] {
                    "",
                    item.id_usuario,
                    item.nombre,
                    item.apellido,
                    item.objPerfil.id_perfil,
                    item.objPerfil.descripcion,
                    item.baja ? 1 : 0,
                    item.baja ? "Dado de Baja" : "Dado de Alta",
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
            TID_user.Text = "0";
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

            TModificarID_user.Text = "0";
            TModificarNombre.Text = "";
            TModificarAp.Text = "";
            TModificarEmail.Text = "";
            TModificarPass.Text = "";
            TModificarConfirmPass.Text = "";
            TModificarUser.Text = "";
            CBModificarPerfil.SelectedIndex = 0;
            CBModificarEstado.SelectedIndex = 0;
            TModificarDomicilio.Text = "";
            TModificarCP.Text = "";
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string criterio = textSearch.Text;

            // Instancia de la clase que contiene el método BuscarUsuarios en el otro proyecto
            Usuario_Datos usuarioService = new Usuario_Datos();
            List<Usuario> resultados = usuarioService.BuscarUsuarios(criterio);

            CargarUsuariosEnDataGridView(resultados);
        }


        private void BRegisterUser_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(TNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TApellido.Text))
            {
                MessageBox.Show("El campo Apellido es obligatorio.");
                return;
            }

            if (CBperfiles.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un perfil.");
                return;
            }

            if (CBEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un estado.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TUser.Text))
            {
                MessageBox.Show("El campo Usuario es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TPass.Text) || TPass.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TEmail.Text) || !TEmail.Text.Contains("@"))
            {
                MessageBox.Show("Debe ingresar un correo electrónico válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TDomicilio.Text))
            {
                MessageBox.Show("El campo Domicilio es obligatorio.");
                return;
            }

            if (string.IsNullOrEmpty(TCP.Text) || !int.TryParse(TCP.Text, out int codigoPostal) || codigoPostal < 1000 || codigoPostal > 9999)
            {
                MessageBox.Show("El Código Postal debe ser un número de 4 dígitos entre 1000 y 9999 (Argentina).");
                return;
            }

            Usuario objUser = new Usuario()
            {
                id_usuario = Convert.ToInt32(TID_user.Text),
                nombre = TNombre.Text,
                apellido = TApellido.Text,
                objPerfil = new Perfil() { id_perfil = Convert.ToInt32(((OpcionSelectUsuario)CBperfiles.SelectedItem).Valor), descripcion = ((OpcionSelectUsuario)CBperfiles.SelectedItem).Texto },
                baja = Convert.ToInt32(((OpcionSelectUsuario)CBEstado.SelectedItem).Valor) == 1 ? true : false,
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
                        ((OpcionSelectUsuario)CBEstado.SelectedItem).Texto.ToString(),
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
                    row.Cells["id_perfil"].Value = ((OpcionSelectUsuario)CBModificarPerfil.SelectedItem).Valor.ToString();
                    row.Cells["perfil"].Value = ((OpcionSelectUsuario)CBModificarPerfil.SelectedItem).Texto.ToString();
                    row.Cells["bajaValor"].Value = ((OpcionSelectUsuario)CBModificarEstado.SelectedItem).Valor.ToString();
                    row.Cells["baja"].Value = ((OpcionSelectUsuario)CBModificarEstado.SelectedItem).Texto.ToString();
                    row.Cells["email"].Value = TModificarEmail.Text;
                    row.Cells["user"].Value = TModificarUser.Text;

                    row.Cells["domicilio"].Value = TModificarDomicilio.Text;


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
                    TModificarConfirmPass.Text = usuariosDataGridView.Rows[indice].Cells["pass"].Value.ToString();

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
                        if (opcionSelect.Valor.ToString() == usuariosDataGridView.Rows[indice].Cells["bajaValor"].Value.ToString())
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
                        VaciarCampos();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void BModificar_click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Validación para nombre (no debe estar vacío)
            if (string.IsNullOrEmpty(TModificarNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            // Validación para apellido (no debe estar vacío)
            if (string.IsNullOrEmpty(TModificarAp.Text))
            {
                MessageBox.Show("El apellido no puede estar vacío.");
                return;
            }

            // Validación para perfil (debe haber un perfil seleccionado)
            if (CBModificarPerfil.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un perfil.");
                return;
            }

            // Validación para estado (debe estar seleccionado un valor)
            if (CBModificarEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar el estado.");
                return;
            }

            // Validación para usuario (no debe estar vacío)
            if (string.IsNullOrEmpty(TModificarUser.Text))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.");
                return;
            }

            // Validación para contraseña (no debe estar vacía)
            if (string.IsNullOrEmpty(TModificarPass.Text))
            {
                MessageBox.Show("La contraseña no puede estar vacía.");
                return;
            }

            // Validación para email (debe tener formato de correo electrónico)
            if (string.IsNullOrEmpty(TModificarEmail.Text) || !Regex.IsMatch(TModificarEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El email no tiene un formato válido.");
                return;
            }

            // Validación para domicilio (no debe estar vacío)
            if (string.IsNullOrEmpty(TModificarDomicilio.Text))
            {
                MessageBox.Show("El domicilio no puede estar vacío.");
                return;
            }

            // Validación para código postal (debe ser un número de 4 dígitos entre 1000 y 9999)
            if (string.IsNullOrEmpty(TModificarCP.Text) || !int.TryParse(TModificarCP.Text, out int codigoPostal) || codigoPostal < 1000 || codigoPostal > 9999)
            {
                MessageBox.Show("El código postal debe ser un número de 4 dígitos entre 1000 y 9999.");
                return;
            }

            Usuario objUser = new Usuario()
            {
                id_usuario = Convert.ToInt32(TModificarID_user.Text),
                nombre = TModificarNombre.Text,
                apellido = TModificarAp.Text,
                objPerfil = new Perfil() { id_perfil = Convert.ToInt32(((OpcionSelectUsuario)CBModificarPerfil.SelectedItem).Valor) },
                baja = Convert.ToInt32(((OpcionSelectUsuario)CBModificarEstado.SelectedItem).Valor) == 1 ? true : false,
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
                row.Cells["id_perfil"].Value = ((OpcionSelectUsuario)CBModificarPerfil.SelectedItem).Valor.ToString();
                row.Cells["perfil"].Value = ((OpcionSelectUsuario)CBModificarPerfil.SelectedItem).Texto.ToString();
                row.Cells["bajaValor"].Value = ((OpcionSelectUsuario)CBModificarEstado.SelectedItem).Valor.ToString();
                row.Cells["baja"].Value = ((OpcionSelectUsuario)CBModificarEstado.SelectedItem).Texto.ToString();
                row.Cells["email"].Value = TModificarEmail.Text;
                row.Cells["user"].Value = TModificarUser.Text;
                row.Cells["pass"].Value = TModificarPass.Text;

                row.Cells["domicilio"].Value = TModificarDomicilio.Text;
                row.Cells["CP"].Value = TModificarCP.Text;

                VaciarCampos();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void TModificarDomicilio_TextChanged(object sender, EventArgs e)
        {

        }

        private void TIndice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
