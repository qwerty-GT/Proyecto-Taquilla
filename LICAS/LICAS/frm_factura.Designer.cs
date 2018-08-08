namespace LICAS
{
    partial class frm_factura
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_factura));
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_seleccionEnviar = new System.Windows.Forms.Button();
            this.Lbl8 = new System.Windows.Forms.Label();
            this.cmb_pago = new System.Windows.Forms.ComboBox();
            this.Lbl6 = new System.Windows.Forms.Label();
            this.Lbl5 = new System.Windows.Forms.Label();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            this.Panel_abajo = new System.Windows.Forms.Panel();
            this.Panel_arriba = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Lbl_correo = new System.Windows.Forms.Label();
            this.Btn_seleccionSalir = new System.Windows.Forms.Button();
            this.txt_tarjeta = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_nombreR = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cb_terminos = new System.Windows.Forms.CheckBox();
            this.Lbl_terminos = new System.Windows.Forms.Label();
            this.Pic_pago = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            this.Panel_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_pago)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(345, 103);
            this.txt_correo.MaxLength = 35;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(170, 20);
            this.txt_correo.TabIndex = 197;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(32, 437);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(625, 17);
            this.label9.TabIndex = 191;
            this.label9.Text = "*Cuando de click en SIGUENTE su transacción sera procesada y no habrá marcha atrá" +
    "s.";
            // 
            // Btn_seleccionEnviar
            // 
            this.Btn_seleccionEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_seleccionEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_seleccionEnviar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_seleccionEnviar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_seleccionEnviar.Image")));
            this.Btn_seleccionEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_seleccionEnviar.Location = new System.Drawing.Point(543, 468);
            this.Btn_seleccionEnviar.Name = "Btn_seleccionEnviar";
            this.Btn_seleccionEnviar.Size = new System.Drawing.Size(129, 41);
            this.Btn_seleccionEnviar.TabIndex = 189;
            this.Btn_seleccionEnviar.Text = "SIGUIENTE";
            this.Btn_seleccionEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_seleccionEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_seleccionEnviar.UseVisualStyleBackColor = true;
            this.Btn_seleccionEnviar.Click += new System.EventHandler(this.Btn_seleccionEnviar_Click);
            // 
            // Lbl8
            // 
            this.Lbl8.AutoSize = true;
            this.Lbl8.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl8.Location = new System.Drawing.Point(153, 183);
            this.Lbl8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl8.Name = "Lbl8";
            this.Lbl8.Size = new System.Drawing.Size(188, 17);
            this.Lbl8.TabIndex = 187;
            this.Lbl8.Text = "Numeración de la tarjeta:";
            this.Lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_pago
            // 
            this.cmb_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pago.FormattingEnabled = true;
            this.cmb_pago.Location = new System.Drawing.Point(345, 130);
            this.cmb_pago.Name = "cmb_pago";
            this.cmb_pago.Size = new System.Drawing.Size(170, 21);
            this.cmb_pago.TabIndex = 184;
            this.cmb_pago.SelectedIndexChanged += new System.EventHandler(this.cmb_pago_SelectedIndexChanged);
            // 
            // Lbl6
            // 
            this.Lbl6.AutoSize = true;
            this.Lbl6.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl6.Location = new System.Drawing.Point(214, 130);
            this.Lbl6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl6.Name = "Lbl6";
            this.Lbl6.Size = new System.Drawing.Size(127, 17);
            this.Lbl6.TabIndex = 183;
            this.Lbl6.Text = "Método de pago:";
            this.Lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl5
            // 
            this.Lbl5.AutoSize = true;
            this.Lbl5.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl5.Location = new System.Drawing.Point(416, 242);
            this.Lbl5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(23, 25);
            this.Lbl5.TabIndex = 182;
            this.Lbl5.Text = "/";
            this.Lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl4.Location = new System.Drawing.Point(167, 244);
            this.Lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(173, 17);
            this.Lbl4.TabIndex = 179;
            this.Lbl4.Text = "Fecha de  vencimiento:\r\n";
            this.Lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.Location = new System.Drawing.Point(140, 209);
            this.Lbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(200, 34);
            this.Lbl3.TabIndex = 177;
            this.Lbl3.Text = "Código de seguridad de la \r\n                                   tarjeta:\r\n";
            this.Lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(240, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 18);
            this.label1.TabIndex = 172;
            this.label1.Text = "COMPRA DE BOLETOS";
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
            this.Panel_abajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_abajo.Location = new System.Drawing.Point(0, 515);
            this.Panel_abajo.Name = "Panel_abajo";
            this.Panel_abajo.Size = new System.Drawing.Size(684, 41);
            this.Panel_abajo.TabIndex = 171;
            // 
            // Panel_arriba
            // 
            this.Panel_arriba.BackColor = System.Drawing.Color.Yellow;
            this.Panel_arriba.Controls.Add(this.lbl_time);
            this.Panel_arriba.Controls.Add(this.Pic_logo);
            this.Panel_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_arriba.Location = new System.Drawing.Point(0, 0);
            this.Panel_arriba.Name = "Panel_arriba";
            this.Panel_arriba.Size = new System.Drawing.Size(684, 41);
            this.Panel_arriba.TabIndex = 170;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(560, 13);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(47, 18);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "TIME";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 236);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 168;
            // 
            // Lbl_correo
            // 
            this.Lbl_correo.AutoSize = true;
            this.Lbl_correo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_correo.Location = new System.Drawing.Point(192, 103);
            this.Lbl_correo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_correo.Name = "Lbl_correo";
            this.Lbl_correo.Size = new System.Drawing.Size(148, 17);
            this.Lbl_correo.TabIndex = 166;
            this.Lbl_correo.Text = "Correo electrónico:";
            // 
            // Btn_seleccionSalir
            // 
            this.Btn_seleccionSalir.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_seleccionSalir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_seleccionSalir.Image")));
            this.Btn_seleccionSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_seleccionSalir.Location = new System.Drawing.Point(444, 468);
            this.Btn_seleccionSalir.Name = "Btn_seleccionSalir";
            this.Btn_seleccionSalir.Size = new System.Drawing.Size(93, 41);
            this.Btn_seleccionSalir.TabIndex = 502;
            this.Btn_seleccionSalir.Text = "SALIR";
            this.Btn_seleccionSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_seleccionSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_seleccionSalir.UseVisualStyleBackColor = true;
            this.Btn_seleccionSalir.Click += new System.EventHandler(this.Btn_seleccionSalir_Click);
            // 
            // txt_tarjeta
            // 
            this.txt_tarjeta.Location = new System.Drawing.Point(345, 183);
            this.txt_tarjeta.MaxLength = 16;
            this.txt_tarjeta.Name = "txt_tarjeta";
            this.txt_tarjeta.Size = new System.Drawing.Size(170, 20);
            this.txt_tarjeta.TabIndex = 505;
            this.txt_tarjeta.TextChanged += new System.EventHandler(this.txt_tarjeta_TextChanged);
            this.txt_tarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tarjeta_KeyPress);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(345, 218);
            this.txt_codigo.MaxLength = 3;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(170, 20);
            this.txt_codigo.TabIndex = 506;
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // cmb_mes
            // 
            this.cmb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mes.FormattingEnabled = true;
            this.cmb_mes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmb_mes.Location = new System.Drawing.Point(345, 244);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(66, 21);
            this.cmb_mes.TabIndex = 507;
            // 
            // cmb_year
            // 
            this.cmb_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmb_year.Location = new System.Drawing.Point(444, 244);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(71, 21);
            this.cmb_year.TabIndex = 508;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(177, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 17);
            this.label2.TabIndex = 509;
            this.label2.Text = "*Tienes 1 minuto para realizar tu compra!";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(345, 156);
            this.txt_nombre.MaxLength = 30;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(170, 20);
            this.txt_nombre.TabIndex = 516;
            // 
            // Lbl_nombreR
            // 
            this.Lbl_nombreR.AutoSize = true;
            this.Lbl_nombreR.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreR.Location = new System.Drawing.Point(129, 156);
            this.Lbl_nombreR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nombreR.Name = "Lbl_nombreR";
            this.Lbl_nombreR.Size = new System.Drawing.Size(211, 17);
            this.Lbl_nombreR.TabIndex = 515;
            this.Lbl_nombreR.Text = "Nombre del tarjetahabiente:\t";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9F);
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(12, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(655, 98);
            this.label3.TabIndex = 517;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Cb_terminos
            // 
            this.Cb_terminos.AutoSize = true;
            this.Cb_terminos.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.Cb_terminos.Location = new System.Drawing.Point(95, 308);
            this.Cb_terminos.Name = "Cb_terminos";
            this.Cb_terminos.Size = new System.Drawing.Size(281, 21);
            this.Cb_terminos.TabIndex = 518;
            this.Cb_terminos.Text = "He leído y estoy de acuerdo con los\t";
            this.Cb_terminos.UseVisualStyleBackColor = true;
            // 
            // Lbl_terminos
            // 
            this.Lbl_terminos.AutoSize = true;
            this.Lbl_terminos.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_terminos.ForeColor = System.Drawing.Color.Navy;
            this.Lbl_terminos.Location = new System.Drawing.Point(372, 310);
            this.Lbl_terminos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_terminos.Name = "Lbl_terminos";
            this.Lbl_terminos.Size = new System.Drawing.Size(225, 16);
            this.Lbl_terminos.TabIndex = 519;
            this.Lbl_terminos.Text = "TERMINOS Y CONDICIONES DE USO";
            this.Lbl_terminos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_terminos.Click += new System.EventHandler(this.Lbl_terminos_Click);
            // 
            // Pic_pago
            // 
            this.Pic_pago.Location = new System.Drawing.Point(521, 130);
            this.Pic_pago.Name = "Pic_pago";
            this.Pic_pago.Size = new System.Drawing.Size(21, 21);
            this.Pic_pago.TabIndex = 520;
            this.Pic_pago.TabStop = false;
            this.Pic_pago.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 521;
            this.label5.Text = "Teléfono:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(345, 271);
            this.txt_telefono.MaxLength = 11;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(170, 20);
            this.txt_telefono.TabIndex = 522;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // frm_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 556);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pic_pago);
            this.Controls.Add(this.Lbl_terminos);
            this.Controls.Add(this.Cb_terminos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.Lbl_nombreR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_year);
            this.Controls.Add(this.cmb_mes);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_tarjeta);
            this.Controls.Add(this.Btn_seleccionSalir);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Btn_seleccionEnviar);
            this.Controls.Add(this.Lbl8);
            this.Controls.Add(this.cmb_pago);
            this.Controls.Add(this.Lbl6);
            this.Controls.Add(this.Lbl5);
            this.Controls.Add(this.Lbl4);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Panel_abajo);
            this.Controls.Add(this.Panel_arriba);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Lbl_correo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_factura_FormClosing);
            this.Load += new System.EventHandler(this.frm_factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            this.Panel_arriba.ResumeLayout(false);
            this.Panel_arriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_pago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_seleccionEnviar;
        private System.Windows.Forms.Label Lbl8;
        private System.Windows.Forms.ComboBox cmb_pago;
        private System.Windows.Forms.Label Lbl6;
        private System.Windows.Forms.Label Lbl5;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pic_logo;
        private System.Windows.Forms.Panel Panel_abajo;
        private System.Windows.Forms.Panel Panel_arriba;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Lbl_correo;
        private System.Windows.Forms.Button Btn_seleccionSalir;
        private System.Windows.Forms.TextBox txt_tarjeta;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.ComboBox cmb_mes;
        private System.Windows.Forms.ComboBox cmb_year;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label Lbl_nombreR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Cb_terminos;
        private System.Windows.Forms.Label Lbl_terminos;
        private System.Windows.Forms.PictureBox Pic_pago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_telefono;
    }
}