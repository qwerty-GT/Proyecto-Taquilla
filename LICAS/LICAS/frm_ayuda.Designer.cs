namespace LICAS
{
    partial class frm_ayuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ayuda));
            this.Lbl_reembolso = new System.Windows.Forms.Label();
            this.txt_asunto = new System.Windows.Forms.TextBox();
            this.Lbl_mensaje = new System.Windows.Forms.Label();
            this.Btn_enviar = new System.Windows.Forms.Button();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.Lbl_asunto = new System.Windows.Forms.Label();
            this.Lbl_correo = new System.Windows.Forms.Label();
            this.Lbl_p3 = new System.Windows.Forms.Label();
            this.Lbl_p1 = new System.Windows.Forms.Label();
            this.Lbl_r3 = new System.Windows.Forms.Label();
            this.Lbl_r2 = new System.Windows.Forms.Label();
            this.Lbl_r1 = new System.Windows.Forms.Label();
            this.Lbl_p2 = new System.Windows.Forms.Label();
            this.Lbl_servicio2 = new System.Windows.Forms.Label();
            this.Lbl_servicio1 = new System.Windows.Forms.Label();
            this.Btn_FAQ = new System.Windows.Forms.Button();
            this.Panel_abajo = new System.Windows.Forms.Panel();
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            this.Lbl_servicioEmail = new System.Windows.Forms.Label();
            this.Panel_arriba = new System.Windows.Forms.Panel();
            this.Btn_ayudaSalir = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Btn_ayudaPregunta = new System.Windows.Forms.Button();
            this.Btn_ayudaReembolso = new System.Windows.Forms.Button();
            this.Btn_ayudaServicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            this.Panel_arriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_reembolso
            // 
            this.Lbl_reembolso.AutoSize = true;
            this.Lbl_reembolso.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_reembolso.ForeColor = System.Drawing.Color.Blue;
            this.Lbl_reembolso.Location = new System.Drawing.Point(2, 300);
            this.Lbl_reembolso.Name = "Lbl_reembolso";
            this.Lbl_reembolso.Size = new System.Drawing.Size(685, 76);
            this.Lbl_reembolso.TabIndex = 469;
            this.Lbl_reembolso.Text = resources.GetString("Lbl_reembolso.Text");
            this.Lbl_reembolso.Visible = false;
            this.Lbl_reembolso.Click += new System.EventHandler(this.Lbl_reembolso_Click);
            // 
            // txt_asunto
            // 
            this.txt_asunto.Location = new System.Drawing.Point(258, 287);
            this.txt_asunto.Name = "txt_asunto";
            this.txt_asunto.Size = new System.Drawing.Size(265, 20);
            this.txt_asunto.TabIndex = 468;
            this.txt_asunto.Visible = false;
            // 
            // Lbl_mensaje
            // 
            this.Lbl_mensaje.AutoSize = true;
            this.Lbl_mensaje.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mensaje.Location = new System.Drawing.Point(191, 290);
            this.Lbl_mensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_mensaje.Name = "Lbl_mensaje";
            this.Lbl_mensaje.Size = new System.Drawing.Size(61, 17);
            this.Lbl_mensaje.TabIndex = 467;
            this.Lbl_mensaje.Text = "Asunto:";
            this.Lbl_mensaje.Visible = false;
            // 
            // Btn_enviar
            // 
            this.Btn_enviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_enviar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_enviar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_enviar.Image")));
            this.Btn_enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_enviar.Location = new System.Drawing.Point(444, 468);
            this.Btn_enviar.Name = "Btn_enviar";
            this.Btn_enviar.Size = new System.Drawing.Size(129, 41);
            this.Btn_enviar.TabIndex = 466;
            this.Btn_enviar.Text = "SIGUIENTE";
            this.Btn_enviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_enviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_enviar.UseVisualStyleBackColor = true;
            this.Btn_enviar.Visible = false;
            this.Btn_enviar.Click += new System.EventHandler(this.Btn_enviar_Click);
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.Location = new System.Drawing.Point(258, 320);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.Size = new System.Drawing.Size(265, 116);
            this.txt_mensaje.TabIndex = 465;
            this.txt_mensaje.Visible = false;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(258, 257);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(265, 20);
            this.txt_correo.TabIndex = 464;
            this.txt_correo.Visible = false;
            // 
            // Lbl_asunto
            // 
            this.Lbl_asunto.AutoSize = true;
            this.Lbl_asunto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_asunto.Location = new System.Drawing.Point(180, 320);
            this.Lbl_asunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_asunto.Name = "Lbl_asunto";
            this.Lbl_asunto.Size = new System.Drawing.Size(72, 17);
            this.Lbl_asunto.TabIndex = 463;
            this.Lbl_asunto.Text = "Mensaje:";
            this.Lbl_asunto.Visible = false;
            // 
            // Lbl_correo
            // 
            this.Lbl_correo.AutoSize = true;
            this.Lbl_correo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_correo.Location = new System.Drawing.Point(104, 257);
            this.Lbl_correo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_correo.Name = "Lbl_correo";
            this.Lbl_correo.Size = new System.Drawing.Size(148, 17);
            this.Lbl_correo.TabIndex = 462;
            this.Lbl_correo.Text = "Correo electrónico:";
            this.Lbl_correo.Visible = false;
            // 
            // Lbl_p3
            // 
            this.Lbl_p3.AutoSize = true;
            this.Lbl_p3.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_p3.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.Lbl_p3.Location = new System.Drawing.Point(20, 375);
            this.Lbl_p3.Name = "Lbl_p3";
            this.Lbl_p3.Size = new System.Drawing.Size(211, 17);
            this.Lbl_p3.TabIndex = 461;
            this.Lbl_p3.Text = "•¿Puedo cancelar la compra?";
            // 
            // Lbl_p1
            // 
            this.Lbl_p1.AutoSize = true;
            this.Lbl_p1.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_p1.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.Lbl_p1.Location = new System.Drawing.Point(20, 257);
            this.Lbl_p1.Name = "Lbl_p1";
            this.Lbl_p1.Size = new System.Drawing.Size(388, 17);
            this.Lbl_p1.TabIndex = 460;
            this.Lbl_p1.Text = "•¿Con cuanto tiempo de anticipación puedo comprar?";
            // 
            // Lbl_r3
            // 
            this.Lbl_r3.AutoSize = true;
            this.Lbl_r3.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_r3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_r3.ForeColor = System.Drawing.Color.Blue;
            this.Lbl_r3.Location = new System.Drawing.Point(41, 392);
            this.Lbl_r3.Name = "Lbl_r3";
            this.Lbl_r3.Size = new System.Drawing.Size(612, 45);
            this.Lbl_r3.TabIndex = 459;
            this.Lbl_r3.Text = resources.GetString("Lbl_r3.Text");
            // 
            // Lbl_r2
            // 
            this.Lbl_r2.AutoSize = true;
            this.Lbl_r2.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_r2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_r2.ForeColor = System.Drawing.Color.Blue;
            this.Lbl_r2.Location = new System.Drawing.Point(39, 345);
            this.Lbl_r2.Name = "Lbl_r2";
            this.Lbl_r2.Size = new System.Drawing.Size(534, 30);
            this.Lbl_r2.TabIndex = 458;
            this.Lbl_r2.Text = "LICAS se reserva el derecho de hacer modificaciones  a las funciones que se halla" +
    "n \r\nreservado.";
            // 
            // Lbl_r1
            // 
            this.Lbl_r1.AutoSize = true;
            this.Lbl_r1.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_r1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_r1.ForeColor = System.Drawing.Color.Blue;
            this.Lbl_r1.Location = new System.Drawing.Point(41, 274);
            this.Lbl_r1.Name = "Lbl_r1";
            this.Lbl_r1.Size = new System.Drawing.Size(517, 15);
            this.Lbl_r1.TabIndex = 457;
            this.Lbl_r1.Text = "Si la película ya está estrenada, puedes comprar hasta con 5 días de aticipación";
            // 
            // Lbl_p2
            // 
            this.Lbl_p2.AutoSize = true;
            this.Lbl_p2.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_p2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_p2.Location = new System.Drawing.Point(20, 294);
            this.Lbl_p2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_p2.Name = "Lbl_p2";
            this.Lbl_p2.Size = new System.Drawing.Size(515, 51);
            this.Lbl_p2.TabIndex = 456;
            this.Lbl_p2.Text = "•¿Puedo cambiar de película una vez haya hecho la compra?\r\n•¿Puedo cambiar de asi" +
    "ento una vez haya reservado ya?\r\n•¿Puedo cambiar el horario de la pelicula despu" +
    "es de haber comprado?";
            // 
            // Lbl_servicio2
            // 
            this.Lbl_servicio2.AutoSize = true;
            this.Lbl_servicio2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_servicio2.ForeColor = System.Drawing.Color.Black;
            this.Lbl_servicio2.Location = new System.Drawing.Point(155, 318);
            this.Lbl_servicio2.Name = "Lbl_servicio2";
            this.Lbl_servicio2.Size = new System.Drawing.Size(379, 19);
            this.Lbl_servicio2.TabIndex = 454;
            this.Lbl_servicio2.Text = "O puedes llamar a éste número: (502) 58257273";
            this.Lbl_servicio2.Visible = false;
            // 
            // Lbl_servicio1
            // 
            this.Lbl_servicio1.AutoSize = true;
            this.Lbl_servicio1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_servicio1.ForeColor = System.Drawing.Color.Black;
            this.Lbl_servicio1.Location = new System.Drawing.Point(19, 281);
            this.Lbl_servicio1.Name = "Lbl_servicio1";
            this.Lbl_servicio1.Size = new System.Drawing.Size(581, 19);
            this.Lbl_servicio1.TabIndex = 453;
            this.Lbl_servicio1.Text = "Si tienes alguna duda o sugerencia, puedes comunicarte con nosotros via";
            this.Lbl_servicio1.Visible = false;
            // 
            // Btn_FAQ
            // 
            this.Btn_FAQ.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.Btn_FAQ.Location = new System.Drawing.Point(495, 114);
            this.Btn_FAQ.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_FAQ.Name = "Btn_FAQ";
            this.Btn_FAQ.Size = new System.Drawing.Size(105, 62);
            this.Btn_FAQ.TabIndex = 452;
            this.Btn_FAQ.Text = "PREGUNTAS FRECUENTES";
            this.Btn_FAQ.UseVisualStyleBackColor = true;
            this.Btn_FAQ.Click += new System.EventHandler(this.Btn_FAQ_Click);
            // 
            // Panel_abajo
            // 
            this.Panel_abajo.BackColor = System.Drawing.Color.Yellow;
            this.Panel_abajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_abajo.Location = new System.Drawing.Point(0, 515);
            this.Panel_abajo.Name = "Panel_abajo";
            this.Panel_abajo.Size = new System.Drawing.Size(684, 41);
            this.Panel_abajo.TabIndex = 451;
            // 
            // Pic_logo
            // 
            this.Pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_logo.Image")));
            this.Pic_logo.Location = new System.Drawing.Point(12, 3);
            this.Pic_logo.Name = "Pic_logo";
            this.Pic_logo.Size = new System.Drawing.Size(91, 38);
            this.Pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_logo.TabIndex = 0;
            this.Pic_logo.TabStop = false;
            // 
            // Lbl_servicioEmail
            // 
            this.Lbl_servicioEmail.AutoSize = true;
            this.Lbl_servicioEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_servicioEmail.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_servicioEmail.ForeColor = System.Drawing.Color.Blue;
            this.Lbl_servicioEmail.Location = new System.Drawing.Point(597, 281);
            this.Lbl_servicioEmail.Name = "Lbl_servicioEmail";
            this.Lbl_servicioEmail.Size = new System.Drawing.Size(64, 19);
            this.Lbl_servicioEmail.TabIndex = 455;
            this.Lbl_servicioEmail.Text = "EMAIL";
            this.Lbl_servicioEmail.Visible = false;
            this.Lbl_servicioEmail.Click += new System.EventHandler(this.Lbl_servicioEmail_Click);
            // 
            // Panel_arriba
            // 
            this.Panel_arriba.BackColor = System.Drawing.Color.Yellow;
            this.Panel_arriba.Controls.Add(this.Pic_logo);
            this.Panel_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_arriba.Location = new System.Drawing.Point(0, 0);
            this.Panel_arriba.Name = "Panel_arriba";
            this.Panel_arriba.Size = new System.Drawing.Size(684, 41);
            this.Panel_arriba.TabIndex = 450;
            // 
            // Btn_ayudaSalir
            // 
            this.Btn_ayudaSalir.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ayudaSalir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayudaSalir.Image")));
            this.Btn_ayudaSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ayudaSalir.Location = new System.Drawing.Point(579, 468);
            this.Btn_ayudaSalir.Name = "Btn_ayudaSalir";
            this.Btn_ayudaSalir.Size = new System.Drawing.Size(93, 41);
            this.Btn_ayudaSalir.TabIndex = 449;
            this.Btn_ayudaSalir.Text = "SALIR";
            this.Btn_ayudaSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ayudaSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ayudaSalir.UseVisualStyleBackColor = true;
            this.Btn_ayudaSalir.Click += new System.EventHandler(this.Btn_ayudaSalir_Click);
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(265, 214);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(209, 18);
            this.Lbl_titulo.TabIndex = 448;
            this.Lbl_titulo.Text = "PREGUNTAS FRECUENTES";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.ForeColor = System.Drawing.Color.Red;
            this.Lbl1.Location = new System.Drawing.Point(255, 69);
            this.Lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(166, 18);
            this.Lbl1.TabIndex = 447;
            this.Lbl1.Text = "SERVICIO DE AYUDA";
            // 
            // Btn_ayudaPregunta
            // 
            this.Btn_ayudaPregunta.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.Btn_ayudaPregunta.Location = new System.Drawing.Point(358, 114);
            this.Btn_ayudaPregunta.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ayudaPregunta.Name = "Btn_ayudaPregunta";
            this.Btn_ayudaPregunta.Size = new System.Drawing.Size(105, 62);
            this.Btn_ayudaPregunta.TabIndex = 446;
            this.Btn_ayudaPregunta.Text = "HAZ UNA PREGUNTA";
            this.Btn_ayudaPregunta.UseVisualStyleBackColor = true;
            this.Btn_ayudaPregunta.Click += new System.EventHandler(this.Btn_ayudaPregunta_Click);
            // 
            // Btn_ayudaReembolso
            // 
            this.Btn_ayudaReembolso.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.Btn_ayudaReembolso.Location = new System.Drawing.Point(226, 114);
            this.Btn_ayudaReembolso.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ayudaReembolso.Name = "Btn_ayudaReembolso";
            this.Btn_ayudaReembolso.Size = new System.Drawing.Size(105, 62);
            this.Btn_ayudaReembolso.TabIndex = 445;
            this.Btn_ayudaReembolso.Text = "REEMBOLSO";
            this.Btn_ayudaReembolso.UseVisualStyleBackColor = true;
            this.Btn_ayudaReembolso.Click += new System.EventHandler(this.Btn_ayudaReembolso_Click);
            // 
            // Btn_ayudaServicio
            // 
            this.Btn_ayudaServicio.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.Btn_ayudaServicio.Location = new System.Drawing.Point(89, 114);
            this.Btn_ayudaServicio.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ayudaServicio.Name = "Btn_ayudaServicio";
            this.Btn_ayudaServicio.Size = new System.Drawing.Size(105, 62);
            this.Btn_ayudaServicio.TabIndex = 444;
            this.Btn_ayudaServicio.Text = "SERVICIO AL CLIENTE";
            this.Btn_ayudaServicio.UseVisualStyleBackColor = true;
            this.Btn_ayudaServicio.Click += new System.EventHandler(this.Btn_ayudaServicio_Click);
            // 
            // frm_ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 556);
            this.Controls.Add(this.Lbl_reembolso);
            this.Controls.Add(this.txt_asunto);
            this.Controls.Add(this.Lbl_mensaje);
            this.Controls.Add(this.Btn_enviar);
            this.Controls.Add(this.txt_mensaje);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.Lbl_asunto);
            this.Controls.Add(this.Lbl_correo);
            this.Controls.Add(this.Lbl_p3);
            this.Controls.Add(this.Lbl_p1);
            this.Controls.Add(this.Lbl_r3);
            this.Controls.Add(this.Lbl_r2);
            this.Controls.Add(this.Lbl_r1);
            this.Controls.Add(this.Lbl_p2);
            this.Controls.Add(this.Lbl_servicio2);
            this.Controls.Add(this.Lbl_servicio1);
            this.Controls.Add(this.Btn_FAQ);
            this.Controls.Add(this.Panel_abajo);
            this.Controls.Add(this.Lbl_servicioEmail);
            this.Controls.Add(this.Panel_arriba);
            this.Controls.Add(this.Btn_ayudaSalir);
            this.Controls.Add(this.Lbl_titulo);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Btn_ayudaPregunta);
            this.Controls.Add(this.Btn_ayudaReembolso);
            this.Controls.Add(this.Btn_ayudaServicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ayuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AYUDA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_ayuda_FormClosing);
            this.Load += new System.EventHandler(this.frm_ayuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            this.Panel_arriba.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_reembolso;
        private System.Windows.Forms.TextBox txt_asunto;
        private System.Windows.Forms.Label Lbl_mensaje;
        private System.Windows.Forms.Button Btn_enviar;
        private System.Windows.Forms.TextBox txt_mensaje;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label Lbl_asunto;
        private System.Windows.Forms.Label Lbl_correo;
        private System.Windows.Forms.Label Lbl_p3;
        private System.Windows.Forms.Label Lbl_p1;
        private System.Windows.Forms.Label Lbl_r3;
        private System.Windows.Forms.Label Lbl_r2;
        private System.Windows.Forms.Label Lbl_r1;
        private System.Windows.Forms.Label Lbl_p2;
        private System.Windows.Forms.Label Lbl_servicio2;
        private System.Windows.Forms.Label Lbl_servicio1;
        private System.Windows.Forms.Button Btn_FAQ;
        private System.Windows.Forms.Panel Panel_abajo;
        private System.Windows.Forms.PictureBox Pic_logo;
        private System.Windows.Forms.Label Lbl_servicioEmail;
        private System.Windows.Forms.Panel Panel_arriba;
        private System.Windows.Forms.Button Btn_ayudaSalir;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Button Btn_ayudaPregunta;
        private System.Windows.Forms.Button Btn_ayudaReembolso;
        private System.Windows.Forms.Button Btn_ayudaServicio;
    }
}