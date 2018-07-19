using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taquilla
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void clubLicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sesion inicio = new frm_sesion();
            inicio.MdiParent = this;
            inicio.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_productos elección = new frm_productos();
            elección.MdiParent = this;
            elección.Show();
        }

        private void proximosEstrenosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_estrenos peliculas = new frm_estrenos();
            peliculas.MdiParent = this;
            peliculas.Show();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ayuda ayudaUs = new frm_ayuda();
            ayudaUs.MdiParent = this;
            ayudaUs.Show();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            frm_cartelera carteleraP = new frm_cartelera();
            carteleraP.MdiParent = this;
            carteleraP.Show();
        }
    }
}
