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
            this.Lbl_email = new System.Windows.Forms.Label();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Btn_enviar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_email
            // 
            this.Lbl_email.AutoSize = true;
            this.Lbl_email.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_email.Location = new System.Drawing.Point(62, 130);
            this.Lbl_email.Name = "Lbl_email";
            this.Lbl_email.Size = new System.Drawing.Size(82, 34);
            this.Lbl_email.TabIndex = 0;
            this.Lbl_email.Text = "Dirección \r\nE-mail";
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(150, 144);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(163, 20);
            this.Txt1.TabIndex = 1;
            // 
            // Btn_enviar
            // 
            this.Btn_enviar.Font = new System.Drawing.Font("Rockwell", 10.55F);
            this.Btn_enviar.Location = new System.Drawing.Point(274, 235);
            this.Btn_enviar.Name = "Btn_enviar";
            this.Btn_enviar.Size = new System.Drawing.Size(75, 35);
            this.Btn_enviar.TabIndex = 2;
            this.Btn_enviar.Text = "Enviar";
            this.Btn_enviar.UseVisualStyleBackColor = true;
            // 
            // Btn_salir
            // 
            this.Btn_salir.Location = new System.Drawing.Point(274, 277);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(75, 23);
            this.Btn_salir.TabIndex = 3;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // frm_correo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(407, 345);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_enviar);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.Lbl_email);
            this.Name = "frm_correo";
            this.Text = "frm_correo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_email;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.Button Btn_enviar;
        private System.Windows.Forms.Button Btn_salir;
    }
}