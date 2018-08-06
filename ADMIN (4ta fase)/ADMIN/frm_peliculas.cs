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
using System.IO;
using System.Drawing.Imaging;
using System.Net;

namespace ADMIN
{
    public partial class frm_peliculas : Form
    {
        frm_menu menu;
        public frm_peliculas(frm_menu anterior, bool[] privilegios)
        {
            InitializeComponent();
            menu = anterior;
            clasif();
            generos();
            actualizar();
            Btn_formatoAceptar.Enabled = privilegios[0];
            dataGridView2.Visible = privilegios[1];
            button10.Enabled = privilegios[2];
            button2.Visible = privilegios[3];
        }

        private void clasif()
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT DESCRIPCION_CLASIFICACION FROM CLASIFICACION;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                comboBox3.Items.Clear();
                comboBox5.Items.Clear();
                while (reader.Read())
                {
                    comboBox3.Items.Add(reader.GetString(0));
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

        private void generos()
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT DESCRIPCION_GENERO FROM GENERO;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                comboBox2.Items.Clear();
                comboBox4.Items.Clear();
                while (reader.Read())
                {
                    comboBox4.Items.Add(reader.GetString(0));
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void Btn_formatoAceptar_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox5.Text != "" && textBox7.Text != "" && comboBox1.Text != "" && comboBox3.Text != "" && comboBox4.Text != "" && textBox9.Text != "" && textBox11.Text != "" && pictureBox5.Image != null)
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("INSERT INTO PELICULA VALUES (NULL, '{0}', {1}, '{2}', (SELECT ID_CLASIFICACION FROM CLASIFICACION WHERE DESCRIPCION_CLASIFICACION = '{3}'), (SELECT ID_GENERO FROM GENERO WHERE DESCRIPCION_GENERO = '{4}'), '{5}', '{6}', '{7}');", textBox2.Text, comboBox1.SelectedIndex, textBox5.Text, comboBox3.Text, comboBox4.Text, textBox7.Text, textBox9.Text, textBox11.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        textBox2.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        textBox11.Text = "";
                        comboBox1.SelectedIndex = -1;
                        comboBox3.SelectedIndex = -1;
                        comboBox4.SelectedIndex = -1;
                        pictureBox5.Image = null;
                        textBox2.Focus();
                        MessageBox.Show("GUARDADO!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("SELECT P.ESTADO_PELICULA, P.ID_PELICULA, P.NOMBRE_PELICULA, P.SINOPSIS_PELICULA, C.DESCRIPCION_CLASIFICACION, G.DESCRIPCION_GENERO, P.DURACION_PELICULA FROM PELICULA P, CLASIFICACION C, GENERO G WHERE P.ID_CLASIFICACION = C.ID_CLASIFICACION AND P.ID_GENERO = G.ID_GENERO;");
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        dataGridView2.Rows.Clear();
                        if (reader.GetInt32(0) == 0)
                            dataGridView2.Rows.Add(reader.GetString(1), reader.GetString(2), "ESTRENADA", reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                        else
                            dataGridView2.Rows.Add(reader.GetString(1), reader.GetString(2), "PROXIMO ESTRENO", reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                        textBox4.Text = "";
                        textBox3.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("PELICULA NO ENCONTRADA!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ESCRIBA UN ID PELICULA!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
            }
        }

        private void actualizar()
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT P.ESTADO_PELICULA, P.ID_PELICULA, P.NOMBRE_PELICULA, P.SINOPSIS_PELICULA, C.DESCRIPCION_CLASIFICACION, G.DESCRIPCION_GENERO, P.DURACION_PELICULA FROM PELICULA P, CLASIFICACION C, GENERO G WHERE P.ID_CLASIFICACION = C.ID_CLASIFICACION AND P.ID_GENERO = G.ID_GENERO;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    if(reader.GetInt32(0) == 0)
                        dataGridView2.Rows.Add(reader.GetString(1), reader.GetString(2), "ESTRENADA", reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                    else
                        dataGridView2.Rows.Add(reader.GetString(1), reader.GetString(2), "PROXIMO ESTRENO", reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
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
                    string sql = string.Format("DELETE FROM PELICULA WHERE ID_PELICULA = {0}", textBox4.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    int ban = cmd.ExecuteNonQuery();
                    if (ban == 1)
                    {
                        MessageBox.Show("PELICULA ELIMINADA!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        actualizar();
                    }
                    else
                        MessageBox.Show("PELICULA NO ENCONTRADA!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ESCRIBA UN ID PELICULA!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string sql = string.Format("SELECT P.ID_PELICULA, P.NOMBRE_PELICULA, P.ESTADO_PELICULA, P.SINOPSIS_PELICULA, C.DESCRIPCION_CLASIFICACION, G.DESCRIPCION_GENERO, P.DURACION_PELICULA, P.VIDEO_PELICULA, P.IMAGEN_PELICULA FROM PELICULA P, CLASIFICACION C, GENERO G WHERE P.ID_CLASIFICACION = C.ID_CLASIFICACION AND P.ID_GENERO = G.ID_GENERO AND ID_PELICULA = {0}", textBox3.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        textBox1.Enabled = true;
                        textBox6.Enabled = true;
                        textBox8.Enabled = true;
                        textBox10.Enabled = true;
                        textBox12.Enabled = true;
                        comboBox2.Enabled = true;
                        comboBox6.Enabled = true;
                        comboBox5.Enabled = true;
                        textBox3.Enabled = false;
                        button10.Enabled = false;
                        button2.Enabled = false;
                        button8.Enabled = true;
                        button7.Enabled = true;
                        button6.Enabled = true;
                        button11.Enabled = true;
                        textBox8.Text = reader.GetString(1);
                        comboBox6.SelectedIndex = reader.GetInt32(2);
                        textBox6.Text = reader.GetString(3);
                        comboBox5.SelectedIndex = comboBox5.FindString(reader.GetString(4));
                        comboBox2.SelectedIndex = comboBox2.FindString(reader.GetString(5));
                        textBox1.Text = reader.GetString(6);
                        textBox10.Text = reader.GetString(7);
                        textBox12.Text = reader.GetString(8);
                        pictureBox6.ImageLocation = textBox12.Text;
                    }
                    else
                    {
                        MessageBox.Show("PELICULA NO ENCONTRADO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ESCRIBA UN ID PELICULA!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox6.Text != "" && textBox8.Text != "" && comboBox2.Text != "" && comboBox5.Text != "" && comboBox6.Text != "" && textBox10.Text != "" && textBox12.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("UPDATE PELICULA SET NOMBRE_PELICULA = '{0}', ESTADO_PELICULA = {1}, SINOPSIS_PELICULA = '{2}', ID_CLASIFICACION = (SELECT ID_CLASIFICACION FROM CLASIFICACION WHERE DESCRIPCION_CLASIFICACION = '{3}'), ID_GENERO = (SELECT ID_GENERO FROM GENERO  WHERE DESCRIPCION_GENERO = '{4}'), DURACION_PELICULA = '{5}' WHERE ID_PELICULA = {6}", textBox8.Text, comboBox6.SelectedIndex, textBox6.Text, comboBox5.Text, comboBox2.Text, textBox1.Text, textBox3.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ACTUALIZADO!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1.Enabled = false; textBox1.Text = "";
                    textBox6.Enabled = false; textBox6.Text = "";
                    textBox8.Enabled = false; textBox8.Text = "";
                    textBox10.Enabled = false; textBox10.Text = "";
                    textBox12.Enabled = false; textBox12.Text = "";
                    textBox3.Enabled = true; textBox3.Text = "";
                    textBox4.Text = "";
                    comboBox2.SelectedIndex = -1; comboBox2.Enabled = false;
                    comboBox5.SelectedIndex = -1; comboBox5.Enabled = false;
                    comboBox6.SelectedIndex = -1; comboBox6.Enabled = false;
                    button10.Enabled = true;
                    button2.Enabled = true;
                    button7.Enabled = false;
                    button6.Enabled = false;
                    button8.Enabled = false;
                    button11.Enabled = false;
                    pictureBox6.Image = null;
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

        private void frm_peliculas_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false; textBox1.Text = "";
            textBox6.Enabled = false; textBox6.Text = "";
            textBox8.Enabled = false; textBox8.Text = "";
            textBox10.Enabled = false; textBox10.Text = "";
            textBox12.Enabled = false; textBox12.Text = "";
            textBox3.Enabled = true;
            button10.Enabled = true;
            button2.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button11.Enabled = false;
            comboBox2.Enabled = false; comboBox2.SelectedIndex = -1;
            comboBox6.Enabled = false; comboBox6.SelectedIndex = -1;
            comboBox5.Enabled = false; comboBox5.SelectedIndex = -1;
            pictureBox6.Image = null;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 47 & e.KeyChar < 58) || (e.KeyChar == ':') || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 47 & e.KeyChar < 58) || (e.KeyChar == '.') || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                try
                {
                    pictureBox5.ImageLocation = textBox11.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("ESCRIBA UN URL IMAGEN!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox11.Focus();
            }
          
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox12.Text != "")
            {
                if (textBox12.Text != pictureBox6.ImageLocation)
                {
                    try
                    {
                        pictureBox6.ImageLocation = textBox11.Text;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("ESCRIBA UN URL IMAGEN!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox12.Focus();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                System.Diagnostics.Process.Start(textBox9.Text);
            }
            else
            {
                MessageBox.Show("ESCRIBA UN URL VIDEO!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox9.Focus();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                System.Diagnostics.Process.Start(textBox10.Text);
            }
            else
            {
                MessageBox.Show("ESCRIBA UN URL VIDEO!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox10.Focus();
            }
        }

        private void frm_peliculas_Load(object sender, EventArgs e)
        {

        }
    }
}
