using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//AXEL, JAVIER, ESTUARDO, IVAN, JOSUE DISEÑO GENERAL DEL FORM
//ESTUARDO, JAVIER E IVAN DISENIO Y PROGRAMACION DE LOS BOTONES DEL TOOLSTRIP DE EL FORM MENU
namespace LICAS
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ayuda nuevo = new frm_ayuda(this);
            nuevo.Show();
            this.Hide();
        }

        private void carteleraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cartelera nuevo = new frm_cartelera(this);
            nuevo.Show();
            this.Hide();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_estrenos nuevo = new frm_estrenos(this);
            nuevo.Show();
            this.Hide();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
