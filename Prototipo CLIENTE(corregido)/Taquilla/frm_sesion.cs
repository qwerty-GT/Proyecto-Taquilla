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
    public partial class frm_sesion : Form
    {
        public frm_sesion()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frm_registro nuevo = new frm_registro();
            
            nuevo.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_usuario tarjeta = new frm_usuario();
            tarjeta.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_sesionSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_sesionEnviar_Click(object sender, EventArgs e)
        {
            frm_usuario siguiente = new frm_usuario();
            siguiente.Show();
        }
    }
}
