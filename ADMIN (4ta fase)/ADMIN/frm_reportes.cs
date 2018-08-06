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
        public frm_reportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reportesEstadisticas_Click(object sender, EventArgs e)
        {
        }

        private void Btn_reportesFunciones_Click(object sender, EventArgs e)
        {
            frm_reporte_peliculas_taquilleras x = new frm_reporte_peliculas_taquilleras();
            x.Show();
            this.Hide();
        }

        private void Btn_reportesHorarios_Click(object sender, EventArgs e)
        {
            frm_reporte_horarios hor = new frm_reporte_horarios();
            hor.Show();
            this.Hide();
        }

        private void Btn_reportesPeliculas_Click(object sender, EventArgs e)
        {
            frm_reporte_puntos cli = new frm_reporte_puntos();
            cli.Show();
            this.Hide();
        }

        private void btn_reportesEstadisticas_Click_1(object sender, EventArgs e)
        {
            frm_reporte_ganancias rep = new frm_reporte_ganancias();
            rep.Show();
            this.Hide();
        }
    }
}
