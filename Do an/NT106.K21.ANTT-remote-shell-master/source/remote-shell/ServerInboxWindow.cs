using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace remote_shell
{
    public partial class ServerInboxWindow : Form
    {
        private ServerForm parent;
        private TcpClient clientSocket;
        private Button btnInbox;

        public ServerInboxWindow(ServerForm parent, TcpClient clientSocket, Button btnInbox)
        {
            InitializeComponent();
            this.parent = parent;
            this.clientSocket = clientSocket;
            this.btnInbox = btnInbox;
        }

        private void ServerInboxWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            Storage.BtnEnabledInvoke(btnInbox, true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            serverInbox.Clear();
            parent.serverInbox = "";
        }

        private void serverInbox_TextChanged(object sender, EventArgs e)
        {
            serverInbox.SelectionStart = serverInbox.Text.Length;
            serverInbox.ScrollToCaret();
        }

        public void UpdateInbox(string serverInbox)
        {
            Storage.RichTextBoxAppend(this.serverInbox, serverInbox);
        }

        private void serverInboxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) (new Thread(o => SendInbox(parent, this, clientSocket))).Start();
        }

        private void SendInbox(ServerForm parent, ServerInboxWindow main, TcpClient clientSocket)
        { 
            string data = main.serverInboxInput.Text;
            Storage.RichTextBoxAppend(main.serverInbox, $"You: {data}");
            parent.serverInbox = $"You: {data}";

            NetworkStream stream = new NetworkStream(clientSocket.Client, false);
            byte[] buffer = Encoding.UTF8.GetBytes($"i{data}");
            stream.Write(buffer, 0, buffer.Length);
            stream.Close();

            Storage.TextBoxClear(main.serverInboxInput);
        }

        private void ServerInboxWindow_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
