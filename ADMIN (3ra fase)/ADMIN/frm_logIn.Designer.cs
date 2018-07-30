namespace ADMIN
{
    partial class frm_logIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_logIn));
            this.Txt_loginUser = new System.Windows.Forms.TextBox();
            this.Txt_loginPass = new System.Windows.Forms.TextBox();
            this.Lbl_loginPass = new System.Windows.Forms.Label();
            this.Lbl_loginUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_loginAyuda = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_loginSalir = new System.Windows.Forms.Button();
            this.Chk_gestionPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_loginUser
            // 
            this.Txt_loginUser.Location = new System.Drawing.Point(241, 389);
            this.Txt_loginUser.MaxLength = 30;
            this.Txt_loginUser.Name = "Txt_loginUser";
            this.Txt_loginUser.Size = new System.Drawing.Size(245, 20);
            this.Txt_loginUser.TabIndex = 0;
            // 
            // Txt_loginPass
            // 
            this.Txt_loginPass.Location = new System.Drawing.Point(241, 415);
            this.Txt_loginPass.MaxLength = 30;
            this.Txt_loginPass.Name = "Txt_loginPass";
            this.Txt_loginPass.Size = new System.Drawing.Size(245, 20);
            this.Txt_loginPass.TabIndex = 1;
            this.Txt_loginPass.UseSystemPasswordChar = true;
            this.Txt_loginPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_loginPass_KeyPress);
            // 
            // Lbl_loginPass
            // 
            this.Lbl_loginPass.AutoSize = true;
            this.Lbl_loginPass.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_loginPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_loginPass.Location = new System.Drawing.Point(179, 419);
            this.Lbl_loginPass.Name = "Lbl_loginPass";
            this.Lbl_loginPass.Size = new System.Drawing.Size(47, 16);
            this.Lbl_loginPass.TabIndex = 7;
            this.Lbl_loginPass.Text = "PASS:";
            // 
            // Lbl_loginUser
            // 
            this.Lbl_loginUser.AutoSize = true;
            this.Lbl_loginUser.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_loginUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_loginUser.Location = new System.Drawing.Point(179, 393);
            this.Lbl_loginUser.Name = "Lbl_loginUser";
            this.Lbl_loginUser.Size = new System.Drawing.Size(50, 16);
            this.Lbl_loginUser.TabIndex = 6;
            this.Lbl_loginUser.Text = "USER:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(214, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 270);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_loginAyuda
            // 
            this.Btn_loginAyuda.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_loginAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_loginAyuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_loginAyuda.Image")));
            this.Btn_loginAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_loginAyuda.Location = new System.Drawing.Point(587, 60);
            this.Btn_loginAyuda.Name = "Btn_loginAyuda";
            this.Btn_loginAyuda.Size = new System.Drawing.Size(85, 43);
            this.Btn_loginAyuda.TabIndex = 9;
            this.Btn_loginAyuda.Text = "AYUDA";
            this.Btn_loginAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_loginAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_loginAyuda.UseVisualStyleBackColor = false;
            this.Btn_loginAyuda.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(0, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 41);
            this.panel2.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 41);
            this.panel1.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Aceptar.Image")));
            this.Btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Aceptar.Location = new System.Drawing.Point(269, 455);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(98, 44);
            this.Btn_Aceptar.TabIndex = 29;
            this.Btn_Aceptar.Text = "ACEPTAR";
            this.Btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.button7_Click);
            // 
            // Btn_loginSalir
            // 
            this.Btn_loginSalir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_loginSalir.Image")));
            this.Btn_loginSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_loginSalir.Location = new System.Drawing.Point(373, 456);
            this.Btn_loginSalir.Name = "Btn_loginSalir";
            this.Btn_loginSalir.Size = new System.Drawing.Size(82, 43);
            this.Btn_loginSalir.TabIndex = 32;
            this.Btn_loginSalir.Text = "SALIR";
            this.Btn_loginSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_loginSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_loginSalir.UseVisualStyleBackColor = true;
            this.Btn_loginSalir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Chk_gestionPass
            // 
            this.Chk_gestionPass.AutoSize = true;
            this.Chk_gestionPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_gestionPass.Location = new System.Drawing.Point(492, 418);
            this.Chk_gestionPass.Name = "Chk_gestionPass";
            this.Chk_gestionPass.Size = new System.Drawing.Size(140, 16);
            this.Chk_gestionPass.TabIndex = 33;
            this.Chk_gestionPass.Text = "MOSTRAR CONTRASEÑA";
            this.Chk_gestionPass.UseVisualStyleBackColor = true;
            this.Chk_gestionPass.CheckedChanged += new System.EventHandler(this.Chk_gestionPass_CheckedChanged);
            // 
            // frm_logIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(684, 556);
            this.Controls.Add(this.Chk_gestionPass);
            this.Controls.Add(this.Btn_loginSalir);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_loginAyuda);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_loginPass);
            this.Controls.Add(this.Lbl_loginUser);
            this.Controls.Add(this.Txt_loginPass);
            this.Controls.Add(this.Txt_loginUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_logIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.frm_logIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_loginUser;
        private System.Windows.Forms.TextBox Txt_loginPass;
        private System.Windows.Forms.Label Lbl_loginPass;
        private System.Windows.Forms.Label Lbl_loginUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_loginAyuda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_loginSalir;
        private System.Windows.Forms.CheckBox Chk_gestionPass;
    }
}