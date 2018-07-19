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
    public partial class frm_estrenos : Form
    {
        public frm_estrenos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_peli1 pelicula1 = new frm_peli1();
            
            pelicula1.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frm_peli2 pelicula2 = new frm_peli2();
            pelicula2.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frm_peli3 pelicula3 = new frm_peli3();
            pelicula3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm_peli4 pelicula4 = new frm_peli4();
            pelicula4.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frm_peli5 pelicula5 = new frm_peli5();
            pelicula5.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frm_peli6 pelicula6 = new frm_peli6();
            pelicula6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_estrenosSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
