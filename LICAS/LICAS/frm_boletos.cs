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
    public partial class frm_boletos : Form
    {
        private double precio_boleto;
        private int cantidadA = 0;
        private int cantidadN = 0;
        private int cantidad3 = 0;
        private double[] precio_tipo = new double[3];
        private double sub_adulto = 0;
        private double sub_ninio = 0;
        private double sub_3ra = 0;
        private double total = 0;
        private int max_boletos = 5;
        private string funcion;
        public frm_pelicula pelicula;

        public frm_boletos(frm_pelicula pelicula, string funcion, double precio_boleto)
        {
            InitializeComponent();
            this.pelicula = pelicula;
            this.precio_boleto = precio_boleto;
            this.funcion = funcion;
            llenar_datos();
        }

        //JOSUE AXEL TOMA LOS DATOS DE LA BD Y LOS ASIGNA EN VARIABLES LOCALES
        public void llenar_datos()
        {
            int i = 0;
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT PRECIO_TIPO FROM TIPO;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    precio_tipo[i] = precio_boleto * reader.GetDouble(0);
                    if (i == 0)
                        Lbl_precioAdulto.Text = "Q" + Convert.ToString(precio_tipo[i]);
                    else if (i == 1)
                        Lbl_precioNinio.Text = "Q" + Convert.ToString(precio_tipo[i]);
                    else if (i == 2)
                        Lbl_precio3ra.Text = "Q" + Convert.ToString(precio_tipo[i]);
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
            }
            conexion.Close();
        }

        //JOSUE AXEL VALIDACION DE QUE LA SELECCION DE BOLETOS NO SEA 0
        private void Btn_seleccionEnviar_Click(object sender, EventArgs e)
        {
            int[] cantidad = new int[] { cantidadA, cantidadN, cantidad3 };
            double[] sub = new double[] { sub_adulto, sub_ninio, sub_3ra };
            if (cantidadA + cantidadN + cantidad3 == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR AL MENOS UN BOLETO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frm_asientos nuevo = new frm_asientos(this, funcion, cantidad, sub);
                nuevo.Show();
                this.Hide();
            }
        }

        private void frm_boletos_Load(object sender, EventArgs e)
        {

        }

        private void Btn_seleccionSalir_Click(object sender, EventArgs e)
        {
            pelicula.Show();
            this.Close();
        }

        //JOSUE AXEL LAS SIGUIENTES LINEAS DE CODIGO SUMAN O RESTAN UN DIGITO A LA CANTIDAD GLOBAL DE BOLETOS ;
        private void Btn_masAdulto_Click(object sender, EventArgs e)
        {
            if (cantidadA + cantidadN + cantidad3 < max_boletos)
            {
                cantidadA++;
                Lbl_cantidadAdulto.Text = Convert.ToString(cantidadA);
                sub_adulto = sub_adulto + precio_tipo[0];
                Lbl_subAdulto.Text = "Q" + Convert.ToString(sub_adulto);
                total = sub_adulto + sub_ninio + sub_3ra;
                Lbl_total.Text = "Q" + Convert.ToString(total);
            }
        }

        private void Btn_menosAdulto_Click(object sender, EventArgs e)
        {
            if (cantidadA > 0)
            {
                cantidadA--;
                Lbl_cantidadAdulto.Text = Convert.ToString(cantidadA);
                sub_adulto = sub_adulto - precio_tipo[0];
                Lbl_subAdulto.Text = "Q" + Convert.ToString(sub_adulto);
                total = sub_adulto + sub_ninio + sub_3ra;
                Lbl_total.Text = "Q" + Convert.ToString(total);
            }
        }

        private void Btn_masNinio_Click(object sender, EventArgs e)
        {
            if (cantidadA + cantidadN + cantidad3 < max_boletos)
            {
                cantidadN++;
                Lbl_cantidadNinio.Text = Convert.ToString(cantidadN);
                sub_ninio = sub_ninio + precio_tipo[1];
                Lbl_subNinio.Text = "Q" + Convert.ToString(sub_ninio);
                total = sub_adulto + sub_ninio + sub_3ra;
                Lbl_total.Text = "Q" + Convert.ToString(total);
            }
        }

        private void Btn_menosNinio_Click(object sender, EventArgs e)
        {
            if (cantidadN > 0)
            {
                cantidadN--;
                Lbl_cantidadNinio.Text = Convert.ToString(cantidadN);
                sub_ninio = sub_ninio - precio_tipo[1];
                Lbl_subNinio.Text = "Q" + Convert.ToString(sub_ninio);
                total = sub_adulto + sub_ninio + sub_3ra;
                Lbl_total.Text = "Q" + Convert.ToString(total);
            }
        }

        private void Btn_mas3ra_Click(object sender, EventArgs e)
        {
            if (cantidadA + cantidadN + cantidad3 < max_boletos)
            {
                cantidad3++;
                Lbl_cantidad3ra.Text = Convert.ToString(cantidad3);
                sub_3ra = sub_3ra + precio_tipo[1];
                Lbl_sub3ra.Text = "Q" + Convert.ToString(sub_3ra);
                total = sub_adulto + sub_ninio + sub_3ra;
                Lbl_total.Text = "Q" + Convert.ToString(total);
            }
        }

        private void Btn_menos3ra_Click(object sender, EventArgs e)
        {
            if (cantidad3 > 0)
            {
                cantidad3--;
                Lbl_cantidad3ra.Text = Convert.ToString(cantidad3);
                sub_3ra = sub_3ra - precio_tipo[1];
                Lbl_sub3ra.Text = "Q" + Convert.ToString(sub_3ra);
                total = sub_adulto + sub_ninio + sub_3ra;
                Lbl_total.Text = "Q" + Convert.ToString(total);
            }
        }

        private void frm_boletos_FormClosing(object sender, FormClosingEventArgs e)
        {
            pelicula.Show();
        }

        private void Btn_seleccionSalir_Click_1(object sender, EventArgs e)
        {
            pelicula.Show();
            this.Close();
        }

        private void Panel_arriba_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
