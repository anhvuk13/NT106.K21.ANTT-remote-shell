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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientShellWindow));
            this.remoteShell = new System.Windows.Forms.RichTextBox();
            this.remoteInput = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // remoteShell
            // 
            this.remoteShell.BackColor = System.Drawing.Color.Black;
            this.remoteShell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.remoteShell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remoteShell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remoteShell.ForeColor = System.Drawing.Color.White;
            this.remoteShell.Location = new System.Drawing.Point(5, 5);
            this.remoteShell.Margin = new System.Windows.Forms.Padding(0);
            this.remoteShell.Name = "remoteShell";
            this.remoteShell.ReadOnly = true;
            this.remoteShell.Size = new System.Drawing.Size(574, 351);
            this.remoteShell.TabIndex = 0;
            this.remoteShell.TabStop = false;
            this.remoteShell.Text = "";
            this.remoteShell.Click += new System.EventHandler(this.remoteShell_Click);
            this.remoteShell.TextChanged += new System.EventHandler(this.remoteShell_TextChanged);
            // 
            // remoteInput
            // 
            this.remoteInput.BackColor = System.Drawing.Color.Black;
            this.remoteInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.remoteInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remoteInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remoteInput.ForeColor = System.Drawing.Color.White;
            this.remoteInput.Location = new System.Drawing.Point(0, 0);
            this.remoteInput.Margin = new System.Windows.Forms.Padding(0);
            this.remoteInput.Multiline = true;
            this.remoteInput.Name = "remoteInput";
            this.remoteInput.Size = new System.Drawing.Size(524, 24);
            this.remoteInput.TabIndex = 0;
            this.remoteInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.remoteInput_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(524, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 24);
            this.btnClear.TabIndex = 1;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.remoteInput, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 332);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 24);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ClientShellWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.remoteShell);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientShellWindow";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "ClientShellWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientShellWindow_FormClosing);
            this.Shown += new System.EventHandler(this.ClientShellWindow_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox remoteShell;
        private System.Windows.Forms.TextBox remoteInput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}