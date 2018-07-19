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
    public partial class frm_asiento : Form
    {
        public frm_asiento()
        {
            InitializeComponent();
          
        }

        private void btn_Pagar_Click(object sender, EventArgs e)
        {
            frm_facturaB facturar = new frm_facturaB();
            facturar.Show();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
