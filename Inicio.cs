using FontAwesome.Sharp;
using ProyectoTallerG8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaLogin
{
    public partial class Inicio : Form
    {
        private static IconButton BotonActivo = null;
        private static Form FormularioActivo = null;

        public Inicio()
        {
            InitializeComponent();
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

        private void ConsultasButton_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FormConsultas());
        }
    }
}
