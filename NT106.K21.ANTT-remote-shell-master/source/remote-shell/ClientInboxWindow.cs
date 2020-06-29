using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace remote_shell
{
    public partial class ClientInboxWindow : Form
    {
        private ClientForm parent;
        private TcpClient clientSocket;
        private Button btnInbox;

        public ClientInboxWindow(ClientForm parent, TcpClient clientSocket, Button btnInbox)
        {
            InitializeComponent();
            this.parent = parent;
            this.clientSocket = clientSocket;
            this.btnInbox = btnInbox;
        }

        private void ClientInboxWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            Storage.BtnEnabledInvoke(btnInbox, true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clientInbox.Clear();
            parent.clientInbox = "";
        }

        private void clientInbox_TextChanged(object sender, EventArgs e)
        {
            clientInbox.SelectionStart = clientInbox.Text.Length;
            clientInbox.ScrollToCaret();
        }

        public void UpdateInbox(string clientInbox)
        {
            Storage.RichTextBoxAppend(this.clientInbox, clientInbox);
        }

        private void clientInboxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) (new Thread(o => SendInbox(parent, this, clientSocket))).Start();
        }

        private void SendInbox(ClientForm parent, ClientInboxWindow main, TcpClient clientSocket)
        {
            string data = main.clientInboxInput.Text;
            Storage.RichTextBoxAppend(main.clientInbox, $"You: {data}");
            parent.clientInbox += $"You: {data}";

            NetworkStream stream = new NetworkStream(clientSocket.Client, false);
            byte[] buffer = Encoding.UTF8.GetBytes($"i{data}");
            stream.Write(buffer, 0, buffer.Length);
            stream.Close();

            Storage.TextBoxClear(main.clientInboxInput);
        }

        private void ClientInboxWindow_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
