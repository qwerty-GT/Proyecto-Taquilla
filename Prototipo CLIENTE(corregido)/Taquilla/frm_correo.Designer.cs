namespace Taquilla
{
    partial class frm_correo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_correo));
            this.Lbl_email = new System.Windows.Forms.Label();
            this.Txt_correoEmail = new System.Windows.Forms.TextBox();
            this.Btn_correoSalir = new System.Windows.Forms.Button();
            this.Btn_correoEnviar = new System.Windows.Forms.Button();
            this.Panel_arriba = new System.Windows.Forms.Panel();
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            this.Panel_abajo = new System.Windows.Forms.Panel();
            this.Panel_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_email
            // 
            this.Lbl_email.AutoSize = true;
            this.Lbl_email.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_email.Location = new System.Drawing.Point(34, 129);
            this.Lbl_email.Name = "Lbl_email";
            this.Lbl_email.Size = new System.Drawing.Size(82, 34);
            this.Lbl_email.TabIndex = 0;
            this.Lbl_email.Text = "Dirección \r\nE-mail";
            // 
            // Txt_correoEmail
            // 
            this.Txt_correoEmail.Location = new System.Drawing.Point(144, 143);
            this.Txt_correoEmail.Name = "Txt_correoEmail";
            this.Txt_correoEmail.Size = new System.Drawing.Size(219, 20);
            this.Txt_correoEmail.TabIndex = 1;
            // 
            // Btn_correoSalir
            // 
            this.Btn_correoSalir.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_correoSalir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_correoSalir.Image")));
            this.Btn_correoSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_correoSalir.Location = new System.Drawing.Point(302, 256);
            this.Btn_correoSalir.Name = "Btn_correoSalir";
            this.Btn_correoSalir.Size = new System.Drawing.Size(93, 41);
            this.Btn_correoSalir.TabIndex = 59;
            this.Btn_correoSalir.Text = "SALIR";
            this.Btn_correoSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_correoSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_correoSalir.UseVisualStyleBackColor = true;
            this.Btn_correoSalir.Click += new System.EventHandler(this.Btn_correoSalir_Click);
            // 
            // Btn_correoEnviar
            // 
            this.Btn_correoEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_correoEnviar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_correoEnviar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_correoEnviar.Image")));
            this.Btn_correoEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_correoEnviar.Location = new System.Drawing.Point(185, 256);
            this.Btn_correoEnviar.Name = "Btn_correoEnviar";
            this.Btn_correoEnviar.Size = new System.Drawing.Size(111, 41);
            this.Btn_correoEnviar.TabIndex = 58;
            this.Btn_correoEnviar.Text = "ENVIAR";
            this.Btn_correoEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_correoEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_correoEnviar.UseVisualStyleBackColor = true;
            // 
            // Panel_arriba
            // 
            this.Panel_arriba.BackColor = System.Drawing.Color.Yellow;
            this.Panel_arriba.Controls.Add(this.Pic_logo);
            this.Panel_arriba.Location = new System.Drawing.Point(1, 1);
            this.Panel_arriba.Name = "Panel_arriba";
            this.Panel_arriba.Size = new System.Drawing.Size(408, 41);
            this.Panel_arriba.TabIndex = 60;
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
            // Panel_abajo
            // 
            this.Panel_abajo.BackColor = System.Drawing.Color.Yellow;
            this.Panel_abajo.Location = new System.Drawing.Point(-1, 303);
            this.Panel_abajo.Name = "Panel_abajo";
            this.Panel_abajo.Size = new System.Drawing.Size(408, 41);
            this.Panel_abajo.TabIndex = 61;
            // 
            // frm_correo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(407, 345);
            this.Controls.Add(this.Panel_abajo);
            this.Controls.Add(this.Panel_arriba);
            this.Controls.Add(this.Btn_correoSalir);
            this.Controls.Add(this.Btn_correoEnviar);
            this.Controls.Add(this.Txt_correoEmail);
            this.Controls.Add(this.Lbl_email);
            this.Name = "frm_correo";
            this.Text = "CORREO";
            this.Panel_arriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_email;
        private System.Windows.Forms.TextBox Txt_correoEmail;
        private System.Windows.Forms.Button Btn_correoSalir;
        private System.Windows.Forms.Button Btn_correoEnviar;
        private System.Windows.Forms.Panel Panel_arriba;
        private System.Windows.Forms.PictureBox Pic_logo;
        private System.Windows.Forms.Panel Panel_abajo;
    }
}