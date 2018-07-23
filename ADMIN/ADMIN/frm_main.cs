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
    public partial class frm_main : Form
    {
        frm_logIn principal;
        public frm_main(frm_logIn anterior)
        {
            InitializeComponent();
            principal = anterior;
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_reportes nuevo = new frm_reportes();
            nuevo.Show();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_peliculas nuevo = new frm_peliculas(this);
            nuevo.Show();
            this.Hide();
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_salas nuevo = new frm_salas(this);
            nuevo.Show();
            this.Hide();
        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_generos nuevo = new frm_generos(this);
            nuevo.Show();
            this.Hide();
        }
        
        private void idiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_idiomas nuevo = new frm_idiomas(this);
            nuevo.Show();
            this.Hide();
        }

        private void proyecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_funciones nuevo = new frm_funciones(this);
            nuevo.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_usuarios nuevo = new frm_usuarios(this);
            nuevo.Show();
            this.Hide();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ayuda nuevo = new frm_ayuda();
            nuevo.Show();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            principal.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
        }

        private void formatoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_formatos nuevo = new frm_formatos(this);
            nuevo.Show();
            this.Hide();
        }

        private void sUBTITULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_subtitulado nuevo = new frm_subtitulado(this);
            nuevo.Show();
            this.Hide();
        }

        private void hORARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_horarios nuevo = new frm_horarios(this);
            nuevo.Show();
            this.Hide();
        }

        private void cINESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cines nuevo = new frm_cines(this);
            nuevo.Show();
            this.Hide();
        }
    }
}
