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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.Btn_menuCartelera = new System.Windows.Forms.Button();
            this.Cmb_menuCIne = new System.Windows.Forms.ComboBox();
            this.Cmb_menuCiudadd = new System.Windows.Forms.ComboBox();
            this.Lbl_menuCine = new System.Windows.Forms.Label();
            this.Lbl_menuCiudad = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Tsm_menuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CubLicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProximosEstrenosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_menuCartelera
            // 
            this.Btn_menuCartelera.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_menuCartelera.Location = new System.Drawing.Point(561, 4);
            this.Btn_menuCartelera.Name = "Btn_menuCartelera";
            this.Btn_menuCartelera.Size = new System.Drawing.Size(111, 42);
            this.Btn_menuCartelera.TabIndex = 12;
            this.Btn_menuCartelera.Text = "VER CARTELERA";
            this.Btn_menuCartelera.UseVisualStyleBackColor = true;
            this.Btn_menuCartelera.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Cmb_menuCIne
            // 
            this.Cmb_menuCIne.FormattingEnabled = true;
            this.Cmb_menuCIne.Location = new System.Drawing.Point(405, 17);
            this.Cmb_menuCIne.Name = "Cmb_menuCIne";
            this.Cmb_menuCIne.Size = new System.Drawing.Size(121, 21);
            this.Cmb_menuCIne.TabIndex = 11;
            // 
            // Cmb_menuCiudadd
            // 
            this.Cmb_menuCiudadd.FormattingEnabled = true;
            this.Cmb_menuCiudadd.Location = new System.Drawing.Point(196, 17);
            this.Cmb_menuCiudadd.Name = "Cmb_menuCiudadd";
            this.Cmb_menuCiudadd.Size = new System.Drawing.Size(121, 21);
            this.Cmb_menuCiudadd.TabIndex = 10;
            this.Cmb_menuCiudadd.SelectedIndexChanged += new System.EventHandler(this.Cbo_ciudad_SelectedIndexChanged);
            // 
            // Lbl_menuCine
            // 
            this.Lbl_menuCine.AutoSize = true;
            this.Lbl_menuCine.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_menuCine.Location = new System.Drawing.Point(357, 17);
            this.Lbl_menuCine.Name = "Lbl_menuCine";
            this.Lbl_menuCine.Size = new System.Drawing.Size(44, 17);
            this.Lbl_menuCine.TabIndex = 9;
            this.Lbl_menuCine.Text = "CINE";
            // 
            // Lbl_menuCiudad
            // 
            this.Lbl_menuCiudad.AutoSize = true;
            this.Lbl_menuCiudad.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_menuCiudad.Location = new System.Drawing.Point(124, 17);
            this.Lbl_menuCiudad.Name = "Lbl_menuCiudad";
            this.Lbl_menuCiudad.Size = new System.Drawing.Size(66, 17);
            this.Lbl_menuCiudad.TabIndex = 8;
            this.Lbl_menuCiudad.Text = "CIUDAD";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_menuMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(50, 50);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 50);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Tsm_menuMenu
            // 
            this.Tsm_menuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CubLicasToolStripMenuItem,
            this.ProximosEstrenosToolStripMenuItem,
            this.ProductosToolStripMenuItem,
            this.AyudaToolStripMenuItem,
            this.SalidaToolStripMenuItem});
            this.Tsm_menuMenu.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tsm_menuMenu.Image = ((System.Drawing.Image)(resources.GetObject("Tsm_menuMenu.Image")));
            this.Tsm_menuMenu.Name = "Tsm_menuMenu";
            this.Tsm_menuMenu.Size = new System.Drawing.Size(87, 46);
            this.Tsm_menuMenu.Text = "MENU";
            // 
            // CubLicasToolStripMenuItem
            // 
            this.CubLicasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CubLicasToolStripMenuItem.Image")));
            this.CubLicasToolStripMenuItem.Name = "CubLicasToolStripMenuItem";
            this.CubLicasToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.CubLicasToolStripMenuItem.Text = "CLUB LICAS";
            this.CubLicasToolStripMenuItem.Click += new System.EventHandler(this.clubLicasToolStripMenuItem_Click);
            // 
            // ProximosEstrenosToolStripMenuItem
            // 
            this.ProximosEstrenosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ProximosEstrenosToolStripMenuItem.Image")));
            this.ProximosEstrenosToolStripMenuItem.Name = "ProximosEstrenosToolStripMenuItem";
            this.ProximosEstrenosToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.ProximosEstrenosToolStripMenuItem.Text = "PROXIMOS ESTRENOS";
            this.ProximosEstrenosToolStripMenuItem.Click += new System.EventHandler(this.proximosEstrenosToolStripMenuItem_Click);
            // 
            // ProductosToolStripMenuItem
            // 
            this.ProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ProductosToolStripMenuItem.Image")));
            this.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem";
            this.ProductosToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.ProductosToolStripMenuItem.Text = "PRODUCTOS";
            this.ProductosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // AyudaToolStripMenuItem
            // 
            this.AyudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AyudaToolStripMenuItem.Image")));
            this.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem";
            this.AyudaToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.AyudaToolStripMenuItem.Text = "AYUDA";
            this.AyudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // SalidaToolStripMenuItem
            // 
            this.SalidaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SalidaToolStripMenuItem.Image")));
            this.SalidaToolStripMenuItem.Name = "SalidaToolStripMenuItem";
            this.SalidaToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.SalidaToolStripMenuItem.Text = "SALIR";
            this.SalidaToolStripMenuItem.Click += new System.EventHandler(this.salidaToolStripMenuItem_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Taquilla.Properties.Resources.photo5077928233810372613;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 487);
            this.Controls.Add(this.Btn_menuCartelera);
            this.Controls.Add(this.Cmb_menuCIne);
            this.Controls.Add(this.Cmb_menuCiudadd);
            this.Controls.Add(this.Lbl_menuCine);
            this.Controls.Add(this.Lbl_menuCiudad);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frm_menu";
            this.Text = "MENU PRINCIPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_menuCartelera;
        private System.Windows.Forms.ComboBox Cmb_menuCIne;
        private System.Windows.Forms.ComboBox Cmb_menuCiudadd;
        private System.Windows.Forms.Label Lbl_menuCine;
        private System.Windows.Forms.Label Lbl_menuCiudad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Tsm_menuMenu;
        private System.Windows.Forms.ToolStripMenuItem CubLicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProximosEstrenosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalidaToolStripMenuItem;
    }
}

