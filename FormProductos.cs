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

            CBEstado.Items.Add(new OpcionSelectUsuario() { Valor = 0, Texto = "Dado de Alta" });
            CBEstado.Items.Add(new OpcionSelectUsuario() { Valor = 1, Texto = "Dado de Baja" });
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = 0;

            CBModificarEstado.Items.Add(new OpcionSelectUsuario() { Valor = 0, Texto = "Dado de Alta" });
            CBModificarEstado.Items.Add(new OpcionSelectUsuario() { Valor = 1, Texto = "Dado de Baja" });
            CBModificarEstado.DisplayMember = "Texto";
            CBModificarEstado.ValueMember = "Valor";

            List<Categoria> listaCategoria = new Categoria_negocio().Listar();
            foreach (Categoria item in listaCategoria)
            {
                CBCategoria.Items.Add(new OpcionSelectUsuario() { Valor = item.id_categoria, Texto = item.descripcion_categoria });
                CBModificarCategoria.Items.Add(new OpcionSelectUsuario() { Valor = item.id_categoria, Texto = item.descripcion_categoria });
            }
            CBCategoria.DisplayMember = "Texto";
            CBCategoria.ValueMember = "Valor";
            CBCategoria.SelectedIndex = 0;

            CBModificarCategoria.DisplayMember = "Texto";
            CBModificarCategoria.ValueMember = "Valor";
            CBModificarCategoria.SelectedIndex = 0;

            //Muestra todos los usuarios
            List<Producto> listaProducto = new Producto_negocio().Listar();
            //Console.WriteLine($"Número de usuarios encontrados: {listaProducto.Count}");
            foreach (Producto item in listaProducto)
            {
                //if (item.objSubCategoria == null)
                //{
                //    item.objSubCategoria.id_subcategoria = 0;
                //    item.objSubCategoria.descripcion_subcategoria = "Sin subcategoria";
                
                //    if (item.objCategoria == null)
                //    {
                //        item.objCategoria.id_categoria = 0;
                //        item.objCategoria.descripcion_categoria = "Sin categoria";
                //    }
                //}

                productosDataGridView.Rows.Add(new object[] {
                    "",
                    item.id_producto,
                    item.nombre,
                    item.descripcion,
                    item.marca,
                    item.modelo,
                    item.precio,
                    item.stock,
                    item.baja == true ? "Dado de Baja" : "Dado de Alta",
                    item.visitas,
                    item.objCategoria.id_categoria,
                    item.objCategoria.descripcion_categoria,
                    item.objSubCategoria.id_subcategoria,
                    item.objSubCategoria.descripcion_subcategoria,
                });
            }
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
                        productosDataGridView.Rows.RemoveAt(Convert.ToInt32(TBModificarIndice.Text));
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
    }
}
