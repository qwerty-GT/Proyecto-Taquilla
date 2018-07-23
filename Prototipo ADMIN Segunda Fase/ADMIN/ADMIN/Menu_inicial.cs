using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN
{
    public partial class Menu_inicial : Form
    {
        public Menu_inicial()
        {
            InitializeComponent();
        }

        private void Menu_inicial_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void soporteAlUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda pAyuda = new Ayuda();
            pAyuda.MdiParent = this;
            pAyuda.Show();
        }

        private void peliculasTaquillerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes pReportes = new Reportes();
            pReportes.MdiParent = this;
            pReportes.Show();
        }

        private void costosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartelera pCartelera = new Cartelera();
            pCartelera.MdiParent = this;
            pCartelera.Show();
        }
    }
}
