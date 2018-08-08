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
    public partial class frm_cartelera : Form
    {
        frm_menu menu;
        private frm_boletos frm_boletos;

        public frm_cartelera(frm_menu anterior)
        {
            InitializeComponent();
            menu = anterior;
            datos_experiencia();
            datos_formato();
            depto();
            cine();
            datos_idioma();
            datos_subtitulo();
            //JOSUE ACTUALIZACION DE LAS FUNCIONES DISPONIBLES EN LA BASE DE DATOS
            actualizar("SELECT FUN.ID_FUNCION, PEL.NOMBRE_PELICULA, GEN.DESCRIPCION_GENERO, CLA.DESCRIPCION_CLASIFICACION, HOR.DESCRIPCION_HORARIO, FUN.FECHA_FUNCION, FR.DESCRIPCION_FORMATO, EXP.DESCRIPCION_EXPERIENCIA, IDI.DESCRIPCION_IDIOMA, SUB.DESCRIPCION_SUBTITULADO, CIN.NOMBRE_CINE FROM PELICULA PEL, GENERO GEN, CLASIFICACION CLA, SALA SAL,FUNCION FUN, CINE CIN, HORARIO HOR, EXPERIENCIA EXP, FORMATO FR, IDIOMA IDI, SUBTITULADO SUB, DEPARTAMENTO DEP WHERE PEL.ID_GENERO = GEN.ID_GENERO AND PEL.ID_CLASIFICACION = CLA.ID_CLASIFICACION AND FUN.ID_PELICULA = PEL.ID_PELICULA AND FUN.ID_SALA = SAL.ID_SALA AND SAL.ID_CINE = CIN.ID_CINE AND CIN.ID_DEPARTAMENTO = DEP. ID_DEPARTAMENTO AND FUN.ID_HORARIO = HOR.ID_HORARIO AND SAL.ID_EXPERIENCIA = EXP.ID_EXPERIENCIA AND FUN.ID_FORMATO = FR.ID_FORMATO AND FUN.ID_IDIOMA = IDI.ID_IDIOMA AND FUN.ID_SUBTITULADO = SUB.ID_SUBTITULADO AND FUN.FECHA_FUNCION BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL + 7 DAY);");
        }

        //JOSUE LAS SIGUIENTES LINEAS LLENAN LOS COMBOBOX DEL NOMBRE DE LA FUNCION CON DATOS DE LA BD
        public void cine()
        {
            OdbcConnection conecction = TaquillaDB.getDB();
            try
            {
                string Query = string.Format("SELECT NOMBRE_CINE FROM CINE;");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                Cmb_menuCine.SelectedIndex = -1;
                Cmb_menuCine.Items.Clear();
                while (reader.Read())
                {
                    Cmb_menuCine.Items.Add(reader.GetString(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conecction.Close();
        }

        public void cine_depto()
        {
            OdbcConnection conecction = TaquillaDB.getDB();
            try
            {
                string Query = string.Format("SELECT CIN.NOMBRE_CINE FROM CINE CIN, DEPARTAMENTO DEP WHERE CIN.ID_DEPARTAMENTO = DEP.ID_DEPARTAMENTO AND DEP.NOMBRE_DEPARTAMENTO = '{0}';", Cmb_menuCiudad.Text);
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                Cmb_menuCine.SelectedIndex = -1;
                Cmb_menuCine.Items.Clear();
                while (reader.Read())
                {
                    Cmb_menuCine.Items.Add(reader.GetString(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conecction.Close();
        }

        public void depto()
        {
            OdbcConnection conecction = TaquillaDB.getDB();
            try
            {
                string Query = string.Format("select NOMBRE_DEPARTAMENTO from DEPARTAMENTO");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                Cmb_menuCiudad.Items.Clear();
                while (reader.Read())
                {
                    Cmb_menuCiudad.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conecction.Close();
        }

        private void actualizar(string sql) 
            //JOSUE actualiza las peliculas existentes en el sistema llamandolas una por una
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                dgb_pelicula.Rows.Clear();
                while (reader.Read())
                {
                    dgb_pelicula.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexion.Close();
        }
        public void datos_experiencia() //JOSUE funcion que se encarga de extraer datos de la tabla experiencia
        {
            OdbcConnection conecction = TaquillaDB.getDB();
            try
            {
                string Query = string.Format("select DESCRIPCION_EXPERIENCIA from EXPERIENCIA");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                cmb_experiencia.Items.Clear();
                while (reader.Read())
                {
                    cmb_experiencia.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void datos_idioma()//JOSUE funcion que se encarga de extraer datos de la tabla de idiomas
        {
            OdbcConnection conecction = TaquillaDB.getDB();
            try
            {
                string Query = string.Format("select DESCRIPCION_IDIOMA from IDIOMA");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                Cmb_Idioma.Items.Clear();
                while (reader.Read())
                {
                    Cmb_Idioma.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void datos_subtitulo()//JOSUE funcion que se encarga de extraer datos de la tabla de subtitulado
        {
            OdbcConnection conecction = TaquillaDB.getDB();
            try
            {
                string Query = string.Format("select DESCRIPCION_SUBTITULADO from SUBTITULADO");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                Cmb_Sub.Items.Clear();
                while (reader.Read())
                {
                    Cmb_Sub.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void datos_formato()
        {
            OdbcConnection conecction = TaquillaDB.getDB();
            try
            {
                string Query = string.Format("select DESCRIPCION_FORMATO from FORMATO;");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                cmb_formato.Items.Clear();
                while (reader.Read())
                {
                    cmb_formato.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void filtrado()
        {
            //JOSUE FUNCION QUE SELECICONA LOS FILTROS QUE SE ESTAN APLICANDO EN LOS COMBOBOX
            string sql = string.Format("SELECT FUN.ID_FUNCION, PEL.NOMBRE_PELICULA, GEN.DESCRIPCION_GENERO, CLA.DESCRIPCION_CLASIFICACION, HOR.DESCRIPCION_HORARIO, FUN.FECHA_FUNCION, FR.DESCRIPCION_FORMATO, EXP.DESCRIPCION_EXPERIENCIA, IDI.DESCRIPCION_IDIOMA, SUB.DESCRIPCION_SUBTITULADO, CIN.NOMBRE_CINE FROM PELICULA PEL, GENERO GEN, CLASIFICACION CLA, SALA SAL,FUNCION FUN, CINE CIN, HORARIO HOR, EXPERIENCIA EXP, FORMATO FR, IDIOMA IDI, SUBTITULADO SUB, DEPARTAMENTO DEP WHERE PEL.ID_GENERO = GEN.ID_GENERO AND PEL.ID_CLASIFICACION = CLA.ID_CLASIFICACION AND FUN.ID_PELICULA = PEL.ID_PELICULA AND FUN.ID_SALA = SAL.ID_SALA AND SAL.ID_CINE = CIN.ID_CINE AND CIN.ID_DEPARTAMENTO = DEP. ID_DEPARTAMENTO AND FUN.ID_HORARIO = HOR.ID_HORARIO AND SAL.ID_EXPERIENCIA = EXP.ID_EXPERIENCIA AND FUN.ID_FORMATO = FR.ID_FORMATO AND FUN.ID_IDIOMA = IDI.ID_IDIOMA AND FUN.ID_SUBTITULADO = SUB.ID_SUBTITULADO");
            if (Cmb_menuCiudad.SelectedIndex != -1)
                sql += string.Format(" AND DEP.NOMBRE_DEPARTAMENTO = '{0}'", Cmb_menuCiudad.Text);
            if (Cmb_menuCine.SelectedIndex != -1)
                sql += string.Format(" AND CIN.NOMBRE_CINE = '{0}'", Cmb_menuCine.Text);
            if (cmb_experiencia.SelectedIndex != -1)
                sql += string.Format(" AND EXP.DESCRIPCION_EXPERIENCIA = '{0}'", cmb_experiencia.Text);
            if (cmb_formato.SelectedIndex != -1)
                sql += string.Format(" AND FR.DESCRIPCION_FORMATO = '{0}'", cmb_formato.Text);
            if (Cmb_Idioma.SelectedIndex != -1)
                sql += string.Format(" AND IDI.DESCRIPCION_IDIOMA = '{0}'", Cmb_Idioma.Text);
            if (Cmb_Sub.SelectedIndex != -1)
                sql += string.Format(" AND SUB.DESCRIPCION_SUBTITULADO = '{0}'", Cmb_Sub.Text);
            sql += " AND FUN.FECHA_FUNCION BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL + 7 DAY);";
            actualizar(sql);
        }

        private void frm_cartelera_Load(object sender, EventArgs e)
        {

        }

        private void Btn_ayudaSalir_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void frm_cartelera_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }

        private void Cmb_menuCiudadd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_menuCiudad.SelectedIndex == -1) cine();
            else cine_depto();
            filtrado();
        }

        private void Cmb_menuCIne_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrado();
        }

        private void Cbo_experiencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrado();
        }

        private void Cmb_Idioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrado();
        }

        private void Cbo_formato_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrado();
        }

        private void Cmb_Sub_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrado();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmb_experiencia.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmb_formato.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cmb_menuCiudad.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cmb_menuCine.SelectedIndex = -1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cmb_Idioma.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cmb_Sub.SelectedIndex = -1;
        }

        private void dgb_pelicula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_pelicula nuevo = new frm_pelicula(this, dgb_pelicula.CurrentRow.Cells[0].Value.ToString());
            nuevo.Show();
            Hide();
        }

        private void dgb_pelicula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pic_logo_Click(object sender, EventArgs e)
        {

        }
    }
}
