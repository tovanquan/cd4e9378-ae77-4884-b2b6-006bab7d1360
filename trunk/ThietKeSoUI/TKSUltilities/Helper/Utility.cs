using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Text.RegularExpressions;
using TKSUltilities.Accessor;

namespace TKSUltilities.Helper
{
    /// <summary>
    /// Provides helper functions.
    /// </summary>
    public static class Utility
    {
        public static bool CheckInputEmail(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                email = email.Trim();
                Regex reg = new Regex("^([0-9a-zA-Z]+[-._+&amp;])*[0-9a-zA-Z]+@([-0-9a-zA-Z]+[.])+[a-zA-Z]{2,6}$");
                return (reg.IsMatch(email) == true);
            }
            return false;
        }

        /// <summary>
        /// Method using to send email to many receivers
        /// </summary>
        /// <param name="address"> Email address</param>
        /// <param name="subject"> Email subject</param>
        /// <param name="content"> Email body</param>
        /// <returns></returns>
        public static bool SendEmail(List<string> address, string subject, string content, bool isBodyHTML) 
        {
            if(string.IsNullOrEmpty(subject)
             &&string.IsNullOrEmpty(content))
                {
                    return false;
                }
            MailMessage email = new MailMessage();
            SmtpClient smtpServer = new SmtpClient();
            try
            {
                foreach (string temp in address)
                {
                    if (string.IsNullOrEmpty(temp))
                        return false;
                    email.To.Add(new MailAddress(temp));
                }
                email.Subject = subject;
                email.Body = content;
                email.IsBodyHtml = isBodyHTML;
                // EnableSsl to sending email
                smtpServer.EnableSsl = true;
                smtpServer.Send(email);
                return true;
            }
            catch(SmtpException)
            {
                // Write log file
                return false;
            }
            finally
            {
                smtpServer.EnableSsl = false;
                email.Dispose();
            }
        }

        /// <summary>
        /// Method using to send email to one receiver
        /// </summary>
        /// <param name="address"> Email address</param>
        /// <param name="subject"> Email subject</param>
        /// <param name="content"> Email body</param>
        /// <returns></returns>
        public static bool SendEmail(string address, string subject, string content, bool isBodyHTML)
        {
            if (string.IsNullOrEmpty(subject)
             && string.IsNullOrEmpty(content))
            {
                return false;
            }
            MailMessage email = new MailMessage();
            SmtpClient smtpServer = new SmtpClient();
            try
            {
                if (string.IsNullOrEmpty(address))
                    return false;
                email.To.Add(new MailAddress(address));
                email.Subject = subject;
                email.Body = content;
                email.IsBodyHtml = isBodyHTML;
                // EnableSsl to sending email
                smtpServer.EnableSsl = true;
                smtpServer.Send(email);
                return true;
            }
            catch (SmtpException)
            {
                // Write log file
                return false;
            }
            finally
            {
                smtpServer.EnableSsl = false;
                email.Dispose();
            }
        }
        public static string rep(string a) 
        {
            a.Replace("abc","def");
            return a;
        }
        /// Method using to send email to one receiver
        /// </summary>
        /// <param name="address"> Email address</param>
        /// <param name="subject"> Email subject</param>
        /// <param name="content"> Email body</param>
        /// <returns></returns>
        public static bool SendEmail(string mailBQT, CustomerInformation customerInfo, bool isBodyHTML)
        {
            if (customerInfo == null
             && string.IsNullOrEmpty(customerInfo.Title)
             && string.IsNullOrEmpty(customerInfo.Content)
             && string.IsNullOrEmpty(customerInfo.Email))
            {
                return false;
            }
            MailMessage email = new MailMessage();
            SmtpClient smtpServer = new SmtpClient();
            // Make a content of email
            string emailBody = customerInfo.Content.Trim().Replace(Environment.NewLine,"<br>");
            emailBody += "<br>";
            emailBody += customerInfo.Name;
            emailBody += "<br>";
            emailBody += customerInfo.Email;
            emailBody += "<br>";
            emailBody += customerInfo.Mobile;
            emailBody += "<br>";
            emailBody += customerInfo.Address;
            try
            {
                email.To.Add(new MailAddress(mailBQT));
                email.Subject = customerInfo.Title;
                email.Body = emailBody;
                email.IsBodyHtml = isBodyHTML;
                // EnableSsl to sending email
                smtpServer.EnableSsl = true;
                smtpServer.Send(email);
                return true;
            }
            catch (SmtpException)
            {
                // Write log file
                return false;
            }
            finally
            {
                smtpServer.EnableSsl = false;
                email.Dispose();
            }
        }
    }
}
//    SmtpClient SmtpServer = new SmtpClient();
//    SmtpServer.Credentials = new System.Net.NetworkCredential("anonymous.testers@gmail.com", "thietkeso");
//    SmtpServer.Port = 587;
//    SmtpServer.Host = "smtp.gmail.com";
//    SmtpServer.EnableSsl = true;
//    MailMessage mail = new MailMessage();
//    string addr = "linhnan00499@fpt.edu.vn";
//    try
//    {
//        mail.From = new MailAddress("anonymous.testers@gmail.com", "Công ty cổ phần công nghệ Thiết Kế Số", Encoding.UTF8);
//        //mail.From = new MailAddress("anonymous.testers@gmail.com",
//        //"Ban trung thuong 1ty dong", System.Text.Encoding.UTF8);
//        mail.To.Add(addr);
//        mail.Subject = "Cam on ban da gui mail";
//        mail.Body = "tao ghet may";
//        //if (lbAttachFile.Items.Count != 0)
//        //{
//        //    for (i = 0; i < lbAttachFile.Items.Count; i++)
//        //        mail.Attachments.Add(new Attachment(lbAttachFile.Items[i].ToString()));
//        //}
//        mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
//        //mail.ReplyTo = new MailAddress(txtTo.Text);
//        SmtpServer.Send(mail);
//}
//catch (Exception ex) { }