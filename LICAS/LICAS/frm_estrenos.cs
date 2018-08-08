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
    public partial class frm_estrenos : Form
    {
        static string link = "";
        private frm_menu menu;

        public frm_estrenos(frm_menu frm_menu)
        {

            this.menu = frm_menu;
            InitializeComponent();
            llenar_datos();
        }

        //JOSUE Y AXEL TOMA LOS DATOS DE LA BD Y LOS AGREGA A UN COMBOBOX
        public void llenar_datos()
        {
            OdbcConnection conecction = TaquillaDB.getDB();
            try
            {
                string Query = string.Format("SELECT NOMBRE_PELICULA FROM PELICULA WHERE ESTADO_PELICULA = '0'");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                Cbo_peliculas.Items.Clear();
                while (reader.Read())
                {
                    Cbo_peliculas.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //JOSUE Y AXEL SI SE SELECCIONA UN ITEM DEL COMBOBOX, SE TOMAN LOS DATOS DE LA BD DE ESE NOMBRE DE ITEM
        private void Cbo_peliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdbcConnection conecction = TaquillaDB.getDB();
            try
            {
                string Query = string.Format("SELECT * FROM PELICULA WHERE NOMBRE_PELICULA = '" + Cbo_peliculas.Text + "'");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);

                OdbcDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    Lbl_Titulo.Text = reader["NOMBRE_PELICULA"].ToString();
                    Txt_Sinopsis.Text = reader["SINOPSIS_PELICULA"].ToString();
                    Lbl_Clasificacion.Text = reader["ID_CLASIFICACION"].ToString();
                    Pic_imagen.ImageLocation = reader["IMAGEN_PELICULA"].ToString();
                    link = reader["VIDEO_PELICULA"].ToString();


                }
                else
                {
                    Lbl_Titulo.Text = "";
                    Txt_Sinopsis.Text = "";
                    Lbl_Clasificacion.Text = "";
                    Pic_imagen = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Btn_Trailer.Show();
            Lbl_tituloSinopsis.Show();
            Txt_Sinopsis.Show();
            try
            {
                string Query = string.Format("SELECT * FROM CLASIFICACION WHERE ID_CLASIFICACION = '" + Lbl_Clasificacion.Text + "'");
                OdbcCommand cmd2 = new OdbcCommand(Query, conecction);
                OdbcDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read() == true)
                {
                    Lbl_Clasificacion.Text = reader2["NOMBRE_CLASIFICACION"].ToString();
                    toolTip1.SetToolTip(Lbl_Clasificacion, reader2.GetString(2));
                }
                else
                {
                    Lbl_Clasificacion.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_estrenos_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Trailer_Click(object sender, EventArgs e)
        {
            //JOSUE Y AXEL CARGA EL LINK DEL TRAILER DE LA PELICULA
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

        private void Btn_misionSalir_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void frm_estrenos_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }
    }
}