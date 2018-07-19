namespace Taquilla
{
    partial class frm_sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sesion));
            this.Lbl_SesionCrear = new System.Windows.Forms.Label();
            this.Lbl_sesionCuenta = new System.Windows.Forms.Label();
            this.Txt_sesionContraseña = new System.Windows.Forms.TextBox();
            this.Txt_sesionEmail = new System.Windows.Forms.TextBox();
            this.Lbl_sesionContraseña = new System.Windows.Forms.Label();
            this.Lbl_sesionEmail = new System.Windows.Forms.Label();
            this.Lbl_sesionClub = new System.Windows.Forms.Label();
            this.Btn_sesionSalir = new System.Windows.Forms.Button();
            this.Panel_abajo = new System.Windows.Forms.Panel();
            this.Panel_arriba = new System.Windows.Forms.Panel();
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            this.Btn_sesionEnviar = new System.Windows.Forms.Button();
            this.Panel_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_SesionCrear
            // 
            this.Lbl_SesionCrear.AutoSize = true;
            this.Lbl_SesionCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_SesionCrear.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SesionCrear.ForeColor = System.Drawing.Color.Red;
            this.Lbl_SesionCrear.Location = new System.Drawing.Point(342, 335);
            this.Lbl_SesionCrear.Name = "Lbl_SesionCrear";
            this.Lbl_SesionCrear.Size = new System.Drawing.Size(81, 17);
            this.Lbl_SesionCrear.TabIndex = 30;
            this.Lbl_SesionCrear.Text = "¡Crea Una!";
            this.Lbl_SesionCrear.Click += new System.EventHandler(this.label5_Click);
            // 
            // Lbl_sesionCuenta
            // 
            this.Lbl_sesionCuenta.AutoSize = true;
            this.Lbl_sesionCuenta.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sesionCuenta.Location = new System.Drawing.Point(242, 335);
            this.Lbl_sesionCuenta.Name = "Lbl_sesionCuenta";
            this.Lbl_sesionCuenta.Size = new System.Drawing.Size(96, 17);
            this.Lbl_sesionCuenta.TabIndex = 29;
            this.Lbl_sesionCuenta.Text = "¿Sin cuenta?";
            // 
            // Txt_sesionContraseña
            // 
            this.Txt_sesionContraseña.Location = new System.Drawing.Point(321, 284);
            this.Txt_sesionContraseña.Name = "Txt_sesionContraseña";
            this.Txt_sesionContraseña.Size = new System.Drawing.Size(231, 20);
            this.Txt_sesionContraseña.TabIndex = 28;
            // 
            // Txt_sesionEmail
            // 
            this.Txt_sesionEmail.Location = new System.Drawing.Point(321, 224);
            this.Txt_sesionEmail.Name = "Txt_sesionEmail";
            this.Txt_sesionEmail.Size = new System.Drawing.Size(231, 20);
            this.Txt_sesionEmail.TabIndex = 27;
            // 
            // Lbl_sesionContraseña
            // 
            this.Lbl_sesionContraseña.AutoSize = true;
            this.Lbl_sesionContraseña.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sesionContraseña.Location = new System.Drawing.Point(135, 284);
            this.Lbl_sesionContraseña.Name = "Lbl_sesionContraseña";
            this.Lbl_sesionContraseña.Size = new System.Drawing.Size(112, 17);
            this.Lbl_sesionContraseña.TabIndex = 26;
            this.Lbl_sesionContraseña.Text = "CONTRASEÑA:";
            // 
            // Lbl_sesionEmail
            // 
            this.Lbl_sesionEmail.AutoSize = true;
            this.Lbl_sesionEmail.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sesionEmail.Location = new System.Drawing.Point(135, 224);
            this.Lbl_sesionEmail.Name = "Lbl_sesionEmail";
            this.Lbl_sesionEmail.Size = new System.Drawing.Size(184, 17);
            this.Lbl_sesionEmail.TabIndex = 25;
            this.Lbl_sesionEmail.Text = "CORREO ELECTRÓNICO:";
            // 
            // Lbl_sesionClub
            // 
            this.Lbl_sesionClub.AutoSize = true;
            this.Lbl_sesionClub.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sesionClub.ForeColor = System.Drawing.Color.Red;
            this.Lbl_sesionClub.Location = new System.Drawing.Point(230, 113);
            this.Lbl_sesionClub.Name = "Lbl_sesionClub";
            this.Lbl_sesionClub.Size = new System.Drawing.Size(213, 39);
            this.Lbl_sesionClub.TabIndex = 24;
            this.Lbl_sesionClub.Text = "CLUB LICAS";
            this.Lbl_sesionClub.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_sesionSalir
            // 
            this.Btn_sesionSalir.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sesionSalir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_sesionSalir.Image")));
            this.Btn_sesionSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_sesionSalir.Location = new System.Drawing.Point(587, 419);
            this.Btn_sesionSalir.Name = "Btn_sesionSalir";
            this.Btn_sesionSalir.Size = new System.Drawing.Size(93, 41);
            this.Btn_sesionSalir.TabIndex = 50;
            this.Btn_sesionSalir.Text = "SALIR";
            this.Btn_sesionSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_sesionSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_sesionSalir.UseVisualStyleBackColor = true;
            this.Btn_sesionSalir.Click += new System.EventHandler(this.Btn_sesionSalir_Click);
            // 
            // Panel_abajo
            // 
            this.Panel_abajo.BackColor = System.Drawing.Color.Yellow;
            this.Panel_abajo.Location = new System.Drawing.Point(2, 466);
            this.Panel_abajo.Name = "Panel_abajo";
            this.Panel_abajo.Size = new System.Drawing.Size(681, 41);
            this.Panel_abajo.TabIndex = 52;
            // 
            // Panel_arriba
            // 
            this.Panel_arriba.BackColor = System.Drawing.Color.Yellow;
            this.Panel_arriba.Controls.Add(this.Pic_logo);
            this.Panel_arriba.Location = new System.Drawing.Point(2, 4);
            this.Panel_arriba.Name = "Panel_arriba";
            this.Panel_arriba.Size = new System.Drawing.Size(681, 41);
            this.Panel_arriba.TabIndex = 51;
            // 
            // Pic_logo
            // 
            this.Pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_logo.Image")));
            this.Pic_logo.Location = new System.Drawing.Point(6, 3);
            this.Pic_logo.Name = "Pic_logo";
            this.Pic_logo.Size = new System.Drawing.Size(91, 38);
            this.Pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_logo.TabIndex = 0;
            this.Pic_logo.TabStop = false;
            // 
            // Btn_sesionEnviar
            // 
            this.Btn_sesionEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_sesionEnviar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sesionEnviar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_sesionEnviar.Image")));
            this.Btn_sesionEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_sesionEnviar.Location = new System.Drawing.Point(452, 419);
            this.Btn_sesionEnviar.Name = "Btn_sesionEnviar";
            this.Btn_sesionEnviar.Size = new System.Drawing.Size(129, 41);
            this.Btn_sesionEnviar.TabIndex = 56;
            this.Btn_sesionEnviar.Text = "SIGUIENTE";
            this.Btn_sesionEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_sesionEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_sesionEnviar.UseVisualStyleBackColor = true;
            this.Btn_sesionEnviar.Click += new System.EventHandler(this.Btn_sesionEnviar_Click);
            // 
            // frm_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 487);
            this.Controls.Add(this.Btn_sesionEnviar);
            this.Controls.Add(this.Btn_sesionSalir);
            this.Controls.Add(this.Panel_abajo);
            this.Controls.Add(this.Panel_arriba);
            this.Controls.Add(this.Lbl_SesionCrear);
            this.Controls.Add(this.Lbl_sesionCuenta);
            this.Controls.Add(this.Txt_sesionContraseña);
            this.Controls.Add(this.Txt_sesionEmail);
            this.Controls.Add(this.Lbl_sesionContraseña);
            this.Controls.Add(this.Lbl_sesionEmail);
            this.Controls.Add(this.Lbl_sesionClub);
            this.Name = "frm_sesion";
            this.Text = "SESION";
            this.Panel_arriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_SesionCrear;
        private System.Windows.Forms.Label Lbl_sesionCuenta;
        private System.Windows.Forms.TextBox Txt_sesionContraseña;
        private System.Windows.Forms.TextBox Txt_sesionEmail;
        private System.Windows.Forms.Label Lbl_sesionContraseña;
        private System.Windows.Forms.Label Lbl_sesionEmail;
        private System.Windows.Forms.Label Lbl_sesionClub;
        private System.Windows.Forms.Button Btn_sesionSalir;
        private System.Windows.Forms.Panel Panel_abajo;
        private System.Windows.Forms.Panel Panel_arriba;
        private System.Windows.Forms.PictureBox Pic_logo;
        private System.Windows.Forms.Button Btn_sesionEnviar;
    }
}