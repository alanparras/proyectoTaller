namespace ProyectoTallerG8
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.usuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.ReceiptsButton = new FontAwesome.Sharp.IconButton();
            this.StatsButton = new FontAwesome.Sharp.IconButton();
            this.ProductsButton = new FontAwesome.Sharp.IconButton();
            this.MsgButton = new FontAwesome.Sharp.IconButton();
            this.ConsultasButton = new FontAwesome.Sharp.IconButton();
            this.UsersButton = new FontAwesome.Sharp.IconButton();
            this.LogOutButton = new FontAwesome.Sharp.IconButton();
            this.usuariosTableAdapter1 = new pruebaLogin.DataSet1TableAdapters.usuariosTableAdapter();
            this.tableAdapterManager1 = new pruebaLogin.DataSet1TableAdapters.TableAdapterManager();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProyectoTallerG8.DataSet1();
            this.usuariosTableAdapter = new ProyectoTallerG8.DataSet1TableAdapters.usuariosTableAdapter();
            this.tableAdapterManager = new ProyectoTallerG8.DataSet1TableAdapters.TableAdapterManager();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.usuariosDataGridView, 0, 1);
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
            // usuariosDataGridView
            // 
            this.usuariosDataGridView.AllowUserToAddRows = false;
            this.usuariosDataGridView.AllowUserToDeleteRows = false;
            this.usuariosDataGridView.AutoGenerateColumns = false;
            this.usuariosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usuariosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usuariosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.usuariosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuariosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.usuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.usuariosDataGridView.DataSource = this.usuariosBindingSource1;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usuariosDataGridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.usuariosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usuariosDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.usuariosDataGridView.Location = new System.Drawing.Point(3, 275);
            this.usuariosDataGridView.Name = "usuariosDataGridView";
            this.usuariosDataGridView.ReadOnly = true;
            this.usuariosDataGridView.Size = new System.Drawing.Size(925, 210);
            this.usuariosDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "baja";
            this.dataGridViewTextBoxColumn4.HeaderText = "baja";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "perfil_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "perfil_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "usuario";
            this.dataGridViewTextBoxColumn6.HeaderText = "usuario";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn7.HeaderText = "email";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "domicilio";
            this.dataGridViewTextBoxColumn8.HeaderText = "domicilio";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "zipcode";
            this.dataGridViewTextBoxColumn9.HeaderText = "zipcode";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "usuarios";
            this.usuariosBindingSource1.DataSource = this.dataSet11;
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
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.ReceiptsButton, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.StatsButton, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.ProductsButton, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.MsgButton, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.ConsultasButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.UsersButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.LogOutButton, 0, 6);
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
            // ReceiptsButton
            // 
            this.ReceiptsButton.AutoSize = true;
            this.ReceiptsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReceiptsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReceiptsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReceiptsButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptsButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.ReceiptsButton.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.ReceiptsButton.IconColor = System.Drawing.Color.AliceBlue;
            this.ReceiptsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReceiptsButton.Location = new System.Drawing.Point(3, 373);
            this.ReceiptsButton.MinimumSize = new System.Drawing.Size(120, 70);
            this.ReceiptsButton.Name = "ReceiptsButton";
            this.ReceiptsButton.Size = new System.Drawing.Size(120, 70);
            this.ReceiptsButton.TabIndex = 10;
            this.ReceiptsButton.Text = "Recibos";
            this.ReceiptsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ReceiptsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ReceiptsButton.UseVisualStyleBackColor = true;
            this.ReceiptsButton.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // StatsButton
            // 
            this.StatsButton.AutoSize = true;
            this.StatsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StatsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatsButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.StatsButton.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.StatsButton.IconColor = System.Drawing.Color.AliceBlue;
            this.StatsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StatsButton.Location = new System.Drawing.Point(3, 299);
            this.StatsButton.MinimumSize = new System.Drawing.Size(120, 70);
            this.StatsButton.Name = "StatsButton";
            this.StatsButton.Size = new System.Drawing.Size(120, 70);
            this.StatsButton.TabIndex = 9;
            this.StatsButton.Text = "Estadísticas";
            this.StatsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StatsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StatsButton.UseVisualStyleBackColor = true;
            this.StatsButton.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.AutoSize = true;
            this.ProductsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProductsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.ProductsButton.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.ProductsButton.IconColor = System.Drawing.Color.AliceBlue;
            this.ProductsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProductsButton.Location = new System.Drawing.Point(3, 225);
            this.ProductsButton.MinimumSize = new System.Drawing.Size(120, 70);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(120, 70);
            this.ProductsButton.TabIndex = 8;
            this.ProductsButton.Text = "Productos";
            this.ProductsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProductsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ProductsButton.UseVisualStyleBackColor = true;
            this.ProductsButton.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // MsgButton
            // 
            this.MsgButton.AutoSize = true;
            this.MsgButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MsgButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MsgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MsgButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.MsgButton.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.MsgButton.IconColor = System.Drawing.Color.AliceBlue;
            this.MsgButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MsgButton.Location = new System.Drawing.Point(3, 151);
            this.MsgButton.MinimumSize = new System.Drawing.Size(120, 70);
            this.MsgButton.Name = "MsgButton";
            this.MsgButton.Size = new System.Drawing.Size(120, 70);
            this.MsgButton.TabIndex = 7;
            this.MsgButton.Text = "Mensajes";
            this.MsgButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MsgButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MsgButton.UseVisualStyleBackColor = true;
            this.MsgButton.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // ConsultasButton
            // 
            this.ConsultasButton.AutoSize = true;
            this.ConsultasButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConsultasButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultasButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.ConsultasButton.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.ConsultasButton.IconColor = System.Drawing.Color.AliceBlue;
            this.ConsultasButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ConsultasButton.Location = new System.Drawing.Point(3, 77);
            this.ConsultasButton.MinimumSize = new System.Drawing.Size(120, 70);
            this.ConsultasButton.Name = "ConsultasButton";
            this.ConsultasButton.Size = new System.Drawing.Size(120, 70);
            this.ConsultasButton.TabIndex = 6;
            this.ConsultasButton.Text = "Consultas";
            this.ConsultasButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConsultasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ConsultasButton.UseVisualStyleBackColor = true;
            this.ConsultasButton.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // UsersButton
            // 
            this.UsersButton.AutoSize = true;
            this.UsersButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UsersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.UsersButton.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.UsersButton.IconColor = System.Drawing.Color.AliceBlue;
            this.UsersButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UsersButton.Location = new System.Drawing.Point(3, 3);
            this.UsersButton.MinimumSize = new System.Drawing.Size(120, 70);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(120, 70);
            this.UsersButton.TabIndex = 5;
            this.UsersButton.Text = "Usuarios";
            this.UsersButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UsersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.AutoSize = true;
            this.LogOutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogOutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.LogOutButton.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.LogOutButton.IconColor = System.Drawing.Color.AliceBlue;
            this.LogOutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogOutButton.Location = new System.Drawing.Point(3, 447);
            this.LogOutButton.MinimumSize = new System.Drawing.Size(120, 70);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(120, 70);
            this.LogOutButton.TabIndex = 4;
            this.LogOutButton.Text = "Cerrar Sesión";
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LogOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.iconButton1_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1064, 525);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(1080, 564);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
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
        private System.Windows.Forms.DataGridView usuariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
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
        private FontAwesome.Sharp.IconButton LogOutButton;
        private FontAwesome.Sharp.IconButton ReceiptsButton;
        private FontAwesome.Sharp.IconButton StatsButton;
        private FontAwesome.Sharp.IconButton ProductsButton;
        private FontAwesome.Sharp.IconButton MsgButton;
        private FontAwesome.Sharp.IconButton ConsultasButton;
        private FontAwesome.Sharp.IconButton UsersButton;
    }
}