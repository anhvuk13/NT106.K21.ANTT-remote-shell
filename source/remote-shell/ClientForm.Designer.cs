namespace remote_shell
{
    partial class ClientForm
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
            this.btnShell = new System.Windows.Forms.Button();
            this.btnInbox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShell
            // 
            this.btnShell.Location = new System.Drawing.Point(12, 12);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(117, 23);
            this.btnShell.TabIndex = 0;
            this.btnShell.Text = "Remote Shell";
            this.btnShell.UseVisualStyleBackColor = true;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // btnInbox
            // 
            this.btnInbox.Location = new System.Drawing.Point(51, 57);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(128, 23);
            this.btnInbox.TabIndex = 1;
            this.btnInbox.Text = "Chat with your partner";
            this.btnInbox.UseVisualStyleBackColor = true;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 102);
            this.Controls.Add(this.btnInbox);
            this.Controls.Add(this.btnShell);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Shown += new System.EventHandler(this.ClientForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShell;
        private System.Windows.Forms.Button btnInbox;
    }
}