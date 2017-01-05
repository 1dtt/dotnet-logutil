using System;
using System.Net.Mail;
using System.Text;

namespace LogUtil
{
    public class MailLogger
    {
        public static bool Send(string to, string subject, string body)
        {
            try
            {
                SmtpClient client = new SmtpClient();
                client.Port = 25;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("1dttpublicmail4test@gmail.com", "accountisall");

                MailMessage mm = new MailMessage("1dttpublicmail4test@gmail.com", to, subject, body);
                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mm);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool SendTohMailServer(string to, string subject, string body)
        {
            try
            {
                SmtpClient client = new SmtpClient();
                client.Host = "127.0.0.1";
                client.EnableSsl = false;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("user3@local.com", "123456");

                MailMessage mm = new MailMessage("user3@local.com", to, subject, body);
                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mm);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
