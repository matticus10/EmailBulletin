using System;
using System.Linq;
using System.Windows.Forms;


namespace EmailBulletin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResetForm();
            status.Text = "";
        }

        private void uploadEmailList_Click(object sender, EventArgs e)
        {
            ExcelFile.SendListPath = FileSelect(openEmailList, toEmailFilePath);
        }

        private void uploadIgnoreList_Click(object sender, EventArgs e)
        {
            ExcelFile.IgnoreListPath = FileSelect(openIgnoreList, ignoreEmailUploadPath);
        }

        private void uploadAttachment_Click(object sender, EventArgs e)
        {
            Email.AttachmentPath = FileSelect(openAttachment, attachmentPath);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            UpdateStatus("Please wait...");
            Cursor.Current = Cursors.WaitCursor;
            TestFormInput(); // Adds error message for each incomplete input

            if (Email.Send(emailSubjectTextbox.Text, emailBodyTextbox.Lines))
            {
                Cursor.Current = Cursors.Default;
                UpdateStatus("Complete.");
                if (MessageBox.Show(Email.MailSentCount + " email(s) sent. \r\n" + Email.MailFailedCount + " email(s) failed.\r\n\r\n Do you wish to view the log?", "Send Complete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(Errors.LogPath);
                }
                
                ResetForm();
                Program.ResetAllVariables();
            }
            else
            {
                Cursor.Current = Cursors.Default;
                UpdateStatus("");
                Errors.Show();
                Errors.ResetVariables();
            }
            
        }

        private string FileSelect(FileDialog fileDialog, Label label)
        {
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                label.Text = fileDialog.FileName;
                return fileDialog.FileName;
            }
            return "";
        }

        private void TestFormInput()
        {
            string[] path = new string[] { ExcelFile.SendListPath, ExcelFile.IgnoreListPath, Email.AttachmentPath, emailSubjectTextbox.Text, emailBodyTextbox.Text };
            string[] message = new string[] { "Email list not selected.", "Opt-out list not selected.", "Attachment not selected.", "Email subject not entered.", "Email body not entered"};

            for (int i = 0; i < path.Count(); i++)
            {
                if (path[i].Length == 0)
                {
                    Errors.Add(message[i]);
                }
            }
        }


        private void UpdateStatus(string message)
        {
            status.Text = message;
        }

        private void ResetForm()
        {
            var message = "Please select...";

            toEmailFilePath.Text = message;
            ignoreEmailUploadPath.Text = message;
            attachmentPath.Text = message;
            emailSubjectTextbox.Text = "";
            emailBodyTextbox.Text = "";
            UpdateStatus("");
        }
    }
}