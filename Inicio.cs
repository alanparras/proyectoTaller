using CapaEntidades;
using CapaNegocio;
using FontAwesome.Sharp;
using ProyectoTallerG8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaLogin
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconButton BotonActivo = null;
        private static Form FormularioActivo = null;


        public Inicio(Usuario objUser)
        {
            usuarioActual = objUser;
            InitializeComponent();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            //if (usuarioActual == null)
            //{
            //    Console.WriteLine("El objeto usuarioActual es null.");
            //}
            //else if (usuarioActual.id_usuario == 0)
            //{
            //    Console.WriteLine("El id_usuario no es válido.");
            //}
            //else
            //{
            //    Console.WriteLine("Usuario válido. ID: " + usuarioActual.id_usuario);
            //}

            List<Permiso> ListaPermisos = new Permiso_negocio().Listar(usuarioActual.id_usuario);

            foreach (Control control in menu.Controls)
            {
                if (control is IconButton iconMenu)
                {
                    bool encontrado = ListaPermisos.Any(m => m.nombreAcceso == iconMenu.Name);

                    // Si el permiso no se encuentra, oculta el botón
                    iconMenu.Visible = encontrado;
                }
            }

            LogOutButton.Visible = true;

            // Ajusta el layout según la cantidad de botones visibles
            int botonesVisibles = menu.Controls.OfType<IconButton>().Count(b => b.Visible);

            menu.RowStyles.Clear();
            menu.RowCount = botonesVisibles;

            for (int i = 0; i < botonesVisibles; i++)
            {
                menu.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / botonesVisibles));
            }

            //// Ajusta cada botón visible para que ocupe el espacio completo de su celda
            //foreach (Control control in menu.Controls.OfType<IconButton>().Where(b => b.Visible))
            //{
            //    control.Dock = DockStyle.Fill; // Expande el botón para ocupar todo el ancho y alto de su celda
            //}

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormulario(IconButton boton, Form formulario)
        {

            if (BotonActivo != null)
            {
                BotonActivo.BackColor = Color.SteelBlue;
            }
            boton.BackColor = Color.Silver;
            BotonActivo = boton;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FormUsuarios());
        }

        private void MsgButton_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FormMensajes());
        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FormStats());
        }


        private void ReceiptsButton_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FormRecibos());
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FormProductos());
        }

        private void UsersButton_Paint(object sender, PaintEventArgs e)
        {
            IconButton btn = sender as IconButton;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Definir el radio para las esquinas redondeadas
            int borderRadius = 20;
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);

            // Crear un path con esquinas redondeadas
            using (GraphicsPath path = new GraphicsPath())
            {
                float diameter = borderRadius * 2;
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Esquina superior izquierda
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // Esquina superior derecha
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Esquina inferior derecha
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // Esquina inferior izquierda
                path.CloseFigure();

                // Rellenar el botón con el color de fondo
                using (Brush brush = new SolidBrush(btn.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Dibujar el borde del botón
                using (Pen pen = new Pen(btn.ForeColor, 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }

                // Dibujar el texto centrado en el botón
                TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, rect, btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                // Dibujar el ícono en el botón
                if (btn.IconChar != IconChar.None)
                {
                    Rectangle iconRect = new Rectangle((btn.Width - btn.IconSize) / 2,
                                                       (btn.Height - btn.IconSize) / 2,
                                                       btn.IconSize, btn.IconSize);
                    IconChar icon = btn.IconChar;
                    Font iconFont = new Font(btn.IconFont.ToString(), btn.IconSize);
                    e.Graphics.DrawString(icon.ToString(), iconFont, new SolidBrush(btn.IconColor), iconRect);
                }
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
