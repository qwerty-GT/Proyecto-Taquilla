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
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.Lbl5 = new System.Windows.Forms.Label();
            this.Lbl6 = new System.Windows.Forms.Label();
            this.Lbl7 = new System.Windows.Forms.Label();
            this.Lbl8 = new System.Windows.Forms.Label();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt3 = new System.Windows.Forms.TextBox();
            this.Txt4 = new System.Windows.Forms.TextBox();
            this.Txt5 = new System.Windows.Forms.TextBox();
            this.Txt6 = new System.Windows.Forms.TextBox();
            this.Cbo_pago = new System.Windows.Forms.ComboBox();
            this.Cbo_combo = new System.Windows.Forms.ComboBox();
            this.Dgv_datos = new System.Windows.Forms.DataGridView();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_facturar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(31, 24);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(88, 17);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "No. Factura";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(32, 90);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(60, 17);
            this.Lbl2.TabIndex = 1;
            this.Lbl2.Text = "Combo";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.Location = new System.Drawing.Point(279, 73);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(89, 34);
            this.Lbl3.TabIndex = 2;
            this.Lbl3.Text = "Cantidad \r\nde Combos";
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl4.Location = new System.Drawing.Point(500, 90);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(54, 17);
            this.Lbl4.TabIndex = 3;
            this.Lbl4.Text = "Precio";
            // 
            // Lbl5
            // 
            this.Lbl5.AutoSize = true;
            this.Lbl5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl5.Location = new System.Drawing.Point(32, 159);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(65, 34);
            this.Lbl5.TabIndex = 5;
            this.Lbl5.Text = "   Tipo \r\nde Pago";
            // 
            // Lbl6
            // 
            this.Lbl6.AutoSize = true;
            this.Lbl6.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl6.Location = new System.Drawing.Point(279, 156);
            this.Lbl6.Name = "Lbl6";
            this.Lbl6.Size = new System.Drawing.Size(72, 34);
            this.Lbl6.TabIndex = 6;
            this.Lbl6.Text = "Efectivo \r\nRecibido";
            // 
            // Lbl7
            // 
            this.Lbl7.AutoSize = true;
            this.Lbl7.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl7.Location = new System.Drawing.Point(490, 173);
            this.Lbl7.Name = "Lbl7";
            this.Lbl7.Size = new System.Drawing.Size(64, 17);
            this.Lbl7.TabIndex = 7;
            this.Lbl7.Text = "Cambio";
            // 
            // Lbl8
            // 
            this.Lbl8.AutoSize = true;
            this.Lbl8.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl8.Location = new System.Drawing.Point(32, 245);
            this.Lbl8.Name = "Lbl8";
            this.Lbl8.Size = new System.Drawing.Size(44, 17);
            this.Lbl8.TabIndex = 8;
            this.Lbl8.Text = "Total";
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(126, 24);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 20);
            this.Txt1.TabIndex = 9;
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(374, 87);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(100, 20);
            this.Txt2.TabIndex = 10;
            // 
            // Txt3
            // 
            this.Txt3.Location = new System.Drawing.Point(560, 87);
            this.Txt3.Name = "Txt3";
            this.Txt3.Size = new System.Drawing.Size(100, 20);
            this.Txt3.TabIndex = 11;
            // 
            // Txt4
            // 
            this.Txt4.Location = new System.Drawing.Point(374, 173);
            this.Txt4.Name = "Txt4";
            this.Txt4.Size = new System.Drawing.Size(100, 20);
            this.Txt4.TabIndex = 12;
            // 
            // Txt5
            // 
            this.Txt5.Location = new System.Drawing.Point(560, 173);
            this.Txt5.Name = "Txt5";
            this.Txt5.Size = new System.Drawing.Size(100, 20);
            this.Txt5.TabIndex = 13;
            // 
            // Txt6
            // 
            this.Txt6.Location = new System.Drawing.Point(127, 242);
            this.Txt6.Name = "Txt6";
            this.Txt6.Size = new System.Drawing.Size(100, 20);
            this.Txt6.TabIndex = 14;
            // 
            // Cbo_pago
            // 
            this.Cbo_pago.FormattingEnabled = true;
            this.Cbo_pago.Location = new System.Drawing.Point(127, 171);
            this.Cbo_pago.Name = "Cbo_pago";
            this.Cbo_pago.Size = new System.Drawing.Size(121, 21);
            this.Cbo_pago.TabIndex = 15;
            // 
            // Cbo_combo
            // 
            this.Cbo_combo.FormattingEnabled = true;
            this.Cbo_combo.Location = new System.Drawing.Point(127, 86);
            this.Cbo_combo.Name = "Cbo_combo";
            this.Cbo_combo.Size = new System.Drawing.Size(121, 21);
            this.Cbo_combo.TabIndex = 16;
            // 
            // Dgv_datos
            // 
            this.Dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_datos.Location = new System.Drawing.Point(34, 288);
            this.Dgv_datos.Name = "Dgv_datos";
            this.Dgv_datos.Size = new System.Drawing.Size(625, 150);
            this.Dgv_datos.TabIndex = 17;
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregar.Location = new System.Drawing.Point(379, 465);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(75, 35);
            this.Btn_agregar.TabIndex = 18;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.UseVisualStyleBackColor = true;
            // 
            // Btn_facturar
            // 
            this.Btn_facturar.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.Btn_facturar.Location = new System.Drawing.Point(490, 460);
            this.Btn_facturar.Name = "Btn_facturar";
            this.Btn_facturar.Size = new System.Drawing.Size(78, 44);
            this.Btn_facturar.TabIndex = 19;
            this.Btn_facturar.Text = "Factura al Correo";
            this.Btn_facturar.UseVisualStyleBackColor = true;
            this.Btn_facturar.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Location = new System.Drawing.Point(597, 476);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(75, 23);
            this.Btn_salir.TabIndex = 20;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // frm_facturaP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_facturar);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.Dgv_datos);
            this.Controls.Add(this.Cbo_combo);
            this.Controls.Add(this.Cbo_pago);
            this.Controls.Add(this.Txt6);
            this.Controls.Add(this.Txt5);
            this.Controls.Add(this.Txt4);
            this.Controls.Add(this.Txt3);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.Lbl8);
            this.Controls.Add(this.Lbl7);
            this.Controls.Add(this.Lbl6);
            this.Controls.Add(this.Lbl5);
            this.Controls.Add(this.Lbl4);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Name = "frm_facturaP";
            this.Text = "frm_facturaP";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.Label Lbl5;
        private System.Windows.Forms.Label Lbl6;
        private System.Windows.Forms.Label Lbl7;
        private System.Windows.Forms.Label Lbl8;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txt3;
        private System.Windows.Forms.TextBox Txt4;
        private System.Windows.Forms.TextBox Txt5;
        private System.Windows.Forms.TextBox Txt6;
        private System.Windows.Forms.ComboBox Cbo_pago;
        private System.Windows.Forms.ComboBox Cbo_combo;
        private System.Windows.Forms.DataGridView Dgv_datos;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_facturar;
        private System.Windows.Forms.Button Btn_salir;
    }
}