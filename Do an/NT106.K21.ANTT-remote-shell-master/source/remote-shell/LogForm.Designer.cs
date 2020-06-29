namespace remote_shell
{
    partial class LogForm
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
            this.header = new System.Windows.Forms.Panel();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.lstvLog = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTimeStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTimeEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.Highlight;
            this.header.Controls.Add(this.btnServer);
            this.header.Controls.Add(this.btnLog);
            this.header.Controls.Add(this.btnClient);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1048, 108);
            this.header.TabIndex = 9;
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.Location = new System.Drawing.Point(36, 63);
            this.btnServer.Margin = new System.Windows.Forms.Padding(0);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(88, 43);
            this.btnServer.TabIndex = 2;
            this.btnServer.Text = "Server";
            this.btnServer.UseVisualStyleBackColor = false;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLog.Enabled = false;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(225, 51);
            this.btnLog.Margin = new System.Windows.Forms.Padding(0);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(112, 55);
            this.btnLog.TabIndex = 1;
            this.btnLog.TabStop = false;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = false;
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
            // lstvLog
            // 
            this.lstvLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmTimeStart,
            this.clmTimeEnd,
            this.clmSize});
            this.lstvLog.HideSelection = false;
            this.lstvLog.Location = new System.Drawing.Point(0, 111);
            this.lstvLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstvLog.Name = "lstvLog";
            this.lstvLog.Size = new System.Drawing.Size(1046, 418);
            this.lstvLog.TabIndex = 3;
            this.lstvLog.UseCompatibleStateImageBehavior = false;
            this.lstvLog.View = System.Windows.Forms.View.Details;
            this.lstvLog.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstvLog_ColumnClick);
            this.lstvLog.DoubleClick += new System.EventHandler(this.lstvLog_DoubleClick);
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 169;
            // 
            // clmTimeStart
            // 
            this.clmTimeStart.Text = "Time Start";
            this.clmTimeStart.Width = 161;
            // 
            // clmTimeEnd
            // 
            this.clmTimeEnd.Text = "Time End";
            this.clmTimeEnd.Width = 154;
            // 
            // clmSize
            // 
            this.clmSize.Text = "Size";
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 532);
            this.Controls.Add(this.lstvLog);
            this.Controls.Add(this.header);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogForm";
            this.Text = "LogForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogForm_FormClosing);
            this.Load += new System.EventHandler(this.LogForm_Load);
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.ListView lstvLog;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmTimeStart;
        private System.Windows.Forms.ColumnHeader clmTimeEnd;
        private System.Windows.Forms.ColumnHeader clmSize;
        private System.Windows.Forms.Button btnClient;
    }
}