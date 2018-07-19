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
    public partial class frm_correo : Form
    {
        public frm_correo()
        {
            InitializeComponent();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_enviar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_correoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
