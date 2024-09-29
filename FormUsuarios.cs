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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using pruebaLogin.Utilidades;

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
            
            // TODO: esta línea de código carga datos en la tabla 'dataSet11.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter1.Fill(this.dataSet11.usuarios);

            CBEstado.Items.Add(new OpcionSelectUsuario() { Valor = "NO", Texto = "Dado de Alta" });
            CBEstado.Items.Add(new OpcionSelectUsuario() { Valor = "SI", Texto = "Dado de Baja"});
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = 0;

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

        }
    }
}
