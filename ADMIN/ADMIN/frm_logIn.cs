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
                if (reader.Read())
                {
                    if (reader.GetString(1) == Txt_loginPass.Text)
                    {
                        if (reader.GetInt32(2) == 0) { 
                            Txt_loginUser.Text = "";
                            Txt_loginPass.Text = "";
                            frm_main nuevo = new frm_main(this);
                            this.Hide();
                            nuevo.Show();
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
