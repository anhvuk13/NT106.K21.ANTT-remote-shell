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
        }

        private void remoteInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string data = remoteInput.Text.TrimStart(new char[] { '\r', '\n' });
                Storage.TextBoxClear(remoteInput);

                if (data == "cls" || data == "clear")
                    btnClear.PerformClick();

                if (data == "") return;

                NetworkStream stream = new NetworkStream(clientSocket.Client, false);
                byte[] buffer = Encoding.UTF8.GetBytes($"s{data}");
                stream.Write(buffer, 0, buffer.Length);
                stream.Close();
            }

            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
            {
                NetworkStream stream = new NetworkStream(clientSocket.Client, false);
                byte[] buffer = Encoding.UTF8.GetBytes("sCTRL+C");
                stream.Write(buffer, 0, buffer.Length);
                stream.Close();
            }
        }

        private void ClientShellWindow_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void remoteShell_Click(object sender, EventArgs e)
        {
            remoteInput.Focus();
        }
    }
}
