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
    public partial class frm_salas : Form
    {
        frm_menu menu;
        public frm_salas(frm_menu anterior, bool[] privilegios)
        {
            InitializeComponent();
            menu = anterior;
            actualizar();
            cine();
            formato();
            Btn_formatoAceptar.Enabled = privilegios[0];
            dataGridView2.Visible = privilegios[1];
            button10.Enabled = privilegios[2];
            button2.Visible = privilegios[3];
        }

        private void cine()
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT NOMBRE_CINE FROM CINE;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                comboBox1.Items.Clear();
                comboBox4.Items.Clear();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString(0));
                    comboBox4.Items.Add(reader.GetString(0));
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
                string sql = string.Format("SELECT DESCRIPCION_EXPERIENCIA FROM EXPERIENCIA ;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader.GetString(0));
                    comboBox3.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
            }
            conexion.Close();
        }

        private void frm_salas_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_gestionFormatos_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void actualizar()
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT S.ID_SALA, S.FILAS_SALA, S.COLUMNAS_SALA, C.NOMBRE_CINE, E.DESCRIPCION_EXPERIENCIA, S.NUMERO_SALA FROM SALA S, CINE C, EXPERIENCIA E WHERE S.ID_CINE = C.ID_CINE AND S.ID_EXPERIENCIA = E.ID_EXPERIENCIA;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
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
                    string sql = string.Format("SELECT S.ID_SALA, S.FILAS_SALA, S.COLUMNAS_SALA, C.NOMBRE_CINE, E.DESCRIPCION_EXPERIENCIA, S.NUMERO_SALA FROM SALA S, CINE C, EXPERIENCIA E WHERE S.ID_CINE = C.ID_CINE AND S.ID_EXPERIENCIA = E.ID_EXPERIENCIA AND ID_SALA = '{0}'", textBox4.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        dataGridView2.Rows.Clear();
                        dataGridView2.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                        textBox4.Text = "";
                        textBox3.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("SALA NO ENCONTRADA!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ESCRIBA ID SALA!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("DELETE FROM SALA WHERE ID_SALA = '{0}'", textBox4.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    int ban = cmd.ExecuteNonQuery();
                    if (ban == 1)
                    {
                        MessageBox.Show("SALA ELIMINADA!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        actualizar();
                    }
                    else
                        MessageBox.Show("SALA NO ENCONTRADA!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ESCRIBA UN ID SALA!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
            }
        }

        private void Btn_formatoAceptar_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox5.Text != "" && comboBox1.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("INSERT INTO SALA VALUES(NULL, {0}, {1}, (SELECT ID_CINE FROM CINE WHERE NOMBRE_CINE = '{2}'), (SELECT ID_EXPERIENCIA FROM EXPERIENCIA WHERE DESCRIPCION_EXPERIENCIA = '{3}'), {4});", textBox2.Text, textBox5.Text, comboBox1.Text, comboBox3.Text, textBox7.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                    textBox2.Text = "";
                    textBox5.Text = "";
                    textBox7.Text = "";
                    comboBox1.SelectedIndex = -1;
                    comboBox3.SelectedIndex = -1;
                    textBox7.Focus();
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

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("SELECT S.ID_SALA, S.FILAS_SALA, S.COLUMNAS_SALA, C.NOMBRE_CINE, E.DESCRIPCION_EXPERIENCIA, S.NUMERO_SALA FROM SALA S, CINE C, EXPERIENCIA E WHERE S.ID_CINE = C.ID_CINE AND S.ID_EXPERIENCIA = E.ID_EXPERIENCIA AND ID_SALA = '{0}'", textBox3.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        textBox1.Enabled = true;
                        textBox6.Enabled = true;
                        textBox8.Enabled = true;
                        comboBox2.Enabled = true;
                        comboBox4.Enabled = true;
                        textBox3.Enabled = false;
                        button10.Enabled = false;
                        button2.Enabled = false;
                        button7.Enabled = true;
                        button6.Enabled = true;
                        textBox6.Text = reader.GetString(1);
                        textBox1.Text = reader.GetString(2);
                        comboBox4.SelectedIndex = comboBox4.FindString(reader.GetString(3));
                        comboBox2.SelectedIndex = comboBox2.FindString(reader.GetString(4));
                        textBox8.Text = reader.GetString(5); textBox8.Focus();
                    }
                    else
                    {
                        MessageBox.Show("SALA NO ENCONTRADA!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ESCRIBA UN SALA!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
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
            comboBox4.Enabled = false; comboBox4.SelectedIndex = -1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox6.Text != "" && textBox6.Text != "" && comboBox4.Text != "" && comboBox2.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("UPDATE SALA SET FILAS_SALA = {0}, COLUMNAS_SALA = {1}, ID_CINE = (SELECT ID_CINE FROM CINE WHERE NOMBRE_CINE = '{2}'), ID_EXPERIENCIA = (SELECT ID_EXPERIENCIA FROM EXPERIENCIA WHERE DESCRIPCION_EXPERIENCIA = '{3}'), NUMERO_SALA = '{4}' WHERE ID_SALA = {5}", textBox6.Text, textBox1.Text, comboBox4.Text, comboBox2.Text, textBox8.Text, textBox3.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ACTUALIZADO!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1.Enabled = false; textBox1.Text = "";
                    textBox6.Enabled = false; textBox6.Text = "";
                    textBox3.Enabled = true; textBox3.Text = "";
                    textBox8.Enabled = false; textBox8.Text = "";
                    textBox4.Text = "";
                    comboBox2.SelectedIndex = -1; comboBox2.Enabled = false;
                    comboBox4.SelectedIndex = -1; comboBox4.Enabled = false;
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            if (textBox3.Enabled)
                textBox3.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 47 & e.KeyChar < 58) || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 47 & e.KeyChar < 58) || (e.KeyChar == 8))
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
            if ((e.KeyChar > 47 & e.KeyChar < 58) || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 47 & e.KeyChar < 58) || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
