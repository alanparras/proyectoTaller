namespace ProyectoTallerG8
{
    partial class FormUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TCUsuarios = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PanelAltaUser = new System.Windows.Forms.Panel();
            this.TIndice = new System.Windows.Forms.TextBox();
            this.TID_user = new System.Windows.Forms.TextBox();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.CBperfiles = new System.Windows.Forms.ComboBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.LPerfil = new System.Windows.Forms.Label();
            this.BRegisterUser = new System.Windows.Forms.Button();
            this.TPassConf = new System.Windows.Forms.TextBox();
            this.LPassConf = new System.Windows.Forms.Label();
            this.TCP = new System.Windows.Forms.TextBox();
            this.LCP = new System.Windows.Forms.Label();
            this.TDomicilio = new System.Windows.Forms.TextBox();
            this.LDomicilio = new System.Windows.Forms.Label();
            this.TEmail = new System.Windows.Forms.TextBox();
            this.LEmail = new System.Windows.Forms.Label();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.TPass = new System.Windows.Forms.TextBox();
            this.LPass = new System.Windows.Forms.Label();
            this.TUser = new System.Windows.Forms.TextBox();
            this.LUser = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PanelModificarUser = new System.Windows.Forms.Panel();
            this.TModificarConfirmPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TModificarPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BEliminar = new System.Windows.Forms.Button();
            this.TBModificarIndice = new System.Windows.Forms.TextBox();
            this.TModificarID_user = new System.Windows.Forms.TextBox();
            this.CBModificarPerfil = new System.Windows.Forms.ComboBox();
            this.LModificarEstado = new System.Windows.Forms.Label();
            this.CBModificarEstado = new System.Windows.Forms.ComboBox();
            this.LModificarPerfil = new System.Windows.Forms.Label();
            this.TModificarCP = new System.Windows.Forms.TextBox();
            this.LModificarCP = new System.Windows.Forms.Label();
            this.TModificarDomicilio = new System.Windows.Forms.TextBox();
            this.LModificarDomicio = new System.Windows.Forms.Label();
            this.TModificarEmail = new System.Windows.Forms.TextBox();
            this.LModificarEmail = new System.Windows.Forms.Label();
            this.TModificarAp = new System.Windows.Forms.TextBox();
            this.LModificarApellido = new System.Windows.Forms.Label();
            this.TModificarNombre = new System.Windows.Forms.TextBox();
            this.LModificarNombre = new System.Windows.Forms.Label();
            this.TModificarUser = new System.Windows.Forms.TextBox();
            this.LModificarUsuario = new System.Windows.Forms.Label();
            this.BModificar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new pruebaLogin.DataSet1();
            this.usuariosTableAdapter1 = new pruebaLogin.DataSet1TableAdapters.usuariosTableAdapter();
            this.tableAdapterManager1 = new pruebaLogin.DataSet1TableAdapters.TableAdapterManager();
            this.perfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfilesTableAdapter1 = new pruebaLogin.DataSet1TableAdapters.perfilesTableAdapter();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProyectoTallerG8.DataSet1();
            this.usuariosTableAdapter = new ProyectoTallerG8.DataSet1TableAdapters.usuariosTableAdapter();
            this.tableAdapterManager = new ProyectoTallerG8.DataSet1TableAdapters.TableAdapterManager();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bajaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.usuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TCUsuarios.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PanelAltaUser.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.PanelModificarUser.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.usuariosDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.88632F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.11368F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 700);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.97297F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.02703F));
            this.tableLayoutPanel4.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.TCUsuarios, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1076, 420);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.textSearch);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(616, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 414);
            this.panel2.TabIndex = 7;
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSearch.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textSearch.Location = new System.Drawing.Point(14, 51);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(232, 27);
            this.textSearch.TabIndex = 5;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label16.Location = new System.Drawing.Point(10, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 23);
            this.label16.TabIndex = 4;
            this.label16.Text = "Buscar...";
            // 
            // TCUsuarios
            // 
            this.TCUsuarios.AllowDrop = true;
            this.TCUsuarios.Controls.Add(this.tabPage1);
            this.TCUsuarios.Controls.Add(this.tabPage2);
            this.TCUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCUsuarios.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCUsuarios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TCUsuarios.Location = new System.Drawing.Point(3, 3);
            this.TCUsuarios.Multiline = true;
            this.TCUsuarios.Name = "TCUsuarios";
            this.TCUsuarios.SelectedIndex = 0;
            this.TCUsuarios.Size = new System.Drawing.Size(607, 414);
            this.TCUsuarios.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.PanelAltaUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(599, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alta de Usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PanelAltaUser
            // 
            this.PanelAltaUser.AutoScroll = true;
            this.PanelAltaUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PanelAltaUser.Controls.Add(this.TIndice);
            this.PanelAltaUser.Controls.Add(this.TID_user);
            this.PanelAltaUser.Controls.Add(this.CBEstado);
            this.PanelAltaUser.Controls.Add(this.CBperfiles);
            this.PanelAltaUser.Controls.Add(this.LEstado);
            this.PanelAltaUser.Controls.Add(this.LPerfil);
            this.PanelAltaUser.Controls.Add(this.BRegisterUser);
            this.PanelAltaUser.Controls.Add(this.TPassConf);
            this.PanelAltaUser.Controls.Add(this.LPassConf);
            this.PanelAltaUser.Controls.Add(this.TCP);
            this.PanelAltaUser.Controls.Add(this.LCP);
            this.PanelAltaUser.Controls.Add(this.TDomicilio);
            this.PanelAltaUser.Controls.Add(this.LDomicilio);
            this.PanelAltaUser.Controls.Add(this.TEmail);
            this.PanelAltaUser.Controls.Add(this.LEmail);
            this.PanelAltaUser.Controls.Add(this.TApellido);
            this.PanelAltaUser.Controls.Add(this.LApellido);
            this.PanelAltaUser.Controls.Add(this.TNombre);
            this.PanelAltaUser.Controls.Add(this.LNombre);
            this.PanelAltaUser.Controls.Add(this.TPass);
            this.PanelAltaUser.Controls.Add(this.LPass);
            this.PanelAltaUser.Controls.Add(this.TUser);
            this.PanelAltaUser.Controls.Add(this.LUser);
            this.PanelAltaUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAltaUser.Location = new System.Drawing.Point(3, 3);
            this.PanelAltaUser.Name = "PanelAltaUser";
            this.PanelAltaUser.Size = new System.Drawing.Size(593, 377);
            this.PanelAltaUser.TabIndex = 7;
            // 
            // TIndice
            // 
            this.TIndice.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TIndice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TIndice.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIndice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TIndice.Location = new System.Drawing.Point(38, 331);
            this.TIndice.Name = "TIndice";
            this.TIndice.Size = new System.Drawing.Size(36, 27);
            this.TIndice.TabIndex = 50;
            this.TIndice.Text = "-1";
            this.TIndice.Visible = false;
            this.TIndice.TextChanged += new System.EventHandler(this.TIndice_TextChanged);
            // 
            // TID_user
            // 
            this.TID_user.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TID_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TID_user.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TID_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TID_user.Location = new System.Drawing.Point(81, 331);
            this.TID_user.Name = "TID_user";
            this.TID_user.Size = new System.Drawing.Size(36, 27);
            this.TID_user.TabIndex = 49;
            this.TID_user.Text = "0";
            this.TID_user.Visible = false;
            // 
            // CBEstado
            // 
            this.CBEstado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CBEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource1, "baja", true));
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(309, 160);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(232, 26);
            this.CBEstado.TabIndex = 25;
            this.CBEstado.SelectedIndexChanged += new System.EventHandler(this.CBEstado_SelectedIndexChanged);
            // 
            // CBperfiles
            // 
            this.CBperfiles.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CBperfiles.DisplayMember = "id_perfiles";
            this.CBperfiles.FormattingEnabled = true;
            this.CBperfiles.Location = new System.Drawing.Point(309, 107);
            this.CBperfiles.Name = "CBperfiles";
            this.CBperfiles.Size = new System.Drawing.Size(231, 26);
            this.CBperfiles.TabIndex = 24;
            this.CBperfiles.ValueMember = "id_perfiles";
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LEstado.Location = new System.Drawing.Point(305, 134);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(52, 23);
            this.LEstado.TabIndex = 24;
            this.LEstado.Text = "Estado";
            // 
            // LPerfil
            // 
            this.LPerfil.AutoSize = true;
            this.LPerfil.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LPerfil.Location = new System.Drawing.Point(305, 79);
            this.LPerfil.Name = "LPerfil";
            this.LPerfil.Size = new System.Drawing.Size(43, 23);
            this.LPerfil.TabIndex = 22;
            this.LPerfil.Text = "Perfil";
            // 
            // BRegisterUser
            // 
            this.BRegisterUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.BRegisterUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BRegisterUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegisterUser.ForeColor = System.Drawing.Color.White;
            this.BRegisterUser.Location = new System.Drawing.Point(447, 342);
            this.BRegisterUser.Name = "BRegisterUser";
            this.BRegisterUser.Size = new System.Drawing.Size(143, 32);
            this.BRegisterUser.TabIndex = 20;
            this.BRegisterUser.Text = "Registrar Usuario";
            this.BRegisterUser.UseVisualStyleBackColor = false;
            this.BRegisterUser.Click += new System.EventHandler(this.BRegisterUser_Click);
            // 
            // TPassConf
            // 
            this.TPassConf.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TPassConf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPassConf.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPassConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TPassConf.Location = new System.Drawing.Point(39, 269);
            this.TPassConf.Name = "TPassConf";
            this.TPassConf.PasswordChar = '*';
            this.TPassConf.Size = new System.Drawing.Size(232, 27);
            this.TPassConf.TabIndex = 19;
            this.TPassConf.UseSystemPasswordChar = true;
            // 
            // LPassConf
            // 
            this.LPassConf.AutoSize = true;
            this.LPassConf.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LPassConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LPassConf.Location = new System.Drawing.Point(35, 244);
            this.LPassConf.Name = "LPassConf";
            this.LPassConf.Size = new System.Drawing.Size(150, 23);
            this.LPassConf.TabIndex = 18;
            this.LPassConf.Text = "Confirmar Contraseña";
            // 
            // TCP
            // 
            this.TCP.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TCP.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TCP.Location = new System.Drawing.Point(309, 271);
            this.TCP.Name = "TCP";
            this.TCP.Size = new System.Drawing.Size(232, 27);
            this.TCP.TabIndex = 17;
            // 
            // LCP
            // 
            this.LCP.AutoSize = true;
            this.LCP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LCP.Location = new System.Drawing.Point(305, 246);
            this.LCP.Name = "LCP";
            this.LCP.Size = new System.Drawing.Size(94, 23);
            this.LCP.TabIndex = 16;
            this.LCP.Text = "Codigo Postal";
            // 
            // TDomicilio
            // 
            this.TDomicilio.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TDomicilio.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDomicilio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TDomicilio.Location = new System.Drawing.Point(309, 216);
            this.TDomicilio.Name = "TDomicilio";
            this.TDomicilio.Size = new System.Drawing.Size(232, 27);
            this.TDomicilio.TabIndex = 15;
            // 
            // LDomicilio
            // 
            this.LDomicilio.AutoSize = true;
            this.LDomicilio.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LDomicilio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LDomicilio.Location = new System.Drawing.Point(305, 190);
            this.LDomicilio.Name = "LDomicilio";
            this.LDomicilio.Size = new System.Drawing.Size(67, 23);
            this.LDomicilio.TabIndex = 14;
            this.LDomicilio.Text = "Domicilio";
            // 
            // TEmail
            // 
            this.TEmail.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TEmail.Location = new System.Drawing.Point(39, 159);
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(232, 27);
            this.TEmail.TabIndex = 13;
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LEmail.Location = new System.Drawing.Point(35, 134);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(52, 23);
            this.LEmail.TabIndex = 12;
            this.LEmail.Text = "E-mail";
            // 
            // TApellido
            // 
            this.TApellido.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TApellido.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TApellido.Location = new System.Drawing.Point(39, 106);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(232, 27);
            this.TApellido.TabIndex = 11;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LApellido.Location = new System.Drawing.Point(35, 81);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(60, 23);
            this.LApellido.TabIndex = 10;
            this.LApellido.Text = "Apellido";
            // 
            // TNombre
            // 
            this.TNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TNombre.Location = new System.Drawing.Point(39, 51);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(232, 27);
            this.TNombre.TabIndex = 9;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LNombre.Location = new System.Drawing.Point(34, 26);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(58, 23);
            this.LNombre.TabIndex = 8;
            this.LNombre.Text = "Nombre";
            // 
            // TPass
            // 
            this.TPass.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPass.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TPass.Location = new System.Drawing.Point(39, 214);
            this.TPass.Name = "TPass";
            this.TPass.PasswordChar = '*';
            this.TPass.Size = new System.Drawing.Size(232, 27);
            this.TPass.TabIndex = 7;
            this.TPass.UseSystemPasswordChar = true;
            // 
            // LPass
            // 
            this.LPass.AutoSize = true;
            this.LPass.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LPass.Location = new System.Drawing.Point(35, 188);
            this.LPass.Name = "LPass";
            this.LPass.Size = new System.Drawing.Size(82, 23);
            this.LPass.TabIndex = 6;
            this.LPass.Text = "Contraseña";
            // 
            // TUser
            // 
            this.TUser.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TUser.Location = new System.Drawing.Point(309, 51);
            this.TUser.Name = "TUser";
            this.TUser.Size = new System.Drawing.Size(232, 27);
            this.TUser.TabIndex = 5;
            // 
            // LUser
            // 
            this.LUser.AutoSize = true;
            this.LUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LUser.Location = new System.Drawing.Point(305, 25);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(58, 23);
            this.LUser.TabIndex = 4;
            this.LUser.Text = "Usuario";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PanelModificarUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(599, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Usuario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PanelModificarUser
            // 
            this.PanelModificarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PanelModificarUser.Controls.Add(this.TModificarConfirmPass);
            this.PanelModificarUser.Controls.Add(this.label1);
            this.PanelModificarUser.Controls.Add(this.TModificarPass);
            this.PanelModificarUser.Controls.Add(this.label2);
            this.PanelModificarUser.Controls.Add(this.BEliminar);
            this.PanelModificarUser.Controls.Add(this.TBModificarIndice);
            this.PanelModificarUser.Controls.Add(this.TModificarID_user);
            this.PanelModificarUser.Controls.Add(this.CBModificarPerfil);
            this.PanelModificarUser.Controls.Add(this.LModificarEstado);
            this.PanelModificarUser.Controls.Add(this.CBModificarEstado);
            this.PanelModificarUser.Controls.Add(this.LModificarPerfil);
            this.PanelModificarUser.Controls.Add(this.TModificarCP);
            this.PanelModificarUser.Controls.Add(this.LModificarCP);
            this.PanelModificarUser.Controls.Add(this.TModificarDomicilio);
            this.PanelModificarUser.Controls.Add(this.LModificarDomicio);
            this.PanelModificarUser.Controls.Add(this.TModificarEmail);
            this.PanelModificarUser.Controls.Add(this.LModificarEmail);
            this.PanelModificarUser.Controls.Add(this.TModificarAp);
            this.PanelModificarUser.Controls.Add(this.LModificarApellido);
            this.PanelModificarUser.Controls.Add(this.TModificarNombre);
            this.PanelModificarUser.Controls.Add(this.LModificarNombre);
            this.PanelModificarUser.Controls.Add(this.TModificarUser);
            this.PanelModificarUser.Controls.Add(this.LModificarUsuario);
            this.PanelModificarUser.Controls.Add(this.BModificar);
            this.PanelModificarUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelModificarUser.Location = new System.Drawing.Point(3, 3);
            this.PanelModificarUser.Name = "PanelModificarUser";
            this.PanelModificarUser.Size = new System.Drawing.Size(593, 377);
            this.PanelModificarUser.TabIndex = 8;
            this.PanelModificarUser.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelModificarUser_Paint);
            // 
            // TModificarConfirmPass
            // 
            this.TModificarConfirmPass.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarConfirmPass.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarConfirmPass.Location = new System.Drawing.Point(37, 271);
            this.TModificarConfirmPass.Name = "TModificarConfirmPass";
            this.TModificarConfirmPass.PasswordChar = '*';
            this.TModificarConfirmPass.Size = new System.Drawing.Size(232, 27);
            this.TModificarConfirmPass.TabIndex = 53;
            this.TModificarConfirmPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(33, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "Confirmar Contraseña";
            // 
            // TModificarPass
            // 
            this.TModificarPass.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarPass.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarPass.Location = new System.Drawing.Point(37, 216);
            this.TModificarPass.Name = "TModificarPass";
            this.TModificarPass.PasswordChar = '*';
            this.TModificarPass.Size = new System.Drawing.Size(232, 27);
            this.TModificarPass.TabIndex = 51;
            this.TModificarPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(33, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 50;
            this.label2.Text = "Contraseña";
            // 
            // BEliminar
            // 
            this.BEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.BEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BEliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEliminar.ForeColor = System.Drawing.Color.White;
            this.BEliminar.Location = new System.Drawing.Point(290, 342);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(143, 32);
            this.BEliminar.TabIndex = 49;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = false;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // TBModificarIndice
            // 
            this.TBModificarIndice.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TBModificarIndice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBModificarIndice.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBModificarIndice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBModificarIndice.Location = new System.Drawing.Point(36, 329);
            this.TBModificarIndice.Name = "TBModificarIndice";
            this.TBModificarIndice.Size = new System.Drawing.Size(36, 27);
            this.TBModificarIndice.TabIndex = 48;
            this.TBModificarIndice.Text = "-1";
            this.TBModificarIndice.Visible = false;
            // 
            // TModificarID_user
            // 
            this.TModificarID_user.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarID_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarID_user.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarID_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarID_user.Location = new System.Drawing.Point(79, 329);
            this.TModificarID_user.Name = "TModificarID_user";
            this.TModificarID_user.Size = new System.Drawing.Size(36, 27);
            this.TModificarID_user.TabIndex = 47;
            this.TModificarID_user.Visible = false;
            // 
            // CBModificarPerfil
            // 
            this.CBModificarPerfil.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CBModificarPerfil.DisplayMember = "id_perfiles";
            this.CBModificarPerfil.FormattingEnabled = true;
            this.CBModificarPerfil.Location = new System.Drawing.Point(307, 107);
            this.CBModificarPerfil.Name = "CBModificarPerfil";
            this.CBModificarPerfil.Size = new System.Drawing.Size(231, 26);
            this.CBModificarPerfil.TabIndex = 46;
            this.CBModificarPerfil.ValueMember = "id_perfiles";
            this.CBModificarPerfil.SelectedIndexChanged += new System.EventHandler(this.CBModificarPerfil_SelectedIndexChanged);
            // 
            // LModificarEstado
            // 
            this.LModificarEstado.AutoSize = true;
            this.LModificarEstado.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LModificarEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarEstado.Location = new System.Drawing.Point(303, 134);
            this.LModificarEstado.Name = "LModificarEstado";
            this.LModificarEstado.Size = new System.Drawing.Size(52, 23);
            this.LModificarEstado.TabIndex = 44;
            this.LModificarEstado.Text = "Estado";
            // 
            // CBModificarEstado
            // 
            this.CBModificarEstado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CBModificarEstado.FormattingEnabled = true;
            this.CBModificarEstado.Location = new System.Drawing.Point(307, 160);
            this.CBModificarEstado.Name = "CBModificarEstado";
            this.CBModificarEstado.Size = new System.Drawing.Size(232, 26);
            this.CBModificarEstado.TabIndex = 43;
            // 
            // LModificarPerfil
            // 
            this.LModificarPerfil.AutoSize = true;
            this.LModificarPerfil.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LModificarPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarPerfil.Location = new System.Drawing.Point(303, 79);
            this.LModificarPerfil.Name = "LModificarPerfil";
            this.LModificarPerfil.Size = new System.Drawing.Size(43, 23);
            this.LModificarPerfil.TabIndex = 42;
            this.LModificarPerfil.Text = "Perfil";
            // 
            // TModificarCP
            // 
            this.TModificarCP.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarCP.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarCP.Location = new System.Drawing.Point(307, 271);
            this.TModificarCP.Name = "TModificarCP";
            this.TModificarCP.Size = new System.Drawing.Size(232, 27);
            this.TModificarCP.TabIndex = 38;
            // 
            // LModificarCP
            // 
            this.LModificarCP.AutoSize = true;
            this.LModificarCP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LModificarCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarCP.Location = new System.Drawing.Point(303, 246);
            this.LModificarCP.Name = "LModificarCP";
            this.LModificarCP.Size = new System.Drawing.Size(94, 23);
            this.LModificarCP.TabIndex = 37;
            this.LModificarCP.Text = "Codigo Postal";
            // 
            // TModificarDomicilio
            // 
            this.TModificarDomicilio.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarDomicilio.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarDomicilio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarDomicilio.Location = new System.Drawing.Point(307, 216);
            this.TModificarDomicilio.Name = "TModificarDomicilio";
            this.TModificarDomicilio.Size = new System.Drawing.Size(232, 27);
            this.TModificarDomicilio.TabIndex = 36;
            this.TModificarDomicilio.TextChanged += new System.EventHandler(this.TModificarDomicilio_TextChanged);
            // 
            // LModificarDomicio
            // 
            this.LModificarDomicio.AutoSize = true;
            this.LModificarDomicio.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LModificarDomicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarDomicio.Location = new System.Drawing.Point(303, 190);
            this.LModificarDomicio.Name = "LModificarDomicio";
            this.LModificarDomicio.Size = new System.Drawing.Size(67, 23);
            this.LModificarDomicio.TabIndex = 35;
            this.LModificarDomicio.Text = "Domicilio";
            // 
            // TModificarEmail
            // 
            this.TModificarEmail.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarEmail.Location = new System.Drawing.Point(37, 159);
            this.TModificarEmail.Name = "TModificarEmail";
            this.TModificarEmail.Size = new System.Drawing.Size(232, 27);
            this.TModificarEmail.TabIndex = 34;
            // 
            // LModificarEmail
            // 
            this.LModificarEmail.AutoSize = true;
            this.LModificarEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LModificarEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarEmail.Location = new System.Drawing.Point(33, 134);
            this.LModificarEmail.Name = "LModificarEmail";
            this.LModificarEmail.Size = new System.Drawing.Size(52, 23);
            this.LModificarEmail.TabIndex = 33;
            this.LModificarEmail.Text = "E-mail";
            // 
            // TModificarAp
            // 
            this.TModificarAp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarAp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarAp.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarAp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarAp.Location = new System.Drawing.Point(37, 106);
            this.TModificarAp.Name = "TModificarAp";
            this.TModificarAp.Size = new System.Drawing.Size(232, 27);
            this.TModificarAp.TabIndex = 32;
            // 
            // LModificarApellido
            // 
            this.LModificarApellido.AutoSize = true;
            this.LModificarApellido.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LModificarApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarApellido.Location = new System.Drawing.Point(33, 81);
            this.LModificarApellido.Name = "LModificarApellido";
            this.LModificarApellido.Size = new System.Drawing.Size(60, 23);
            this.LModificarApellido.TabIndex = 31;
            this.LModificarApellido.Text = "Apellido";
            // 
            // TModificarNombre
            // 
            this.TModificarNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarNombre.Location = new System.Drawing.Point(37, 51);
            this.TModificarNombre.Name = "TModificarNombre";
            this.TModificarNombre.Size = new System.Drawing.Size(232, 27);
            this.TModificarNombre.TabIndex = 30;
            // 
            // LModificarNombre
            // 
            this.LModificarNombre.AutoSize = true;
            this.LModificarNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificarNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarNombre.Location = new System.Drawing.Point(32, 26);
            this.LModificarNombre.Name = "LModificarNombre";
            this.LModificarNombre.Size = new System.Drawing.Size(58, 23);
            this.LModificarNombre.TabIndex = 29;
            this.LModificarNombre.Text = "Nombre";
            // 
            // TModificarUser
            // 
            this.TModificarUser.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarUser.Location = new System.Drawing.Point(307, 51);
            this.TModificarUser.Name = "TModificarUser";
            this.TModificarUser.Size = new System.Drawing.Size(232, 27);
            this.TModificarUser.TabIndex = 26;
            // 
            // LModificarUsuario
            // 
            this.LModificarUsuario.AutoSize = true;
            this.LModificarUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LModificarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LModificarUsuario.Location = new System.Drawing.Point(303, 25);
            this.LModificarUsuario.Name = "LModificarUsuario";
            this.LModificarUsuario.Size = new System.Drawing.Size(58, 23);
            this.LModificarUsuario.TabIndex = 25;
            this.LModificarUsuario.Text = "Usuario";
            // 
            // BModificar
            // 
            this.BModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.BModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BModificar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BModificar.ForeColor = System.Drawing.Color.White;
            this.BModificar.Location = new System.Drawing.Point(439, 342);
            this.BModificar.Name = "BModificar";
            this.BModificar.Size = new System.Drawing.Size(143, 32);
            this.BModificar.TabIndex = 21;
            this.BModificar.Text = "Modificar Usuario";
            this.BModificar.UseVisualStyleBackColor = false;
            this.BModificar.Click += new System.EventHandler(this.BModificar_click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.93609F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.06391F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1088, 706);
            this.tableLayoutPanel2.TabIndex = 4;
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
            this.tableAdapterManager1.perfilesTableAdapter = null;
            this.tableAdapterManager1.productos_pcTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = pruebaLogin.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ventas_cabeceraTableAdapter = null;
            this.tableAdapterManager1.ventas_detalleTableAdapter = null;
            // 
            // perfilesBindingSource
            // 
            this.perfilesBindingSource.DataMember = "perfiles";
            this.perfilesBindingSource.DataSource = this.dataSet11;
            // 
            // perfilesTableAdapter1
            // 
            this.perfilesTableAdapter1.ClearBeforeFill = true;
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
            // CP
            // 
            this.CP.HeaderText = "Código postal";
            this.CP.Name = "CP";
            this.CP.ReadOnly = true;
            // 
            // domicilio
            // 
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            this.domicilio.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // pass
            // 
            this.pass.HeaderText = "Pass";
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            this.pass.Visible = false;
            // 
            // user
            // 
            this.user.HeaderText = "Usuario";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // baja
            // 
            this.baja.DataPropertyName = "baja";
            this.baja.HeaderText = "Baja";
            this.baja.Name = "baja";
            this.baja.ReadOnly = true;
            // 
            // bajaValor
            // 
            this.bajaValor.HeaderText = "BajaValor";
            this.bajaValor.Name = "bajaValor";
            this.bajaValor.ReadOnly = true;
            this.bajaValor.Visible = false;
            // 
            // Perfil
            // 
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Name = "Perfil";
            this.Perfil.ReadOnly = true;
            // 
            // id_perfil
            // 
            this.id_perfil.DataPropertyName = "perfil_id";
            this.id_perfil.HeaderText = "id_perfil";
            this.id_perfil.Name = "id_perfil";
            this.id_perfil.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // id_user
            // 
            this.id_user.HeaderText = "ID de Usuario";
            this.id_user.Name = "id_user";
            this.id_user.ReadOnly = true;
            // 
            // btnSeleccionar
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.DefaultCellStyle = dataGridViewCellStyle5;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.HeaderText = "Seleccionar";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnSeleccionar.Text = "";
            // 
            // usuariosDataGridView
            // 
            this.usuariosDataGridView.AllowUserToAddRows = false;
            this.usuariosDataGridView.AllowUserToDeleteRows = false;
            this.usuariosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usuariosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usuariosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.usuariosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuariosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.usuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id_user,
            this.nombre,
            this.apellido,
            this.id_perfil,
            this.Perfil,
            this.bajaValor,
            this.baja,
            this.user,
            this.pass,
            this.email,
            this.domicilio,
            this.CP});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usuariosDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.usuariosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usuariosDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.usuariosDataGridView.Location = new System.Drawing.Point(3, 429);
            this.usuariosDataGridView.MultiSelect = false;
            this.usuariosDataGridView.Name = "usuariosDataGridView";
            this.usuariosDataGridView.ReadOnly = true;
            this.usuariosDataGridView.Size = new System.Drawing.Size(1076, 268);
            this.usuariosDataGridView.TabIndex = 4;
            this.usuariosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuariosDataGridView_CellContentClick);
            this.usuariosDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.usuariosDataGridView_CellPainting);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1088, 706);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(1080, 564);
            this.Name = "FormUsuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TCUsuarios.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.PanelAltaUser.ResumeLayout(false);
            this.PanelAltaUser.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.PanelModificarUser.ResumeLayout(false);
            this.PanelModificarUser.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DataSet1TableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private pruebaLogin.DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private pruebaLogin.DataSet1TableAdapters.usuariosTableAdapter usuariosTableAdapter1;
        private pruebaLogin.DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabControl TCUsuarios;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel PanelAltaUser;
        private System.Windows.Forms.Button BRegisterUser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel PanelModificarUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LModificarEstado;
        private System.Windows.Forms.ComboBox CBModificarEstado;
        private System.Windows.Forms.Label LModificarPerfil;
        private System.Windows.Forms.TextBox TModificarCP;
        private System.Windows.Forms.Label LModificarCP;
        private System.Windows.Forms.TextBox TModificarDomicilio;
        private System.Windows.Forms.Label LModificarDomicio;
        private System.Windows.Forms.TextBox TModificarEmail;
        private System.Windows.Forms.Label LModificarEmail;
        private System.Windows.Forms.TextBox TModificarAp;
        private System.Windows.Forms.Label LModificarApellido;
        private System.Windows.Forms.TextBox TModificarNombre;
        private System.Windows.Forms.Label LModificarNombre;
        private System.Windows.Forms.TextBox TModificarUser;
        private System.Windows.Forms.Label LModificarUsuario;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.Label LPerfil;
        private System.Windows.Forms.TextBox TPassConf;
        private System.Windows.Forms.Label LPassConf;
        private System.Windows.Forms.TextBox TCP;
        private System.Windows.Forms.Label LCP;
        private System.Windows.Forms.TextBox TDomicilio;
        private System.Windows.Forms.Label LDomicilio;
        private System.Windows.Forms.TextBox TEmail;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TPass;
        private System.Windows.Forms.Label LPass;
        private System.Windows.Forms.TextBox TUser;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.BindingSource perfilesBindingSource;
        private pruebaLogin.DataSet1TableAdapters.perfilesTableAdapter perfilesTableAdapter1;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.ComboBox CBperfiles;
        private System.Windows.Forms.ComboBox CBModificarPerfil;
        private System.Windows.Forms.TextBox TModificarID_user;
        private System.Windows.Forms.TextBox TBModificarIndice;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button BModificar;
        private System.Windows.Forms.TextBox TIndice;
        private System.Windows.Forms.TextBox TID_user;
        private System.Windows.Forms.TextBox TModificarConfirmPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TModificarPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView usuariosDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn bajaValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn baja;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
    }
}