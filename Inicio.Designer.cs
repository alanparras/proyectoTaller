namespace pruebaLogin
{
    partial class Inicio
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
            this.menu = new System.Windows.Forms.TableLayoutPanel();
            this.ReceiptsButton = new FontAwesome.Sharp.IconButton();
            this.StatsButton = new FontAwesome.Sharp.IconButton();
            this.ProductsButton = new FontAwesome.Sharp.IconButton();
            this.MsgButton = new FontAwesome.Sharp.IconButton();
            this.ConsultasButton = new FontAwesome.Sharp.IconButton();
            this.UsersButton = new FontAwesome.Sharp.IconButton();
            this.LogOutButton = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoScroll = true;
            this.menu.AutoSize = true;
            this.menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.menu.ColumnCount = 1;
            this.menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menu.Controls.Add(this.ReceiptsButton, 0, 5);
            this.menu.Controls.Add(this.StatsButton, 0, 4);
            this.menu.Controls.Add(this.ProductsButton, 0, 3);
            this.menu.Controls.Add(this.MsgButton, 0, 2);
            this.menu.Controls.Add(this.ConsultasButton, 0, 1);
            this.menu.Controls.Add(this.UsersButton, 0, 0);
            this.menu.Controls.Add(this.LogOutButton, 0, 6);
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.Location = new System.Drawing.Point(3, 3);
            this.menu.Name = "menu";
            this.menu.RowCount = 7;
            this.menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.menu.Size = new System.Drawing.Size(141, 509);
            this.menu.TabIndex = 5;
            // 
            // ReceiptsButton
            // 
            this.ReceiptsButton.AutoSize = true;
            this.ReceiptsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReceiptsButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ReceiptsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReceiptsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReceiptsButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptsButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.ReceiptsButton.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.ReceiptsButton.IconColor = System.Drawing.Color.AliceBlue;
            this.ReceiptsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReceiptsButton.Location = new System.Drawing.Point(3, 363);
            this.ReceiptsButton.MinimumSize = new System.Drawing.Size(120, 70);
            this.ReceiptsButton.Name = "ReceiptsButton";
            this.ReceiptsButton.Size = new System.Drawing.Size(135, 70);
            this.ReceiptsButton.TabIndex = 10;
            this.ReceiptsButton.Text = "Recibos";
            this.ReceiptsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ReceiptsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ReceiptsButton.UseVisualStyleBackColor = false;
            // 
            // StatsButton
            // 
            this.StatsButton.AutoSize = true;
            this.StatsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StatsButton.BackColor = System.Drawing.Color.SteelBlue;
            this.StatsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatsButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.StatsButton.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.StatsButton.IconColor = System.Drawing.Color.AliceBlue;
            this.StatsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StatsButton.Location = new System.Drawing.Point(3, 291);
            this.StatsButton.MinimumSize = new System.Drawing.Size(120, 70);
            this.StatsButton.Name = "StatsButton";
            this.StatsButton.Size = new System.Drawing.Size(135, 70);
            this.StatsButton.TabIndex = 9;
            this.StatsButton.Text = "Estadísticas";
            this.StatsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StatsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StatsButton.UseVisualStyleBackColor = false;
            this.StatsButton.Click += new System.EventHandler(this.StatsButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.AutoSize = true;
            this.ProductsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProductsButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ProductsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.ProductsButton.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.ProductsButton.IconColor = System.Drawing.Color.AliceBlue;
            this.ProductsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProductsButton.Location = new System.Drawing.Point(3, 219);
            this.ProductsButton.MinimumSize = new System.Drawing.Size(120, 70);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(135, 70);
            this.ProductsButton.TabIndex = 8;
            this.ProductsButton.Text = "Productos";
            this.ProductsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProductsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ProductsButton.UseVisualStyleBackColor = false;
            // 
            // MsgButton
            // 
            this.MsgButton.AutoSize = true;
            this.MsgButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MsgButton.BackColor = System.Drawing.Color.SteelBlue;
            this.MsgButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MsgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MsgButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.MsgButton.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.MsgButton.IconColor = System.Drawing.Color.AliceBlue;
            this.MsgButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MsgButton.Location = new System.Drawing.Point(3, 147);
            this.MsgButton.MinimumSize = new System.Drawing.Size(120, 70);
            this.MsgButton.Name = "MsgButton";
            this.MsgButton.Size = new System.Drawing.Size(135, 70);
            this.MsgButton.TabIndex = 7;
            this.MsgButton.Text = "Mensajes";
            this.MsgButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MsgButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MsgButton.UseVisualStyleBackColor = false;
            this.MsgButton.Click += new System.EventHandler(this.MsgButton_Click);
            // 
            // ConsultasButton
            // 
            this.ConsultasButton.AutoSize = true;
            this.ConsultasButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConsultasButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ConsultasButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultasButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.ConsultasButton.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.ConsultasButton.IconColor = System.Drawing.Color.AliceBlue;
            this.ConsultasButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ConsultasButton.Location = new System.Drawing.Point(3, 75);
            this.ConsultasButton.MinimumSize = new System.Drawing.Size(120, 70);
            this.ConsultasButton.Name = "ConsultasButton";
            this.ConsultasButton.Size = new System.Drawing.Size(135, 70);
            this.ConsultasButton.TabIndex = 6;
            this.ConsultasButton.Text = "Consultas";
            this.ConsultasButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConsultasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ConsultasButton.UseVisualStyleBackColor = false;
            // 
            // UsersButton
            // 
            this.UsersButton.AutoSize = true;
            this.UsersButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UsersButton.BackColor = System.Drawing.Color.SteelBlue;
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
            this.UsersButton.Size = new System.Drawing.Size(135, 70);
            this.UsersButton.TabIndex = 5;
            this.UsersButton.Text = "Usuarios";
            this.UsersButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UsersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UsersButton.UseVisualStyleBackColor = false;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.AutoSize = true;
            this.LogOutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogOutButton.BackColor = System.Drawing.Color.SteelBlue;
            this.LogOutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.LogOutButton.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.LogOutButton.IconColor = System.Drawing.Color.AliceBlue;
            this.LogOutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogOutButton.Location = new System.Drawing.Point(3, 435);
            this.LogOutButton.MinimumSize = new System.Drawing.Size(120, 70);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(135, 71);
            this.LogOutButton.TabIndex = 4;
            this.LogOutButton.Text = "Cerrar Sesión";
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LogOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LogOutButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.65417F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.34583F));
            this.tableLayoutPanel2.Controls.Add(this.menu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.contenedor, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 515F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(837, 515);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // contenedor
            // 
            this.contenedor.BackgroundImage = global::pruebaLogin.Properties.Resources.LogoGio;
            this.contenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(150, 3);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(684, 509);
            this.contenedor.TabIndex = 6;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 515);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel menu;
        private FontAwesome.Sharp.IconButton ReceiptsButton;
        private FontAwesome.Sharp.IconButton StatsButton;
        private FontAwesome.Sharp.IconButton ProductsButton;
        private FontAwesome.Sharp.IconButton MsgButton;
        private FontAwesome.Sharp.IconButton ConsultasButton;
        private FontAwesome.Sharp.IconButton UsersButton;
        private FontAwesome.Sharp.IconButton LogOutButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel contenedor;
    }
}