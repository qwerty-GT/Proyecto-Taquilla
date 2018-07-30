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

namespace ADMIN
{
    public partial class frm_funciones : Form
    {
        frm_main menu;
        public frm_funciones(frm_main anterior, bool[] privilegios)
        {
            InitializeComponent();
            menu = anterior;
            actualizar();
            peli();
            subt();
            idiom();
            sala();
            hora();
            formato();
            Btn_formatoAceptar.Enabled = privilegios[0];
            dataGridView2.Visible = privilegios[1];
            button10.Enabled = privilegios[2];
            button2.Visible = privilegios[3];
        }

        private void peli()
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT NOMBRE_PELICULA FROM PELICULA;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                comboBox8.Items.Clear();
                comboBox2.Items.Clear();
                while (reader.Read())
                {
                    comboBox8.Items.Add(reader.GetString(0));
                    comboBox2.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
            }
            conexion.Close();
        }

        private void subt()
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT DESCRIPCION_SUBTITULADO FROM SUBTITULADO;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                comboBox1.Items.Clear();
                comboBox10.Items.Clear();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString(0));
                    comboBox10.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
            }
            conexion.Close();
        }

        private void idiom()
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT DESCRIPCION_IDIOMA FROM IDIOMA;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                comboBox3.Items.Clear();
                comboBox9.Items.Clear();
                while (reader.Read())
                {
                    comboBox3.Items.Add(reader.GetString(0));
                    comboBox9.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
            }
            conexion.Close();
        }

        private void hora()
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT DESCRIPCION_HORARIO FROM HORARIO;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                comboBox4.Items.Clear();
                comboBox6.Items.Clear();
                while (reader.Read())
                {
                    comboBox4.Items.Add(reader.GetString(0));
                    comboBox6.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
            }
            conexion.Close();
        }

        private void sala()
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT ID_SALA FROM SALA;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                comboBox7.Items.Clear();
                comboBox5.Items.Clear();
                while (reader.Read())
                {
                    comboBox7.Items.Add(reader.GetString(0));
                    comboBox5.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
            }
            conexion.Close();
        }

        private void formato()
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT DESCRIPCION_FORMATO FROM FORMATO;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                comboBox11.Items.Clear();
                comboBox12.Items.Clear();
                while (reader.Read())
                {
                    comboBox11.Items.Add(reader.GetString(0));
                    comboBox12.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
            }
            conexion.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void frm_funciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_formatoAceptar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox3.Text != "" && comboBox8.Text != "" && comboBox4.Text != "" && comboBox7.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("INSERT INTO FUNCION VALUES (NULL, (SELECT ID_PELICULA FROM PELICULA WHERE NOMBRE_PELICULA = '{0}'), '{1}', (SELECT ID_SUBTITULADO FROM SUBTITULADO WHERE DESCRIPCION_SUBTITULADO = '{2}'), (SELECT ID_IDIOMA FROM IDIOMA WHERE DESCRIPCION_IDIOMA = '{3}'), (SELECT ID_HORARIO FROM HORARIO WHERE DESCRIPCION_HORARIO = '{4}'), {5}, (SELECT ID_FORMATO FROM FORMATO WHERE DESCRIPCION_FORMATO = '{6}')); ", comboBox8.Text, dateTimePicker1.Text, comboBox1.Text, comboBox3.Text, comboBox4.Text, comboBox7.Text, comboBox11.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                    dateTimePicker1.Value = DateTime.Now;
                    comboBox1.SelectedIndex = -1;
                    comboBox3.SelectedIndex = -1;
                    comboBox4.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox7.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox8.Focus();
                    MessageBox.Show("GUARDADO!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conexion.Close();
            }
            else
                MessageBox.Show("COMPLETE TODOS LOS CAMPOS!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void actualizar()
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT F.ID_FUNCION, P.NOMBRE_PELICULA, F.FECHA_FUNCION, S.DESCRIPCION_SUBTITULADO, I.DESCRIPCION_IDIOMA, H.DESCRIPCION_HORARIO, F.ID_SALA, FR.DESCRIPCION_FORMATO FROM FUNCION F, PELICULA P, SUBTITULADO S, IDIOMA I, HORARIO H, FORMATO FR WHERE F.ID_PELICULA = P.ID_PELICULA AND F.ID_SUBTITULADO = S.ID_SUBTITULADO AND F.ID_IDIOMA = I.ID_IDIOMA AND F.ID_HORARIO = H.ID_HORARIO AND F.ID_FORMATO = FR.ID_FORMATO;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("SELECT F.ID_FUNCION, P.NOMBRE_PELICULA, F.FECHA_FUNCION, S.DESCRIPCION_SUBTITULADO, I.DESCRIPCION_IDIOMA, H.DESCRIPCION_HORARIO, F.ID_SALA, FR.DESCRIPCION_FORMATO FROM FUNCION F, PELICULA P, SUBTITULADO S, IDIOMA I, HORARIO H, FORMATO FR WHERE F.ID_PELICULA = P.ID_PELICULA AND F.ID_SUBTITULADO = S.ID_SUBTITULADO AND F.ID_IDIOMA = I.ID_IDIOMA AND F.ID_HORARIO = H.ID_HORARIO AND F.ID_FORMATO = FR.ID_FORMATO AND ID_FUNCION = {0}", textBox4.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        dataGridView2.Rows.Clear();
                        dataGridView2.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                        textBox4.Text = "";
                        textBox3.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("FUNCION NO ENCONTRADA!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    textBox4.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conexion.Close();
            }
            else
            {
                MessageBox.Show("ESCRIBA UN ID FUNCION!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            if (textBox3.Enabled)
                textBox3.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("DELETE FROM FUNCION WHERE ID_FUNCION = {0}", textBox4.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    int ban = cmd.ExecuteNonQuery();
                    if (ban == 1)
                    {
                        MessageBox.Show("FUNCION ELIMINADA!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        actualizar();
                    }
                    else
                        MessageBox.Show("FUNCION NO ENCONTRADA!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox4.Text = "";
                    textBox3.Text = "";
                    textBox4.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conexion.Close();
            }
            else
            {
                MessageBox.Show("ESCRIBA UN ID FUNCION!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("SELECT F.ID_FUNCION, P.NOMBRE_PELICULA, F.FECHA_FUNCION, S.DESCRIPCION_SUBTITULADO, I.DESCRIPCION_IDIOMA, H.DESCRIPCION_HORARIO, F.ID_SALA, FR.DESCRIPCION_FORMATO FROM FUNCION F, PELICULA P, SUBTITULADO S, IDIOMA I, HORARIO H, FORMATO FR WHERE F.ID_PELICULA = P.ID_PELICULA AND F.ID_SUBTITULADO = S.ID_SUBTITULADO AND F.ID_IDIOMA = I.ID_IDIOMA AND F.ID_HORARIO = H.ID_HORARIO AND F.ID_FORMATO = FR.ID_FORMATO AND ID_FUNCION = '{0}'", textBox3.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        dateTimePicker2.Enabled = true;
                        comboBox2.Enabled = true;
                        comboBox10.Enabled = true;
                        comboBox9.Enabled = true;
                        comboBox6.Enabled = true;
                        comboBox5.Enabled = true;
                        comboBox12.Enabled = true;
                        textBox3.Enabled = false;
                        button10.Enabled = false;
                        button2.Enabled = false;
                        button7.Enabled = true;
                        button6.Enabled = true;
                        comboBox2.SelectedIndex = comboBox2.FindString(reader.GetString(1));
                        dateTimePicker2.Value = reader.GetDate(2);
                        comboBox10.SelectedIndex = comboBox10.FindString(reader.GetString(3));
                        comboBox9.SelectedIndex = comboBox9.FindString(reader.GetString(4));
                        comboBox6.SelectedIndex = comboBox6.FindString(reader.GetString(5));
                        comboBox5.SelectedIndex = comboBox5.FindString(reader.GetString(6));
                        comboBox12.SelectedIndex = comboBox12.FindString(reader.GetString(7));
                    }
                    else
                    {
                        MessageBox.Show("FUNCION NO ENCONTRADA!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conexion.Close();
            }
            else
            {
                MessageBox.Show("ESCRIBA UN ID FUNCION!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = false; dateTimePicker2.Value = DateTime.Now;
            textBox3.Enabled = true;
            button10.Enabled = true;
            button2.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = false;
            comboBox2.Enabled = false; comboBox2.SelectedIndex = -1;
            comboBox6.Enabled = false; comboBox6.SelectedIndex = -1;
            comboBox5.Enabled = false; comboBox5.SelectedIndex = -1;
            comboBox10.Enabled = false; comboBox10.SelectedIndex = -1;
            comboBox9.Enabled = false; comboBox9.SelectedIndex = -1;
            comboBox12.Enabled = false; comboBox12.SelectedIndex = -1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && comboBox5.Text != "" && comboBox6.Text != "" && comboBox9.Text != "" && comboBox10.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("UPDATE FUNCION SET ID_PELICULA = (SELECT ID_PELICULA FROM PELICULA WHERE NOMBRE_PELICULA = '{0}'), FECHA_FUNCION = '{1}', ID_SUBTITULADO = (SELECT ID_SUBTITULADO FROM SUBTITULADO WHERE DESCRIPCION_SUBTITULADO = '{2}'), ID_IDIOMA = (SELECT ID_IDIOMA FROM IDIOMA WHERE DESCRIPCION_IDIOMA = '{3}'), ID_HORARIO = (SELECT ID_HORARIO FROM HORARIO WHERE DESCRIPCION_HORARIO = '{4}'), ID_SALA = {5}, ID_FORMATO = (SELECT ID_FORMATO FROM FORMATO WHERE DESCRIPCION_FORMATO = '{6}') WHERE ID_FUNCION = {7}", comboBox2.Text, dateTimePicker2.Text, comboBox10.Text, comboBox9.Text, comboBox6.Text, comboBox5.Text, comboBox12.Text, textBox3.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ACTUALIZADO!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dateTimePicker2.Enabled = false; dateTimePicker2.Value = DateTime.Now;
                    textBox3.Enabled = true; textBox3.Text = "";
                    textBox4.Text = "";
                    comboBox2.SelectedIndex = -1; comboBox2.Enabled = false;
                    comboBox5.SelectedIndex = -1; comboBox5.Enabled = false;
                    comboBox6.SelectedIndex = -1; comboBox6.Enabled = false;
                    comboBox10.Enabled = false; comboBox10.SelectedIndex = -1;
                    comboBox12.Enabled = false; comboBox12.SelectedIndex = -1;
                    comboBox9.Enabled = false; comboBox9.SelectedIndex = -1;
                    button10.Enabled = true;
                    button2.Enabled = true;
                    button7.Enabled = false;
                    button6.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conexion.Close();
            }
            else
                MessageBox.Show("COMPLETE TODOS LOS CAMPOS!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
