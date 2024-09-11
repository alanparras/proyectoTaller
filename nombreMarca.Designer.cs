namespace pruebaLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BLogin = new System.Windows.Forms.Button();
            this.LLogin = new System.Windows.Forms.Label();
            this.TPass = new System.Windows.Forms.TextBox();
            this.LPass = new System.Windows.Forms.Label();
            this.TUser = new System.Windows.Forms.TextBox();
            this.LUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.BLogin);
            this.panel1.Controls.Add(this.LLogin);
            this.panel1.Controls.Add(this.TPass);
            this.panel1.Controls.Add(this.LPass);
            this.panel1.Controls.Add(this.TUser);
            this.panel1.Controls.Add(this.LUser);
            this.panel1.Location = new System.Drawing.Point(256, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 274);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(67, 205);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(122, 27);
            this.BLogin.TabIndex = 5;
            this.BLogin.Text = "Iniciar Sesión";
            this.BLogin.UseVisualStyleBackColor = true;
            // 
            // LLogin
            // 
            this.LLogin.AutoSize = true;
            this.LLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLogin.Location = new System.Drawing.Point(51, 40);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(154, 31);
            this.LLogin.TabIndex = 4;
            this.LLogin.Text = "Logo de gio";
            this.LLogin.Click += new System.EventHandler(this.LLogin_Click);
            // 
            // TPass
            // 
            this.TPass.Location = new System.Drawing.Point(67, 164);
            this.TPass.Name = "TPass";
            this.TPass.Size = new System.Drawing.Size(122, 20);
            this.TPass.TabIndex = 3;
            this.TPass.UseSystemPasswordChar = true;
            // 
            // LPass
            // 
            this.LPass.AutoSize = true;
            this.LPass.Location = new System.Drawing.Point(64, 148);
            this.LPass.Name = "LPass";
            this.LPass.Size = new System.Drawing.Size(61, 13);
            this.LPass.TabIndex = 2;
            this.LPass.Text = "Contraseña";
            // 
            // TUser
            // 
            this.TUser.Location = new System.Drawing.Point(67, 115);
            this.TUser.Name = "TUser";
            this.TUser.Size = new System.Drawing.Size(122, 20);
            this.TUser.TabIndex = 1;
            // 
            // LUser
            // 
            this.LUser.AutoSize = true;
            this.LUser.Location = new System.Drawing.Point(64, 99);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(43, 13);
            this.LUser.TabIndex = 0;
            this.LUser.Text = "Usuario";
            // 
            // nombreMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 447);
            this.Controls.Add(this.panel1);
            this.Name = "nombreMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TUser;
        private System.Windows.Forms.TextBox TPass;
        private System.Windows.Forms.Label LLogin;
        private System.Windows.Forms.Label LPass;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.Button BLogin;
    }
}

