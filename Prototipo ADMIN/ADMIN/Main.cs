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
            Reportes nuevo = new Reportes();
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
            Reportes nuevo = new Reportes();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void carteleraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void salasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Salas nuevo = new Salas();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void generosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Generos nuevo = new Generos();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Usuarios nuevo = new Usuarios();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void ayudaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Ayuda nuevo = new Ayuda();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void peliculasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Peliculas nuevo = new Peliculas();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formatos nuevo = new Formatos();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void idiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Idiomas nuevo = new Idiomas();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void proyecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proyecciones nuevo = new Proyecciones();
            nuevo.MdiParent = this;
            nuevo.Show();
        }
    }
}
