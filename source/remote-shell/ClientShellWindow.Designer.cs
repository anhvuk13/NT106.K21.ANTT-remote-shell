namespace remote_shell
{
    partial class ClientShellWindow
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
            this.remoteShell = new System.Windows.Forms.RichTextBox();
            this.remoteInput = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // remoteShell
            // 
            this.remoteShell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remoteShell.Location = new System.Drawing.Point(12, 44);
            this.remoteShell.Name = "remoteShell";
            this.remoteShell.ReadOnly = true;
            this.remoteShell.Size = new System.Drawing.Size(560, 505);
            this.remoteShell.TabIndex = 0;
            this.remoteShell.TabStop = false;
            this.remoteShell.Text = "";
            this.remoteShell.TextChanged += new System.EventHandler(this.remoteShell_TextChanged);
            // 
            // remoteInput
            // 
            this.remoteInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remoteInput.Location = new System.Drawing.Point(12, 12);
            this.remoteInput.Name = "remoteInput";
            this.remoteInput.Size = new System.Drawing.Size(464, 26);
            this.remoteInput.TabIndex = 0;
            this.remoteInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.remoteInput_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(482, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 26);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ClientShellWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.remoteInput);
            this.Controls.Add(this.remoteShell);
            this.Name = "ClientShellWindow";
            this.Text = "ClientShellWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientShellWindow_FormClosing);
            this.Shown += new System.EventHandler(this.ClientShellWindow_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox remoteShell;
        private System.Windows.Forms.TextBox remoteInput;
        private System.Windows.Forms.Button btnClear;
    }
}