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

// Thư viện hỗ trợ tạo tiến trình Powershell
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Collections;
using System.Diagnostics;

using CMDRemote;
using System.Collections.ObjectModel;

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

            NetworkStream stream = clientSocket.GetStream();
            while (Thread.CurrentThread.IsAlive && clientSocket.Connected)
            {
                //string text = "";
                byte[] buffer = new byte[1024];
                int byte_count = stream.Read(buffer, 0, buffer.Length);

                if (byte_count == 0) break;

                string data = Encoding.UTF8.GetString(buffer, 0, byte_count);

                // Thực thi lệnh từ client
                // Trả về kết quả cho client
                buffer = Encoding.UTF8.GetBytes(result);
                stream.Write(buffer, 0, buffer.Length);
            }
            clientSocket.Close();
            serverSocket.Stop();

        }

        
        void Recieved()
        {
            while (true)
            {

            }
        }


        PowerShell powerShell;

        public Runspace CreateRunspace { get; private set; }
        public object ConsoleControl { get; private set; }

        /// <summary>
        /// Khởi tạo các giá trị ban đầu cho powershell
        /// </summary>


        

        ProcessStartInfo initializeProcess(string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "powershell.exe";
            startInfo.Arguments = command;

            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;

            return startInfo;
        }

        Process process;
        Stack<ProcessStartInfo> processStack = new Stack<ProcessStartInfo>(); // dùng để lưu các chương trình được gọi

        /// <summary>
        /// Thực thi command và trả về kết quả
        /// </summary>
        /// <param name="commnad"></param>
        /// <returns></returns>
        void executeCommand(String command)
        {
            // Lấy info từ đỉnh của stack
            ProcessStartInfo startInfo = processStack.Peek();
            startInfo.Arguments = command;

            // set up process
            process = new Process();
            process.StartInfo = initializeProcess(command);

            process.EnableRaisingEvents = true;

            process.ErrorDataReceived += new DataReceivedEventHandler(ErrorRecievedHandle);
            process.OutputDataReceived += new DataReceivedEventHandler(OutputRecievedHandle);
            process.Exited += new EventHandler(ExitedHandle);

            process.Start();

            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }       

        void ErrorRecievedHandle(Object sender, DataReceivedEventArgs e)
        {
            AddMessage(e.Data);
        }

        void OutputRecievedHandle(Object sender, DataReceivedEventArgs e)
        {
            AddMessage(e.Data);
        }

        void ExitedHandle(Object sender, EventArgs e)
        {
            process.CancelErrorRead();
            process.CancelOutputRead();
        }

        void myProgressEventHandler(object sender, DataAddedEventArgs e)
        {
            Object newRecord = sender as Object;

            AddMessage(newRecord.ToString());
        }

        void AddMessage(String message)
        {
            if (richTextBox1.InvokeRequired)
                richTextBox1.Invoke(new MethodInvoker(delegate ()
                {
                    /*richTextBox1.Text += (message + '\n');*/
                    AddMessage(message);
                }));
            else
            {
                richTextBox1.Text += (message + '\n');
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
            }
        }
    }
}
