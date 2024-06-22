using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Npassignment2
{
    public partial class Form1 : Form
    {
        private List<string> fileAttachements = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
                {
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new NetworkCredential("your personal hello email", "your encrypted pasword");

                    MailMessage emailMatter = new MailMessage();
                    emailMatter.From = new MailAddress(senderemail.Text);
                    emailMatter.To.Add(receiver.Text);
                    emailMatter.Subject = subject.Text;
                    emailMatter.Body = emailbody.Text;

                    foreach (string fileName in fileAttachements)
                    {
                        emailMatter.Attachments.Add(new Attachment(fileName));
                    }

                    smtpClient.Send(emailMatter);

                    MessageBox.Show("Email sent successfully.", "Success Acheived", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void attachfiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileExplorer = new OpenFileDialog();
            openFileExplorer.Multiselect = true;

            if (openFileExplorer.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileExplorer.FileNames)
                {
                    fileAttachements.Add(fileName);
                }

                UpdateAttachedFilesDisplay();
            }
        }

        private void UpdateAttachedFilesDisplay()
        {
            emailbody.Clear();
            foreach (string fileName in fileAttachements)
            {
                emailbody.AppendText(fileName + Environment.NewLine);
            }
    }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
