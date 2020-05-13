namespace remote_shell
{
    partial class ServerShellWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerShellWindow));
            this.localShell = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // localShell
            // 
            this.localShell.BackColor = System.Drawing.Color.Black;
            this.localShell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.localShell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.localShell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localShell.ForeColor = System.Drawing.Color.White;
            this.localShell.Location = new System.Drawing.Point(5, 5);
            this.localShell.Margin = new System.Windows.Forms.Padding(0);
            this.localShell.Name = "localShell";
            this.localShell.ReadOnly = true;
            this.localShell.Size = new System.Drawing.Size(574, 351);
            this.localShell.TabIndex = 0;
            this.localShell.TabStop = false;
            this.localShell.Text = "";
            this.localShell.TextChanged += new System.EventHandler(this.localShell_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(5, 330);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(574, 26);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ServerShellWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.localShell);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerShellWindow";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "ServerShellWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerShellWindow_FormClosing);
            this.Shown += new System.EventHandler(this.ServerShellWindow_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox localShell;
        private System.Windows.Forms.Button btnClear;
    }
}