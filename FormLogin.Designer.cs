namespace FormCarpinteria
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.NomEmpresa = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.btnAcceso = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelContra = new System.Windows.Forms.Label();
            this.textBoxContra = new System.Windows.Forms.TextBox();
            this.labelSMSError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NomEmpresa
            // 
            this.NomEmpresa.AutoSize = true;
            this.NomEmpresa.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomEmpresa.ForeColor = System.Drawing.SystemColors.Info;
            this.NomEmpresa.Location = new System.Drawing.Point(102, 33);
            this.NomEmpresa.Name = "NomEmpresa";
            this.NomEmpresa.Size = new System.Drawing.Size(237, 34);
            this.NomEmpresa.TabIndex = 0;
            this.NomEmpresa.Text = "Carpintería Aguilar";
            this.NomEmpresa.Click += new System.EventHandler(this.NomEmpresa_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.DarkRed;
            this.labelLogin.Location = new System.Drawing.Point(157, 286);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(114, 35);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "LOGIN";
            // 
            // btnAcceso
            // 
            this.btnAcceso.BackColor = System.Drawing.Color.Maroon;
            this.btnAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceso.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnAcceso.Location = new System.Drawing.Point(129, 588);
            this.btnAcceso.Name = "btnAcceso";
            this.btnAcceso.Size = new System.Drawing.Size(196, 52);
            this.btnAcceso.TabIndex = 4;
            this.btnAcceso.Text = "ACCEDER";
            this.btnAcceso.UseVisualStyleBackColor = false;
            this.btnAcceso.Click += new System.EventHandler(this.btnAcceso_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUsuario.Location = new System.Drawing.Point(24, 347);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(68, 16);
            this.labelUsuario.TabIndex = 7;
            this.labelUsuario.Text = "USUARIO";
            this.labelUsuario.Click += new System.EventHandler(this.labelUsuario_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(27, 366);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(378, 30);
            this.textBoxUsuario.TabIndex = 9;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // labelContra
            // 
            this.labelContra.AutoSize = true;
            this.labelContra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelContra.Location = new System.Drawing.Point(24, 427);
            this.labelContra.Name = "labelContra";
            this.labelContra.Size = new System.Drawing.Size(101, 16);
            this.labelContra.TabIndex = 11;
            this.labelContra.Text = "CONTRASEÑA";
            // 
            // textBoxContra
            // 
            this.textBoxContra.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxContra.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContra.Location = new System.Drawing.Point(27, 446);
            this.textBoxContra.Name = "textBoxContra";
            this.textBoxContra.PasswordChar = '*';
            this.textBoxContra.Size = new System.Drawing.Size(378, 30);
            this.textBoxContra.TabIndex = 12;
            this.textBoxContra.TextChanged += new System.EventHandler(this.textBoxContra_TextChanged);
            // 
            // labelSMSError
            // 
            this.labelSMSError.AutoSize = true;
            this.labelSMSError.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSMSError.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSMSError.Image = ((System.Drawing.Image)(resources.GetObject("labelSMSError.Image")));
            this.labelSMSError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSMSError.Location = new System.Drawing.Point(24, 499);
            this.labelSMSError.Name = "labelSMSError";
            this.labelSMSError.Size = new System.Drawing.Size(148, 18);
            this.labelSMSError.TabIndex = 10;
            this.labelSMSError.Text = "    Mensaje de Error";
            this.labelSMSError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSMSError.Visible = false;
            this.labelSMSError.Click += new System.EventHandler(this.labelSMSError_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormCarpinteria.Properties.Resources.kisspng_tree_of_life_clip_art_tree_vector_png_5aada1b892db02_7385197315213285686015;
            this.pictureBox1.Location = new System.Drawing.Point(129, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(447, 695);
            this.Controls.Add(this.textBoxContra);
            this.Controls.Add(this.labelContra);
            this.Controls.Add(this.labelSMSError);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.btnAcceso);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NomEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.Load += new System.EventHandler(this.LoginUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomEmpresa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button btnAcceso;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelSMSError;
        private System.Windows.Forms.Label labelContra;
        private System.Windows.Forms.TextBox textBoxContra;
    }
}

