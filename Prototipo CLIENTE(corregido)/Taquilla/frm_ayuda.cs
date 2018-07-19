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
    public partial class frm_ayuda : Form
    {
        public frm_ayuda()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_reserva_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ayudaSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
