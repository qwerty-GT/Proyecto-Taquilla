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
    public partial class Main : Form
    {
        private int childFormNumber = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        
        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_reportes nuevo = new frm_reportes();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void carteleraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_reportes nuevo = new frm_reportes();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void carteleraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void salasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_salas nuevo = new frm_salas();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void generosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_generos nuevo = new frm_generos();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_usuarios nuevo = new frm_usuarios();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void ayudaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_ayuda nuevo = new frm_ayuda();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void peliculasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_peliculas nuevo = new frm_peliculas();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_formatos nuevo = new frm_formatos();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void idiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_idiomas nuevo = new frm_idiomas();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void proyecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_proyecciones nuevo = new frm_proyecciones();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
