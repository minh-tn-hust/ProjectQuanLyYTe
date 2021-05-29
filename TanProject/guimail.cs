using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace QLPK
{
    public class SendingMail
    {
        String tennguoikham;
        String diachikham;
        String thoigianhenkham;
        String toMail;
        public SendingMail(String tennguoikham, String diachikham, String thoigianhenkham, String mail)
        {
            this.thoigianhenkham = thoigianhenkham;
            this.diachikham = diachikham;
            this.tennguoikham = tennguoikham;
            this.toMail = mail;
        }
        public void send()
        {
            string FilePath = "x.html";
            StreamReader str = new StreamReader(FilePath);
            string MailText = str.ReadToEnd();
            str.Close();

            MailText = MailText.Replace("[thoigiangui]", DateTime.Now.ToString().Trim());
            MailText = MailText.Replace("[tennguoikham]", tennguoikham.Trim());
            MailText = MailText.Replace("[diachikham]", diachikham.Trim());
            MailText = MailText.Replace("[thoigianhenkham]", thoigianhenkham.Trim());




            string subject = "Welcome to CSharpCorner.Com";


            MailMessage _mailmsg = new MailMessage();


            _mailmsg.IsBodyHtml = true;


            _mailmsg.From = new MailAddress("trungtamytedemo@gmail.com");

            _mailmsg.To.Add(toMail);

            _mailmsg.Subject = subject;

            _mailmsg.Body = MailText;

            SmtpClient _smtp = new SmtpClient();

            _smtp.Host = "smtp.gmail.com";

            _smtp.Port = 587;

            _smtp.EnableSsl = true;

            NetworkCredential _network = new NetworkCredential("trungtamytedemo@gmail.com", "05060101minh");
            _smtp.Credentials = _network;

            _smtp.Send(_mailmsg);
        }
    }
}
