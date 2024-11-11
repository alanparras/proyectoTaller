namespace ProyectoTallerG8
{
    partial class FormProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new pruebaLogin.DataSet1();
            this.usuariosTableAdapter1 = new pruebaLogin.DataSet1TableAdapters.usuariosTableAdapter();
            this.tableAdapterManager1 = new pruebaLogin.DataSet1TableAdapters.TableAdapterManager();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.productosDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSubCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TCUsuarios = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PanelAltaUser = new System.Windows.Forms.Panel();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TIndice = new System.Windows.Forms.TextBox();
            this.TID_prod = new System.Windows.Forms.TextBox();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.CBSubCategoria = new System.Windows.Forms.ComboBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.LPerfil = new System.Windows.Forms.Label();
            this.BRegisterProd = new System.Windows.Forms.Button();
            this.TPrecio = new System.Windows.Forms.TextBox();
            this.LPassConf = new System.Windows.Forms.Label();
            this.TStock = new System.Windows.Forms.TextBox();
            this.LDomicilio = new System.Windows.Forms.Label();
            this.TMarca = new System.Windows.Forms.TextBox();
            this.LEmail = new System.Windows.Forms.Label();
            this.TDescripcion = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.TModelo = new System.Windows.Forms.TextBox();
            this.LPass = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PanelModificarUser = new System.Windows.Forms.Panel();
            this.CBModificarCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBModificarEstado = new System.Windows.Forms.ComboBox();
            this.CBModificarSubCat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TModificarPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TModificarStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TModificarMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TModificarDescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TModificarNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TModificarModelo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BEliminar = new System.Windows.Forms.Button();
            this.TBModificarIndice = new System.Windows.Forms.TextBox();
            this.TModificarID_prod = new System.Windows.Forms.TextBox();
            this.BModificar = new System.Windows.Forms.Button();
            this.productospcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.perfilesTableAdapter1 = new pruebaLogin.DataSet1TableAdapters.perfilesTableAdapter();
            this.productos_pcTableAdapter = new pruebaLogin.DataSet1TableAdapters.productos_pcTableAdapter();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProyectoTallerG8.DataSet1();
            this.usuariosTableAdapter = new ProyectoTallerG8.DataSet1TableAdapters.usuariosTableAdapter();
            this.tableAdapterManager = new ProyectoTallerG8.DataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TCUsuarios.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PanelAltaUser.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.PanelModificarUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productospcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.productosDataGridView, 0, 1);
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
            // productosDataGridView
            // 
            this.productosDataGridView.AllowUserToAddRows = false;
            this.productosDataGridView.AllowUserToDeleteRows = false;
            this.productosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.productosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id,
            this.nombre,
            this.descripcion,
            this.marca,
            this.modelo,
            this.precio,
            this.stock,
            this.baja,
            this.visitas,
            this.IdCategoria,
            this.categoria,
            this.IdSubCategoria,
            this.subcategoria});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productosDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.productosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productosDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.productosDataGridView.Location = new System.Drawing.Point(3, 429);
            this.productosDataGridView.MultiSelect = false;
            this.productosDataGridView.Name = "productosDataGridView";
            this.productosDataGridView.ReadOnly = true;
            this.productosDataGridView.Size = new System.Drawing.Size(1076, 268);
            this.productosDataGridView.TabIndex = 6;
            // 
            // btnSeleccionar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.HeaderText = "Seleccionar";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnSeleccionar.Text = "";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // baja
            // 
            this.baja.HeaderText = "Baja";
            this.baja.Name = "baja";
            this.baja.ReadOnly = true;
            // 
            // visitas
            // 
            this.visitas.HeaderText = "Visitas";
            this.visitas.Name = "visitas";
            this.visitas.ReadOnly = true;
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Visible = false;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoría";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // IdSubCategoria
            // 
            this.IdSubCategoria.HeaderText = "IdSubCategoria";
            this.IdSubCategoria.Name = "IdSubCategoria";
            this.IdSubCategoria.ReadOnly = true;
            this.IdSubCategoria.Visible = false;
            // 
            // subcategoria
            // 
            this.subcategoria.HeaderText = "SubCategoría";
            this.subcategoria.Name = "subcategoria";
            this.subcategoria.ReadOnly = true;
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
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1076, 420);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textSearch);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(616, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 414);
            this.panel2.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(10, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Búsqueda Avanzada";
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSearch.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textSearch.Location = new System.Drawing.Point(14, 65);
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
            this.label16.Location = new System.Drawing.Point(10, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 23);
            this.label16.TabIndex = 4;
            this.label16.Text = "Buscar...";
            // 
            // TCUsuarios
            // 
            this.TCUsuarios.Controls.Add(this.tabPage1);
            this.TCUsuarios.Controls.Add(this.tabPage2);
            this.TCUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCUsuarios.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tabPage1.Text = "Alta de Producto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PanelAltaUser
            // 
            this.PanelAltaUser.AutoScroll = true;
            this.PanelAltaUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PanelAltaUser.Controls.Add(this.CBCategoria);
            this.PanelAltaUser.Controls.Add(this.label1);
            this.PanelAltaUser.Controls.Add(this.TIndice);
            this.PanelAltaUser.Controls.Add(this.TID_prod);
            this.PanelAltaUser.Controls.Add(this.CBEstado);
            this.PanelAltaUser.Controls.Add(this.CBSubCategoria);
            this.PanelAltaUser.Controls.Add(this.LEstado);
            this.PanelAltaUser.Controls.Add(this.LPerfil);
            this.PanelAltaUser.Controls.Add(this.BRegisterProd);
            this.PanelAltaUser.Controls.Add(this.TPrecio);
            this.PanelAltaUser.Controls.Add(this.LPassConf);
            this.PanelAltaUser.Controls.Add(this.TStock);
            this.PanelAltaUser.Controls.Add(this.LDomicilio);
            this.PanelAltaUser.Controls.Add(this.TMarca);
            this.PanelAltaUser.Controls.Add(this.LEmail);
            this.PanelAltaUser.Controls.Add(this.TDescripcion);
            this.PanelAltaUser.Controls.Add(this.LApellido);
            this.PanelAltaUser.Controls.Add(this.TNombre);
            this.PanelAltaUser.Controls.Add(this.LNombre);
            this.PanelAltaUser.Controls.Add(this.TModelo);
            this.PanelAltaUser.Controls.Add(this.LPass);
            this.PanelAltaUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAltaUser.Location = new System.Drawing.Point(3, 3);
            this.PanelAltaUser.Name = "PanelAltaUser";
            this.PanelAltaUser.Size = new System.Drawing.Size(593, 377);
            this.PanelAltaUser.TabIndex = 7;
            // 
            // CBCategoria
            // 
            this.CBCategoria.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CBCategoria.DisplayMember = "id_perfiles";
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Location = new System.Drawing.Point(310, 52);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(231, 26);
            this.CBCategoria.TabIndex = 52;
            this.CBCategoria.ValueMember = "id_perfiles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(305, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Categoria";
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
            // 
            // TID_prod
            // 
            this.TID_prod.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TID_prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TID_prod.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TID_prod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TID_prod.Location = new System.Drawing.Point(81, 331);
            this.TID_prod.Name = "TID_prod";
            this.TID_prod.Size = new System.Drawing.Size(36, 27);
            this.TID_prod.TabIndex = 49;
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
            // 
            // CBSubCategoria
            // 
            this.CBSubCategoria.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CBSubCategoria.DisplayMember = "id_perfiles";
            this.CBSubCategoria.FormattingEnabled = true;
            this.CBSubCategoria.Location = new System.Drawing.Point(310, 104);
            this.CBSubCategoria.Name = "CBSubCategoria";
            this.CBSubCategoria.Size = new System.Drawing.Size(231, 26);
            this.CBSubCategoria.TabIndex = 24;
            this.CBSubCategoria.ValueMember = "id_perfiles";
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
            this.LPerfil.Size = new System.Drawing.Size(102, 23);
            this.LPerfil.TabIndex = 22;
            this.LPerfil.Text = "Sub-Categoria";
            // 
            // BRegisterProd
            // 
            this.BRegisterProd.BackColor = System.Drawing.Color.Gray;
            this.BRegisterProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BRegisterProd.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegisterProd.ForeColor = System.Drawing.Color.White;
            this.BRegisterProd.Location = new System.Drawing.Point(447, 342);
            this.BRegisterProd.Name = "BRegisterProd";
            this.BRegisterProd.Size = new System.Drawing.Size(143, 32);
            this.BRegisterProd.TabIndex = 20;
            this.BRegisterProd.Text = "Registrar Producto";
            this.BRegisterProd.UseVisualStyleBackColor = false;
            // 
            // TPrecio
            // 
            this.TPrecio.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPrecio.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TPrecio.Location = new System.Drawing.Point(39, 269);
            this.TPrecio.Name = "TPrecio";
            this.TPrecio.PasswordChar = '*';
            this.TPrecio.Size = new System.Drawing.Size(232, 27);
            this.TPrecio.TabIndex = 19;
            this.TPrecio.UseSystemPasswordChar = true;
            // 
            // LPassConf
            // 
            this.LPassConf.AutoSize = true;
            this.LPassConf.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LPassConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LPassConf.Location = new System.Drawing.Point(35, 244);
            this.LPassConf.Name = "LPassConf";
            this.LPassConf.Size = new System.Drawing.Size(49, 23);
            this.LPassConf.TabIndex = 18;
            this.LPassConf.Text = "Precio";
            // 
            // TStock
            // 
            this.TStock.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TStock.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TStock.Location = new System.Drawing.Point(309, 216);
            this.TStock.Name = "TStock";
            this.TStock.Size = new System.Drawing.Size(232, 27);
            this.TStock.TabIndex = 15;
            // 
            // LDomicilio
            // 
            this.LDomicilio.AutoSize = true;
            this.LDomicilio.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LDomicilio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LDomicilio.Location = new System.Drawing.Point(305, 190);
            this.LDomicilio.Name = "LDomicilio";
            this.LDomicilio.Size = new System.Drawing.Size(45, 23);
            this.LDomicilio.TabIndex = 14;
            this.LDomicilio.Text = "Stock";
            // 
            // TMarca
            // 
            this.TMarca.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TMarca.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TMarca.Location = new System.Drawing.Point(39, 159);
            this.TMarca.Name = "TMarca";
            this.TMarca.Size = new System.Drawing.Size(232, 27);
            this.TMarca.TabIndex = 13;
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LEmail.Location = new System.Drawing.Point(35, 134);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(50, 23);
            this.LEmail.TabIndex = 12;
            this.LEmail.Text = "Marca";
            // 
            // TDescripcion
            // 
            this.TDescripcion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TDescripcion.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TDescripcion.Location = new System.Drawing.Point(39, 106);
            this.TDescripcion.Name = "TDescripcion";
            this.TDescripcion.Size = new System.Drawing.Size(232, 27);
            this.TDescripcion.TabIndex = 11;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LApellido.Location = new System.Drawing.Point(35, 81);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(83, 23);
            this.LApellido.TabIndex = 10;
            this.LApellido.Text = "Descripción";
            this.LApellido.Click += new System.EventHandler(this.LApellido_Click);
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
            // TModelo
            // 
            this.TModelo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModelo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModelo.Location = new System.Drawing.Point(39, 214);
            this.TModelo.Name = "TModelo";
            this.TModelo.PasswordChar = '*';
            this.TModelo.Size = new System.Drawing.Size(232, 27);
            this.TModelo.TabIndex = 7;
            this.TModelo.UseSystemPasswordChar = true;
            // 
            // LPass
            // 
            this.LPass.AutoSize = true;
            this.LPass.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LPass.Location = new System.Drawing.Point(35, 188);
            this.LPass.Name = "LPass";
            this.LPass.Size = new System.Drawing.Size(54, 23);
            this.LPass.TabIndex = 6;
            this.LPass.Text = "Modelo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PanelModificarUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(599, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Producto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PanelModificarUser
            // 
            this.PanelModificarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PanelModificarUser.Controls.Add(this.CBModificarCategoria);
            this.PanelModificarUser.Controls.Add(this.label2);
            this.PanelModificarUser.Controls.Add(this.CBModificarEstado);
            this.PanelModificarUser.Controls.Add(this.CBModificarSubCat);
            this.PanelModificarUser.Controls.Add(this.label3);
            this.PanelModificarUser.Controls.Add(this.label4);
            this.PanelModificarUser.Controls.Add(this.TModificarPrecio);
            this.PanelModificarUser.Controls.Add(this.label5);
            this.PanelModificarUser.Controls.Add(this.TModificarStock);
            this.PanelModificarUser.Controls.Add(this.label6);
            this.PanelModificarUser.Controls.Add(this.TModificarMarca);
            this.PanelModificarUser.Controls.Add(this.label7);
            this.PanelModificarUser.Controls.Add(this.TModificarDescripcion);
            this.PanelModificarUser.Controls.Add(this.label9);
            this.PanelModificarUser.Controls.Add(this.TModificarNombre);
            this.PanelModificarUser.Controls.Add(this.label10);
            this.PanelModificarUser.Controls.Add(this.TModificarModelo);
            this.PanelModificarUser.Controls.Add(this.label11);
            this.PanelModificarUser.Controls.Add(this.BEliminar);
            this.PanelModificarUser.Controls.Add(this.TBModificarIndice);
            this.PanelModificarUser.Controls.Add(this.TModificarID_prod);
            this.PanelModificarUser.Controls.Add(this.BModificar);
            this.PanelModificarUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelModificarUser.Location = new System.Drawing.Point(3, 3);
            this.PanelModificarUser.Name = "PanelModificarUser";
            this.PanelModificarUser.Size = new System.Drawing.Size(593, 377);
            this.PanelModificarUser.TabIndex = 8;
            // 
            // CBModificarCategoria
            // 
            this.CBModificarCategoria.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CBModificarCategoria.DisplayMember = "id_perfiles";
            this.CBModificarCategoria.FormattingEnabled = true;
            this.CBModificarCategoria.Location = new System.Drawing.Point(307, 36);
            this.CBModificarCategoria.Name = "CBModificarCategoria";
            this.CBModificarCategoria.Size = new System.Drawing.Size(231, 26);
            this.CBModificarCategoria.TabIndex = 70;
            this.CBModificarCategoria.ValueMember = "id_perfiles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(302, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 69;
            this.label2.Text = "Categoria";
            // 
            // CBModificarEstado
            // 
            this.CBModificarEstado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CBModificarEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource1, "baja", true));
            this.CBModificarEstado.FormattingEnabled = true;
            this.CBModificarEstado.Location = new System.Drawing.Point(306, 144);
            this.CBModificarEstado.Name = "CBModificarEstado";
            this.CBModificarEstado.Size = new System.Drawing.Size(232, 26);
            this.CBModificarEstado.TabIndex = 68;
            // 
            // CBModificarSubCat
            // 
            this.CBModificarSubCat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CBModificarSubCat.DisplayMember = "id_perfiles";
            this.CBModificarSubCat.FormattingEnabled = true;
            this.CBModificarSubCat.Location = new System.Drawing.Point(307, 88);
            this.CBModificarSubCat.Name = "CBModificarSubCat";
            this.CBModificarSubCat.Size = new System.Drawing.Size(231, 26);
            this.CBModificarSubCat.TabIndex = 67;
            this.CBModificarSubCat.ValueMember = "id_perfiles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(302, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 66;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(302, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 65;
            this.label4.Text = "Sub-Categoria";
            // 
            // TModificarPrecio
            // 
            this.TModificarPrecio.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarPrecio.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarPrecio.Location = new System.Drawing.Point(36, 253);
            this.TModificarPrecio.Name = "TModificarPrecio";
            this.TModificarPrecio.PasswordChar = '*';
            this.TModificarPrecio.Size = new System.Drawing.Size(232, 27);
            this.TModificarPrecio.TabIndex = 64;
            this.TModificarPrecio.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(32, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 63;
            this.label5.Text = "Precio";
            // 
            // TModificarStock
            // 
            this.TModificarStock.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarStock.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarStock.Location = new System.Drawing.Point(306, 200);
            this.TModificarStock.Name = "TModificarStock";
            this.TModificarStock.Size = new System.Drawing.Size(232, 27);
            this.TModificarStock.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(302, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 23);
            this.label6.TabIndex = 61;
            this.label6.Text = "Stock";
            // 
            // TModificarMarca
            // 
            this.TModificarMarca.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarMarca.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarMarca.Location = new System.Drawing.Point(36, 143);
            this.TModificarMarca.Name = "TModificarMarca";
            this.TModificarMarca.Size = new System.Drawing.Size(232, 27);
            this.TModificarMarca.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(32, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 23);
            this.label7.TabIndex = 59;
            this.label7.Text = "Marca";
            // 
            // TModificarDescripcion
            // 
            this.TModificarDescripcion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarDescripcion.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarDescripcion.Location = new System.Drawing.Point(36, 90);
            this.TModificarDescripcion.Name = "TModificarDescripcion";
            this.TModificarDescripcion.Size = new System.Drawing.Size(232, 27);
            this.TModificarDescripcion.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(32, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 23);
            this.label9.TabIndex = 57;
            this.label9.Text = "Descripción";
            // 
            // TModificarNombre
            // 
            this.TModificarNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarNombre.Location = new System.Drawing.Point(36, 35);
            this.TModificarNombre.Name = "TModificarNombre";
            this.TModificarNombre.Size = new System.Drawing.Size(232, 27);
            this.TModificarNombre.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(31, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 23);
            this.label10.TabIndex = 55;
            this.label10.Text = "Nombre";
            // 
            // TModificarModelo
            // 
            this.TModificarModelo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarModelo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarModelo.Location = new System.Drawing.Point(36, 198);
            this.TModificarModelo.Name = "TModificarModelo";
            this.TModificarModelo.PasswordChar = '*';
            this.TModificarModelo.Size = new System.Drawing.Size(232, 27);
            this.TModificarModelo.TabIndex = 54;
            this.TModificarModelo.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(32, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 23);
            this.label11.TabIndex = 53;
            this.label11.Text = "Modelo";
            // 
            // BEliminar
            // 
            this.BEliminar.BackColor = System.Drawing.Color.IndianRed;
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
            // 
            // TModificarID_prod
            // 
            this.TModificarID_prod.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TModificarID_prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TModificarID_prod.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TModificarID_prod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TModificarID_prod.Location = new System.Drawing.Point(79, 329);
            this.TModificarID_prod.Name = "TModificarID_prod";
            this.TModificarID_prod.Size = new System.Drawing.Size(36, 27);
            this.TModificarID_prod.TabIndex = 47;
            // 
            // BModificar
            // 
            this.BModificar.BackColor = System.Drawing.Color.Gray;
            this.BModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BModificar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BModificar.ForeColor = System.Drawing.Color.White;
            this.BModificar.Location = new System.Drawing.Point(439, 342);
            this.BModificar.Name = "BModificar";
            this.BModificar.Size = new System.Drawing.Size(143, 32);
            this.BModificar.TabIndex = 21;
            this.BModificar.Text = "Modificar Usuario";
            this.BModificar.UseVisualStyleBackColor = false;
            this.BModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // productospcBindingSource
            // 
            this.productospcBindingSource.DataMember = "productos_pc";
            this.productospcBindingSource.DataSource = this.dataSet11;
            // 
            // perfilesBindingSource
            // 
            this.perfilesBindingSource.DataMember = "perfiles";
            this.perfilesBindingSource.DataSource = this.dataSet11;
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
            // perfilesTableAdapter1
            // 
            this.perfilesTableAdapter1.ClearBeforeFill = true;
            // 
            // productos_pcTableAdapter
            // 
            this.productos_pcTableAdapter.ClearBeforeFill = true;
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
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1088, 706);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(1080, 564);
            this.Name = "FormProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.productospcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private pruebaLogin.DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private pruebaLogin.DataSet1TableAdapters.usuariosTableAdapter usuariosTableAdapter1;
        private pruebaLogin.DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabControl TCUsuarios;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel PanelAltaUser;
        private System.Windows.Forms.Button BRegisterProd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel PanelModificarUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.Label LPerfil;
        private System.Windows.Forms.TextBox TPrecio;
        private System.Windows.Forms.Label LPassConf;
        private System.Windows.Forms.TextBox TStock;
        private System.Windows.Forms.Label LDomicilio;
        private System.Windows.Forms.TextBox TMarca;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.TextBox TDescripcion;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TModelo;
        private System.Windows.Forms.Label LPass;
        private System.Windows.Forms.BindingSource perfilesBindingSource;
        private pruebaLogin.DataSet1TableAdapters.perfilesTableAdapter perfilesTableAdapter1;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.ComboBox CBSubCategoria;
        private System.Windows.Forms.TextBox TModificarID_prod;
        private System.Windows.Forms.TextBox TBModificarIndice;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button BModificar;
        private System.Windows.Forms.TextBox TIndice;
        private System.Windows.Forms.TextBox TID_prod;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBModificarCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBModificarEstado;
        private System.Windows.Forms.ComboBox CBModificarSubCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TModificarPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TModificarStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TModificarMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TModificarDescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TModificarNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TModificarModelo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource productospcBindingSource;
        private pruebaLogin.DataSet1TableAdapters.productos_pcTableAdapter productos_pcTableAdapter;
        private System.Windows.Forms.DataGridView productosDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn baja;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSubCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategoria;
    }
}