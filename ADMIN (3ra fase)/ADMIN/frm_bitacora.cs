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
    public partial class frm_bitacora : Form
    {
        frm_main menu;
        public frm_bitacora(frm_main anterior)
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
                string sql = string.Format("SELECT * FROM bitacora;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                try
                {
                    string sql = string.Format("SELECT * FROM bitacora WHERE ID_bitacora = {0}", textBox4.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        dataGridView2.Rows.Clear();
                        dataGridView2.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                        textBox4.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("ID bitacora NO ECONTRADO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ESCRIBA UN ID bitacora!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void frm_bitacora_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }
    }
}
