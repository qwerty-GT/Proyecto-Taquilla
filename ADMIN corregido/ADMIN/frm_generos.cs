﻿using System;
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
    public partial class frm_generos : Form
    {
        frm_main menu;
        public frm_generos(frm_main anterior)
        {
            InitializeComponent();
            menu = anterior;
            actualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void Btn_formatoAceptar_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("SELECT ID_GENERO FROM GENERO WHERE DESCRIPCION_GENERO = '{0}'", textBox2.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        conexion.Close();
                        conexion = TaquillaDB.getDB();
                        sql = string.Format("INSERT INTO GENERO VALUES(NULL, '{0}');", textBox2.Text);
                        cmd = new OdbcCommand(sql, conexion);
                        cmd.ExecuteNonQuery();
                        textBox2.Text = "";
                        textBox2.Focus();
                        MessageBox.Show("GUARDADO!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("GENERO EXISTENTE!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void actualizar()
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT * FROM GENERO;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader.GetString(0), reader.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("SELECT * FROM GENERO WHERE ID_GENERO = {0}", textBox4.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        dataGridView2.Rows.Clear();
                        dataGridView2.Rows.Add(reader.GetString(0), reader.GetString(1));
                        textBox4.Text = "";
                        textBox3.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("GENERO NO ENCONTRADO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ESCRIBA UN GENERO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("DELETE FROM GENERO WHERE ID_GENERO = {0}", textBox4.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    int ban = cmd.ExecuteNonQuery();
                    if (ban == 1)
                    {
                        MessageBox.Show("GENERO ELIMINADO!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        actualizar();
                    }
                    else
                        MessageBox.Show("GENERO NO ENCONTRADO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ESCRIBA UN ID GENERO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false; textBox1.Text = "";
            textBox3.Enabled = true;
            button10.Enabled = true;
            button2.Enabled = true;
            button7.Enabled = false;
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("SELECT ID_GENERO FROM GENERO WHERE DESCRIPCION_GENERO = '{0}'", textBox1.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (!reader.Read() || (textBox3.Text == reader.GetString(0)))
                    {
                        conexion.Close();
                        conexion = TaquillaDB.getDB();
                        sql = string.Format("UPDATE GENERO SET DESCRIPCION_GENERO = '{0}' WHERE ID_GENERO = {1};", textBox1.Text, textBox3.Text);
                        cmd = new OdbcCommand(sql, conexion);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("ACTUALIZADO!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBox1.Enabled = false; textBox1.Text = "";
                        textBox3.Enabled = true; textBox3.Text = "";
                        textBox4.Text = "";
                        button10.Enabled = true;
                        button2.Enabled = true;
                        button7.Enabled = false;
                        button6.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("GENERO EXISTENTE!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("SELECT DESCRIPCION_GENERO FROM GENERO WHERE ID_GENERO = {0}", textBox3.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        textBox1.Enabled = true;
                        textBox3.Enabled = false;
                        button10.Enabled = false;
                        button2.Enabled = false;
                        button7.Enabled = true;
                        button6.Enabled = true;
                        textBox1.Text = reader.GetString(0);
                    }
                    else
                    {
                        MessageBox.Show("GENERO NO ENCONTRADO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ESCRIBA UN ID GENERO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void frm_generos_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }
    }
}
