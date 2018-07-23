namespace ADMIN
{
    partial class Menu_inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_inicial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carteleraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculasTaquillerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteAlUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem,
            this.carteleraToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peliculasTaquillerasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // carteleraToolStripMenuItem
            // 
            this.carteleraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.costosToolStripMenuItem});
            this.carteleraToolStripMenuItem.Name = "carteleraToolStripMenuItem";
            this.carteleraToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.carteleraToolStripMenuItem.Text = "Cartelera";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soporteAlUsuarioToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // peliculasTaquillerasToolStripMenuItem
            // 
            this.peliculasTaquillerasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("peliculasTaquillerasToolStripMenuItem.Image")));
            this.peliculasTaquillerasToolStripMenuItem.Name = "peliculasTaquillerasToolStripMenuItem";
            this.peliculasTaquillerasToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.peliculasTaquillerasToolStripMenuItem.Text = "Detalle de reportes";
            this.peliculasTaquillerasToolStripMenuItem.Click += new System.EventHandler(this.peliculasTaquillerasToolStripMenuItem_Click);
            // 
            // costosToolStripMenuItem
            // 
            this.costosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("costosToolStripMenuItem.Image")));
            this.costosToolStripMenuItem.Name = "costosToolStripMenuItem";
            this.costosToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.costosToolStripMenuItem.Text = "Detalle de cartelera";
            this.costosToolStripMenuItem.Click += new System.EventHandler(this.costosToolStripMenuItem_Click);
            // 
            // soporteAlUsuarioToolStripMenuItem
            // 
            this.soporteAlUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("soporteAlUsuarioToolStripMenuItem.Image")));
            this.soporteAlUsuarioToolStripMenuItem.Name = "soporteAlUsuarioToolStripMenuItem";
            this.soporteAlUsuarioToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.soporteAlUsuarioToolStripMenuItem.Text = "Soporte al usuario";
            this.soporteAlUsuarioToolStripMenuItem.Click += new System.EventHandler(this.soporteAlUsuarioToolStripMenuItem_Click);
            // 
            // Menu_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 548);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_inicial";
            this.Text = "Menu_inicial";
            this.Load += new System.EventHandler(this.Menu_inicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculasTaquillerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carteleraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteAlUsuarioToolStripMenuItem;
    }
}