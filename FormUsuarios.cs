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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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

        private void TUserA_TextChanged(object sender, EventArgs e)
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
            var Form1 = new FormUsuarios();
            Form1.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            var FormMensajes = new FormMensajes();
            FormMensajes.Show();
            this.Hide();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            var FormConsultas = new FormConsultas();
            FormConsultas.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
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

        private void holaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
