namespace remote_shell
{
    partial class ServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.tutorialPic = new System.Windows.Forms.PictureBox();
            this.tutorialText = new System.Windows.Forms.RichTextBox();
            this.btnInbox = new System.Windows.Forms.Button();
            this.btnShell = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialPic)).BeginInit();
            this.SuspendLayout();
            // 
            // tutorialPic
            // 
            this.tutorialPic.Image = ((System.Drawing.Image)(resources.GetObject("tutorialPic.Image")));
            this.tutorialPic.Location = new System.Drawing.Point(12, 12);
            this.tutorialPic.Name = "tutorialPic";
            this.tutorialPic.Size = new System.Drawing.Size(604, 28);
            this.tutorialPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tutorialPic.TabIndex = 0;
            this.tutorialPic.TabStop = false;
            this.tutorialPic.Tag = "Room ID";
            // 
            // tutorialText
            // 
            this.tutorialText.Location = new System.Drawing.Point(12, 46);
            this.tutorialText.Name = "tutorialText";
            this.tutorialText.ReadOnly = true;
            this.tutorialText.Size = new System.Drawing.Size(604, 33);
            this.tutorialText.TabIndex = 2;
            this.tutorialText.TabStop = false;
            this.tutorialText.Text = "Look for the above line in your Command Prompt and you will find the Room ID ther" +
    "e. Forward it to your partner.\nPlease don\'t turn off the Command Prompt as soon " +
    "as closing the ServerForm.";
            // 
            // btnInbox
            // 
            this.btnInbox.Enabled = false;
            this.btnInbox.Location = new System.Drawing.Point(349, 112);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(131, 23);
            this.btnInbox.TabIndex = 1;
            this.btnInbox.Text = "Chat with your partner";
            this.btnInbox.UseVisualStyleBackColor = true;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // btnShell
            // 
            this.btnShell.Enabled = false;
            this.btnShell.Location = new System.Drawing.Point(140, 112);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(123, 23);
            this.btnShell.TabIndex = 0;
            this.btnShell.Text = "Supervise the shell";
            this.btnShell.UseVisualStyleBackColor = true;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 147);
            this.Controls.Add(this.btnShell);
            this.Controls.Add(this.btnInbox);
            this.Controls.Add(this.tutorialText);
            this.Controls.Add(this.tutorialPic);
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerForm_FormClosing);
            this.Shown += new System.EventHandler(this.ServerForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.tutorialPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tutorialPic;
        private System.Windows.Forms.RichTextBox tutorialText;
        private System.Windows.Forms.Button btnInbox;
        private System.Windows.Forms.Button btnShell;
    }
}