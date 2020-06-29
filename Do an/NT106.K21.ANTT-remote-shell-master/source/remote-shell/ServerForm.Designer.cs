namespace remote_shell
{
    partial class ServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.tutorialText = new System.Windows.Forms.RichTextBox();
            this.btnInbox = new System.Windows.Forms.Button();
            this.btnShell = new System.Windows.Forms.Button();
            this.hostPort = new System.Windows.Forms.TextBox();
            this.btnHost = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Panel();
            this.btnLogs = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.filter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iPList = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tutorialPic = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialPic)).BeginInit();
            this.SuspendLayout();
            // 
            // tutorialText
            // 
            this.tutorialText.BackColor = System.Drawing.Color.Black;
            this.tutorialText.Dock = System.Windows.Forms.DockStyle.Top;
            this.tutorialText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialText.ForeColor = System.Drawing.Color.White;
            this.tutorialText.Location = new System.Drawing.Point(0, 136);
            this.tutorialText.Margin = new System.Windows.Forms.Padding(0);
            this.tutorialText.Name = "tutorialText";
            this.tutorialText.ReadOnly = true;
            this.tutorialText.Size = new System.Drawing.Size(1026, 118);
            this.tutorialText.TabIndex = 2;
            this.tutorialText.TabStop = false;
            this.tutorialText.Text = "Pick a port and click \"Host a connection\".\nAfterward, look for the above line in " +
    "your Command Prompt and you will find the Room ID there, forward it to your part" +
    "ner.";
            // 
            // btnInbox
            // 
            this.btnInbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInbox.Enabled = false;
            this.btnInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInbox.Location = new System.Drawing.Point(184, 308);
            this.btnInbox.Margin = new System.Windows.Forms.Padding(0);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(196, 247);
            this.btnInbox.TabIndex = 3;
            this.btnInbox.Text = "Chat with your partner";
            this.btnInbox.UseVisualStyleBackColor = true;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // btnShell
            // 
            this.btnShell.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShell.Enabled = false;
            this.btnShell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShell.Location = new System.Drawing.Point(0, 308);
            this.btnShell.Margin = new System.Windows.Forms.Padding(0);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(184, 247);
            this.btnShell.TabIndex = 2;
            this.btnShell.Text = "Supervise the shell";
            this.btnShell.UseVisualStyleBackColor = true;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // hostPort
            // 
            this.hostPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostPort.Location = new System.Drawing.Point(0, 0);
            this.hostPort.Margin = new System.Windows.Forms.Padding(0);
            this.hostPort.MaxLength = 5;
            this.hostPort.Multiline = true;
            this.hostPort.Name = "hostPort";
            this.hostPort.Size = new System.Drawing.Size(84, 54);
            this.hostPort.TabIndex = 1;
            this.hostPort.Text = "65535";
            this.hostPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hostPort_KeyDown);
            // 
            // btnHost
            // 
            this.btnHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHost.Location = new System.Drawing.Point(84, 0);
            this.btnHost.Margin = new System.Windows.Forms.Padding(0);
            this.btnHost.Name = "btnHost";
            this.btnHost.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnHost.Size = new System.Drawing.Size(1044, 54);
            this.btnHost.TabIndex = 4;
            this.btnHost.TabStop = false;
            this.btnHost.Text = "Host a connection";
            this.btnHost.UseVisualStyleBackColor = true;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Location = new System.Drawing.Point(130, 63);
            this.btnClient.Margin = new System.Windows.Forms.Padding(0);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(88, 43);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnServer.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnServer.Enabled = false;
            this.btnServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.Location = new System.Drawing.Point(12, 51);
            this.btnServer.Margin = new System.Windows.Forms.Padding(0);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(112, 55);
            this.btnServer.TabIndex = 0;
            this.btnServer.TabStop = false;
            this.btnServer.Text = "Server";
            this.btnServer.UseVisualStyleBackColor = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.Highlight;
            this.header.Controls.Add(this.btnLogs);
            this.header.Controls.Add(this.btnClient);
            this.header.Controls.Add(this.btnServer);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1026, 108);
            this.header.TabIndex = 8;
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogs.Location = new System.Drawing.Point(226, 63);
            this.btnLogs.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(88, 43);
            this.btnLogs.TabIndex = 1;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = false;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.hostPort, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnHost, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 254);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1026, 54);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // filter
            // 
            this.filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.filter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.filter.Dock = System.Windows.Forms.DockStyle.Right;
            this.filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.FormattingEnabled = true;
            this.filter.Items.AddRange(new object[] {
            "None",
            "Permit IPs ",
            "Deny IPs"});
            this.filter.Location = new System.Drawing.Point(491, 308);
            this.filter.Margin = new System.Windows.Forms.Padding(0);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(176, 40);
            this.filter.TabIndex = 14;
            this.filter.TabStop = false;
            this.filter.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(667, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "IPs List:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iPList
            // 
            this.iPList.Dock = System.Windows.Forms.DockStyle.Right;
            this.iPList.Enabled = false;
            this.iPList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iPList.Location = new System.Drawing.Point(782, 308);
            this.iPList.Margin = new System.Windows.Forms.Padding(0);
            this.iPList.Name = "iPList";
            this.iPList.Size = new System.Drawing.Size(244, 247);
            this.iPList.TabIndex = 11;
            this.iPList.TabStop = false;
            this.iPList.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 308);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Filter:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(381, 465);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(399, 91);
            this.btnClose.TabIndex = 16;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close the connection";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tutorialPic
            // 
            this.tutorialPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tutorialPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tutorialPic.Image = global::remote_shell.Properties.Resources.tutorial;
            this.tutorialPic.Location = new System.Drawing.Point(0, 108);
            this.tutorialPic.Margin = new System.Windows.Forms.Padding(0);
            this.tutorialPic.Name = "tutorialPic";
            this.tutorialPic.Size = new System.Drawing.Size(1026, 28);
            this.tutorialPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tutorialPic.TabIndex = 0;
            this.tutorialPic.TabStop = false;
            this.tutorialPic.Tag = "Room ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(580, 374);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 91);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Update the IPs list";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(381, 374);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(200, 91);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Text = "Refresh the IPs list";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 555);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInbox);
            this.Controls.Add(this.btnShell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iPList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tutorialText);
            this.Controls.Add(this.tutorialPic);
            this.Controls.Add(this.header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerForm_FormClosing);
            this.header.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tutorialPic;
        private System.Windows.Forms.RichTextBox tutorialText;
        private System.Windows.Forms.Button btnInbox;
        private System.Windows.Forms.Button btnShell;
        private System.Windows.Forms.TextBox hostPort;
        private System.Windows.Forms.Button btnHost;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox iPList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogs;
    }
}