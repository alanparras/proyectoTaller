﻿using CapaEntidades;
using CapaNegocio;
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
        private static Usuario usuarioActual;
        private static IconButton BotonActivo = null;
        private static Form FormularioActivo = null;


        public Inicio()
        {
            //usuarioActual = objUser;
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

        private void Inicio_Load(object sender, EventArgs e)
        {
            //List<Permiso> ListaPermisos = new Permiso_negocio().Listar(usuarioActual.id_usuario);

            //foreach (IconMenuItem iconMenu in menu.RowStyles)
            //{
            //    bool encontrado = ListaPermisos.Any(m => m.nombreAcceso ==  iconMenu.Name);

            //    if (encontrado == false)
            //    {
            //        iconMenu.Visible = false;
            //    }
            //}

        }

        private void ReceiptsButton_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FormRecibos());
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FormProductos());
        }
    }
}
