using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN
{
    public partial class frm_reportes : Form
    {
        frm_menu menu;
        bool[] privilegios;
        public frm_reportes(frm_menu anterior, bool[] privilegios)
        {//REALIZADOS POR JULIO
            InitializeComponent();
            menu = anterior;
            this.privilegios = privilegios;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void btn_reportesEstadisticas_Click(object sender, EventArgs e)
        {
        }

        private void Btn_reportesFunciones_Click(object sender, EventArgs e)
        {
            frm_reporte_peliculas_taquilleras x = new frm_reporte_peliculas_taquilleras(this, privilegios);
            x.Show();
            this.Hide();
        }

        private void Btn_reportesHorarios_Click(object sender, EventArgs e)
        {
            frm_reporte_horarios hor = new frm_reporte_horarios(this, privilegios);
            hor.Show();
            this.Hide();
        }

        private void Btn_reportesPeliculas_Click(object sender, EventArgs e)
        {
            frm_reporte_puntos cli = new frm_reporte_puntos(this, privilegios);
            cli.Show();
            this.Hide();
        }

        private void btn_reportesEstadisticas_Click_1(object sender, EventArgs e)
        {
            frm_reporte_ganancia rep = new frm_reporte_ganancia(this, privilegios);
            rep.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_reportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }

        private void frm_reportes_Load(object sender, EventArgs e)
        {

        }
    }
}
