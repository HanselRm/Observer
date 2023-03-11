using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Clases
{
    static class CMail
    {
        public static void send(string correo, string nombre)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("hanselrodriguezm02@gmail.com",
                                                    "tjauvzgkzrurnwgx"),
                EnableSsl = true,
            };
            try
            {
                smtpClient.Send(mensaje(correo, nombre));
            }catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public static dynamic mensaje(string correo,string nombre)
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress("hanselrodriguezm02@gmail.com"),
                Subject = "Cambio de Materia",
                Body = $"Saludos {nombre} la materia tenido una modificacion en los cupos",
            };
            try
            {
                mailMessage.To.Add(new MailAddress(correo));
            }catch(FormatException ex)
            {
                Console.WriteLine("Correo Incorrecto" + ex.Message);
            }
            
            return mailMessage;
        }
    }
}
