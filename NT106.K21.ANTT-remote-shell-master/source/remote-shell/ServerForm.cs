using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace remote_shell
{
    public partial class ServerForm : Form
    {
        private Dashboard parent;
        private ClientForm client = null;
        private ServerShellWindow serverShellWindow = null;
        private ServerInboxWindow serverInboxWindow = null;
        private TcpListener serverSocket = null;
        private TcpClient clientSocket = null;
        private Thread listenThread = null;
        private Terminal terminal = null;
        public string serverShell = "";
        public string serverInbox = "";
        private string path;
        private List<IPAddress> ips;
        Log log;

        public ServerForm(Dashboard parent)
        {
            InitializeComponent();
            this.parent = parent;
            filter.SelectedIndex = 0;
            path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            __destructor();
            if (client == null) parent.Show();
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterChanged();
            if (filter.SelectedIndex != 0) btnRefresh.PerformClick();
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            try
            {
                serverSocket = new TcpListener(IPAddress.Any, Int32.Parse(hostPort.Text));
            }
            catch
            {
                MessageBox.Show("The port is invalid or already in use.", "Error");
                serverSocket = null;
                return;
            }

            HostPortChanged(false);

            Process.Start("cmd", $" /C ngrok tcp {((IPEndPoint)serverSocket.LocalEndpoint).Port}");
            (new Thread(o => ServerThread(this))).Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.Text = "ServerForm";
                }));
            else this.Text = "ServerForm";
            __destructor();
            ConnectionChanged(false);
            HostPortChanged(true);
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

        private void btnClient_Click(object sender, EventArgs e)
        {
            client = new ClientForm(parent);
            client.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string path = GetPath();
            if (!File.Exists(path))
                (File.Create(path)).Close();
            try
            {
                ips = new List<IPAddress>();
                foreach (var line in iPList.Lines)
                {
                    IPAddress temp;
                    if (IPAddress.TryParse(line, out temp))
                        ips.Add(temp);
                }
            }
            catch
            {
                MessageBox.Show("You haven't typed any IPs in the box or some of them are invalid.", "Error");
                return;
            }
            FileStream fs = new FileStream(GetPath(), FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ips);
            fs.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string path = GetPath();
            if (!File.Exists(path))
            {
                ips = new List<IPAddress>();
                (File.Create(path)).Close();
                MessageBox.Show($"Created a new empty file: {path}", "Create");
                return;
            }
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                ips = (List<IPAddress>)bf.Deserialize(fs);
            }
            catch
            {
                fs.Close();
                ips = new List<IPAddress>();
                DialogResult answer = MessageBox.Show("Your file is empty or corrupted. Do you want to format it?", "Error", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes) (File.Create(path)).Close();
                iPList.Clear();
                return;
            }
            fs.Close();
            iPList.Clear();
            foreach (IPAddress ip in ips) iPList.AppendText($"{ip.ToString()}\n");
        }

        // Func
        private void __destructor()
        {
            if (terminal != null) terminal.Stop();

            if (clientSocket != null)
            {
                try
                {
                    NetworkStream stream = new NetworkStream(clientSocket.Client, false);
                    byte[] buffer = Encoding.UTF8.GetBytes(@"!@#$%^&*()_+EXIT!@#$%^&*()_+");
                    stream.Write(buffer, 0, buffer.Length);
                    stream.Close();
                }
                catch { }
                clientSocket = null;
            }

            if (listenThread != null)
            {
                listenThread.Abort();
                listenThread = null;
            }
            if (serverShellWindow != null)
                serverShellWindow.Invoke(new MethodInvoker(delegate ()
                {
                    serverShellWindow.Close();
                    serverShellWindow = null;
                }));
            if (serverInboxWindow != null)
                serverInboxWindow.Invoke(new MethodInvoker(delegate ()
                {
                    serverInboxWindow.Close();
                    serverInboxWindow = null;
                }));
            if (serverSocket != null)
            {
                serverSocket.Stop();
                serverSocket = null;
            }
        }

        private void DenyConnection(TcpClient clientSocket)
        {
            NetworkStream stream = new NetworkStream(clientSocket.Client, false);
            byte[] buffer = Encoding.UTF8.GetBytes(@"!@#$%^&*()_+DENY!@#$%^&*()_+");
            stream.Write(buffer, 0, buffer.Length);
            stream.Close();
        }

        private bool Passed(ServerForm main, TcpClient clientSocket, string ip)
        {
            int mode = 0;
            filter.Invoke(new MethodInvoker(delegate ()
            {
                mode = filter.SelectedIndex;
            }));

            if (mode == 0) return true;
            bool inList;

            try
            {
                inList = ips.Contains(IPAddress.Parse(ip));
            }
            catch
            {
                DenyConnection(clientSocket);
                (new Thread(o => ServerThread(main))).Start();
                MessageBox.Show("Unknown IP tried to connect.", "Deny");
                return false;
            }

            if (mode == 1)
            {
                if (inList) return true;
                DenyConnection(clientSocket);
                (new Thread(o => ServerThread(main))).Start();
                MessageBox.Show($"{ip} tried to connect.", "Deny");
                return false;
            }

            if (!inList) return true;
            DenyConnection(clientSocket);
            (new Thread(o => ServerThread(main))).Start();
            MessageBox.Show($"{ip} tried to connect.", "Deny");
            return false;
        }

        private void PartnerLeft()
        {
            btnClose.Invoke(new MethodInvoker(delegate ()
            {
                btnClose.PerformClick();
            }));
            MessageBox.Show("Your partner is away.", "Exit");
        }

        private string GetPath()
        {
            string path = this.path;
            switch (filter.SelectedIndex)
            {
                case 1: path += @"\permit.dat"; break;
                case 2: path += @"\deny.dat"; break;
                default: return "";
            }
            return path;
        }

        public void TerminalBreak(ServerForm main)
        {
            main.terminal.__destructor();
            main.terminal = new Terminal(main);
            main.terminal.Start();
        }

        // Thread
        private void ServerThread(ServerForm main)
        {
            try
            {
                main.serverSocket.Start();
            } catch
            {
                MessageBox.Show("The port is invalid or already in use.", "Error");
                serverSocket = null;
                main.Invoke(new MethodInvoker(delegate ()
                {
                    main.btnClose.PerformClick();
                }));
                return;
            }
            try
            {
                main.clientSocket = serverSocket.AcceptTcpClient();
            } catch(SocketException e)
            {
                return;
            }

            NetworkStream stream = new NetworkStream(clientSocket.Client, false);
            byte[] buffer = new byte[1024];
            int bytesCount = stream.Read(buffer, 0, buffer.Length);
            stream.Close();
            string ip = Encoding.UTF8.GetString(buffer, 0, bytesCount);

            if (Passed(main, clientSocket, ip) == false) return;

            main.serverShellWindow = new ServerShellWindow(main, btnShell);
            main.serverInboxWindow = new ServerInboxWindow(main, clientSocket, btnInbox);
            main.Invoke(new MethodInvoker(delegate ()
            {
                main.Text = $"{ip} connected.";
                main.serverShellWindow.Show();
                main.serverInboxWindow.Show();
            }));
            main.terminal = new Terminal(this);
            main.terminal.Start();
            main.listenThread = new Thread(o => ListenThread(main));
            listenThread.Start();

            ConnectionChanged(true);

            // Bắt đầu viết log vì client đã được server cho phép truy cập
            log = new Log(parent.pathLogFolder, ip);
        }

        private void ListenThread(ServerForm main)
        {
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

                if (data[0] == 'i')
                    (new Thread(o => InboxReceiveThread(main, data))).Start();//serverInboxWindow, ref serverInbox, data))).Start();

                else if (data[0] == 's')
                    (new Thread(o => ShellReceiveThread(main, data))).Start();//clientSocket, serverShellWindow, ref serverShell, data))).Start();
            
                else if (data == @"!@#$%^&*()_+EXIT!@#$%^&*()_+")
                {
                    (new Thread(PartnerLeft)).Start();
                    break;
                }
            }
            stream.Close();
            Storage.BtnEnabledInvoke(main.btnShell, false);
            Storage.BtnEnabledInvoke(main.btnInbox, false);
        }

        private void ShellReceiveThread(ServerForm main, string data)
        {
            data = data.Substring(1);
            if (data == "CTRL+C")
            {
                main.TerminalBreak(main);
                return;
            }
            if (data == "cls" || data == "clear")
            {
                main.serverShellWindow.ClearShell();
                return;
            }

            // ghi vao log lenh duoc thuc thi
            log.updateLog("Input: " + data + '\n');
            log.updateLog("=> Output:\n");


            main.terminal.executeCommand(data);
        }

        public void ShellOutputReturn(string data)
        {
            if (
                serverShell.Length > 1 && 
                serverShell[serverShell.Length - 1] == '\n' && 
                serverShell[serverShell.Length - 2] == '\n' &&
                data == "\n"
            ) return;
            serverShell += data;
            serverShellWindow.UpdateShell(data);
            NetworkStream stream = new NetworkStream(clientSocket.Client, false);
            byte[] buffer = Encoding.UTF8.GetBytes($"s/_{data}");
            stream.Write(buffer, 0, buffer.Length);

            // lưu kết quả trả về từ server
            log.updateLog("\t" + data);

            stream.Close();
        }

        private void InboxReceiveThread(ServerForm main, string data)//ServerInboxWindow serverInboxWindow, ref string serverInbox, string data)
        {
            data = $"Partner: {data.Substring(1)}";
            main.serverInbox += data;
            main.serverInboxWindow.UpdateInbox(data);
        }        

        // Enable or Disable Controls
        private void HostPortChanged(bool flag)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    hostPort.Enabled = btnHost.Enabled = flag;
                    btnClose.Enabled = !flag;
                }));
                return;
            }
            hostPort.Enabled = btnHost.Enabled = flag;
            btnClose.Enabled = !flag;
        }

        private void ConnectionChanged(bool flag)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    btnShell.Enabled = btnInbox.Enabled = btnClose.Enabled = flag;
                    if (flag)
                        label1.Enabled = label2.Enabled = filter.Enabled = iPList.Enabled = false;
                    else
                    {
                        label1.Enabled = filter.Enabled = true;
                        FilterChanged();
                    }
                }));
                return;
            }
            btnShell.Enabled = btnInbox.Enabled = btnClose.Enabled = flag;
            if (flag)
                label1.Enabled = label2.Enabled = filter.Enabled = iPList.Enabled = false;
            else
            {
                label1.Enabled = filter.Enabled = true;
                FilterChanged();

                // close log
                if(log != null)
                    log._destructor();
            }
        }

        private void FilterChanged()
        {
            switch (filter.SelectedIndex)
            {
                case 0:
                    {
                        iPList.Enabled = label2.Enabled = btnUpdate.Enabled = btnRefresh.Enabled = false;
                        iPList.Clear(); break;
                    }
                case 1: case 2:
                    {
                        iPList.Enabled = label2.Enabled = btnUpdate.Enabled = btnRefresh.Enabled = true;
                        btnRefresh.PerformClick();  break;
                    }
            }
        }

        private void hostPort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnHost.PerformClick();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            LogForm logForm = new LogForm(parent);
            logForm.Show();
            this.Hide();
        }
    }
}
