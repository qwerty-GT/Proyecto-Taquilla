using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
//AXEL, JAVIER, ESTUARDO, IVAN, JOSUE DISEÑO GENERAL DEL FORM
namespace LICAS
{
    public partial class frm_pelicula : Form
    {

        private string link = "";
        public frm_cartelera cartelera;
        private string funcion;
        private double precio_formato;
        private double precio_experiencia;
        
        public frm_pelicula(frm_cartelera cartelera, string funcion)
        {
            InitializeComponent();
            this.cartelera = cartelera;
            this.funcion = funcion;
            llenar_datos();
        }

        public void llenar_datos()
        {
            //JAVIER, ESTUARDO, IVAN CONSULTA A LA BASE DE DATOS TODOS LOS DATOS RELACIONADOS CON UNA PELICULA Y LOS ALMACENA EN VARIABLES DENTRO DEL PROGRAMA
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT PEL.NOMBRE_PELICULA, GEN.DESCRIPCION_GENERO, CLA.NOMBRE_CLASIFICACION, HOR.DESCRIPCION_HORARIO, FUN.FECHA_FUNCION, CIN.NOMBRE_CINE, FR.DESCRIPCION_FORMATO, EXP.DESCRIPCION_EXPERIENCIA, IDI.DESCRIPCION_IDIOMA, SUB.DESCRIPCION_SUBTITULADO, PEL.DURACION_PELICULA, PEL.SINOPSIS_PELICULA, PEL.VIDEO_PELICULA, PEL.IMAGEN_PELICULA, FR.PRECIO_FORMATO, EXP.PRECIO_EXPERIENCIA, CLA.DESCRIPCION_CLASIFICACION FROM PELICULA PEL, GENERO GEN, CLASIFICACION CLA, SALA SAL,FUNCION FUN, CINE CIN, HORARIO HOR, EXPERIENCIA EXP, FORMATO FR, IDIOMA IDI, SUBTITULADO SUB, DEPARTAMENTO DEP WHERE PEL.ID_GENERO = GEN.ID_GENERO AND PEL.ID_CLASIFICACION = CLA.ID_CLASIFICACION AND FUN.ID_PELICULA = PEL.ID_PELICULA AND FUN.ID_SALA = SAL.ID_SALA AND SAL.ID_CINE = CIN.ID_CINE AND CIN.ID_DEPARTAMENTO = DEP. ID_DEPARTAMENTO AND FUN.ID_HORARIO = HOR.ID_HORARIO AND SAL.ID_EXPERIENCIA = EXP.ID_EXPERIENCIA AND FUN.ID_FORMATO = FR.ID_FORMATO AND FUN.ID_IDIOMA = IDI.ID_IDIOMA AND FUN.ID_SUBTITULADO = SUB.ID_SUBTITULADO AND FUN.ID_FUNCION = {0}", funcion);
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    label7.Text = reader.GetString(0);
                    label1.Text = reader.GetString(1);
                    label2.Text = reader.GetString(2);
                    label3.Text = reader.GetString(3);
                    label4.Text = reader.GetString(4);
                    label10.Text = reader.GetString(5);
                    label5.Text = reader.GetString(6);
                    label11.Text = reader.GetString(7);
                    label6.Text = reader.GetString(8);
                    label8.Text = reader.GetString(9);
                    label9.Text = reader.GetString(10);
                    Txt_Sinopsis.Text = reader.GetString(11);
                    link = reader.GetString(12);
                    Pic_imagen.ImageLocation = reader.GetString(13);
                    precio_formato = reader.GetDouble(14);
                    precio_experiencia = reader.GetDouble(15);
                    toolTip1.SetToolTip(label2, reader.GetString(16));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexion.Close();
        }

        private void Btn_misionSalir_Click(object sender, EventArgs e)
        {
            cartelera.Show();
            this.Hide();
        }

        private void Btn_Trailer_Click(object sender, EventArgs e)
        {
        }

        private void Btn_comprar1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_comprar_Click(object sender, EventArgs e)
        {
            frm_boletos nuevo = new frm_boletos(this, funcion, precio_formato * precio_experiencia);
            nuevo.Show();
            this.Hide();
        }

        private void frm_pelicula_FormClosing(object sender, FormClosingEventArgs e)
        {
            cartelera.Show();
        }

        private void frm_pelicula_Load(object sender, EventArgs e)
        {
        }

        private void Pic_imagen_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Panel_arriba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_seleccionSalir_Click(object sender, EventArgs e)
        {
            cartelera.Show();
            this.Close();
        }

        //JAVIER, ESTUARDO, IVAN VALIDACION DE QUE EL URL DEL VIDEO DE TRAILER NO ESTE VACIO, Y SI LO ESTA MUESTRA UNA EXCEPCION
        private void Btn_Trailer_Click_1(object sender, EventArgs e)
        {
            if (link != "")
            {
                try
                {
                    System.Diagnostics.Process.Start(link);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("URL VIDEO NULL!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
