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
    public partial class frm_cartelera : Form
    {
        public frm_cartelera()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_asiento elegirA = new frm_asiento();
            elegirA.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
