using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ADMIN
{
    public partial class frm_ayuda : Form
    {
        public frm_ayuda()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Gbp1(object sender, EventArgs e)
        {

        }

        private void Gbp2_Enter(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            //Preceso para abrir PDF dentro del proyecto
            Process proceso = new Process();
            proceso.StartInfo.FileName = @"ManualUsuarioAdmin.pdf";
            proceso.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ayuda_Load(object sender, EventArgs e)
        {

        }

        private void btn_Manual_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_ayudaManual_Click(object sender, EventArgs e)
        {
            //Preceso para abrir PDF dentro del proyecto
            Process proceso2 = new Process();
            proceso2.StartInfo.FileName = @"ManualTecnico.pdf";
            proceso2.Start();
        }
    }
}
