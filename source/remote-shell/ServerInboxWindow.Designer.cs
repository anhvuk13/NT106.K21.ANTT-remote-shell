namespace remote_shell
{
    partial class ServerInboxWindow
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
            this.serverInbox = new System.Windows.Forms.RichTextBox();
            this.serverInboxInput = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverInbox
            // 
            this.serverInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverInbox.Location = new System.Drawing.Point(12, 44);
            this.serverInbox.Name = "serverInbox";
            this.serverInbox.ReadOnly = true;
            this.serverInbox.Size = new System.Drawing.Size(560, 505);
            this.serverInbox.TabIndex = 1;
            this.serverInbox.TabStop = false;
            this.serverInbox.Text = "";
            this.serverInbox.TextChanged += new System.EventHandler(this.serverInbox_TextChanged);
            // 
            // serverInboxInput
            // 
            this.serverInboxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverInboxInput.Location = new System.Drawing.Point(12, 12);
            this.serverInboxInput.Name = "serverInboxInput";
            this.serverInboxInput.Size = new System.Drawing.Size(494, 26);
            this.serverInboxInput.TabIndex = 0;
            this.serverInboxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serverInboxInput_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(512, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 26);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ServerInboxWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.serverInboxInput);
            this.Controls.Add(this.serverInbox);
            this.Name = "ServerInboxWindow";
            this.Text = "ServerInboxWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerInboxWindow_FormClosing);
            this.Shown += new System.EventHandler(this.ServerInboxWindow_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox serverInbox;
        private System.Windows.Forms.TextBox serverInboxInput;
        private System.Windows.Forms.Button btnClear;
    }
}