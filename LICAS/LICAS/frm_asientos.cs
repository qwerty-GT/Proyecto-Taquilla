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
    public partial class frm_asientos : Form
    {
        public frm_boletos boletos;
        private Button[] botones;
        private int[] cantidad;
        private double[] sub;
        private string funcion;
        private int cnt;
        public frm_asientos(frm_boletos boletos, string funcion, int[] cantidad, double[] sub)
        {
            InitializeComponent();
            this.boletos = boletos;
            //JOSUE ARREGLO DE LOS BOTONES DE LOS ASIENTOS
            botones = new Button[] { A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, E1, E2, E3, E4, E5, E6, E7, E8, E9, E10, F1, F2, F3, F4, F5, F6, F7, F8, F9, F10 };
            this.cantidad = cantidad;
            this.funcion = funcion;
            this.sub = sub;
            //JOSUE CONTADOR DE ASIENTOS RESTANTES POR SELECCIONAR
            button3.Text = String.Format("{0}", cantidad[2] + cantidad[1] + cantidad[0] - cnt);
            asientosReservados();
        }

        //SE CARGAN LOS ASIENTOS QUE YA ESTAN RESERVADOS EN LA BASE DE DATOS
        private void asientosReservados()
        {
            int numero;
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT ASIENTO_RESERVACION FROM RESERVACION WHERE ID_FUNCION = {0};",funcion);
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    numero = reader.GetInt32(0);
                    botones[numero].BackColor = Color.Red;
                    botones[numero].Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
            }
            conexion.Close();
        }

        //JOSUE si se selecciona un asiento no reservado, se cambia de color a verde
        private void cambioColor(Button boton)
        {
            if ((boton.BackColor == Color.LightGray) && (cantidad[2] + cantidad[1] + cantidad[0] > cnt))
            {
                boton.BackColor = Color.LawnGreen;
                cnt++;
            }
            else if (boton.BackColor == Color.LawnGreen)
            {
                boton.BackColor = Color.LightGray;
                cnt--;
            }
            button3.Text = String.Format("{0}", cantidad[2] + cantidad[1] + cantidad[0] - cnt);
        }

        private void frm_asientos_Load(object sender, EventArgs e)
        {

        }

        private void frm_asientos_FormClosing(object sender, FormClosingEventArgs e)
        {
            boletos.Show();
        }

        private void Btn_seleccionSalir_Click(object sender, EventArgs e)
        {
            boletos.Show();
            this.Close();
        }

        //JOSUE NUMERO DE ASIENTOS SELECCIONADOS
        private int[] numeroAsientos()
        {
            int[] numero = new int[cnt];
            int j = 0;
            for (int i = 0; i < 60 && j < cnt; i++)
            {
                if (botones[i].BackColor == Color.LawnGreen)
                {
                    numero[j++] = i;
                }
            }
            return numero;
        }

        //JOSUE VALIDACION DE ASIENTOS POR SELECCIONAR
        private void button1_Click(object sender, EventArgs e)
        {
            if (cantidad[2] + cantidad[1] + cantidad[0] == cnt)
            {
                frm_factura nuevo = new frm_factura(this, funcion, cantidad, sub, numeroAsientos());
                nuevo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(string.Format("NUMERO DE ASIENTOS QUE FALTAN SELECCIONAR: {0}", cantidad[2] + cantidad[1] + cantidad[0] - cnt), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Pic1_Click(object sender, EventArgs e)
        {

        }

        private void A1_Click(object sender, EventArgs e)
        {
            cambioColor(botones[0]);
        }

        private void A2_Click(object sender, EventArgs e)
        {
            cambioColor(botones[1]);
        }

        private void A3_Click(object sender, EventArgs e)
        {
            cambioColor(botones[2]);
        }

        private void A4_Click(object sender, EventArgs e)
        {
            cambioColor(botones[3]);
        }

        private void A5_Click(object sender, EventArgs e)
        {
            cambioColor(botones[4]);
        }

        private void A6_Click(object sender, EventArgs e)
        {
            cambioColor(botones[5]);
        }

        private void A7_Click(object sender, EventArgs e)
        {
            cambioColor(botones[6]);
        }

        private void A8_Click(object sender, EventArgs e)
        {
            cambioColor(botones[7]);
        }

        private void A9_Click(object sender, EventArgs e)
        {
            cambioColor(botones[8]);
        }

        private void A10_Click(object sender, EventArgs e)
        {
            cambioColor(botones[9]);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            cambioColor(botones[10]);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            cambioColor(botones[11]);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            cambioColor(botones[12]);
        }

        private void B4_Click(object sender, EventArgs e)
        {
            cambioColor(botones[13]);
        }

        private void B5_Click(object sender, EventArgs e)
        {
            cambioColor(botones[14]);
        }

        private void B6_Click(object sender, EventArgs e)
        {
            cambioColor(botones[15]);
        }

        private void B7_Click(object sender, EventArgs e)
        {
            cambioColor(botones[16]);
        }

        private void B8_Click(object sender, EventArgs e)
        {
            cambioColor(botones[17]);
        }

        private void B9_Click(object sender, EventArgs e)
        {
            cambioColor(botones[18]);
        }

        private void B10_Click(object sender, EventArgs e)
        {
            cambioColor(botones[19]);
        }

        private void C1_Click(object sender, EventArgs e)
        {
            cambioColor(botones[20]);
        }

        private void C2_Click(object sender, EventArgs e)
        {
            cambioColor(botones[21]);
        }

        private void C3_Click(object sender, EventArgs e)
        {
            cambioColor(botones[22]);
        }

        private void C4_Click(object sender, EventArgs e)
        {
            cambioColor(botones[23]);
        }

        private void C5_Click(object sender, EventArgs e)
        {
            cambioColor(botones[24]);
        }

        private void C6_Click(object sender, EventArgs e)
        {
            cambioColor(botones[25]);
        }

        private void C7_Click(object sender, EventArgs e)
        {
            cambioColor(botones[26]);
        }

        private void C8_Click(object sender, EventArgs e)
        {
            cambioColor(botones[27]);
        }

        private void C9_Click(object sender, EventArgs e)
        {
            cambioColor(botones[28]);
        }

        private void C10_Click(object sender, EventArgs e)
        {
            cambioColor(botones[29]);
        }

        private void D1_Click(object sender, EventArgs e)
        {
            cambioColor(botones[30]);
        }

        private void D2_Click(object sender, EventArgs e)
        {
            cambioColor(botones[31]);
        }

        private void D3_Click(object sender, EventArgs e)
        {
            cambioColor(botones[32]);
        }

        private void D4_Click(object sender, EventArgs e)
        {
            cambioColor(botones[33]);
        }

        private void D5_Click(object sender, EventArgs e)
        {
            cambioColor(botones[34]);
        }

        private void D6_Click(object sender, EventArgs e)
        {
            cambioColor(botones[35]);
        }

        private void D7_Click(object sender, EventArgs e)
        {
            cambioColor(botones[36]);
        }

        private void D8_Click(object sender, EventArgs e)
        {
            cambioColor(botones[37]);
        }

        private void D9_Click(object sender, EventArgs e)
        {
            cambioColor(botones[38]);
        }

        private void D10_Click(object sender, EventArgs e)
        {
            cambioColor(botones[39]);
        }

        private void E1_Click(object sender, EventArgs e)
        {
            cambioColor(botones[40]);
        }

        private void E2_Click(object sender, EventArgs e)
        {
            cambioColor(botones[41]);
        }

        private void E3_Click(object sender, EventArgs e)
        {
            cambioColor(botones[42]);
        }

        private void E4_Click(object sender, EventArgs e)
        {
            cambioColor(botones[43]);
        }

        private void E5_Click(object sender, EventArgs e)
        {
            cambioColor(botones[44]);
        }

        private void E6_Click(object sender, EventArgs e)
        {
            cambioColor(botones[45]);
        }

        private void E7_Click(object sender, EventArgs e)
        {
            cambioColor(botones[46]);
        }

        private void E8_Click(object sender, EventArgs e)
        {
            cambioColor(botones[47]);
        }

        private void E9_Click(object sender, EventArgs e)
        {
            cambioColor(botones[48]);
        }

        private void E10_Click(object sender, EventArgs e)
        {
            cambioColor(botones[49]);
        }

        private void F1_Click(object sender, EventArgs e)
        {
            cambioColor(botones[50]);
        }

        private void F2_Click(object sender, EventArgs e)
        {
            cambioColor(botones[51]);
        }

        private void F3_Click(object sender, EventArgs e)
        {
            cambioColor(botones[52]);
        }

        private void F4_Click(object sender, EventArgs e)
        {
            cambioColor(botones[53]);
        }

        private void F5_Click(object sender, EventArgs e)
        {
            cambioColor(botones[54]);
        }

        private void F6_Click(object sender, EventArgs e)
        {
            cambioColor(botones[55]);
        }

        private void F7_Click(object sender, EventArgs e)
        {
            cambioColor(botones[56]);
        }

        private void F8_Click(object sender, EventArgs e)
        {
            cambioColor(botones[57]);
        }

        private void F9_Click(object sender, EventArgs e)
        {
            cambioColor(botones[58]);
        }

        private void F10_Click(object sender, EventArgs e)
        {
            cambioColor(botones[59]);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_asientoMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}
