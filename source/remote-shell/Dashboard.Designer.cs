namespace remote_shell
{
    partial class Dashboard
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
            this.btnServer = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.hostPort = new System.Windows.Forms.TextBox();
            this.roomID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(44, 38);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(122, 34);
            this.btnServer.TabIndex = 1;
            this.btnServer.TabStop = false;
            this.btnServer.Text = "Host a connection";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(130, 101);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(133, 34);
            this.btnClient.TabIndex = 3;
            this.btnClient.TabStop = false;
            this.btnClient.Text = "Connect to your partner";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // hostPort
            // 
            this.hostPort.Location = new System.Drawing.Point(44, 12);
            this.hostPort.Name = "hostPort";
            this.hostPort.Size = new System.Drawing.Size(100, 20);
            this.hostPort.TabIndex = 0;
            this.hostPort.Text = "Port";
            this.hostPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hostPort_KeyDown);
            // 
            // roomID
            // 
            this.roomID.Location = new System.Drawing.Point(130, 141);
            this.roomID.Name = "roomID";
            this.roomID.Size = new System.Drawing.Size(100, 20);
            this.roomID.TabIndex = 1;
            this.roomID.Text = "Room ID";
            this.roomID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.roomID_KeyDown);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 202);
            this.Controls.Add(this.roomID);
            this.Controls.Add(this.hostPort);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnServer);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.TextBox hostPort;
        private System.Windows.Forms.TextBox roomID;
    }
}

