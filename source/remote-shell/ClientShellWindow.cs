using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace remote_shell
{
    public partial class ClientShellWindow : Form
    {
        private ClientForm parent;
        private TcpClient clientSocket;
        private Button btnShell;

        public ClientShellWindow(ClientForm parent, TcpClient clientSocket, Button btnShell)
        {
            InitializeComponent();
            this.parent = parent;
            this.clientSocket = clientSocket;
            this.btnShell = btnShell;
        }

        private void ClientShellWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            Storage.BtnEnabledInvoke(btnShell, true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            remoteShell.Clear();
            parent.clientShell = "";
        }

        private void remoteShell_TextChanged(object sender, EventArgs e)
        {
            remoteShell.SelectionStart = remoteShell.Text.Length;
            remoteShell.ScrollToCaret();
        }

        public void UpdateShell(string clientShell)
        {
            Storage.RichTextBoxAppend(remoteShell, clientShell);
            remoteInput.Invoke(new MethodInvoker(delegate ()
            {
                remoteInput.Enabled = true;
                remoteInput.Focus();
            }));
        }

        private void remoteInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                remoteInput.Enabled = false;
                string data = remoteInput.Text;
                Storage.RichTextBoxAppend(remoteShell, $"{data}\n");
                parent.clientShell += $"{data}\n";

                NetworkStream stream = new NetworkStream(clientSocket.Client, false);
                byte[] buffer = Encoding.UTF8.GetBytes($"s{data}");
                stream.Write(buffer, 0, buffer.Length);
                stream.Close();

                Storage.TextBoxClear(remoteInput);
            }
        }

        private void ClientShellWindow_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
