﻿namespace ProyectoTallerG8
{
    partial class FormConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.consultasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new pruebaLogin.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TConfPassA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TZipA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TAddressA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TEmailA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TSNameA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TNameA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TPassA = new System.Windows.Forms.TextBox();
            this.LPass = new System.Windows.Forms.Label();
            this.TUserA = new System.Windows.Forms.TextBox();
            this.LUser = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProyectoTallerG8.DataSet1();
            this.usuariosTableAdapter1 = new pruebaLogin.DataSet1TableAdapters.usuariosTableAdapter();
            this.tableAdapterManager1 = new pruebaLogin.DataSet1TableAdapters.TableAdapterManager();
            this.usuariosTableAdapter = new ProyectoTallerG8.DataSet1TableAdapters.usuariosTableAdapter();
            this.tableAdapterManager = new ProyectoTallerG8.DataSet1TableAdapters.TableAdapterManager();
            this.mensajesTableAdapter = new pruebaLogin.DataSet1TableAdapters.mensajesTableAdapter();
            this.consultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultasTableAdapter = new pruebaLogin.DataSet1TableAdapters.consultasTableAdapter();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensajesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.93609F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.06391F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1064, 525);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.consultasDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(130, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.47748F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.63063F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(931, 519);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // consultasDataGridView
            // 
            this.consultasDataGridView.AllowUserToAddRows = false;
            this.consultasDataGridView.AllowUserToDeleteRows = false;
            this.consultasDataGridView.AutoGenerateColumns = false;
            this.consultasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.consultasDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.consultasDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.consultasDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consultasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.consultasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.correo,
            this.mensaje,
            this.leido,
            this.created_at,
            this.dataGridViewTextBoxColumn2});
            this.consultasDataGridView.DataSource = this.mensajesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.consultasDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.consultasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consultasDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.consultasDataGridView.Location = new System.Drawing.Point(3, 275);
            this.consultasDataGridView.Name = "consultasDataGridView";
            this.consultasDataGridView.ReadOnly = true;
            this.consultasDataGridView.Size = new System.Drawing.Size(925, 210);
            this.consultasDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 147;
            // 
            // correo
            // 
            this.correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.correo.DataPropertyName = "correo";
            this.correo.Frozen = true;
            this.correo.HeaderText = "correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 147;
            // 
            // mensaje
            // 
            this.mensaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mensaje.DataPropertyName = "mensaje";
            this.mensaje.Frozen = true;
            this.mensaje.HeaderText = "mensaje";
            this.mensaje.Name = "mensaje";
            this.mensaje.ReadOnly = true;
            this.mensaje.Width = 147;
            // 
            // leido
            // 
            this.leido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.leido.DataPropertyName = "leido";
            this.leido.HeaderText = "leido";
            this.leido.Name = "leido";
            this.leido.ReadOnly = true;
            this.leido.Width = 147;
            // 
            // created_at
            // 
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "created_at";
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // mensajesBindingSource
            // 
            this.mensajesBindingSource.DataMember = "mensajes";
            this.mensajesBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.TConfPassA);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TZipA);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TAddressA);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TEmailA);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TSNameA);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TNameA);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TPassA);
            this.panel1.Controls.Add(this.LPass);
            this.panel1.Controls.Add(this.TUserA);
            this.panel1.Controls.Add(this.LUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 266);
            this.panel1.TabIndex = 5;
            // 
            // TConfPassA
            // 
            this.TConfPassA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TConfPassA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TConfPassA.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TConfPassA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TConfPassA.Location = new System.Drawing.Point(14, 195);
            this.TConfPassA.Name = "TConfPassA";
            this.TConfPassA.Size = new System.Drawing.Size(232, 27);
            this.TConfPassA.TabIndex = 19;
            this.TConfPassA.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(10, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Confirmar Contraseña";
            // 
            // TZipA
            // 
            this.TZipA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TZipA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TZipA.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TZipA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TZipA.Location = new System.Drawing.Point(276, 195);
            this.TZipA.Name = "TZipA";
            this.TZipA.Size = new System.Drawing.Size(232, 27);
            this.TZipA.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(272, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Codigo Postal";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TAddressA
            // 
            this.TAddressA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TAddressA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TAddressA.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAddressA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TAddressA.Location = new System.Drawing.Point(276, 140);
            this.TAddressA.Name = "TAddressA";
            this.TAddressA.Size = new System.Drawing.Size(232, 27);
            this.TAddressA.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(272, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Domicilio";
            // 
            // TEmailA
            // 
            this.TEmailA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TEmailA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEmailA.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEmailA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TEmailA.Location = new System.Drawing.Point(14, 84);
            this.TEmailA.Name = "TEmailA";
            this.TEmailA.Size = new System.Drawing.Size(232, 27);
            this.TEmailA.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(10, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "E-mail";
            // 
            // TSNameA
            // 
            this.TSNameA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TSNameA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TSNameA.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSNameA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TSNameA.Location = new System.Drawing.Point(276, 84);
            this.TSNameA.Name = "TSNameA";
            this.TSNameA.Size = new System.Drawing.Size(232, 27);
            this.TSNameA.TabIndex = 11;
            this.TSNameA.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(272, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TNameA
            // 
            this.TNameA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TNameA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TNameA.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNameA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TNameA.Location = new System.Drawing.Point(276, 29);
            this.TNameA.Name = "TNameA";
            this.TNameA.Size = new System.Drawing.Size(232, 27);
            this.TNameA.TabIndex = 9;
            this.TNameA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(271, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TPassA
            // 
            this.TPassA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TPassA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPassA.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPassA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TPassA.Location = new System.Drawing.Point(14, 140);
            this.TPassA.Name = "TPassA";
            this.TPassA.Size = new System.Drawing.Size(232, 27);
            this.TPassA.TabIndex = 7;
            this.TPassA.UseSystemPasswordChar = true;
            // 
            // LPass
            // 
            this.LPass.AutoSize = true;
            this.LPass.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LPass.Location = new System.Drawing.Point(10, 114);
            this.LPass.Name = "LPass";
            this.LPass.Size = new System.Drawing.Size(82, 23);
            this.LPass.TabIndex = 6;
            this.LPass.Text = "Contraseña";
            // 
            // TUserA
            // 
            this.TUserA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TUserA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TUserA.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUserA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TUserA.Location = new System.Drawing.Point(14, 29);
            this.TUserA.Name = "TUserA";
            this.TUserA.Size = new System.Drawing.Size(232, 27);
            this.TUserA.TabIndex = 5;
            this.TUserA.TextChanged += new System.EventHandler(this.TUserA_TextChanged);
            // 
            // LUser
            // 
            this.LUser.AutoSize = true;
            this.LUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LUser.Location = new System.Drawing.Point(10, 3);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(58, 23);
            this.LUser.TabIndex = 4;
            this.LUser.Text = "Usuario";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.iconButton7, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.iconButton6, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.iconButton5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.iconButton4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.iconButton3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.iconButton2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.iconButton1, 0, 6);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(121, 519);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // iconButton7
            // 
            this.iconButton7.AutoSize = true;
            this.iconButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton7.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.Color.Silver;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.iconButton7.IconColor = System.Drawing.Color.Silver;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.Location = new System.Drawing.Point(3, 373);
            this.iconButton7.MinimumSize = new System.Drawing.Size(120, 70);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(120, 70);
            this.iconButton7.TabIndex = 10;
            this.iconButton7.Text = "Recibos";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton7.UseVisualStyleBackColor = true;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // iconButton6
            // 
            this.iconButton6.AutoSize = true;
            this.iconButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.ForeColor = System.Drawing.Color.Silver;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.iconButton6.IconColor = System.Drawing.Color.Silver;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.Location = new System.Drawing.Point(3, 299);
            this.iconButton6.MinimumSize = new System.Drawing.Size(120, 70);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(120, 70);
            this.iconButton6.TabIndex = 9;
            this.iconButton6.Text = "Estadísticas";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.AutoSize = true;
            this.iconButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.Silver;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.iconButton5.IconColor = System.Drawing.Color.Silver;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(3, 225);
            this.iconButton5.MinimumSize = new System.Drawing.Size(120, 70);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(120, 70);
            this.iconButton5.TabIndex = 8;
            this.iconButton5.Text = "Productos";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.AutoSize = true;
            this.iconButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.Silver;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconButton4.IconColor = System.Drawing.Color.Silver;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(3, 151);
            this.iconButton4.MinimumSize = new System.Drawing.Size(120, 70);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(120, 70);
            this.iconButton4.TabIndex = 7;
            this.iconButton4.Text = "Mensajes";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.AutoSize = true;
            this.iconButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.Silver;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.iconButton3.IconColor = System.Drawing.Color.Silver;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(3, 77);
            this.iconButton3.MinimumSize = new System.Drawing.Size(120, 70);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(120, 70);
            this.iconButton3.TabIndex = 6;
            this.iconButton3.Text = "Consultas";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.AutoSize = true;
            this.iconButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Silver;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton2.IconColor = System.Drawing.Color.Silver;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(3, 3);
            this.iconButton2.MinimumSize = new System.Drawing.Size(120, 70);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(120, 70);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.Text = "Usuarios";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.AutoSize = true;
            this.iconButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Silver;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.iconButton1.IconColor = System.Drawing.Color.Silver;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(3, 447);
            this.iconButton1.MinimumSize = new System.Drawing.Size(120, 70);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(120, 70);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Cerrar Sesión";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "usuarios";
            this.usuariosBindingSource1.DataSource = this.dataSet11;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.consultasTableAdapter = null;
            this.tableAdapterManager1.mensajesTableAdapter = null;
            this.tableAdapterManager1.productos_pcTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = pruebaLogin.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ventas_cabeceraTableAdapter = null;
            this.tableAdapterManager1.ventas_detalleTableAdapter = null;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.consultasTableAdapter = null;
            this.tableAdapterManager.mensajesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoTallerG8.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // mensajesTableAdapter
            // 
            this.mensajesTableAdapter.ClearBeforeFill = true;
            // 
            // consultasBindingSource
            // 
            this.consultasBindingSource.DataMember = "consultas";
            this.consultasBindingSource.DataSource = this.dataSet11;
            // 
            // consultasTableAdapter
            // 
            this.consultasTableAdapter.ClearBeforeFill = true;
            // 
            // FormConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1064, 525);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(1080, 564);
            this.Name = "FormConsultas";
            this.Text = "FormConsultas";
            this.Load += new System.EventHandler(this.FormConsultas_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensajesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DataSet1TableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private pruebaLogin.DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private pruebaLogin.DataSet1TableAdapters.usuariosTableAdapter usuariosTableAdapter1;
        private pruebaLogin.DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView consultasDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TNameA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TPassA;
        private System.Windows.Forms.Label LPass;
        private System.Windows.Forms.TextBox TUserA;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.TextBox TEmailA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TSNameA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TZipA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TAddressA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TConfPassA;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.BindingSource mensajesBindingSource;
        private pruebaLogin.DataSet1TableAdapters.mensajesTableAdapter mensajesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensaje;
        private System.Windows.Forms.DataGridViewCheckBoxColumn leido;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource consultasBindingSource;
        private pruebaLogin.DataSet1TableAdapters.consultasTableAdapter consultasTableAdapter;
    }
}