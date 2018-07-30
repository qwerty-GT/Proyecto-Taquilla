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
    public partial class frm_logIn : Form
    {
        public frm_logIn()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_ayuda x = new frm_ayuda();
            x.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT * FROM USUARIO WHERE USU_USUARIO = '{0}'", Txt_loginUser.Text);
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                bool[] privilegios = new bool[4];
                if (reader.Read())
                {
                    conexion.Close();
                    conexion = TaquillaDB.getDB();
                    sql = string.Format("SELECT INSERT_USUARIO, SELECT_USUARIO, UPDATE_USUARIO, DELETE_USUARIO FROM USUARIO WHERE USU_USUARIO = '{0}' AND PASS_USUARIO = MD5('{1}');", Txt_loginUser.Text, Txt_loginPass.Text);
                    cmd = new OdbcCommand(sql, conexion);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        privilegios[0] = Convert.ToBoolean(reader.GetInt32(0));
                        privilegios[1] = Convert.ToBoolean(reader.GetInt32(1));
                        privilegios[2] = Convert.ToBoolean(reader.GetInt32(2));
                        privilegios[3] = Convert.ToBoolean(reader.GetInt32(3));

                        if (privilegios[0] || privilegios[1] || privilegios[2] || privilegios[3]) {
                            OdbcConnection cnx = TaquillaDB.getDB();
                            sql = string.Format("INSERT INTO BITACORA VALUES (NULL, 'LOG IN', NOW(), '{0}', USER());", Txt_loginUser.Text);
                            OdbcCommand cm = new OdbcCommand(sql, cnx);
                            cm.ExecuteNonQuery();
                            Txt_loginUser.Text = "";
                            Txt_loginPass.Text = "";
                            Txt_loginUser.Focus();
                            frm_main nuevo = new frm_main(this, privilegios);
                            this.Hide();
                            nuevo.Show();
                            cnx.Close();
                        }
                        else
                        {
                            MessageBox.Show("Falta de privilegios!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Txt_loginUser.Text = "";
                            Txt_loginUser.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password incorrect!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Txt_loginPass.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no valido!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_loginUser.Text = "";
                    Txt_loginUser.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Txt_loginPass.Text = "";
            Chk_gestionPass.Checked = false;
            conexion.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_logIn_Load(object sender, EventArgs e)
        {

        }

        private void Chk_gestionPass_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_gestionPass.Checked)
                Txt_loginPass.UseSystemPasswordChar = false;
            else
                Txt_loginPass.UseSystemPasswordChar = true;
        }

        private void Txt_loginPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
                Btn_Aceptar.PerformClick();
        }
    }
}
