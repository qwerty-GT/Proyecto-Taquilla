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
        public frm_usuarios(frm_main anterior)
        {
            InitializeComponent();
            menu = anterior;
            actualizar();
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
                    if(reader.GetInt32(2) == 0)
                        dataGridView2.Rows.Add(reader.GetString(0), reader.GetString(1), "admin [0]");
                    else
                        dataGridView2.Rows.Add(reader.GetString(0), reader.GetString(1), "usuario [1]");
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
            if (Txt_gestionUsuario.Text != "" && Txt_gestionPass.Text != "" && Cmb_gestionPrivilegios.Text != "")
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
                        int nivel = Cmb_gestionPrivilegios.SelectedIndex;
                        sql = string.Format("INSERT INTO USUARIO VALUES('{0}','{1}',{2});", Txt_gestionUsuario.Text, Txt_gestionPass.Text, nivel);
                        cmd = new OdbcCommand(sql, conexion);
                        cmd.ExecuteNonQuery();
                        Txt_gestionUsuario.Text = "";
                        Txt_gestionPass.Text = "";
                        Cmb_gestionPrivilegios.SelectedIndex = -1;
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
                MessageBox.Show("ESCRIBA NOMBRE DE USUARIO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        dataGridView2.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                        textBox4.Text = "";
                        textBox3.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Escriba nombre de usuario!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            comboBox1.Enabled = false; comboBox1.SelectedIndex = -1;
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
                        comboBox1.Enabled = true; comboBox1.SelectedIndex = reader.GetInt32(2);
                        checkBox1.Enabled = true;
                        textBox1.Text = reader.GetString(0);
                        textBox2.Text = reader.GetString(1);
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
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
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
                        int nivel = comboBox1.SelectedIndex;
                        sql = string.Format("UPDATE USUARIO SET USU_USUARIO = '{0}', PASS_USUARIO = '{1}', PRIVILEGIO_USUARIO = {2} WHERE USU_USUARIO = '{3}';", textBox1.Text, textBox2.Text, nivel, textBox3.Text);
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
                        comboBox1.Enabled = false; comboBox1.SelectedIndex = -1;
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
