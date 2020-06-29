using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace remote_shell
{
    public partial class ClientForm : Form
    {
        private Dashboard parent;
        private ServerForm server = null;
        private ClientShellWindow clientShellWindow = null;
        private ClientInboxWindow clientInboxWindow = null;
        private TcpClient clientSocket = null;
        private Thread listenThread = null;
        private string publicIP;
        public string clientShell = "";
        public string clientInbox = "";

        public ClientForm(Dashboard parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.publicIP = Storage.GetIPAddress();
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            __destructor();
            if (server == null) parent.Show();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            clientSocket = new TcpClient();
            try
            {
                clientSocket.Connect(Dns.Resolve(serverHost.Text).AddressList, Int32.Parse(serverPort.Text));
            }
            catch
            {
                MessageBox.Show("Wrong Room ID or unavailable partner.", "Error");
                clientSocket = null;
                return;
            }

            clientShellWindow = new ClientShellWindow(this, clientSocket, btnShell);
            clientShellWindow.Show();
            clientInboxWindow = new ClientInboxWindow(this, clientSocket, btnInbox);
            clientInboxWindow.Show();
            listenThread = new Thread(o => ListenThread(this));
            listenThread.Start();

            NetworkStream stream = new NetworkStream(clientSocket.Client, false);
            byte[] buffer = Encoding.UTF8.GetBytes(publicIP);
            stream.Write(buffer, 0, buffer.Length);
            stream.Close();

            serverPort.Enabled = btnJoin.Enabled = false;
            btnShell.Enabled = btnInbox.Enabled = btnClose.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            __destructor();
            btnJoin.Enabled = serverPort.Enabled = true;
            btnShell.Enabled = btnInbox.Enabled = btnClose.Enabled = false;
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            btnShell.Enabled = false;
            clientShellWindow.Show();
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            btnInbox.Enabled = false;
            clientInboxWindow.Show();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            server = new ServerForm(parent);
            server.Show();
            this.Close();
        }

        // Thread
        private void ListenThread(ClientForm main)
        {
            NetworkStream stream = new NetworkStream(main.clientSocket.Client, false);
            byte[] buffer = new byte[1024];
            while (Thread.CurrentThread.IsAlive)
            {
                int bytesCount = 0;
                try
                {
                    bytesCount = stream.Read(buffer, 0, buffer.Length);
                } catch { }
                if (bytesCount == 0) break;
                string data = Encoding.UTF8.GetString(buffer, 0, bytesCount);

                if (data[0] == 'i')
                    (new Thread(o => InboxReceiveThread(main, data))).Start();//clientInboxWindow, clientInbox, data))).Start();

                else if (data[0] == 's')
                    (new Thread(o => ShellReceiveThread(main, data))).Start();//clientShellWindow, clientShell, data))).Start();

                else if (data == @"!@#$%^&*()_+EXIT!@#$%^&*()_+")
                {
                    (new Thread(o => PartnerLeft('e'))).Start();
                    break;
                }

                else if (data == @"!@#$%^&*()_+DENY!@#$%^&*()_+")
                {
                    (new Thread(o => PartnerLeft('d'))).Start();
                    break;
                }
            }
            stream.Close();
        }

        private void ShellReceiveThread(ClientForm main, string data)//ClientShellWindow clientShellWindow, string clientShell, string data)
        {
            data = data.Substring(3).Replace("\ns/_", "\n");
            main.clientShell += data;
            main.clientShellWindow.UpdateShell(data);
        }

        private void InboxReceiveThread(ClientForm main, string data)//ClientInboxWindow clientInboxWindow, string clientInbox, string data)
        {
            data = $"Partner: {data.Substring(1)}";
            main.clientInbox += data;
            main.clientInboxWindow.UpdateInbox(data);
        }

        // Func
        private void __destructor()
        {
            if (clientSocket != null)
                try
                {
                    NetworkStream stream = new NetworkStream(clientSocket.Client, false);
                    byte[] buffer = Encoding.UTF8.GetBytes(@"!@#$%^&*()_+EXIT!@#$%^&*()_+");
                    stream.Write(buffer, 0, buffer.Length);
                    stream.Close();
                }
                catch { }

            if (listenThread != null)
            {
                listenThread.Abort();
                listenThread = null;
            }
            if (clientShellWindow != null)
            {
                clientShellWindow.Close();
                clientShellWindow = null;
            }
            if (clientInboxWindow != null)
            {
                clientInboxWindow.Close();
                clientInboxWindow = null;
            }
            if (clientSocket != null)
            {
                try
                {
                    clientSocket.Client.Shutdown(SocketShutdown.Both);
                }
                catch { }
                clientSocket.Close();
                clientSocket = null;
            }
        }

        private void PartnerLeft(char c)
        {
            btnClose.Invoke(new MethodInvoker(delegate ()
            {
                btnClose.PerformClick();
            }));
            string s = (c == 'e') ? "Your partner is away." : "Your IP is denied.";
            MessageBox.Show(s, "Exit");
            if (clientSocket != null) clientSocket.Close();
            clientSocket = null;
        }

        private void roomID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnJoin.PerformClick();
        }
    }
}
