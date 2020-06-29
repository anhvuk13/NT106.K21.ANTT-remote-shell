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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.btnShell = new System.Windows.Forms.Button();
            this.btnInbox = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Panel();
            this.serverPort = new System.Windows.Forms.TextBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tutorialText = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.serverHost = new System.Windows.Forms.TextBox();
            this.header.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShell
            // 
            this.btnShell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShell.Enabled = false;
            this.btnShell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShell.Location = new System.Drawing.Point(0, 0);
            this.btnShell.Margin = new System.Windows.Forms.Padding(0);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(227, 178);
            this.btnShell.TabIndex = 2;
            this.btnShell.Text = "Manipulate the\nRemote Shell";
            this.btnShell.UseVisualStyleBackColor = true;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // btnInbox
            // 
            this.btnInbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInbox.Enabled = false;
            this.btnInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInbox.Location = new System.Drawing.Point(227, 0);
            this.btnInbox.Margin = new System.Windows.Forms.Padding(0);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(228, 178);
            this.btnInbox.TabIndex = 3;
            this.btnInbox.Text = "Enter the conversation";
            this.btnInbox.UseVisualStyleBackColor = true;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // btnServer
            // 
            this.btnServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.Location = new System.Drawing.Point(8, 41);
            this.btnServer.Margin = new System.Windows.Forms.Padding(0);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(59, 28);
            this.btnServer.TabIndex = 0;
            this.btnServer.Text = "Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClient.Enabled = false;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Location = new System.Drawing.Point(71, 33);
            this.btnClient.Margin = new System.Windows.Forms.Padding(0);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(75, 36);
            this.btnClient.TabIndex = 3;
            this.btnClient.TabStop = false;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.Highlight;
            this.header.Controls.Add(this.btnServer);
            this.header.Controls.Add(this.btnClient);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(684, 70);
            this.header.TabIndex = 5;
            // 
            // serverPort
            // 
            this.serverPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverPort.Location = new System.Drawing.Point(200, 0);
            this.serverPort.Margin = new System.Windows.Forms.Padding(0);
            this.serverPort.MaxLength = 5;
            this.serverPort.Multiline = true;
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(56, 35);
            this.serverPort.TabIndex = 1;
            this.serverPort.Text = "12345";
            this.serverPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.serverPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.roomID_KeyDown);
            // 
            // btnJoin
            // 
            this.btnJoin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.Location = new System.Drawing.Point(256, 0);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(0);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(440, 35);
            this.btnJoin.TabIndex = 7;
            this.btnJoin.TabStop = false;
            this.btnJoin.Text = "Connect to your partner";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 440F));
            this.tableLayoutPanel1.Controls.Add(this.serverHost, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnJoin, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.serverPort, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 148);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 35);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tutorialText
            // 
            this.tutorialText.BackColor = System.Drawing.Color.Black;
            this.tutorialText.Dock = System.Windows.Forms.DockStyle.Top;
            this.tutorialText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialText.ForeColor = System.Drawing.Color.White;
            this.tutorialText.Location = new System.Drawing.Point(0, 70);
            this.tutorialText.Margin = new System.Windows.Forms.Padding(0);
            this.tutorialText.Name = "tutorialText";
            this.tutorialText.ReadOnly = true;
            this.tutorialText.Size = new System.Drawing.Size(684, 78);
            this.tutorialText.TabIndex = 11;
            this.tutorialText.TabStop = false;
            this.tutorialText.Text = "Ask your partner the Room ID.\nFill the below box and press \"Connect to your partn" +
    "er\".";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.Controls.Add(this.btnClose, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnShell, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInbox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 183);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(684, 178);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Enabled = false;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(455, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(229, 178);
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Disconnect";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // serverHost
            // 
            this.serverHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverHost.Location = new System.Drawing.Point(0, 0);
            this.serverHost.Margin = new System.Windows.Forms.Padding(0);
            this.serverHost.Multiline = true;
            this.serverHost.Name = "serverHost";
            this.serverHost.Size = new System.Drawing.Size(200, 35);
            this.serverHost.TabIndex = 8;
            this.serverHost.Text = "0.tcp.ngrok.io";
            this.serverHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tutorialText);
            this.Controls.Add(this.header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.header.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShell;
        private System.Windows.Forms.Button btnInbox;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.TextBox serverPort;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox tutorialText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox serverHost;
    }
}