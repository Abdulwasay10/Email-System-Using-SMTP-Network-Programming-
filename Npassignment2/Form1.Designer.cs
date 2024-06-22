
namespace Npassignment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.senderemail = new System.Windows.Forms.TextBox();
            this.receiver = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.emailbody = new System.Windows.Forms.RichTextBox();
            this.attachfiles = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // senderemail
            // 
            this.senderemail.Location = new System.Drawing.Point(137, 39);
            this.senderemail.Name = "senderemail";
            this.senderemail.Size = new System.Drawing.Size(168, 23);
            this.senderemail.TabIndex = 0;
            // 
            // receiver
            // 
            this.receiver.Location = new System.Drawing.Point(137, 80);
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(168, 23);
            this.receiver.TabIndex = 1;
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(137, 122);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(257, 23);
            this.subject.TabIndex = 2;
            // 
            // emailbody
            // 
            this.emailbody.Location = new System.Drawing.Point(137, 168);
            this.emailbody.Name = "emailbody";
            this.emailbody.Size = new System.Drawing.Size(575, 133);
            this.emailbody.TabIndex = 3;
            this.emailbody.Text = "";
            // 
            // attachfiles
            // 
            this.attachfiles.Location = new System.Drawing.Point(193, 340);
            this.attachfiles.Name = "attachfiles";
            this.attachfiles.Size = new System.Drawing.Size(112, 23);
            this.attachfiles.TabIndex = 4;
            this.attachfiles.Text = "Attach Files";
            this.attachfiles.UseVisualStyleBackColor = true;
            this.attachfiles.Click += new System.EventHandler(this.attachfiles_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(555, 340);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(97, 23);
            this.send.TabIndex = 5;
            this.send.Text = "Send Email";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sender Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Receiver Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Subject";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email Body";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(459, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Abdul Wasay Ali Khan-11669";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(459, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "NP(114745) Assignment 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.attachfiles);
            this.Controls.Add(this.emailbody);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.receiver);
            this.Controls.Add(this.senderemail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox senderemail;
        private System.Windows.Forms.TextBox receiver;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.RichTextBox emailbody;
        private System.Windows.Forms.Button attachfiles;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

