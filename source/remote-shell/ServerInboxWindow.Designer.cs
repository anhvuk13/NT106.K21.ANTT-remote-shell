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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerInboxWindow));
            this.serverInbox = new System.Windows.Forms.RichTextBox();
            this.serverInboxInput = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverInbox
            // 
            this.serverInbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverInbox.Location = new System.Drawing.Point(5, 5);
            this.serverInbox.Margin = new System.Windows.Forms.Padding(0);
            this.serverInbox.Name = "serverInbox";
            this.serverInbox.ReadOnly = true;
            this.serverInbox.Size = new System.Drawing.Size(474, 351);
            this.serverInbox.TabIndex = 1;
            this.serverInbox.TabStop = false;
            this.serverInbox.Text = "";
            this.serverInbox.TextChanged += new System.EventHandler(this.serverInbox_TextChanged);
            // 
            // serverInboxInput
            // 
            this.serverInboxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverInboxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverInboxInput.Location = new System.Drawing.Point(0, 0);
            this.serverInboxInput.Margin = new System.Windows.Forms.Padding(0);
            this.serverInboxInput.Multiline = true;
            this.serverInboxInput.Name = "serverInboxInput";
            this.serverInboxInput.Size = new System.Drawing.Size(424, 24);
            this.serverInboxInput.TabIndex = 0;
            this.serverInboxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serverInboxInput_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(424, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 24);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.serverInboxInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 332);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(474, 24);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ServerInboxWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.serverInbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerInboxWindow";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "ServerInboxWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerInboxWindow_FormClosing);
            this.Shown += new System.EventHandler(this.ServerInboxWindow_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox serverInbox;
        private System.Windows.Forms.TextBox serverInboxInput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}