namespace remote_shell
{
    partial class clientForm
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
            this.rtxbShellOutput = new System.Windows.Forms.RichTextBox();
            this.txbShellCommand = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtxbShellOutput
            // 
            this.rtxbShellOutput.BackColor = System.Drawing.SystemColors.ControlText;
            this.rtxbShellOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbShellOutput.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.rtxbShellOutput.Location = new System.Drawing.Point(5, 6);
            this.rtxbShellOutput.Margin = new System.Windows.Forms.Padding(6);
            this.rtxbShellOutput.Name = "rtxbShellOutput";
            this.rtxbShellOutput.ReadOnly = true;
            this.rtxbShellOutput.Size = new System.Drawing.Size(990, 400);
            this.rtxbShellOutput.TabIndex = 3;
            this.rtxbShellOutput.Text = "";
            // 
            // txbShellCommand
            // 
            this.txbShellCommand.BackColor = System.Drawing.SystemColors.MenuText;
            this.txbShellCommand.ForeColor = System.Drawing.SystemColors.Window;
            this.txbShellCommand.Location = new System.Drawing.Point(5, 415);
            this.txbShellCommand.Name = "txbShellCommand";
            this.txbShellCommand.Size = new System.Drawing.Size(990, 29);
            this.txbShellCommand.TabIndex = 4;
            this.txbShellCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbShellCommand_KeyDown);
            this.txbShellCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbShellCommand_KeyPress);
            // 
            // clientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(998, 446);
            this.Controls.Add(this.txbShellCommand);
            this.Controls.Add(this.rtxbShellOutput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "clientForm";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxbShellOutput;
        private System.Windows.Forms.TextBox txbShellCommand;
    }
}