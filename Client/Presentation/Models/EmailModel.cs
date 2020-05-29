using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class EmailModel : Client
    {
        public string action { get; set; }
    }
    public class SendMail : EmailModel  {
        public void SendMailAction()
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("proyectolkn2020@gmail.com");//correo que envia el mensaje
                mail.To.Add(email);
                mail.Subject = "RESERVAS HOTEL PATITO";
                mail.Body = "Señor/a " + name + " " + lastname + " identidad: " + identification +
                " su solicitud " + action;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.Normal;


                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                string sendmail = "proyectolkn2020@gmail.com";
                string sendMailPassword = "Proyecto2020!";
                smtp.Credentials = new System.Net.NetworkCredential(sendmail, sendMailPassword);
                smtp.Port = 587;
                smtp.Send(mail);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}



