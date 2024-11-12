using CapaEntidades;
using CapaNegocio;
using ProyectoTallerG8;
using ProyectoTallerG8.Utilidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoTallerG8
{
    public partial class FormMensajes : Form
    {
        public FormMensajes()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FormMensajes_Load(object sender, EventArgs e)
        {
            List<Mensaje> listaMensaje = new Mensaje_negocio().Listar();
            //Console.WriteLine($"Número de mensajes encontrados: {listaMensaje.Count}");
            foreach (Mensaje item in listaMensaje)
            {
                mensajesDataGridView.Rows.Add(new object[] {
                    "",
                    item.id_mensaje,
                    item.nombreCliente,
                    item.emailCliente,
                    item.mensaje,
                    item.created_at,
                    item.updated_at,
                    item.respuesta,
                });
            }
        }

        private void VaciarCampos()
        {
            TID_mensaje.Text = "";
            TNombre.Text = "";
            TEmail.Text = "";
            TMensaje.Text = "";
            TFechaCreado.Text = "";
            TFechaRespuesta.Text = "";
            TRespuesta.Text = "";
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void ConsultasButton_Click(object sender, EventArgs e)
        {

        }

        private void B_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mensajesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mensajesDataGridView.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    TBIndice.Text = indice.ToString();

                    TID_mensaje.Text = mensajesDataGridView.Rows[indice].Cells["id_mensaje"].Value.ToString();
                    TNombre.Text = mensajesDataGridView.Rows[indice].Cells["nombre"].Value.ToString();
                    TEmail.Text = mensajesDataGridView.Rows[indice].Cells["correo"].Value.ToString();
                    TMensaje.Text = mensajesDataGridView.Rows[indice].Cells["mensaje"].Value.ToString();
                    TFechaCreado.Text = mensajesDataGridView.Rows[indice].Cells["fecha_mensaje"].Value.ToString();
                    TFechaRespuesta.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    TRespuesta.Text = "";
                }
            }
        }

        private void mensajesDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void BEnviarRespuesta_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Mensaje objMensaje = new Mensaje()
            {
                id_mensaje = Convert.ToInt32(TID_mensaje.Text),
                nombreCliente = TNombre.Text,
                emailCliente = TEmail.Text,
                mensaje = TMensaje.Text,
                created_at = TFechaCreado.Text,
                updated_at = TFechaRespuesta.Text,
                respuesta = TRespuesta.Text,
            };

            bool resultado = new Mensaje_negocio().Registrar(objMensaje, out mensaje);

            if (resultado)
            {
                DataGridViewRow row = mensajesDataGridView.Rows[Convert.ToInt32(TBIndice.Text)];

                row.Cells["id_mensaje"].Value = TID_mensaje.Text;
                row.Cells["nombre"].Value = TNombre.Text;
                row.Cells["correo"].Value = TEmail.Text;
                row.Cells["mensaje"].Value = TMensaje.Text;
                row.Cells["fecha_mensaje"].Value = TFechaCreado.Text;
                row.Cells["fecha_respuesta"].Value = TFechaRespuesta.Text;
                row.Cells["respuesta"].Value = TRespuesta.Text;

                VaciarCampos();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }
    }
}
