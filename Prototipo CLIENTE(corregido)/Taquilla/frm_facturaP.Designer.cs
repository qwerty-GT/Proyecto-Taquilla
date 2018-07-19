namespace Taquilla
{
    partial class frm_facturaP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_facturaP));
            this.Lbl_facturaProductosNumero = new System.Windows.Forms.Label();
            this.Lbl_facturaProductosCombo = new System.Windows.Forms.Label();
            this.Lbl_facturaProductosCantidad = new System.Windows.Forms.Label();
            this.Lbl_facturaProductosPrecio = new System.Windows.Forms.Label();
            this.Lbl_facturaProductosPago = new System.Windows.Forms.Label();
            this.Lbl_facturaProductosEfectuvi = new System.Windows.Forms.Label();
            this.Lbl_facturaProductosCambio = new System.Windows.Forms.Label();
            this.Lbl_facturaProductosTotal = new System.Windows.Forms.Label();
            this.Txt_facturaProductosNumero = new System.Windows.Forms.TextBox();
            this.Txt_facturaProductosCantidad = new System.Windows.Forms.TextBox();
            this.Txt_facturaProductosPrecio = new System.Windows.Forms.TextBox();
            this.Txt_facturaProductosEfectivo = new System.Windows.Forms.TextBox();
            this.Txt_facturaProductosCambio = new System.Windows.Forms.TextBox();
            this.Txt_facturaProductosTotal = new System.Windows.Forms.TextBox();
            this.Cbo_pago = new System.Windows.Forms.ComboBox();
            this.Cbo_combo = new System.Windows.Forms.ComboBox();
            this.Dgv_facturaProductosLista = new System.Windows.Forms.DataGridView();
            this.Btn_facturaProductoAgregar = new System.Windows.Forms.Button();
            this.Btn_facturaProductoEmail = new System.Windows.Forms.Button();
            this.Btn_facturaProductoSalir = new System.Windows.Forms.Button();
            this.Panel_abajo = new System.Windows.Forms.Panel();
            this.Panel_arriba = new System.Windows.Forms.Panel();
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_facturaProductosLista)).BeginInit();
            this.Panel_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_facturaProductosNumero
            // 
            this.Lbl_facturaProductosNumero.AutoSize = true;
            this.Lbl_facturaProductosNumero.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_facturaProductosNumero.Location = new System.Drawing.Point(23, 72);
            this.Lbl_facturaProductosNumero.Name = "Lbl_facturaProductosNumero";
            this.Lbl_facturaProductosNumero.Size = new System.Drawing.Size(88, 17);
            this.Lbl_facturaProductosNumero.TabIndex = 0;
            this.Lbl_facturaProductosNumero.Text = "No. Factura";
            // 
            // Lbl_facturaProductosCombo
            // 
            this.Lbl_facturaProductosCombo.AutoSize = true;
            this.Lbl_facturaProductosCombo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_facturaProductosCombo.Location = new System.Drawing.Point(23, 131);
            this.Lbl_facturaProductosCombo.Name = "Lbl_facturaProductosCombo";
            this.Lbl_facturaProductosCombo.Size = new System.Drawing.Size(60, 17);
            this.Lbl_facturaProductosCombo.TabIndex = 1;
            this.Lbl_facturaProductosCombo.Text = "Combo";
            // 
            // Lbl_facturaProductosCantidad
            // 
            this.Lbl_facturaProductosCantidad.AutoSize = true;
            this.Lbl_facturaProductosCantidad.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_facturaProductosCantidad.Location = new System.Drawing.Point(270, 114);
            this.Lbl_facturaProductosCantidad.Name = "Lbl_facturaProductosCantidad";
            this.Lbl_facturaProductosCantidad.Size = new System.Drawing.Size(89, 34);
            this.Lbl_facturaProductosCantidad.TabIndex = 2;
            this.Lbl_facturaProductosCantidad.Text = "Cantidad \r\nde Combos";
            // 
            // Lbl_facturaProductosPrecio
            // 
            this.Lbl_facturaProductosPrecio.AutoSize = true;
            this.Lbl_facturaProductosPrecio.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_facturaProductosPrecio.Location = new System.Drawing.Point(491, 131);
            this.Lbl_facturaProductosPrecio.Name = "Lbl_facturaProductosPrecio";
            this.Lbl_facturaProductosPrecio.Size = new System.Drawing.Size(54, 17);
            this.Lbl_facturaProductosPrecio.TabIndex = 3;
            this.Lbl_facturaProductosPrecio.Text = "Precio";
            // 
            // Lbl_facturaProductosPago
            // 
            this.Lbl_facturaProductosPago.AutoSize = true;
            this.Lbl_facturaProductosPago.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_facturaProductosPago.Location = new System.Drawing.Point(23, 177);
            this.Lbl_facturaProductosPago.Name = "Lbl_facturaProductosPago";
            this.Lbl_facturaProductosPago.Size = new System.Drawing.Size(65, 34);
            this.Lbl_facturaProductosPago.TabIndex = 5;
            this.Lbl_facturaProductosPago.Text = "   Tipo \r\nde Pago";
            // 
            // Lbl_facturaProductosEfectuvi
            // 
            this.Lbl_facturaProductosEfectuvi.AutoSize = true;
            this.Lbl_facturaProductosEfectuvi.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_facturaProductosEfectuvi.Location = new System.Drawing.Point(270, 174);
            this.Lbl_facturaProductosEfectuvi.Name = "Lbl_facturaProductosEfectuvi";
            this.Lbl_facturaProductosEfectuvi.Size = new System.Drawing.Size(72, 34);
            this.Lbl_facturaProductosEfectuvi.TabIndex = 6;
            this.Lbl_facturaProductosEfectuvi.Text = "Efectivo \r\nRecibido";
            // 
            // Lbl_facturaProductosCambio
            // 
            this.Lbl_facturaProductosCambio.AutoSize = true;
            this.Lbl_facturaProductosCambio.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_facturaProductosCambio.Location = new System.Drawing.Point(481, 191);
            this.Lbl_facturaProductosCambio.Name = "Lbl_facturaProductosCambio";
            this.Lbl_facturaProductosCambio.Size = new System.Drawing.Size(64, 17);
            this.Lbl_facturaProductosCambio.TabIndex = 7;
            this.Lbl_facturaProductosCambio.Text = "Cambio";
            // 
            // Lbl_facturaProductosTotal
            // 
            this.Lbl_facturaProductosTotal.AutoSize = true;
            this.Lbl_facturaProductosTotal.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_facturaProductosTotal.Location = new System.Drawing.Point(44, 430);
            this.Lbl_facturaProductosTotal.Name = "Lbl_facturaProductosTotal";
            this.Lbl_facturaProductosTotal.Size = new System.Drawing.Size(44, 17);
            this.Lbl_facturaProductosTotal.TabIndex = 8;
            this.Lbl_facturaProductosTotal.Text = "Total";
            // 
            // Txt_facturaProductosNumero
            // 
            this.Txt_facturaProductosNumero.Location = new System.Drawing.Point(118, 72);
            this.Txt_facturaProductosNumero.Name = "Txt_facturaProductosNumero";
            this.Txt_facturaProductosNumero.Size = new System.Drawing.Size(100, 20);
            this.Txt_facturaProductosNumero.TabIndex = 9;
            // 
            // Txt_facturaProductosCantidad
            // 
            this.Txt_facturaProductosCantidad.Location = new System.Drawing.Point(365, 128);
            this.Txt_facturaProductosCantidad.Name = "Txt_facturaProductosCantidad";
            this.Txt_facturaProductosCantidad.Size = new System.Drawing.Size(100, 20);
            this.Txt_facturaProductosCantidad.TabIndex = 10;
            // 
            // Txt_facturaProductosPrecio
            // 
            this.Txt_facturaProductosPrecio.Location = new System.Drawing.Point(551, 128);
            this.Txt_facturaProductosPrecio.Name = "Txt_facturaProductosPrecio";
            this.Txt_facturaProductosPrecio.Size = new System.Drawing.Size(100, 20);
            this.Txt_facturaProductosPrecio.TabIndex = 11;
            // 
            // Txt_facturaProductosEfectivo
            // 
            this.Txt_facturaProductosEfectivo.Location = new System.Drawing.Point(365, 191);
            this.Txt_facturaProductosEfectivo.Name = "Txt_facturaProductosEfectivo";
            this.Txt_facturaProductosEfectivo.Size = new System.Drawing.Size(100, 20);
            this.Txt_facturaProductosEfectivo.TabIndex = 12;
            // 
            // Txt_facturaProductosCambio
            // 
            this.Txt_facturaProductosCambio.Location = new System.Drawing.Point(551, 191);
            this.Txt_facturaProductosCambio.Name = "Txt_facturaProductosCambio";
            this.Txt_facturaProductosCambio.Size = new System.Drawing.Size(100, 20);
            this.Txt_facturaProductosCambio.TabIndex = 13;
            // 
            // Txt_facturaProductosTotal
            // 
            this.Txt_facturaProductosTotal.Location = new System.Drawing.Point(139, 430);
            this.Txt_facturaProductosTotal.Name = "Txt_facturaProductosTotal";
            this.Txt_facturaProductosTotal.Size = new System.Drawing.Size(100, 20);
            this.Txt_facturaProductosTotal.TabIndex = 14;
            // 
            // Cbo_pago
            // 
            this.Cbo_pago.FormattingEnabled = true;
            this.Cbo_pago.Location = new System.Drawing.Point(118, 189);
            this.Cbo_pago.Name = "Cbo_pago";
            this.Cbo_pago.Size = new System.Drawing.Size(121, 21);
            this.Cbo_pago.TabIndex = 15;
            // 
            // Cbo_combo
            // 
            this.Cbo_combo.FormattingEnabled = true;
            this.Cbo_combo.Location = new System.Drawing.Point(118, 127);
            this.Cbo_combo.Name = "Cbo_combo";
            this.Cbo_combo.Size = new System.Drawing.Size(121, 21);
            this.Cbo_combo.TabIndex = 16;
            // 
            // Dgv_facturaProductosLista
            // 
            this.Dgv_facturaProductosLista.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Dgv_facturaProductosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_facturaProductosLista.Location = new System.Drawing.Point(35, 248);
            this.Dgv_facturaProductosLista.Name = "Dgv_facturaProductosLista";
            this.Dgv_facturaProductosLista.Size = new System.Drawing.Size(625, 150);
            this.Dgv_facturaProductosLista.TabIndex = 17;
            // 
            // Btn_facturaProductoAgregar
            // 
            this.Btn_facturaProductoAgregar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_facturaProductoAgregar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_facturaProductoAgregar.Image")));
            this.Btn_facturaProductoAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_facturaProductoAgregar.Location = new System.Drawing.Point(314, 416);
            this.Btn_facturaProductoAgregar.Name = "Btn_facturaProductoAgregar";
            this.Btn_facturaProductoAgregar.Size = new System.Drawing.Size(121, 44);
            this.Btn_facturaProductoAgregar.TabIndex = 18;
            this.Btn_facturaProductoAgregar.Text = "AGREGAR";
            this.Btn_facturaProductoAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_facturaProductoAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_facturaProductoAgregar.UseVisualStyleBackColor = true;
            // 
            // Btn_facturaProductoEmail
            // 
            this.Btn_facturaProductoEmail.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.Btn_facturaProductoEmail.Image = ((System.Drawing.Image)(resources.GetObject("Btn_facturaProductoEmail.Image")));
            this.Btn_facturaProductoEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_facturaProductoEmail.Location = new System.Drawing.Point(441, 416);
            this.Btn_facturaProductoEmail.Name = "Btn_facturaProductoEmail";
            this.Btn_facturaProductoEmail.Size = new System.Drawing.Size(132, 44);
            this.Btn_facturaProductoEmail.TabIndex = 19;
            this.Btn_facturaProductoEmail.Text = "FACTURA AL CORREO";
            this.Btn_facturaProductoEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_facturaProductoEmail.UseVisualStyleBackColor = true;
            this.Btn_facturaProductoEmail.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn_facturaProductoSalir
            // 
            this.Btn_facturaProductoSalir.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_facturaProductoSalir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_facturaProductoSalir.Image")));
            this.Btn_facturaProductoSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_facturaProductoSalir.Location = new System.Drawing.Point(579, 416);
            this.Btn_facturaProductoSalir.Name = "Btn_facturaProductoSalir";
            this.Btn_facturaProductoSalir.Size = new System.Drawing.Size(93, 44);
            this.Btn_facturaProductoSalir.TabIndex = 48;
            this.Btn_facturaProductoSalir.Text = "SALIR";
            this.Btn_facturaProductoSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_facturaProductoSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_facturaProductoSalir.UseVisualStyleBackColor = true;
            this.Btn_facturaProductoSalir.Click += new System.EventHandler(this.Btn_facturaProductoSalir_Click);
            // 
            // Panel_abajo
            // 
            this.Panel_abajo.BackColor = System.Drawing.Color.Yellow;
            this.Panel_abajo.Location = new System.Drawing.Point(2, 466);
            this.Panel_abajo.Name = "Panel_abajo";
            this.Panel_abajo.Size = new System.Drawing.Size(681, 41);
            this.Panel_abajo.TabIndex = 51;
            // 
            // Panel_arriba
            // 
            this.Panel_arriba.BackColor = System.Drawing.Color.Yellow;
            this.Panel_arriba.Controls.Add(this.Pic_logo);
            this.Panel_arriba.Location = new System.Drawing.Point(2, 4);
            this.Panel_arriba.Name = "Panel_arriba";
            this.Panel_arriba.Size = new System.Drawing.Size(681, 41);
            this.Panel_arriba.TabIndex = 50;
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
            // frm_facturaP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 487);
            this.Controls.Add(this.Panel_abajo);
            this.Controls.Add(this.Panel_arriba);
            this.Controls.Add(this.Btn_facturaProductoSalir);
            this.Controls.Add(this.Btn_facturaProductoEmail);
            this.Controls.Add(this.Btn_facturaProductoAgregar);
            this.Controls.Add(this.Dgv_facturaProductosLista);
            this.Controls.Add(this.Cbo_combo);
            this.Controls.Add(this.Cbo_pago);
            this.Controls.Add(this.Txt_facturaProductosTotal);
            this.Controls.Add(this.Txt_facturaProductosCambio);
            this.Controls.Add(this.Txt_facturaProductosEfectivo);
            this.Controls.Add(this.Txt_facturaProductosPrecio);
            this.Controls.Add(this.Txt_facturaProductosCantidad);
            this.Controls.Add(this.Txt_facturaProductosNumero);
            this.Controls.Add(this.Lbl_facturaProductosTotal);
            this.Controls.Add(this.Lbl_facturaProductosCambio);
            this.Controls.Add(this.Lbl_facturaProductosEfectuvi);
            this.Controls.Add(this.Lbl_facturaProductosPago);
            this.Controls.Add(this.Lbl_facturaProductosPrecio);
            this.Controls.Add(this.Lbl_facturaProductosCantidad);
            this.Controls.Add(this.Lbl_facturaProductosCombo);
            this.Controls.Add(this.Lbl_facturaProductosNumero);
            this.Name = "frm_facturaP";
            this.Text = "FACTURA PRODUCTOS";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_facturaProductosLista)).EndInit();
            this.Panel_arriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_facturaProductosNumero;
        private System.Windows.Forms.Label Lbl_facturaProductosCombo;
        private System.Windows.Forms.Label Lbl_facturaProductosCantidad;
        private System.Windows.Forms.Label Lbl_facturaProductosPrecio;
        private System.Windows.Forms.Label Lbl_facturaProductosPago;
        private System.Windows.Forms.Label Lbl_facturaProductosEfectuvi;
        private System.Windows.Forms.Label Lbl_facturaProductosCambio;
        private System.Windows.Forms.Label Lbl_facturaProductosTotal;
        private System.Windows.Forms.TextBox Txt_facturaProductosNumero;
        private System.Windows.Forms.TextBox Txt_facturaProductosCantidad;
        private System.Windows.Forms.TextBox Txt_facturaProductosPrecio;
        private System.Windows.Forms.TextBox Txt_facturaProductosEfectivo;
        private System.Windows.Forms.TextBox Txt_facturaProductosCambio;
        private System.Windows.Forms.TextBox Txt_facturaProductosTotal;
        private System.Windows.Forms.ComboBox Cbo_pago;
        private System.Windows.Forms.ComboBox Cbo_combo;
        private System.Windows.Forms.DataGridView Dgv_facturaProductosLista;
        private System.Windows.Forms.Button Btn_facturaProductoAgregar;
        private System.Windows.Forms.Button Btn_facturaProductoEmail;
        private System.Windows.Forms.Button Btn_facturaProductoSalir;
        private System.Windows.Forms.Panel Panel_abajo;
        private System.Windows.Forms.Panel Panel_arriba;
        private System.Windows.Forms.PictureBox Pic_logo;
    }
}