namespace remote_shell
{
    partial class serverForm
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
            this.txbInp = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txbInp
            // 
            this.txbInp.BackColor = System.Drawing.SystemColors.ControlText;
            this.txbInp.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txbInp.Location = new System.Drawing.Point(40, 44);
            this.txbInp.Name = "txbInp";
            this.txbInp.Size = new System.Drawing.Size(523, 30);
            this.txbInp.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.richTextBox1.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.richTextBox1.Location = new System.Drawing.Point(40, 94);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(523, 239);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // serverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(603, 384);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txbInp);
            this.Name = "serverForm";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.serverForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbInp;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}