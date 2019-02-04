namespace EmailBulletin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openEmailList = new System.Windows.Forms.OpenFileDialog();
            this.uploadEmailList = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.toEmailFilePath = new System.Windows.Forms.Label();
            this.uploadIgnoreList = new System.Windows.Forms.Button();
            this.openIgnoreList = new System.Windows.Forms.OpenFileDialog();
            this.ignoreEmailUploadPath = new System.Windows.Forms.Label();
            this.uploadAttachment = new System.Windows.Forms.Button();
            this.attachmentPath = new System.Windows.Forms.Label();
            this.openAttachment = new System.Windows.Forms.OpenFileDialog();
            this.emailBodyTextbox = new System.Windows.Forms.RichTextBox();
            this.emailText = new System.Windows.Forms.Label();
            this.emailSubjectTextbox = new System.Windows.Forms.TextBox();
            this.emailSubject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uploadEmailList
            // 
            this.uploadEmailList.Location = new System.Drawing.Point(13, 13);
            this.uploadEmailList.Name = "uploadEmailList";
            this.uploadEmailList.Size = new System.Drawing.Size(106, 23);
            this.uploadEmailList.TabIndex = 0;
            this.uploadEmailList.Text = "Upload Email List";
            this.uploadEmailList.UseVisualStyleBackColor = true;
            this.uploadEmailList.Click += new System.EventHandler(this.uploadEmailList_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(440, 340);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 5;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(10, 345);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(35, 13);
            this.status.TabIndex = 2;
            this.status.Text = "status";
            // 
            // toEmailFilePath
            // 
            this.toEmailFilePath.AutoSize = true;
            this.toEmailFilePath.Location = new System.Drawing.Point(146, 18);
            this.toEmailFilePath.Name = "toEmailFilePath";
            this.toEmailFilePath.Size = new System.Drawing.Size(79, 13);
            this.toEmailFilePath.TabIndex = 3;
            this.toEmailFilePath.Text = "toEmailFilePath";
            // 
            // uploadIgnoreList
            // 
            this.uploadIgnoreList.Location = new System.Drawing.Point(13, 42);
            this.uploadIgnoreList.Name = "uploadIgnoreList";
            this.uploadIgnoreList.Size = new System.Drawing.Size(106, 23);
            this.uploadIgnoreList.TabIndex = 1;
            this.uploadIgnoreList.Text = "Upload Ignore List";
            this.uploadIgnoreList.UseVisualStyleBackColor = true;
            this.uploadIgnoreList.Click += new System.EventHandler(this.uploadIgnoreList_Click);
            // 
            // openIgnoreList
            // 
            this.openIgnoreList.FileName = "openIgnoreList";
            // 
            // ignoreEmailUploadPath
            // 
            this.ignoreEmailUploadPath.AutoSize = true;
            this.ignoreEmailUploadPath.Location = new System.Drawing.Point(146, 47);
            this.ignoreEmailUploadPath.Name = "ignoreEmailUploadPath";
            this.ignoreEmailUploadPath.Size = new System.Drawing.Size(117, 13);
            this.ignoreEmailUploadPath.TabIndex = 5;
            this.ignoreEmailUploadPath.Text = "ignoreEmailUploadPath";
            // 
            // uploadAttachment
            // 
            this.uploadAttachment.Location = new System.Drawing.Point(13, 71);
            this.uploadAttachment.Name = "uploadAttachment";
            this.uploadAttachment.Size = new System.Drawing.Size(106, 23);
            this.uploadAttachment.TabIndex = 2;
            this.uploadAttachment.Text = "Upload Attachment";
            this.uploadAttachment.UseVisualStyleBackColor = true;
            this.uploadAttachment.Click += new System.EventHandler(this.uploadAttachment_Click);
            // 
            // attachmentPath
            // 
            this.attachmentPath.AutoSize = true;
            this.attachmentPath.Location = new System.Drawing.Point(146, 76);
            this.attachmentPath.Name = "attachmentPath";
            this.attachmentPath.Size = new System.Drawing.Size(82, 13);
            this.attachmentPath.TabIndex = 7;
            this.attachmentPath.Text = "attachmentPath";
            // 
            // openAttachment
            // 
            this.openAttachment.FileName = "openAttachment";
            // 
            // emailBodyTextbox
            // 
            this.emailBodyTextbox.Location = new System.Drawing.Point(13, 178);
            this.emailBodyTextbox.Name = "emailBodyTextbox";
            this.emailBodyTextbox.Size = new System.Drawing.Size(502, 156);
            this.emailBodyTextbox.TabIndex = 4;
            this.emailBodyTextbox.Text = "";
            // 
            // emailText
            // 
            this.emailText.AutoSize = true;
            this.emailText.Location = new System.Drawing.Point(10, 162);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(56, 13);
            this.emailText.TabIndex = 9;
            this.emailText.Text = "Email Text";
            // 
            // emailSubjectTextbox
            // 
            this.emailSubjectTextbox.Location = new System.Drawing.Point(13, 136);
            this.emailSubjectTextbox.Name = "emailSubjectTextbox";
            this.emailSubjectTextbox.Size = new System.Drawing.Size(502, 20);
            this.emailSubjectTextbox.TabIndex = 3;
            // 
            // emailSubject
            // 
            this.emailSubject.AutoSize = true;
            this.emailSubject.Location = new System.Drawing.Point(10, 120);
            this.emailSubject.Name = "emailSubject";
            this.emailSubject.Size = new System.Drawing.Size(71, 13);
            this.emailSubject.TabIndex = 11;
            this.emailSubject.Text = "Email Subject";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 376);
            this.Controls.Add(this.emailSubject);
            this.Controls.Add(this.emailSubjectTextbox);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.emailBodyTextbox);
            this.Controls.Add(this.attachmentPath);
            this.Controls.Add(this.uploadAttachment);
            this.Controls.Add(this.ignoreEmailUploadPath);
            this.Controls.Add(this.uploadIgnoreList);
            this.Controls.Add(this.toEmailFilePath);
            this.Controls.Add(this.status);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.uploadEmailList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(543, 414);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(543, 414);
            this.Name = "Form1";
            this.Text = "Email Bulletin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openEmailList;
        private System.Windows.Forms.Button uploadEmailList;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label toEmailFilePath;
        private System.Windows.Forms.Button uploadIgnoreList;
        private System.Windows.Forms.OpenFileDialog openIgnoreList;
        private System.Windows.Forms.Label ignoreEmailUploadPath;
        private System.Windows.Forms.Button uploadAttachment;
        private System.Windows.Forms.Label attachmentPath;
        private System.Windows.Forms.OpenFileDialog openAttachment;
        private System.Windows.Forms.RichTextBox emailBodyTextbox;
        private System.Windows.Forms.Label emailText;
        private System.Windows.Forms.TextBox emailSubjectTextbox;
        private System.Windows.Forms.Label emailSubject;
    }
}

