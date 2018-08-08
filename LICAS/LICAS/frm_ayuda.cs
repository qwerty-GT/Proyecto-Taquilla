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
    public partial class frm_ayuda : Form
    {
        //AXEL DEFINICION DE CREDENCIALES
        static string correo = "reservaciones.licasguatemala@gmail.com";
        static string pass = "licas123";
        frm_menu menu;
        public frm_ayuda(frm_menu anterior)
        {
            InitializeComponent();
            menu = anterior;
        }
        private void Lbl_servicioEmail_Click(object sender, EventArgs e)
        {
            Lbl_servicio1.Visible = false;
            Lbl_servicio2.Visible = false;
            Lbl_servicioEmail.Visible = false;
            Lbl_titulo.Text = Btn_ayudaPregunta.Text;
            Btn_enviar.Visible = true;
            txt_correo.Visible = true;
            txt_mensaje.Visible = true;
            txt_asunto.Visible = true;
            Lbl_asunto.Visible = true;
            Lbl_correo.Visible = true;
            Lbl_mensaje.Visible = true;
        }

        private void Btn_ayudaServicio_Click(object sender, EventArgs e)
        {
            Lbl_titulo.Text = Btn_ayudaServicio.Text;
            Lbl_servicio1.Visible = true;
            Lbl_servicio2.Visible = true;
            Lbl_servicioEmail.Visible = true;

            Btn_enviar.Visible = false;
            txt_correo.Visible = false;
            txt_mensaje.Visible = false;
            txt_asunto.Visible = false;
            Lbl_asunto.Visible = false;
            Lbl_correo.Visible = false;
            Lbl_mensaje.Visible = false;

            Lbl_p1.Visible = false;
            Lbl_p2.Visible = false;
            Lbl_p3.Visible = false;
            Lbl_r1.Visible = false;
            Lbl_r2.Visible = false;
            Lbl_r3.Visible = false;

            Lbl_reembolso.Visible = false;
        }

        private void Btn_ayudaReembolso_Click(object sender, EventArgs e)
        {
            Lbl_titulo.Text = Btn_ayudaReembolso.Text;
            Lbl_reembolso.Visible = true;

            Btn_enviar.Visible = false;
            txt_correo.Visible = false;
            txt_mensaje.Visible = false;
            txt_asunto.Visible = false;
            Btn_enviar.Visible = false;
            Lbl_asunto.Visible = false;
            Lbl_correo.Visible = false;
            Lbl_mensaje.Visible = false;

            Lbl_servicio1.Visible = false;
            Lbl_servicio2.Visible = false;
            Lbl_servicioEmail.Visible = false;

            Lbl_p1.Visible = false;
            Lbl_p2.Visible = false;
            Lbl_p3.Visible = false;
            Lbl_r1.Visible = false;
            Lbl_r2.Visible = false;
            Lbl_r3.Visible = false;
        }

        private void Btn_ayudaPregunta_Click(object sender, EventArgs e)
        {
            Lbl_titulo.Text = Btn_ayudaPregunta.Text;
            Btn_enviar.Visible = true;
            txt_correo.Visible = true;
            txt_mensaje.Visible = true;
            txt_asunto.Visible = true;
            Lbl_asunto.Visible = true;
            Lbl_correo.Visible = true;
            Lbl_mensaje.Visible = true;

            Lbl_reembolso.Visible = false;

            Lbl_servicio1.Visible = false;
            Lbl_servicio2.Visible = false;
            Lbl_servicioEmail.Visible = false;

            Lbl_p1.Visible = false;
            Lbl_p2.Visible = false;
            Lbl_p3.Visible = false;
            Lbl_r1.Visible = false;
            Lbl_r2.Visible = false;
            Lbl_r3.Visible = false;
        }

        private void Btn_FAQ_Click(object sender, EventArgs e)
        {
            Lbl_titulo.Text = Btn_FAQ.Text;
            Lbl_p1.Visible = true;
            Lbl_p2.Visible = true;
            Lbl_p3.Visible = true;
            Lbl_r1.Visible = true;
            Lbl_r2.Visible = true;
            Lbl_r3.Visible = true;

            Btn_enviar.Visible = false;
            txt_correo.Visible = false;
            txt_mensaje.Visible = false;
            txt_asunto.Visible = false;
            Btn_enviar.Visible = false;
            Lbl_asunto.Visible = false;
            Lbl_correo.Visible = false;
            Lbl_mensaje.Visible = false;

            Lbl_reembolso.Visible = false;

            Lbl_servicio1.Visible = false;
            Lbl_servicio2.Visible = false;
            Lbl_servicioEmail.Visible = false;
        }

        //AXEL ENVIO DE CORREO A CLIENTE Y A CUENTA LICAS
        private void Btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage(correo, correo);
                mail.Subject = "NUEVA PREGUNTA DE: " + txt_correo.Text;
                NetworkCredential networkcred = new NetworkCredential(correo, pass);
                mail.IsBodyHtml = true;
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
                mail = new MailMessage(correo, txt_correo.Text);
                mail.Subject = "¡Gracias por tu pregunta!";
                networkcred = new NetworkCredential(correo, pass);
                mail.Body = crearCuerpocliente();
                mail.IsBodyHtml = true;
                smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCred = new NetworkCredential(correo, pass);
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 25;
                smtp.Send(mail);
                txt_asunto.Text = "";
                txt_correo.Text = "";
                txt_mensaje.Text = "";
                MessageBox.Show("Gracias por tu correo!\nNos tomamos tu opinión muy en serio.", "PREGUNTA",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private string crearCuerpocliente()
        {
            
            string cuerpoCliente = File.ReadAllText("formato_correoPregunta.html");
            cuerpoCliente = cuerpoCliente.Replace("{asunto}", txt_asunto.Text);
            cuerpoCliente = cuerpoCliente.Replace("{mensaje}", txt_mensaje.Text);
            return cuerpoCliente;
        }

        private string crearCuerpo()
        {

            string cuerpo = File.ReadAllText("formato_correoLicas.html");
            cuerpo = cuerpo.Replace("{correo}", txt_correo.Text);
            cuerpo = cuerpo.Replace("{asunto}", txt_asunto.Text);
            cuerpo = cuerpo.Replace("{mensaje}", txt_mensaje.Text);
            return cuerpo;
        }

        private void Btn_ayudaSalir_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void frm_ayuda_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }

        private void frm_ayuda_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_reembolso_Click(object sender, EventArgs e)
        {

        }
    }
}
