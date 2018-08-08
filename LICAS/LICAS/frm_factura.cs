using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;
using System.Data.Odbc;
using System.Net;
using System.IO;
//AXEL, JAVIER, ESTUARDO, IVAN, JOSUE DISEÑO GENERAL DEL FORM
namespace LICAS
{
    public partial class frm_factura : Form
    {
        private frm_asientos asientos;
        private int tiempo = 60;
        private int id_factura;
        private int[] cantidad_asientos;
        private double[] sub_asientos;
        int[] numero_asientos;
        private string funcion;
        //JOSUE FUNCION QUE GUARDA EN UN ARRAY LOS NOMBRES DE LOS ASIENTOS
        private string[] nombres_asientos = new string[] { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "C10", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D10", "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "E10", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10" };

        //AXEL CREDENCIALES DE EMAIL
        static string correo = "reservaciones.licasguatemala@gmail.com";
        static string pass = "licas123";
        public frm_factura(frm_asientos asientos, string funcion, int[] cantidad_asientos, double[] sub_asientos, int[] numero_asientos)
        {
            InitializeComponent();
            metodosPagos();
            this.asientos = asientos;
            this.cantidad_asientos = cantidad_asientos;
            this.funcion = funcion;
            this.sub_asientos = sub_asientos;
            this.numero_asientos = numero_asientos;
        }

        //JOSUE AñADE LAS FORMAS DE PAGO QUE ESTAN EN LA BASE DE DATOS
        private void metodosPagos()
        {
            OdbcConnection conexion = TaquillaDB.getDB();
            try
            {
                string sql = string.Format("SELECT DESCRIPCION_METODO_PAGO FROM METODO_PAGO;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                cmb_pago.Items.Clear();
                while (reader.Read())
                {
                    cmb_pago.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
            }
            conexion.Close();
        }

        //AXEL Y JOSUE ENVIA UN CORREO DE CONFIRMACION AL CLIENTE Y SE RESERVAN LOS ASIENTOS
        private void Btn_seleccionEnviar_Click(object sender, EventArgs e)
        {
            if (Cb_terminos.Checked == false)
            {
                //AXEL VALIDACION DE TERMINOS Y CONDICIONES CHECKBOX
                MessageBox.Show("DEBE ACEPTAR LOS TÉRMINOS Y CONDICIONES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //JOSUE VALIDACION DE QUE LOS CAMPOS NO ESTEN VACIOS
            else if (!Cb_terminos.Checked || txt_correo.Text == "" || txt_nombre.Text == "" || txt_telefono.Text == "" || cmb_pago.Text == "" || txt_tarjeta.Text == "" || txt_codigo.Text == "" || cmb_mes.Text == "" || cmb_year.Text == "")
            {
                MessageBox.Show("COMPLETE TODOS LOS CAMPOS!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OdbcConnection conexion = TaquillaDB.getDB();
                OdbcCommand cmd;
                OdbcDataReader reader;
                try
                {
                    string sql = string.Format("SELECT EMAIL_CLIENTE FROM CLIENTE WHERE EMAIL_CLIENTE = '{0}'", txt_correo.Text);
                    cmd = new OdbcCommand(sql, conexion);
                    reader = cmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        //JOSUE INSERCION DE DATOS DE CLIENE Y DE LA TRANSACCION EN LA BD
                        sql = string.Format("INSERT INTO CLIENTE VALUES('{0}','{1}',{2}, 0);", txt_correo.Text, txt_nombre.Text, txt_telefono.Text);
                        cmd = new OdbcCommand(sql, conexion);
                        cmd.ExecuteNonQuery();
                    }
                    double monto_total = sub_asientos[0] + sub_asientos[1] + sub_asientos[2];
                    sql = string.Format("INSERT INTO FACTURA VALUES(NULL,{0},{1},(SELECT ID_METODO_PAGO FROM METODO_PAGO WHERE DESCRIPCION_METODO_PAGO = '{2}'),{3},CURDATE(),DATE_FORMAT(NOW(),'%H:%i:%S'),'{4}');", monto_total, monto_total * .07, cmb_pago.Text, 1, txt_correo.Text);
                    cmd = new OdbcCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                    sql = string.Format("SELECT MAX(ID_FACTURA) FROM FACTURA;");
                    cmd = new OdbcCommand(sql, conexion);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        id_factura = reader.GetInt32(0);
                    }
                    int cnt = 0;
                    for (int j = 0; j < 3; j++) { 
                        for (int i = 0; i < cantidad_asientos[j]; i++)
                        {
                            sql = string.Format("INSERT INTO RESERVACION VALUES(NULL,{0},{1},{2},{3},{4});", funcion, id_factura, numero_asientos[cnt++], j+1, sub_asientos[j] / cantidad_asientos[j]);
                            cmd = new OdbcCommand(sql, conexion);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    //AXEL ENVIO DE CORREO DE CONFIRMACION DE LA RESERVACION HACIA EL CLIENTE
                    MailMessage mail = new MailMessage(correo, txt_correo.Text);
                    mail.Subject = "Detalles de Reservación";
                    NetworkCredential networkcred = new NetworkCredential(correo, pass);
                    mail.Body = crearCuerpo();
                    mail.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred = new NetworkCredential(correo, pass);
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 25;
                    smtp.Send(mail);
                    MessageBox.Show("RESERVA REALIZADA CON ÉXITO!\nRECIBIRAS UN CORREO DE CONFIRMACIÓN.", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    asientos.Close();
                    asientos.boletos.Close();
                    asientos.boletos.pelicula.Close();
                    asientos.boletos.pelicula.cartelera.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conexion.Close();
            }
        }

        private string crearCuerpo()
        {
        
            //AXEL CUERPO DEL CORREO
            string cuerpo = File.ReadAllText("formato_correo.html");
            OdbcConnection conexion = TaquillaDB.getDB();
            double total = sub_asientos[0] + sub_asientos[1] + sub_asientos[2];
            string name_asientos = "";
            int cnt = 0;
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < cantidad_asientos[j]; i++)
                {
                    if(name_asientos == "")
                        name_asientos = name_asientos + nombres_asientos[numero_asientos[cnt++]];
                    else
                        name_asientos = name_asientos + ", " + nombres_asientos[numero_asientos[cnt++]];
                }
            }
            try
            {
                //JOSUE Y AXEL SE SELECCIONAN DATOS DE LA BD Y SE SUSTITUYEN POR CIERTOS DATOS EN EL ARCHIVO DE FORMATO DE CORREO HTML
                string sql = string.Format("SELECT CIN.NOMBRE_CINE, PEL.NOMBRE_PELICULA, SAL.NUMERO_SALA, FUN.FECHA_FUNCION, HOR.DESCRIPCION_HORARIO, CIN.ID_CINE, PEL.IMAGEN_PELICULA FROM CINE CIN, PELICULA PEL, SALA SAL, FUNCION FUN, HORARIO HOR WHERE FUN.ID_SALA = SAL.ID_SALA AND SAL.ID_CINE = CIN.ID_CINE AND FUN.ID_PELICULA = PEL.ID_PELICULA AND FUN.ID_HORARIO = HOR.ID_HORARIO AND FUN.ID_FUNCION = {0};", funcion);
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cuerpo = cuerpo.Replace("{idfactura}", "" + id_factura);
                    cuerpo = cuerpo.Replace("{cine}", reader.GetString(0));
                    cuerpo = cuerpo.Replace("{pelicula}", reader.GetString(1));
                    cuerpo = cuerpo.Replace("{sala}", reader.GetString(2));
                    cuerpo = cuerpo.Replace("{fecha}", reader.GetString(3));
                    cuerpo = cuerpo.Replace("{hora}", reader.GetString(4));
                    cuerpo = cuerpo.Replace("{asientos}", name_asientos);
                    cuerpo = cuerpo.Replace("{idcine}", reader.GetString(5));
                    cuerpo = cuerpo.Replace("{na}", "" + cantidad_asientos[0]);
                    cuerpo = cuerpo.Replace("{nc}", "" + cantidad_asientos[1]);
                    cuerpo = cuerpo.Replace("{n3}", "" + cantidad_asientos[2]);
                    cuerpo = cuerpo.Replace("{sa}", "" + sub_asientos[0]);
                    cuerpo = cuerpo.Replace("{sn}", "" + sub_asientos[1]);
                    cuerpo = cuerpo.Replace("{s3}", "" + sub_asientos[2]);
                    cuerpo = cuerpo.Replace("{total}", "" + total);
                    cuerpo = cuerpo.Replace("{imagen}",reader.GetString(6));
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
            return cuerpo;
        }

        private void Btn_seleccionSalir_Click(object sender, EventArgs e)
        {
            asientos.Show();
            this.Close();
        }

        private void Rdb_reservar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cbo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_factura_FormClosing(object sender, FormClosingEventArgs e)
        {
            asientos.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempo > 0)
            {
                tiempo--;
                lbl_time.Text = "TIME: 00:" + tiempo ;
            }
            else
            {
                this.Close();
                asientos.Close();
                asientos.boletos.Close();
                asientos.boletos.pelicula.Close();
                asientos.boletos.pelicula.cartelera.Close();
                MessageBox.Show("TIEMPO AGOTADO PARA REALIZAR LA COMPRA!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmb_pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_pago.Text == "Visa")
            {
                Pic_pago.Image = Image.FromFile("visa.png");
            }
            if (cmb_pago.Text == "Mastercard")
            {
                Pic_pago.Image = Image.FromFile("master.png");
            }
            if (cmb_pago.Text == "Amex")
            {
                Pic_pago.Image = Image.FromFile("amex.png");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_tarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 & e.KeyChar < 58)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 & e.KeyChar < 58)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 & e.KeyChar < 58)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Lbl_terminos_Click(object sender, EventArgs e)
        {
            frm_terminos nuevo = new frm_terminos(this);
            nuevo.Show();
            this.Hide();
        }

        private void txt_tarjeta_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_factura_Load(object sender, EventArgs e)
        {

        }
    }
}
