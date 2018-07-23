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
    public partial class frm_peliculas : Form
    {
        frm_main menu;
        public frm_peliculas(frm_main anterior)
        {
            InitializeComponent();
            menu = anterior;
            clasif();
            generos();
            actualizar();
        }

        private void clasif()
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT * FROM CLASIFICACION;");
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
                string sql = string.Format("SELECT * FROM GENERO;");
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
            if (textBox2.Text != "" && textBox5.Text != "" && textBox7.Text != "" && comboBox1.Text != "" && comboBox3.Text != "" && comboBox4.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("INSERT INTO PELICULA VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}'); ", textBox2.Text, comboBox1.Text, textBox5.Text, comboBox3.Text, comboBox4.Text, textBox7.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                    textBox2.Text = "";
                    textBox5.Text = "";
                    textBox7.Text = "";
                    comboBox1.SelectedIndex = -1;
                    comboBox3.SelectedIndex = -1;
                    comboBox4.SelectedIndex = -1;
                    textBox2.Focus();
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("SELECT * FROM PELICULA WHERE ID_PELICULA = '{0}'", textBox4.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        dataGridView2.Rows.Clear();
                        dataGridView2.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
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
                string sql = string.Format("SELECT * FROM PELICULA;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
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
                    string sql = string.Format("DELETE FROM PELICULA WHERE ID_PELICULA = '{0}'", textBox4.Text);
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
                    string sql = string.Format("SELECT * FROM PELICULA WHERE ID_PELICULA = '{0}'", textBox3.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        textBox1.Enabled = true;
                        textBox6.Enabled = true;
                        textBox8.Enabled = true;
                        comboBox2.Enabled = true;
                        comboBox6.Enabled = true;
                        comboBox5.Enabled = true;
                        textBox3.Enabled = false;
                        button10.Enabled = false;
                        button2.Enabled = false;
                        button7.Enabled = true;
                        button6.Enabled = true;
                        textBox8.Text = reader.GetString(1);
                        comboBox6.SelectedIndex = comboBox6.FindString(reader.GetString(2));
                        textBox6.Text = reader.GetString(3);
                        comboBox5.SelectedIndex = comboBox5.FindString(reader.GetString(4));
                        comboBox2.SelectedIndex = comboBox2.FindString(reader.GetString(5));
                        textBox1.Text = reader.GetString(6);
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
            if (textBox1.Text != "" && textBox6.Text != "" && textBox8.Text != "" && comboBox2.Text != "" && comboBox5.Text != "" && comboBox6.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("UPDATE PELICULA SET NOMBRE_PELICULA = '{0}', ESTADO_PELICULA = '{1}', SINOPSIS_PELICULA = '{2}', ID_CLASIFICACION = '{3}', ID_GENERO = '{4}', DURACION_PELICULA = '{5}' WHERE ID_PELICULA = {6}", textBox8.Text, comboBox6.Text, textBox6.Text, comboBox5.Text, comboBox2.Text, textBox1.Text, textBox3.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ACTUALIZADO!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1.Enabled = false; textBox1.Text = "";
                    textBox6.Enabled = false; textBox6.Text = "";
                    textBox8.Enabled = false; textBox8.Text = "";
                    textBox3.Enabled = true; textBox3.Text = "";
                    textBox4.Text = "";
                    comboBox2.SelectedIndex = -1; comboBox2.Enabled = false;
                    comboBox5.SelectedIndex = -1; comboBox5.Enabled = false;
                    comboBox6.SelectedIndex = -1; comboBox6.Enabled = false;
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
            textBox3.Enabled = true;
            button10.Enabled = true;
            button2.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = false;
            comboBox2.Enabled = false; comboBox2.SelectedIndex = -1;
            comboBox6.Enabled = false; comboBox6.SelectedIndex = -1;
            comboBox5.Enabled = false; comboBox5.SelectedIndex = -1;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
