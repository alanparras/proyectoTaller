using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;
using System.Windows.Media;
using CapaEntidades;
using CapaNegocio;
using ProyectoTallerG8.Utilidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoTallerG8
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productospcBindingSource.EndEdit();
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
            List<SubCategoria> listaSubCategoria = new SubCategoria_negocio().Listar();
            

            foreach (Categoria itemCat in listaCategoria)
            {
                CBCategoria.Items.Add(new OpcionSelectUsuario() { Valor = itemCat.id_categoria, Texto = itemCat.descripcion_categoria });
                CBModificarCategoria.Items.Add(new OpcionSelectUsuario() { Valor = itemCat.id_categoria, Texto = itemCat.descripcion_categoria });
            }

            // Maneja el evento SelectedIndexChanged de CBCategoria para actualizar las subcategorías
            CBCategoria.SelectedIndexChanged += (s, a) => ActualizarSubcategorias((OpcionSelectUsuario)CBCategoria.SelectedItem, CBSubCategoria);
            CBModificarCategoria.SelectedIndexChanged += (s, a) => ActualizarSubcategorias((OpcionSelectUsuario)CBModificarCategoria.SelectedItem, CBModificarSubCat);

            CBCategoria.DisplayMember = "Texto";
            CBCategoria.ValueMember = "Valor";
            CBCategoria.SelectedIndex = 0;

            CBModificarCategoria.DisplayMember = "Texto";
            CBModificarCategoria.ValueMember = "Valor";
            CBModificarCategoria.SelectedIndex = 0;

            CBSubCategoria.DisplayMember = "Texto";
            CBSubCategoria.ValueMember = "Valor";
            CBSubCategoria.SelectedIndex = 0;

            CBModificarSubCat.DisplayMember = "Texto";
            CBModificarSubCat.ValueMember = "Valor";
            CBModificarSubCat.SelectedIndex = 0;

            //Muestra todos los productos
            List<Producto> listaProducto = new Producto_negocio().Listar();
            //Console.WriteLine($"Número de productos encontrados: {listaProducto.Count}");
            foreach (Producto item in listaProducto)
            {
                productosDataGridView.Rows.Add(new object[] {
                    "",
                    item.id_producto,
                    item.nombre,
                    item.descripcion,
                    item.marca,
                    item.modelo,
                    item.precio,
                    item.stock,
                    item.baja == true ? 1 : 0,
                    item.baja == true ? "Dado de Baja" : "Dado de Alta",
                    item.objCategoria.id_categoria,
                    item.objCategoria.descripcion_categoria,
                    item.objSubCategoria.id_subcategoria,
                    item.objSubCategoria.descripcion_subcategoria,
                });
            }
        }

        // Método para actualizar el ComboBox de subcategorías
        void ActualizarSubcategorias(OpcionSelectUsuario categoriaSeleccionada, ComboBox comboSubcategoria)
        {
            comboSubcategoria.Items.Clear(); // Limpia las subcategorías previas

            if (categoriaSeleccionada?.Valor is int idCategoriaSeleccionada) // Verifica y convierte a int
            {
                // Filtra las subcategorías según la categoría seleccionada
                List<SubCategoria> listaSubCategoria = new SubCategoria_negocio().Listar();
                foreach (SubCategoria itemSubCat in listaSubCategoria)
                {
                    if (itemSubCat.objCategoria_subCat.id_categoria == idCategoriaSeleccionada)
                    {
                        comboSubcategoria.Items.Add(new OpcionSelectUsuario()
                        {
                            Valor = itemSubCat.id_subcategoria,
                            Texto = itemSubCat.descripcion_subcategoria
                        });
                    }
                }
            }

            // Opcional: Puedes agregar un mensaje para cuando no haya subcategorías disponibles
            if (comboSubcategoria.Items.Count == 0)
            {
                comboSubcategoria.Items.Add(new OpcionSelectUsuario() { Valor = null, Texto = "No tiene subcategorías" });
            }
            comboSubcategoria.SelectedIndex = 0; // Selecciona el primer elemento (o "No hay subcategorías")
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
                //this.productosTableAdapter1.FillBySearch(this.dataSet11.productos, searchTerm);
            }
            else
            {
                // Si no hay texto, se cargan todos los registros
                //this.productosTableAdapter1.Fill(this.dataSet11.productos);
            }
        }

        private void VaciarCampos()
        {
            TID_prod.Text = "0";
            TNombre.Text = "";
            TDescripcion.Text = "";
            TMarca.Text = "";
            TModelo.Text = "";
            TPrecio.Text = "";
            TStock.Text = "";
            CBEstado.SelectedIndex = 0;
            CBCategoria.SelectedIndex = 0;
            CBSubCategoria.SelectedIndex = 0;

            TModificarID_prod.Text = "0";
            TModificarNombre.Text = "";
            TModificarDescripcion.Text = "";
            TModificarMarca.Text = "";
            TModificarModelo.Text = "";
            TModificarPrecio.Text = "";
            TModificarStock.Text = "";
            CBModificarEstado.SelectedIndex = 0;
            CBModificarCategoria.SelectedIndex = 0;
            CBModificarSubCat.SelectedIndex = 0;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TModificarID_prod.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto objproducto = new Producto()
                    {
                        id_producto = Convert.ToInt32(TModificarID_prod.Text)
                    };

                    bool respuesta = new Producto_negocio().Eliminar(objproducto, out mensaje);

                    if (respuesta)
                    {
                        productosDataGridView.Rows.RemoveAt(Convert.ToInt32(TBModificarIndice.Text));
                        VaciarCampos();
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

            // Validación para nombre (no debe estar vacío)
            if (string.IsNullOrEmpty(TModificarNombre.Text))
            {
                MessageBox.Show("El nombre del producto no puede estar vacío.");
                return;
            }

            // Validación para descripción (no debe estar vacío)
            if (string.IsNullOrEmpty(TModificarDescripcion.Text))
            {
                MessageBox.Show("La descripción del producto no puede estar vacía.");
                return;
            }

            // Validación para marca (no debe estar vacío)
            if (string.IsNullOrEmpty(TModificarMarca.Text))
            {
                MessageBox.Show("La marca del producto no puede estar vacía.");
                return;
            }

            // Validación para modelo (no debe estar vacío)
            if (string.IsNullOrEmpty(TModificarModelo.Text))
            {
                MessageBox.Show("El modelo del producto no puede estar vacío.");
                return;
            }

            // Validación para precio (debe ser un número positivo)
            if (string.IsNullOrEmpty(TModificarPrecio.Text) || !decimal.TryParse(TModificarPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número válido mayor que 0.");
                return;
            }

            // Validación para stock (debe ser un número entero no negativo)
            if (string.IsNullOrEmpty(TModificarStock.Text) || !int.TryParse(TModificarStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número entero no negativo.");
                return;
            }

            // Validación para estado (debe haber un estado seleccionado)
            if (CBModificarEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar el estado del producto.");
                return;
            }

            // Validación para categoría (debe haber una categoría seleccionada)
            if (CBModificarCategoria.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una categoría.");
                return;
            }

            // Validación para subcategoría (debe haber una subcategoría seleccionada)
            if (CBModificarSubCat.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una subcategoría.");
                return;
            }

            Producto objProducto = new Producto()
            {
                id_producto = Convert.ToInt32(TModificarID_prod.Text),
                nombre = TModificarNombre.Text,
                descripcion = TModificarDescripcion.Text,
                marca = TModificarMarca.Text,
                modelo = TModificarModelo.Text,
                precio = Convert.ToDecimal(TModificarPrecio.Text),
                stock = Convert.ToInt32(TModificarStock.Text),
                baja = Convert.ToInt32(((OpcionSelectUsuario)CBModificarEstado.SelectedItem).Valor) == 1 ? true : false,
                objCategoria = new Categoria() { id_categoria = Convert.ToInt32(((OpcionSelectUsuario)CBModificarCategoria.SelectedItem).Valor), descripcion_categoria = ((OpcionSelectUsuario)CBModificarCategoria.SelectedItem).Texto },
                objSubCategoria = CBSubCategoria.SelectedItem != null
                        ? new SubCategoria()
                        {
                            id_subcategoria = Convert.ToInt32(((OpcionSelectUsuario)CBSubCategoria.SelectedItem).Valor),
                            descripcion_subcategoria = ((OpcionSelectUsuario)CBSubCategoria.SelectedItem).Texto
                        }
                        : null // Si no hay subcategoría seleccionada, asignar null
            };

            bool resultado = new Producto_negocio().Editar(objProducto, out mensaje);

            if (resultado)
            {
                DataGridViewRow row = productosDataGridView.Rows[Convert.ToInt32(TBModificarIndice.Text)];

                row.Cells["id_producto"].Value = TModificarID_prod.Text;
                row.Cells["nombre"].Value = TModificarNombre.Text;
                row.Cells["descripcion"].Value = TModificarDescripcion.Text;
                row.Cells["marca"].Value = TModificarMarca.Text;
                row.Cells["modelo"].Value = TModificarModelo.Text;
                row.Cells["precio"].Value = TModificarPrecio.Text;
                row.Cells["stock"].Value = TModificarStock.Text;
                row.Cells["bajaValor"].Value = ((OpcionSelectUsuario)CBModificarEstado.SelectedItem).Valor.ToString();
                row.Cells["baja"].Value = ((OpcionSelectUsuario)CBModificarEstado.SelectedItem).Texto.ToString();
                row.Cells["id_categoria"].Value = ((OpcionSelectUsuario)CBModificarCategoria.SelectedItem).Valor.ToString();
                row.Cells["categoria"].Value = ((OpcionSelectUsuario)CBModificarCategoria.SelectedItem).Texto.ToString();
                row.Cells["id_subcategoria"].Value = ((OpcionSelectUsuario)CBModificarSubCat.SelectedItem).Valor.ToString();
                row.Cells["subcategoria"].Value = ((OpcionSelectUsuario)CBModificarSubCat.SelectedItem).Texto.ToString();

                VaciarCampos();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void LApellido_Click(object sender, EventArgs e)
        {

        }

        private void productosDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void productosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productosDataGridView.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    TCProductos.SelectedIndex = 1;

                    TBModificarIndice.Text = indice.ToString();

                    TModificarID_prod.Text = productosDataGridView.Rows[indice].Cells["id_producto"].Value.ToString();
                    TModificarNombre.Text = productosDataGridView.Rows[indice].Cells["nombre"].Value.ToString();
                    TModificarDescripcion.Text = productosDataGridView.Rows[indice].Cells["descripcion"].Value.ToString();
                    TModificarMarca.Text = productosDataGridView.Rows[indice].Cells["marca"].Value.ToString();
                    TModificarModelo.Text = productosDataGridView.Rows[indice].Cells["modelo"].Value.ToString();
                    TModificarPrecio.Text = productosDataGridView.Rows[indice].Cells["precio"].Value.ToString();
                    TModificarStock.Text = productosDataGridView.Rows[indice].Cells["stock"].Value.ToString();

                    foreach (OpcionSelectUsuario opcionSelect in CBModificarEstado.Items)
                    {
                        if (opcionSelect.Valor.ToString() == productosDataGridView.Rows[indice].Cells["bajaValor"].Value.ToString())
                        {
                            int indice_select = CBModificarEstado.Items.IndexOf(opcionSelect);
                            CBModificarEstado.SelectedIndex = indice_select;
                            break;
                        }
                    }

                    foreach (OpcionSelectUsuario opcionSelect in CBModificarCategoria.Items)
                    {
                        if (Convert.ToInt32(opcionSelect.Valor) == Convert.ToInt32(productosDataGridView.Rows[indice].Cells["id_categoria"].Value))
                        {
                            int indice_select = CBModificarCategoria.Items.IndexOf(opcionSelect);
                            CBModificarCategoria.SelectedIndex = indice_select;
                            break;
                        }
                    }

                    foreach (OpcionSelectUsuario opcionSelect in CBModificarSubCat.Items)
                    {
                        if (Convert.ToInt32(opcionSelect.Valor) == Convert.ToInt32(productosDataGridView.Rows[indice].Cells["id_subcategoria"].Value))
                        {
                            int indice_select = CBModificarSubCat.Items.IndexOf(opcionSelect);
                            CBModificarSubCat.SelectedIndex = indice_select;
                            break;
                        }
                    }

                }
            }
        }

        private void productosDataGridView_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void BRegisterProd_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Validación para nombre (no debe estar vacío)
            if (string.IsNullOrEmpty(TNombre.Text))
            {
                MessageBox.Show("El nombre del producto no puede estar vacío.");
                return;
            }

            // Validación para descripción (no debe estar vacío)
            if (string.IsNullOrEmpty(TDescripcion.Text))
            {
                MessageBox.Show("La descripción del producto no puede estar vacía.");
                return;
            }

            // Validación para marca (no debe estar vacío)
            if (string.IsNullOrEmpty(TMarca.Text))
            {
                MessageBox.Show("La marca del producto no puede estar vacía.");
                return;
            }

            // Validación para modelo (no debe estar vacío)
            if (string.IsNullOrEmpty(TModelo.Text))
            {
                MessageBox.Show("El modelo del producto no puede estar vacío.");
                return;
            }

            // Validación para precio (debe ser un número positivo)
            if (string.IsNullOrEmpty(TPrecio.Text) || !decimal.TryParse(TPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número válido mayor que 0.");
                return;
            }

            // Validación para stock (debe ser un número entero no negativo)
            if (string.IsNullOrEmpty(TStock.Text) || !int.TryParse(TStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número entero no negativo.");
                return;
            }

            // Validación para estado (debe haber un estado seleccionado)
            if (CBEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar el estado del producto.");
                return;
            }

            // Validación para categoría (debe haber una categoría seleccionada)
            if (CBCategoria.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una categoría.");
                return;
            }

            // Validación para subcategoría (debe haber una subcategoría seleccionada)
            if (CBSubCategoria.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una subcategoría.");
                return;
            }

            Producto objProducto = new Producto()
            {
                id_producto = Convert.ToInt32(TID_prod.Text),
                nombre = TNombre.Text,
                descripcion = TDescripcion.Text,
                marca = TMarca.Text,
                modelo = TModelo.Text,
                precio = Convert.ToDecimal(TPrecio.Text),
                stock = Convert.ToInt32(TStock.Text),
                baja = Convert.ToInt32(((OpcionSelectUsuario)CBEstado.SelectedItem).Valor) == 1 ? true : false,
                objCategoria = new Categoria() { id_categoria = Convert.ToInt32(((OpcionSelectUsuario)CBCategoria.SelectedItem).Valor), descripcion_categoria = ((OpcionSelectUsuario)CBCategoria.SelectedItem).Texto },
                objSubCategoria = new SubCategoria() { id_subcategoria = Convert.ToInt32(((OpcionSelectUsuario)CBSubCategoria.SelectedItem).Valor), descripcion_subcategoria = ((OpcionSelectUsuario)CBSubCategoria.SelectedItem).Texto }
            };

            if (objProducto.id_producto == 0)
            {
                int idproductoregistrado = new Producto_negocio().Registrar(objProducto, out mensaje);
                
                if (idproductoregistrado != 0)
                {
                    productosDataGridView.Rows.Add(new object[] {
                        "",
                        idproductoregistrado,
                        TNombre.Text,
                        TDescripcion.Text,
                        TMarca.Text,
                        TModelo.Text,
                        TPrecio.Text,
                        TStock.Text,
                        ((OpcionSelectUsuario)CBEstado.SelectedItem).Valor.ToString(),
                        ((OpcionSelectUsuario)CBEstado.SelectedItem).Texto.ToString(),
                        ((OpcionSelectUsuario)CBCategoria.SelectedItem).Valor.ToString(),    //id_categoria
                        ((OpcionSelectUsuario)CBCategoria.SelectedItem).Texto.ToString(),    //descripcion
                        ((OpcionSelectUsuario)CBSubCategoria.SelectedItem).Valor.ToString(), //id_subcat
                        ((OpcionSelectUsuario)CBSubCategoria.SelectedItem).Texto.ToString()  //descripcion
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
                bool resultado = new Producto_negocio().Editar(objProducto, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = productosDataGridView.Rows[Convert.ToInt32(TIndice.Text)];

                    row.Cells["id_producto"].Value = TModificarID_prod.Text;
                    row.Cells["nombre"].Value = TModificarNombre.Text;
                    row.Cells["descripcion"].Value = TModificarDescripcion.Text;
                    row.Cells["marca"].Value = TModificarMarca.Text;
                    row.Cells["modelo"].Value = TModificarModelo.Text;
                    row.Cells["precio"].Value = TModificarPrecio.Text;
                    row.Cells["stock"].Value = TModificarStock.Text;
                    row.Cells["bajaValor"].Value = ((OpcionSelectUsuario)CBModificarEstado.SelectedItem).Valor.ToString();
                    row.Cells["baja"].Value = ((OpcionSelectUsuario)CBModificarEstado.SelectedItem).Texto.ToString();
                    row.Cells["id_categoria"].Value = ((OpcionSelectUsuario)CBModificarCategoria.SelectedItem).Valor.ToString();
                    row.Cells["categoria"].Value = ((OpcionSelectUsuario)CBModificarCategoria.SelectedItem).Texto.ToString();
                    row.Cells["id_subcategoria"].Value = ((OpcionSelectUsuario)CBModificarSubCat.SelectedItem).Valor.ToString();
                    row.Cells["subcategoria"].Value = ((OpcionSelectUsuario)CBModificarSubCat.SelectedItem).Texto.ToString();


                    VaciarCampos();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }
    }
}
