namespace ADMIN
{
    partial class frm_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_usuarios));
            this.Lbl_gestionUsuarios = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_usuarioSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_gestionAceptar = new System.Windows.Forms.Button();
            this.Lbl_gestionPrivilegios = new System.Windows.Forms.Label();
            this.Cmb_gestionPrivilegios = new System.Windows.Forms.ComboBox();
            this.Chk_gestionPass = new System.Windows.Forms.CheckBox();
            this.Lbl_gestionPass = new System.Windows.Forms.Label();
            this.Lbl_gestionUsuario = new System.Windows.Forms.Label();
            this.Txt_gestionPass = new System.Windows.Forms.TextBox();
            this.Txt_gestionUsuario = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_gestionUsuarios
            // 
            this.Lbl_gestionUsuarios.AutoSize = true;
            this.Lbl_gestionUsuarios.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_gestionUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_gestionUsuarios.Location = new System.Drawing.Point(12, 9);
            this.Lbl_gestionUsuarios.Name = "Lbl_gestionUsuarios";
            this.Lbl_gestionUsuarios.Size = new System.Drawing.Size(191, 21);
            this.Lbl_gestionUsuarios.TabIndex = 7;
            this.Lbl_gestionUsuarios.Text = "GESTION USUARIOS";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 511);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "INGRESAR";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.Btn_usuarioSalir);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.Btn_gestionAceptar);
            this.groupBox1.Controls.Add(this.Lbl_gestionPrivilegios);
            this.groupBox1.Controls.Add(this.Cmb_gestionPrivilegios);
            this.groupBox1.Controls.Add(this.Chk_gestionPass);
            this.groupBox1.Controls.Add(this.Lbl_gestionPass);
            this.groupBox1.Controls.Add(this.Lbl_gestionUsuario);
            this.groupBox1.Controls.Add(this.Txt_gestionPass);
            this.groupBox1.Controls.Add(this.Txt_gestionUsuario);
            this.groupBox1.Location = new System.Drawing.Point(6, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 479);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Btn_usuarioSalir
            // 
            this.Btn_usuarioSalir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_usuarioSalir.Image")));
            this.Btn_usuarioSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_usuarioSalir.Location = new System.Drawing.Point(554, 364);
            this.Btn_usuarioSalir.Name = "Btn_usuarioSalir";
            this.Btn_usuarioSalir.Size = new System.Drawing.Size(82, 43);
            this.Btn_usuarioSalir.TabIndex = 21;
            this.Btn_usuarioSalir.Text = "SALIR";
            this.Btn_usuarioSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_usuarioSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_usuarioSalir.UseVisualStyleBackColor = true;
            this.Btn_usuarioSalir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(0, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 41);
            this.panel1.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 41);
            this.panel2.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_gestionAceptar
            // 
            this.Btn_gestionAceptar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_gestionAceptar.Image")));
            this.Btn_gestionAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_gestionAceptar.Location = new System.Drawing.Point(451, 364);
            this.Btn_gestionAceptar.Name = "Btn_gestionAceptar";
            this.Btn_gestionAceptar.Size = new System.Drawing.Size(97, 43);
            this.Btn_gestionAceptar.TabIndex = 41;
            this.Btn_gestionAceptar.Text = "ACEPTAR";
            this.Btn_gestionAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_gestionAceptar.UseVisualStyleBackColor = true;
            // 
            // Lbl_gestionPrivilegios
            // 
            this.Lbl_gestionPrivilegios.AutoSize = true;
            this.Lbl_gestionPrivilegios.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_gestionPrivilegios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_gestionPrivilegios.Location = new System.Drawing.Point(66, 226);
            this.Lbl_gestionPrivilegios.Name = "Lbl_gestionPrivilegios";
            this.Lbl_gestionPrivilegios.Size = new System.Drawing.Size(82, 15);
            this.Lbl_gestionPrivilegios.TabIndex = 14;
            this.Lbl_gestionPrivilegios.Text = "PRIVILEGIOS:";
            // 
            // Cmb_gestionPrivilegios
            // 
            this.Cmb_gestionPrivilegios.FormattingEnabled = true;
            this.Cmb_gestionPrivilegios.Items.AddRange(new object[] {
            "0 - Aministrador",
            "1 - Usuario"});
            this.Cmb_gestionPrivilegios.Location = new System.Drawing.Point(171, 224);
            this.Cmb_gestionPrivilegios.Name = "Cmb_gestionPrivilegios";
            this.Cmb_gestionPrivilegios.Size = new System.Drawing.Size(245, 21);
            this.Cmb_gestionPrivilegios.TabIndex = 13;
            this.Cmb_gestionPrivilegios.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Chk_gestionPass
            // 
            this.Chk_gestionPass.AutoSize = true;
            this.Chk_gestionPass.Location = new System.Drawing.Point(422, 200);
            this.Chk_gestionPass.Name = "Chk_gestionPass";
            this.Chk_gestionPass.Size = new System.Drawing.Size(157, 17);
            this.Chk_gestionPass.TabIndex = 12;
            this.Chk_gestionPass.Text = "MOSTRAR CONTRASEÑA";
            this.Chk_gestionPass.UseVisualStyleBackColor = true;
            // 
            // Lbl_gestionPass
            // 
            this.Lbl_gestionPass.AutoSize = true;
            this.Lbl_gestionPass.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_gestionPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_gestionPass.Location = new System.Drawing.Point(66, 199);
            this.Lbl_gestionPass.Name = "Lbl_gestionPass";
            this.Lbl_gestionPass.Size = new System.Drawing.Size(89, 15);
            this.Lbl_gestionPass.TabIndex = 11;
            this.Lbl_gestionPass.Text = "CONTRASEÑA:";
            // 
            // Lbl_gestionUsuario
            // 
            this.Lbl_gestionUsuario.AutoSize = true;
            this.Lbl_gestionUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_gestionUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_gestionUsuario.Location = new System.Drawing.Point(66, 174);
            this.Lbl_gestionUsuario.Name = "Lbl_gestionUsuario";
            this.Lbl_gestionUsuario.Size = new System.Drawing.Size(62, 15);
            this.Lbl_gestionUsuario.TabIndex = 10;
            this.Lbl_gestionUsuario.Text = "USUARIO:";
            // 
            // Txt_gestionPass
            // 
            this.Txt_gestionPass.Location = new System.Drawing.Point(171, 197);
            this.Txt_gestionPass.Name = "Txt_gestionPass";
            this.Txt_gestionPass.Size = new System.Drawing.Size(245, 20);
            this.Txt_gestionPass.TabIndex = 9;
            // 
            // Txt_gestionUsuario
            // 
            this.Txt_gestionUsuario.Location = new System.Drawing.Point(171, 170);
            this.Txt_gestionUsuario.Name = "Txt_gestionUsuario";
            this.Txt_gestionUsuario.Size = new System.Drawing.Size(245, 20);
            this.Txt_gestionUsuario.TabIndex = 8;
            this.Txt_gestionUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MODIFICAR/ELIMINAR";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 473);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSQUEDA USUARIO";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(548, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 43);
            this.button2.TabIndex = 48;
            this.button2.Text = "SALIR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(441, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 43);
            this.button3.TabIndex = 47;
            this.button3.Text = "BUSCAR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Location = new System.Drawing.Point(0, 432);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 41);
            this.panel3.TabIndex = 45;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(0, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(642, 41);
            this.panel4.TabIndex = 44;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(79, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "USUARIO:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(169, 180);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(379, 20);
            this.textBox4.TabIndex = 8;
            // 
            // frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(684, 556);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Lbl_gestionUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_usuarios";
            this.Text = "GESTION DE USUASRIOS";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_gestionUsuarios;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_gestionPass;
        private System.Windows.Forms.Label Lbl_gestionUsuario;
        private System.Windows.Forms.TextBox Txt_gestionPass;
        private System.Windows.Forms.TextBox Txt_gestionUsuario;
        private System.Windows.Forms.CheckBox Chk_gestionPass;
        private System.Windows.Forms.Label Lbl_gestionPrivilegios;
        private System.Windows.Forms.ComboBox Cmb_gestionPrivilegios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Btn_gestionAceptar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Btn_usuarioSalir;
        private System.Windows.Forms.Button button2;
    }
}