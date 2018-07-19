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
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(62, 130);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(82, 34);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "Dirección \r\nE-mail";
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(150, 144);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(163, 20);
            this.Txt1.TabIndex = 1;
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Rockwell", 10.55F);
            this.Btn1.Location = new System.Drawing.Point(274, 235);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(75, 35);
            this.Btn1.TabIndex = 2;
            this.Btn1.Text = "Enviar";
            this.Btn1.UseVisualStyleBackColor = true;
            // 
            // frm_correo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 345);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.Lbl1);
            this.Name = "frm_correo";
            this.Text = "frm_correo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.Button Btn1;
    }
}