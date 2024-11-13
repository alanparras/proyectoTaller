using CapaEntidades;
using CapaNegocio;
using ProyectoTallerG8;
using System;
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
    public partial class FormConsultas : Form
    {
        public FormConsultas()
        {
            InitializeComponent();
        }


        private void FormConsultas_Load(object sender, EventArgs e)
        {
            List<Consulta> listaConsulta = new Consulta_negocio().Listar();
            //Console.WriteLine($"Número de consultas encontrados: {listaConsulta.Count}");
            foreach (Consulta item in listaConsulta)
            {
                consultasDataGridView.Rows.Add(new object[] {
                    "",
                    item.id_consulta,
                    item.nombreCliente,
                    item.apellidoCliente,
                    item.usuarioCliente,
                    item.correoCliente,
                    item.mensaje,
                    item.created_at,
                    item.updated_at,
                    item.respuesta,
                });
            }
        }

        private void VaciarCampos()
        {
            TID_consulta.Text = "";
            TUsuario.Text = "";
            TNombre.Text = "";
            TApellido.Text = "";
            TEmail.Text = "";
            TMensaje.Text = "";
            TFechaCreado.Text = "";
            TFechaRespuesta.Text = "";
            TRespuesta.Text = "";
        }
        private void consultasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (consultasDataGridView.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    TBIndice.Text = indice.ToString();

                    TID_consulta.Text = consultasDataGridView.Rows[indice].Cells["id_consulta"].Value.ToString();
                    TUsuario.Text = consultasDataGridView.Rows[indice].Cells["usuario"].Value.ToString();
                    TNombre.Text = consultasDataGridView.Rows[indice].Cells["nombre"].Value.ToString();
                    TApellido.Text = consultasDataGridView.Rows[indice].Cells["apellido"].Value.ToString();
                    TEmail.Text = consultasDataGridView.Rows[indice].Cells["correo"].Value.ToString();
                    TMensaje.Text = consultasDataGridView.Rows[indice].Cells["mensaje"].Value.ToString();
                    TFechaCreado.Text = consultasDataGridView.Rows[indice].Cells["fecha_mensaje"].Value.ToString();
                    TFechaRespuesta.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    TRespuesta.Text = "";
                }
            }
        }

        private void consultasDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void BEnviarRespuesta_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Consulta objConsulta = new Consulta()
            {
                id_consulta = Convert.ToInt32(TID_consulta.Text),
                usuarioCliente = TUsuario.Text,
                nombreCliente = TNombre.Text,
                apellidoCliente = TApellido.Text,
                correoCliente = TEmail.Text,
                mensaje = TMensaje.Text,
                created_at = TFechaCreado.Text,
                updated_at = TFechaRespuesta.Text,
                respuesta = TRespuesta.Text,
            };

            bool resultado = new Consulta_negocio().Registrar(objConsulta, out mensaje);

            if (resultado)
            {
                DataGridViewRow row = consultasDataGridView.Rows[Convert.ToInt32(TBIndice.Text)];

                row.Cells["id_consulta"].Value = TID_consulta.Text;
                row.Cells["nombre"].Value = TNombre.Text;
                row.Cells["apellido"].Value = TApellido.Text;
                row.Cells["usuario"].Value = TUsuario.Text;
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

        private void TUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
