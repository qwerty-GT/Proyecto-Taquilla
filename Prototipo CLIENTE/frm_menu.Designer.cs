namespace Taquilla
{
    partial class frm_menu
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
            this.Btn1 = new System.Windows.Forms.Button();
            this.Cbo2 = new System.Windows.Forms.ComboBox();
            this.Cbo1 = new System.Windows.Forms.ComboBox();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clubLicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proximosEstrenosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(561, 8);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(90, 42);
            this.Btn1.TabIndex = 12;
            this.Btn1.Text = "Ver Cartelera";
            this.Btn1.UseVisualStyleBackColor = true;
            // 
            // Cbo2
            // 
            this.Cbo2.FormattingEnabled = true;
            this.Cbo2.Location = new System.Drawing.Point(405, 22);
            this.Cbo2.Name = "Cbo2";
            this.Cbo2.Size = new System.Drawing.Size(121, 21);
            this.Cbo2.TabIndex = 11;
            // 
            // Cbo1
            // 
            this.Cbo1.FormattingEnabled = true;
            this.Cbo1.Location = new System.Drawing.Point(197, 22);
            this.Cbo1.Name = "Cbo1";
            this.Cbo1.Size = new System.Drawing.Size(121, 21);
            this.Cbo1.TabIndex = 10;
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(357, 22);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(42, 17);
            this.Lbl2.TabIndex = 9;
            this.Lbl2.Text = "Cine";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(132, 22);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(59, 17);
            this.Lbl1.TabIndex = 8;
            this.Lbl1.Text = "Ciudad";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(50, 50);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 50);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clubLicasToolStripMenuItem,
            this.proximosEstrenosToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salidaToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 46);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // clubLicasToolStripMenuItem
            // 
            this.clubLicasToolStripMenuItem.Name = "clubLicasToolStripMenuItem";
            this.clubLicasToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.clubLicasToolStripMenuItem.Text = "Club Licas";
            this.clubLicasToolStripMenuItem.Click += new System.EventHandler(this.clubLicasToolStripMenuItem_Click);
            // 
            // proximosEstrenosToolStripMenuItem
            // 
            this.proximosEstrenosToolStripMenuItem.Name = "proximosEstrenosToolStripMenuItem";
            this.proximosEstrenosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.proximosEstrenosToolStripMenuItem.Text = "Proximos Estrenos";
            this.proximosEstrenosToolStripMenuItem.Click += new System.EventHandler(this.proximosEstrenosToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // salidaToolStripMenuItem
            // 
            this.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            this.salidaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.salidaToolStripMenuItem.Text = "Salir";
            this.salidaToolStripMenuItem.Click += new System.EventHandler(this.salidaToolStripMenuItem_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Taquilla.Properties.Resources.fondoMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 536);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Cbo2);
            this.Controls.Add(this.Cbo1);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frm_menu";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.ComboBox Cbo2;
        private System.Windows.Forms.ComboBox Cbo1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clubLicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proximosEstrenosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem;
    }
}

