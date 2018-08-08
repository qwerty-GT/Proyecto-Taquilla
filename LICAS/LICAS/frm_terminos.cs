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
namespace LICAS
{
    public partial class frm_terminos : Form
    {
        private frm_factura factura;

        public frm_terminos(frm_factura frm_factura)
        {
            InitializeComponent();
            this.factura = frm_factura;
        }

        private void Btn_seleccionSalir_Click(object sender, EventArgs e)
        {
            factura.Show();
            Close();
        }

        private void Panel_abajo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel_arriba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_terminos_FormClosing(object sender, FormClosingEventArgs e)
        {
            factura.Show();
        }

        private void frm_terminos_Load(object sender, EventArgs e)
        {

        }

        private void Pic_logo_Click(object sender, EventArgs e)
        {

        }
    }
}
