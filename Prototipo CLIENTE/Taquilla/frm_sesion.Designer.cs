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
            this.Lbl_crear = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Lbl_contraseña = new System.Windows.Forms.Label();
            this.Lbl_email = new System.Windows.Forms.Label();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Btn_sig = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_crear
            // 
            this.Lbl_crear.AutoSize = true;
            this.Lbl_crear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_crear.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_crear.ForeColor = System.Drawing.Color.MediumBlue;
            this.Lbl_crear.Location = new System.Drawing.Point(343, 461);
            this.Lbl_crear.Name = "Lbl_crear";
            this.Lbl_crear.Size = new System.Drawing.Size(81, 17);
            this.Lbl_crear.TabIndex = 30;
            this.Lbl_crear.Text = "¡Crea Una!";
            this.Lbl_crear.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "¿Sin cuenta?";
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(316, 255);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(171, 20);
            this.Txt2.TabIndex = 28;
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(316, 195);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(171, 20);
            this.Txt1.TabIndex = 27;
            // 
            // Lbl_contraseña
            // 
            this.Lbl_contraseña.AutoSize = true;
            this.Lbl_contraseña.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_contraseña.Location = new System.Drawing.Point(151, 255);
            this.Lbl_contraseña.Name = "Lbl_contraseña";
            this.Lbl_contraseña.Size = new System.Drawing.Size(89, 17);
            this.Lbl_contraseña.TabIndex = 26;
            this.Lbl_contraseña.Text = "Contraseña";
            // 
            // Lbl_email
            // 
            this.Lbl_email.AutoSize = true;
            this.Lbl_email.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_email.Location = new System.Drawing.Point(151, 193);
            this.Lbl_email.Name = "Lbl_email";
            this.Lbl_email.Size = new System.Drawing.Size(144, 17);
            this.Lbl_email.TabIndex = 25;
            this.Lbl_email.Text = "Correo electrónico";
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Lbl_titulo.Location = new System.Drawing.Point(226, 58);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(213, 39);
            this.Lbl_titulo.TabIndex = 24;
            this.Lbl_titulo.Text = "CLUB LICAS";
            this.Lbl_titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_sig
            // 
            this.Btn_sig.Location = new System.Drawing.Point(488, 311);
            this.Btn_sig.Name = "Btn_sig";
            this.Btn_sig.Size = new System.Drawing.Size(75, 23);
            this.Btn_sig.TabIndex = 31;
            this.Btn_sig.Text = "Siguiente";
            this.Btn_sig.UseVisualStyleBackColor = true;
            // 
            // Btn_salir
            // 
            this.Btn_salir.Location = new System.Drawing.Point(488, 354);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(75, 23);
            this.Btn_salir.TabIndex = 32;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // frm_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_sig);
            this.Controls.Add(this.Lbl_crear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.Lbl_contraseña);
            this.Controls.Add(this.Lbl_email);
            this.Controls.Add(this.Lbl_titulo);
            this.Name = "frm_sesion";
            this.Text = "frm_sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_crear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.Label Lbl_contraseña;
        private System.Windows.Forms.Label Lbl_email;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Button Btn_sig;
        private System.Windows.Forms.Button Btn_salir;
    }
}