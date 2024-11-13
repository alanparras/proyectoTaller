namespace ProyectoTallerG8
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.consultasDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TUsuario = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TBIndice = new System.Windows.Forms.TextBox();
            this.TFechaRespuesta = new System.Windows.Forms.TextBox();
            this.TFechaCreado = new System.Windows.Forms.TextBox();
            this.TEmail = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TID_consulta = new System.Windows.Forms.TextBox();
            this.TMensaje = new System.Windows.Forms.TextBox();
            this.BEnviarRespuesta = new System.Windows.Forms.Button();
            this.TRespuesta = new System.Windows.Forms.TextBox();
            this.LRespuesta = new System.Windows.Forms.Label();
            this.consultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new pruebaLogin.DataSet1();
            this.mensajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter1 = new pruebaLogin.DataSet1TableAdapters.usuariosTableAdapter();
            this.tableAdapterManager1 = new pruebaLogin.DataSet1TableAdapters.TableAdapterManager();
            this.mensajesTableAdapter = new pruebaLogin.DataSet1TableAdapters.mensajesTableAdapter();
            this.consultasTableAdapter = new pruebaLogin.DataSet1TableAdapters.consultasTableAdapter();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProyectoTallerG8.DataSet1();
            this.usuariosTableAdapter = new ProyectoTallerG8.DataSet1TableAdapters.usuariosTableAdapter();
            this.tableAdapterManager = new ProyectoTallerG8.DataSet1TableAdapters.TableAdapterManager();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensajesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.06391F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
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
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.50097F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.49903F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1058, 519);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // consultasDataGridView
            // 
            this.consultasDataGridView.AllowUserToAddRows = false;
            this.consultasDataGridView.AllowUserToDeleteRows = false;
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
            this.btnSeleccionar,
            this.id_consulta,
            this.nombre,
            this.apellido,
            this.usuario,
            this.correo,
            this.mensaje,
            this.fecha_mensaje,
            this.fecha_respuesta,
            this.respuesta});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.consultasDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.consultasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consultasDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.consultasDataGridView.Location = new System.Drawing.Point(3, 317);
            this.consultasDataGridView.MultiSelect = false;
            this.consultasDataGridView.Name = "consultasDataGridView";
            this.consultasDataGridView.ReadOnly = true;
            this.consultasDataGridView.Size = new System.Drawing.Size(1052, 199);
            this.consultasDataGridView.TabIndex = 12;
            this.consultasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consultasDataGridView_CellContentClick);
            this.consultasDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.consultasDataGridView_CellPainting);
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
            // id_consulta
            // 
            this.id_consulta.HeaderText = "ID";
            this.id_consulta.Name = "id_consulta";
            this.id_consulta.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // mensaje
            // 
            this.mensaje.HeaderText = "Mensaje";
            this.mensaje.Name = "mensaje";
            this.mensaje.ReadOnly = true;
            // 
            // fecha_mensaje
            // 
            this.fecha_mensaje.HeaderText = "Fecha del mensaje";
            this.fecha_mensaje.Name = "fecha_mensaje";
            this.fecha_mensaje.ReadOnly = true;
            // 
            // fecha_respuesta
            // 
            this.fecha_respuesta.HeaderText = "Fecha de respuesta";
            this.fecha_respuesta.Name = "fecha_respuesta";
            this.fecha_respuesta.ReadOnly = true;
            // 
            // respuesta
            // 
            this.respuesta.HeaderText = "Respuesta";
            this.respuesta.Name = "respuesta";
            this.respuesta.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TUsuario);
            this.panel2.Controls.Add(this.TApellido);
            this.panel2.Controls.Add(this.TBIndice);
            this.panel2.Controls.Add(this.TFechaRespuesta);
            this.panel2.Controls.Add(this.TFechaCreado);
            this.panel2.Controls.Add(this.TEmail);
            this.panel2.Controls.Add(this.TNombre);
            this.panel2.Controls.Add(this.TID_consulta);
            this.panel2.Controls.Add(this.TMensaje);
            this.panel2.Controls.Add(this.BEnviarRespuesta);
            this.panel2.Controls.Add(this.TRespuesta);
            this.panel2.Controls.Add(this.LRespuesta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 308);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Consulta";
            // 
            // TUsuario
            // 
            this.TUsuario.Location = new System.Drawing.Point(449, 258);
            this.TUsuario.Name = "TUsuario";
            this.TUsuario.Size = new System.Drawing.Size(100, 20);
            this.TUsuario.TabIndex = 32;
            this.TUsuario.Visible = false;
            this.TUsuario.TextChanged += new System.EventHandler(this.TUsuario_TextChanged);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(343, 258);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(100, 20);
            this.TApellido.TabIndex = 31;
            this.TApellido.Visible = false;
            this.TApellido.TextChanged += new System.EventHandler(this.TApellido_TextChanged);
            // 
            // TBIndice
            // 
            this.TBIndice.Location = new System.Drawing.Point(25, 258);
            this.TBIndice.Name = "TBIndice";
            this.TBIndice.Size = new System.Drawing.Size(100, 20);
            this.TBIndice.TabIndex = 30;
            this.TBIndice.Visible = false;
            // 
            // TFechaRespuesta
            // 
            this.TFechaRespuesta.Location = new System.Drawing.Point(767, 258);
            this.TFechaRespuesta.Name = "TFechaRespuesta";
            this.TFechaRespuesta.Size = new System.Drawing.Size(100, 20);
            this.TFechaRespuesta.TabIndex = 29;
            this.TFechaRespuesta.Visible = false;
            // 
            // TFechaCreado
            // 
            this.TFechaCreado.Location = new System.Drawing.Point(661, 258);
            this.TFechaCreado.Name = "TFechaCreado";
            this.TFechaCreado.Size = new System.Drawing.Size(100, 20);
            this.TFechaCreado.TabIndex = 27;
            this.TFechaCreado.Visible = false;
            // 
            // TEmail
            // 
            this.TEmail.Location = new System.Drawing.Point(555, 258);
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(100, 20);
            this.TEmail.TabIndex = 25;
            this.TEmail.Visible = false;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(237, 258);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(100, 20);
            this.TNombre.TabIndex = 24;
            this.TNombre.Visible = false;
            // 
            // TID_consulta
            // 
            this.TID_consulta.Location = new System.Drawing.Point(131, 258);
            this.TID_consulta.Name = "TID_consulta";
            this.TID_consulta.Size = new System.Drawing.Size(100, 20);
            this.TID_consulta.TabIndex = 23;
            this.TID_consulta.Visible = false;
            // 
            // TMensaje
            // 
            this.TMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMensaje.Location = new System.Drawing.Point(25, 42);
            this.TMensaje.Multiline = true;
            this.TMensaje.Name = "TMensaje";
            this.TMensaje.ReadOnly = true;
            this.TMensaje.Size = new System.Drawing.Size(453, 210);
            this.TMensaje.TabIndex = 7;
            // 
            // BEnviarRespuesta
            // 
            this.BEnviarRespuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.BEnviarRespuesta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BEnviarRespuesta.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEnviarRespuesta.ForeColor = System.Drawing.Color.White;
            this.BEnviarRespuesta.Location = new System.Drawing.Point(546, 194);
            this.BEnviarRespuesta.Name = "BEnviarRespuesta";
            this.BEnviarRespuesta.Size = new System.Drawing.Size(143, 32);
            this.BEnviarRespuesta.TabIndex = 22;
            this.BEnviarRespuesta.Text = "Enviar Respuesta";
            this.BEnviarRespuesta.UseVisualStyleBackColor = false;
            this.BEnviarRespuesta.Click += new System.EventHandler(this.BEnviarRespuesta_Click);
            // 
            // TRespuesta
            // 
            this.TRespuesta.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TRespuesta.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRespuesta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TRespuesta.Location = new System.Drawing.Point(546, 42);
            this.TRespuesta.Multiline = true;
            this.TRespuesta.Name = "TRespuesta";
            this.TRespuesta.Size = new System.Drawing.Size(443, 146);
            this.TRespuesta.TabIndex = 5;
            // 
            // LRespuesta
            // 
            this.LRespuesta.AutoSize = true;
            this.LRespuesta.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.LRespuesta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LRespuesta.Location = new System.Drawing.Point(542, 16);
            this.LRespuesta.Name = "LRespuesta";
            this.LRespuesta.Size = new System.Drawing.Size(79, 23);
            this.LRespuesta.TabIndex = 4;
            this.LRespuesta.Text = "Respuesta:";
            // 
            // consultasBindingSource
            // 
            this.consultasBindingSource.DataMember = "consultas";
            this.consultasBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mensajesBindingSource
            // 
            this.mensajesBindingSource.DataMember = "mensajes";
            this.mensajesBindingSource.DataSource = this.dataSet11;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "usuarios";
            this.usuariosBindingSource1.DataSource = this.dataSet11;
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
            // mensajesTableAdapter
            // 
            this.mensajesTableAdapter.ClearBeforeFill = true;
            // 
            // consultasTableAdapter
            // 
            this.consultasTableAdapter.ClearBeforeFill = true;
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
            // FormConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1064, 525);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(1080, 564);
            this.Name = "FormConsultas";
            this.Text = "Consultas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormConsultas_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensajesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
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
        private pruebaLogin.DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private pruebaLogin.DataSet1TableAdapters.usuariosTableAdapter usuariosTableAdapter1;
        private pruebaLogin.DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource mensajesBindingSource;
        private pruebaLogin.DataSet1TableAdapters.mensajesTableAdapter mensajesTableAdapter;
        private System.Windows.Forms.BindingSource consultasBindingSource;
        private pruebaLogin.DataSet1TableAdapters.consultasTableAdapter consultasTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TBIndice;
        private System.Windows.Forms.TextBox TFechaRespuesta;
        private System.Windows.Forms.TextBox TFechaCreado;
        private System.Windows.Forms.TextBox TEmail;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TID_consulta;
        private System.Windows.Forms.TextBox TMensaje;
        private System.Windows.Forms.Button BEnviarRespuesta;
        private System.Windows.Forms.TextBox TRespuesta;
        private System.Windows.Forms.Label LRespuesta;
        private System.Windows.Forms.DataGridView consultasDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_mensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_respuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn respuesta;
        private System.Windows.Forms.TextBox TUsuario;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Label label1;
    }
}