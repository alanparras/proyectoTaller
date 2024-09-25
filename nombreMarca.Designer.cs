namespace ProyectoTallerG8
{
    partial class nombreMarca
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nombreMarca));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BLogin = new System.Windows.Forms.Button();
            this.TPass = new System.Windows.Forms.TextBox();
            this.LPass = new System.Windows.Forms.Label();
            this.TUser = new System.Windows.Forms.TextBox();
            this.LUser = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1064, 518);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BLogin);
            this.panel1.Controls.Add(this.TPass);
            this.panel1.Controls.Add(this.LPass);
            this.panel1.Controls.Add(this.TUser);
            this.panel1.Controls.Add(this.LUser);
            this.panel1.Location = new System.Drawing.Point(400, 97);
            this.panel1.MaximumSize = new System.Drawing.Size(264, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 324);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BLogin
            // 
            this.BLogin.BackColor = System.Drawing.Color.Gray;
            this.BLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BLogin.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BLogin.Location = new System.Drawing.Point(73, 280);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(122, 32);
            this.BLogin.TabIndex = 5;
            this.BLogin.Text = "Iniciar Sesión";
            this.BLogin.UseVisualStyleBackColor = false;
            // 
            // TPass
            // 
            this.TPass.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPass.Location = new System.Drawing.Point(73, 239);
            this.TPass.Name = "TPass";
            this.TPass.Size = new System.Drawing.Size(122, 20);
            this.TPass.TabIndex = 3;
            this.TPass.UseSystemPasswordChar = true;
            // 
            // LPass
            // 
            this.LPass.AutoSize = true;
            this.LPass.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LPass.Location = new System.Drawing.Point(69, 217);
            this.LPass.Name = "LPass";
            this.LPass.Size = new System.Drawing.Size(71, 19);
            this.LPass.TabIndex = 2;
            this.LPass.Text = "Contraseña";
            // 
            // TUser
            // 
            this.TUser.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TUser.ForeColor = System.Drawing.Color.Gray;
            this.TUser.Location = new System.Drawing.Point(73, 190);
            this.TUser.Name = "TUser";
            this.TUser.Size = new System.Drawing.Size(122, 20);
            this.TUser.TabIndex = 1;
            // 
            // LUser
            // 
            this.LUser.AutoSize = true;
            this.LUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LUser.Location = new System.Drawing.Point(69, 168);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(50, 19);
            this.LUser.TabIndex = 0;
            this.LUser.Text = "Usuario";
            // 
            // nombreMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1064, 518);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "nombreMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.TextBox TPass;
        private System.Windows.Forms.Label LPass;
        private System.Windows.Forms.TextBox TUser;
        private System.Windows.Forms.Label LUser;
    }
}

