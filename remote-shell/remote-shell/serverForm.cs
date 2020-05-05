using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace remote_shell
{
    public partial class serverForm : Form
    {
        private Thread tcpServerThread = null;
        private TcpListener serverSocket = null;
        
        public serverForm()
        {
            InitializeComponent();
            tcpServerThread = new Thread(serverThread);
            tcpServerThread.Start();
        }

        private void serverThread()
        {
            serverSocket = new TcpListener(IPAddress.Any, 8080);
            serverSocket.Start();
            TcpClient clientSocket = serverSocket.AcceptTcpClient();

            while (Thread.CurrentThread.IsAlive && clientSocket.Connected)
            {
                string text = "";

                NetworkStream stream = clientSocket.GetStream();
                byte[] buffer = new byte[1024];
                int byte_count = stream.Read(buffer, 0, buffer.Length);

                if (byte_count == 0) break;

                string data = Encoding.UTF8.GetString(buffer, 0, byte_count);

                buffer = Encoding.UTF8.GetBytes(data);
                stream.Write(buffer, 0, buffer.Length);
            }
            clientSocket.Close();
            serverSocket.Stop();
        }
    }
}
