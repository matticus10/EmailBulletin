using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;

namespace EmailBulletin
{
    class Email
    {
        public static string AttachmentPath { get; set; } = "";
        public static int MailSentCount { get; set; } = 0;
        public static int MailFailedCount { get; set; } = 0;
        public static List<string> sendList = new List<string>();

        private static void GetSendList()
        {
            sendList = ExcelFile.CreateSendList();
            if (Errors.Count() == 0 && sendList.Count == 0)
            {
                Errors.Add("No emails in send list.");
            }
        }

        public static bool Send(string emailSubject, string[] emailBodyLines)
        {
            bool isSent = true;
            GetSendList();

            if (Errors.Count() < 1)
            {
                Errors.LogPath = Directory.GetCurrentDirectory() + "/logs/log" + DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".txt";

                for (int i = 0; i < sendList.Count; i++)
                {
                    SendEmail(sendList[i], emailSubject, emailBodyLines);
                }
            }
            else
            {
                isSent = false;
            }

            return isSent;
        }

        private static void SendEmail(string emailAddress, string emailSubject, string[] emailBodyLines)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.office365.com", 587);

            string email = "";
            string password = "";
            smtpClient.Credentials = new System.Net.NetworkCredential(email, password);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;

            mail.From = new MailAddress(email);
            mail.To.Add(new MailAddress(emailAddress));
            mail.Subject = emailSubject;
            mail.Body = "";

            foreach (string line in emailBodyLines)
            {
                mail.Body += line + "<br>";
            }


            if (AttachmentPath.Length > 0)
            {
                Attachment attachment = new Attachment(AttachmentPath, MediaTypeNames.Application.Octet);
                ContentDisposition disposition = attachment.ContentDisposition;
                disposition.CreationDate = File.GetCreationTime(AttachmentPath);
                disposition.ModificationDate = File.GetLastWriteTime(AttachmentPath);
                disposition.ReadDate = File.GetLastAccessTime(AttachmentPath);
                disposition.FileName = Path.GetFileName(AttachmentPath);
                disposition.Size = new FileInfo(AttachmentPath).Length;
                disposition.DispositionType = DispositionTypeNames.Attachment;
                mail.Attachments.Add(attachment);
            }

            if (mail.Attachments.Count < 1)
            {
                Errors.Add("No attatchment selected");
            }

            try
            {
                smtpClient.Send(mail);
                MailSentCount++;
                File.AppendAllText(Errors.LogPath, DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + " " + emailAddress + " success" + Environment.NewLine);

            }
            catch
            {
                MailFailedCount++;
                File.AppendAllText(Errors.LogPath, DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + "\t\t" + emailAddress + "\t\tfailed" + Environment.NewLine);
            }
        }

        public static void ResetVariables()
        {
            sendList.Clear();
            MailSentCount = 0;
            MailFailedCount = 0;
            AttachmentPath = "";
        }
    }
}
