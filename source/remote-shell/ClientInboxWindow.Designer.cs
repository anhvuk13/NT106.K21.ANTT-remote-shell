namespace remote_shell
{
    partial class ClientInboxWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientInboxWindow));
            this.btnClear = new System.Windows.Forms.Button();
            this.clientInboxInput = new System.Windows.Forms.TextBox();
            this.clientInbox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(424, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 24);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // clientInboxInput
            // 
            this.clientInboxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientInboxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientInboxInput.Location = new System.Drawing.Point(0, 0);
            this.clientInboxInput.Margin = new System.Windows.Forms.Padding(0);
            this.clientInboxInput.Multiline = true;
            this.clientInboxInput.Name = "clientInboxInput";
            this.clientInboxInput.Size = new System.Drawing.Size(424, 24);
            this.clientInboxInput.TabIndex = 2;
            this.clientInboxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientInboxInput_KeyDown);
            // 
            // clientInbox
            // 
            this.clientInbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientInbox.Location = new System.Drawing.Point(5, 5);
            this.clientInbox.Margin = new System.Windows.Forms.Padding(0);
            this.clientInbox.Name = "clientInbox";
            this.clientInbox.ReadOnly = true;
            this.clientInbox.Size = new System.Drawing.Size(474, 351);
            this.clientInbox.TabIndex = 4;
            this.clientInbox.TabStop = false;
            this.clientInbox.Text = "";
            this.clientInbox.TextChanged += new System.EventHandler(this.clientInbox_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.clientInboxInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 332);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(474, 24);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // ClientInboxWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.clientInbox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientInboxWindow";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "ClientInboxWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientInboxWindow_FormClosing);
            this.Shown += new System.EventHandler(this.ClientInboxWindow_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox clientInboxInput;
        private System.Windows.Forms.RichTextBox clientInbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}