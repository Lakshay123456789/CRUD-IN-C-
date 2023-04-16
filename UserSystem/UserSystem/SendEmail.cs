using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UserSystem
{
    internal class SendEmail
    {
        public static void SendMailUser(List<UserClass> list)
        {
           
            try
            {
                Console.WriteLine("enter user id");
                String userId =Console.ReadLine();
                UserClass user = list.Find(em => em.UserId == userId);
                if(user != null)
                {
                    Console.WriteLine("enter the subject ");
                    string subject=Console.ReadLine();
                    Console.WriteLine("enter the body ");
                    string body = Console.ReadLine();
                    string email = user.UserEmail;
                    Thread t = new Thread(() => SendMailTo(email,subject,body));
                    t.Start();
                    t.Join();
                 
                    Console.WriteLine("end  the successfully");
                }

            }
            catch(Exception ex)
            {
              Console.WriteLine(ex.Message);        
            }
        }
        public static void SendMailTo(string email,string subject,string body)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("lakshayk.Aspirefox@gmail.com");
                message.To.Add(email);
                message.Subject =subject;
                message.IsBodyHtml = true; //to make message body as html
                message.Body = body;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("lakshayk.Aspirefox@gmail.com", "xjpaynapcmfwhvxt");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex) {
                Console.WriteLine();
                Console.WriteLine($"Error sending email to {email}: {ex.Message}");
                Console.WriteLine();
            }
        }
        
    }
   
}
