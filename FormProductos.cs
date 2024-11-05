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
    public partial class FormProductos : Form
    {
        public FormProductos()
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
            // TODO: esta línea de código carga datos en la tabla 'dataSet11.productos_pc' Puede moverla o quitarla según sea necesario.
            this.productos_pcTableAdapter.Fill(this.dataSet11.productos_pc);


            

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
            
        }

        private void LApellido_Click(object sender, EventArgs e)
        {

        }

        private void usuariosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usuariosDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }
    }
}
