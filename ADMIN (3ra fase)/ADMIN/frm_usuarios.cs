using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Odbc;


namespace ADMIN
{
    public partial class frm_usuarios : Form
    {
        frm_main menu;
        public frm_usuarios(frm_main anterior, bool[] privilegios)
        {
            InitializeComponent();
            menu = anterior;
            actualizar();
            Btn_gestionAceptar.Enabled = privilegios[0];
            dataGridView2.Visible = privilegios[1];
            button10.Enabled = privilegios[2];
            button2.Visible = privilegios[3];
        }
        
        private void actualizar()
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT * FROM USUARIO;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader.GetString(0), reader.GetString(1), Convert.ToBoolean(reader.GetInt32(2)), Convert.ToBoolean(reader.GetInt32(3)), Convert.ToBoolean(reader.GetInt32(4)), Convert.ToBoolean(reader.GetInt32(5)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexion.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void frm_usuarios_Load(object sender, EventArgs e)
        {

        }

        private void frm_usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void Chk_gestionPass_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_gestionPass.Checked)
                Txt_gestionPass.UseSystemPasswordChar = false;
            else
                Txt_gestionPass.UseSystemPasswordChar = true;
        }

        private void Btn_gestionAceptar_Click(object sender, EventArgs e)
        {
            if (Txt_gestionUsuario.Text != "" && Txt_gestionPass.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("SELECT USU_USUARIO FROM USUARIO WHERE USU_USUARIO = '{0}'", Txt_gestionUsuario.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        conexion.Close();
                        conexion = TaquillaDB.getDB();
                        sql = string.Format("INSERT INTO USUARIO VALUES('{0}',MD5('{1}'),{2},{3},{4},{5});", Txt_gestionUsuario.Text, Txt_gestionPass.Text, Convert.ToInt32(checkBox2.Checked), Convert.ToInt32(checkBox3.Checked), Convert.ToInt32(checkBox4.Checked), Convert.ToInt32(checkBox5.Checked));
                        cmd = new OdbcCommand(sql, conexion);
                        cmd.ExecuteNonQuery();
                        Txt_gestionUsuario.Text = "";
                        Txt_gestionPass.Text = "";
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        checkBox4.Checked = false;
                        checkBox5.Checked = false;
                        MessageBox.Show("GUARDADO!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("USUARIO EXISTENTE!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button3_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("DELETE FROM USUARIO WHERE USU_USUARIO = '{0}'", textBox4.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    int ban = cmd.ExecuteNonQuery();
                    if (ban == 1)
                    {
                        MessageBox.Show("USUARIO ELIMINADO!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        actualizar();
                    }
                    else
                        MessageBox.Show("USUARIO NO ENCONTRADO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ESCRIBA UN USUARIO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            if (textBox3.Enabled)
                textBox3.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("SELECT * FROM USUARIO WHERE USU_USUARIO = '{0}'", textBox4.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        dataGridView2.Rows.Clear();
                        dataGridView2.Rows.Add(reader.GetString(0), reader.GetString(1), Convert.ToBoolean(reader.GetInt32(2)), Convert.ToBoolean(reader.GetInt32(3)), Convert.ToBoolean(reader.GetInt32(4)), Convert.ToBoolean(reader.GetInt32(5)));
                        textBox4.Text = "";
                        textBox3.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("USUARIO NO ENCONTRADO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ESCRIBA UN USUARIO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false; textBox1.Text = "";
            textBox2.Enabled = false; textBox2.Text = "";
            textBox3.Enabled = true; 
            button10.Enabled = true;
            button1.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = false;
            checkBox8.Enabled = false; checkBox8.Checked = false;
            checkBox7.Enabled = false; checkBox7.Checked = false;
            checkBox6.Enabled = false; checkBox6.Checked = false;
            checkBox9.Enabled = false; checkBox9.Checked = false;
            checkBox1.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("SELECT * FROM USUARIO WHERE USU_USUARIO = '{0}'", textBox3.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = false;
                        button10.Enabled = false;
                        button6.Enabled = true;
                        button7.Enabled = true;
                        button1.Enabled = false;
                        checkBox1.Enabled = true;
                        textBox1.Text = reader.GetString(0);
                        //textBox2.Text = reader.GetString(1);
                        checkBox9.Enabled = true; checkBox9.Checked = reader.GetBoolean(2);
                        checkBox8.Enabled = true; checkBox8.Checked = reader.GetBoolean(3);
                        checkBox7.Enabled = true; checkBox7.Checked = reader.GetBoolean(4);
                        checkBox6.Enabled = true; checkBox6.Checked = reader.GetBoolean(5);
                    }
                    else
                    {
                        MessageBox.Show("USUARIO NO ENCONTRADO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ESCRIBA NOMBRE DE USUARIO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("SELECT USU_USUARIO FROM USUARIO WHERE USU_USUARIO = '{0}'", textBox1.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (!reader.Read() || (textBox3.Text == textBox1.Text))
                    {
                        conexion.Close();
                        conexion = TaquillaDB.getDB();
                        sql = string.Format("UPDATE USUARIO SET USU_USUARIO = '{0}', PASS_USUARIO = MD5('{1}'), INSERT_USUARIO = {2}, SELECT_USUARIO = {3}, UPDATE_USUARIO = {4}, DELETE_USUARIO = {5} WHERE USU_USUARIO = '{6}';", textBox1.Text, textBox2.Text, Convert.ToInt32(checkBox9.Checked), Convert.ToInt32(checkBox8.Checked), Convert.ToInt32(checkBox7.Checked), Convert.ToInt32(checkBox6.Checked), textBox3.Text);
                        cmd = new OdbcCommand(sql, conexion);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("ACTUALIZADO!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBox1.Enabled = false; textBox1.Text = "";
                        textBox2.Enabled = false; textBox2.Text = "";
                        textBox3.Enabled = true; textBox3.Text = "";
                        textBox4.Text = "";
                        button10.Enabled = true;
                        button1.Enabled = true;
                        button6.Enabled = false;
                        button7.Enabled = false;
                        checkBox8.Enabled = false; checkBox8.Checked = false;
                        checkBox7.Enabled = false; checkBox7.Checked = false;
                        checkBox6.Enabled = false; checkBox6.Checked = false;
                        checkBox9.Enabled = false; checkBox9.Checked = false;
                        checkBox1.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("USUARIO EXISTENTE!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
