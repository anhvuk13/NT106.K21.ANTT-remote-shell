using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace remote_shell
{
    public partial class ServerForm : Form
    {
        private Dashboard parent;
        private ServerShellWindow serverShellWindow = null;
        private ServerInboxWindow serverInboxWindow = null;
        private TcpListener serverSocket = null;
        private TcpClient clientSocket = null;
        private Thread serverThread;
        private Thread listenThread = null;
        private string port;
        public string serverShell = "";
        public string serverInbox = "";

        public ServerForm(Dashboard parent, string port)
        {
            InitializeComponent();
            this.parent = parent;
            this.port = port;
        }

        private void ServerForm_Shown(object sender, EventArgs e)
        {
            try
            {
                serverSocket = new TcpListener(IPAddress.Any, Int32.Parse(port));
            }
            catch
            {
                MessageBox.Show("The port is invalid or already in use.", "Error");
                this.Close();
                return;
            }

            Process.Start("cmd", $" /C ngrok tcp {((IPEndPoint)serverSocket.LocalEndpoint).Port}");
            //ServerThread();
            serverThread = new Thread(o => ServerThread(
                this//,
                //serverSocket, clientSocket,
                //serverShellWindow, serverInboxWindow,
                //listenThread, 
                //btnShell, btnInbox,
                //ref serverShell, ref serverInbox
            ));
            serverThread.Start();
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
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

            if (listenThread != null) listenThread.Abort();
            if (serverShellWindow != null)
                serverShellWindow.Invoke(new MethodInvoker(delegate ()
                {
                    serverShellWindow.Close();
                }));
            if (serverInboxWindow != null)
                serverInboxWindow.Invoke(new MethodInvoker(delegate ()
                {
                    serverInboxWindow.Close();
                }));
            if (serverSocket != null) serverSocket.Stop();
            parent.Show();
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            btnShell.Enabled = false;
            serverShellWindow.Invoke(new MethodInvoker(delegate ()
            {
                serverShellWindow.Show();
            }));
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            btnInbox.Enabled = false;
            serverInboxWindow.Invoke(new MethodInvoker(delegate ()
            {
                serverInboxWindow.Show();
            }));
        }

        // Thread
        private void ServerThread
        (
            ServerForm main//,
            //TcpListener serverSocket, TcpClient clientSocket,
            //ServerShellWindow serverShellWindow, ServerInboxWindow serverInboxWindow,
            //Thread listenThread,
            //Button btnShell, Button btnInbox,
            //ref string serverShell, ref string serverInbox
        ) {
            main.serverSocket.Start();
            try
            {
                main.clientSocket = serverSocket.AcceptTcpClient();
            } catch(SocketException e)
            {
                return;
            }
            main.serverShellWindow = new ServerShellWindow(this, btnShell);
            main.Invoke(new MethodInvoker(delegate ()
            {
                main.serverShellWindow.Show();
            }));
            main.serverInboxWindow = new ServerInboxWindow(this, clientSocket, btnInbox);
            main.Invoke(new MethodInvoker(delegate ()
            {
                main.serverInboxWindow.Show();
            }));
            main.listenThread = new Thread(o => ListenThread(
                main//, clientSocket, /*serverShellWindow, serverInboxWindow, */btnShell, btnInbox, ref serverShell, serverInbox
            ));
            listenThread.Start();
        }

        private void ListenThread(
            ServerForm main
            //TcpClient clientSocket,
            //ServerShellWindow serverShellWindow, ServerInboxWindow serverInboxWindow,
            //Button btnShell, Button btnInbox,
            //ref string serverShell, ref string serverInbox
        ) {
            Storage.BtnEnabledInvoke(main.btnShell, true);
            Storage.BtnEnabledInvoke(main.btnInbox, true);
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
                    (new Thread(o => InboxReceiveThread(main, data))).Start();//serverInboxWindow, ref serverInbox, data))).Start();

                else if (data[0] == 's')
                    (new Thread(o => ShellReceiveThread(main, data))).Start();//clientSocket, serverShellWindow, ref serverShell, data))).Start();
            }
            stream.Close();
            Storage.BtnEnabledInvoke(main.btnShell, false);
            Storage.BtnEnabledInvoke(main.btnInbox, false);
        }

        private void ShellReceiveThread(
            ServerForm main, string data//TcpClient clientSocket, ServerShellWindow serverShellWindow, ref string serverShell, string data
        ) {
            data = data.Substring(1);
            main.serverShell += $"{data}\n";
            main.serverShellWindow.UpdateShell($"{data}\n");

            data = "Hồi đáp shell";
            main.serverShell += $"{data}\n";
            main.serverShellWindow.UpdateShell($"{data}\n");

            NetworkStream stream = new NetworkStream(main.clientSocket.Client, false);
            byte[] buffer = Encoding.UTF8.GetBytes($"s{data}");
            stream.Write(buffer, 0, buffer.Length);
            stream.Close();
        }

        private void InboxReceiveThread(ServerForm main, string data)//ServerInboxWindow serverInboxWindow, ref string serverInbox, string data)
        {
            data = $"Partner: {data.Substring(1)}\n";
            main.serverInbox += data;
            main.serverInboxWindow.UpdateInbox(data);
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
