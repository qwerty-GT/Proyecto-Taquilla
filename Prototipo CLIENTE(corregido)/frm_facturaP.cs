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
    public partial class frm_facturaP : Form
    {
        public frm_facturaP()
        {
            InitializeComponent();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            frm_correo facturas = new frm_correo();
            facturas.Show();
        }
    }
}
