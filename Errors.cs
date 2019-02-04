using System.Collections.Generic;
using System.Windows.Forms;

namespace EmailBulletin
{
    class Errors
    {
        private static List<string> errorList = new List<string>();
        public static string LogPath { get; set; } = "";

        public static void Add(string errorMessage)
        {
            errorList.Add(errorMessage);
        }

        public static int Count()
        {
            return errorList.Count;
        }

        public static void Show()
        {
            if (errorList.Count > 0)
            {
                Cursor.Current = Cursors.Default;
                var messageText = "The process could not be completed because of the following error(s): \r\n \r\n";
                for (int i = 0; i < errorList.Count; i++)
                {
                    messageText += "- " + errorList[i] + "\r\n";
                }
                Email.sendList.Clear();
                ExcelFile.toList.Clear();
                ExcelFile.ignoreList.Clear();
                
                MessageBox.Show(messageText, "Email Bulletin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ResetVariables()
        {
            errorList.Clear();
        }
    }
}