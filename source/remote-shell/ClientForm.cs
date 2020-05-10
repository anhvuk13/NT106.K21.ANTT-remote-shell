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
        private ClientShellWindow clientShellWindow = null;
        private ClientInboxWindow clientInboxWindow = null;
        private TcpClient clientSocket = null;
        private Thread listenThread = null;
        private string room;
        public string clientShell = "";
        public string clientInbox = "";

        public ClientForm(Dashboard parent, string room)
        {
            InitializeComponent();
            this.parent = parent;
            this.room = room;
        }

        private void ClientForm_Shown(object sender, EventArgs e)
        {
            clientSocket = new TcpClient();
            try
            {
                clientSocket.Connect(Dns.Resolve("0.tcp.ngrok.io").AddressList, Int32.Parse(room));
            }
            catch
            {
                MessageBox.Show("Wrong Room ID or unavailable partner.", "Error");
                this.Close();
                return;
            }
            clientShellWindow = new ClientShellWindow(this, clientSocket, btnShell);
            clientShellWindow.Show();
            clientInboxWindow = new ClientInboxWindow(this, clientSocket, btnInbox);
            clientInboxWindow.Show();
            listenThread = new Thread(o => ListenThread(
                this//clientSocket, clientShellWindow, clientInboxWindow, clientShell, clientInbox
            ));
            listenThread.Start();
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clientSocket != null)
                try
                {
                    NetworkStream stream = new NetworkStream(clientSocket.Client, false);
                    byte[] buffer = Encoding.UTF8.GetBytes(@"!@#$%^&*()_+EXIT!@#$%^&*()_+");
                    stream.Write(buffer, 0, buffer.Length);
                    stream.Close();
                } catch { }

            if (listenThread != null) listenThread.Abort();
            if (clientShellWindow != null) clientShellWindow.Close();
            if (clientInboxWindow != null) clientInboxWindow.Close();
            if (clientSocket != null)
            {
                try
                {
                    clientSocket.Client.Shutdown(SocketShutdown.Both);
                } catch { }
                clientSocket.Close();
            }
            parent.Show();
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

        private void ListenThread(
            ClientForm main
        //TcpClient clientSocket,
        //ClientShellWindow clientShellWindow, ClientInboxWindow clientInboxWindow,
        //string clientShell, string clientInbox
        ) {
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

                if (data == @"!@#$%^&*()_+EXIT!@#$%^&*()_+")
                {
                    (new Thread(PartnerLeft)).Start();
                    break;
                }

                else if (data[0] == 'i')
                    (new Thread(o => InboxReceiveThread(main, data))).Start();//clientInboxWindow, clientInbox, data))).Start();

                else if (data[0] == 's')
                    (new Thread(o => ShellReceiveThread(main, data))).Start();//clientShellWindow, clientShell, data))).Start();
            }
            stream.Close();
        }

        private void ShellReceiveThread(ClientForm main, string data)//ClientShellWindow clientShellWindow, string clientShell, string data)
        {
            data = $"{data.Substring(1)}\n";
            main.clientShell += data;
            main.clientShellWindow.UpdateShell(data);
        }

        private void InboxReceiveThread(ClientForm main, string data)//ClientInboxWindow clientInboxWindow, string clientInbox, string data)
        {
            data = $"Partner: {data.Substring(1)}\n";
            main.clientInbox += data;
            main.clientInboxWindow.UpdateInbox(data);
        }

        public void PartnerLeft()
        {
            MessageBox.Show("Your partner is away.", "Exit");
            this.Invoke(new MethodInvoker(delegate ()
            {
                this.Close();
            }));
        }
    }
}
