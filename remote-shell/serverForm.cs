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
        private TcpClient tcpClient = new TcpClient();

        public serverForm()
        {
            InitializeComponent();
            /*tcpServerThread = new Thread(serverThread);
            tcpServerThread.Start();*/

            serverSocket = new TcpListener(IPAddress.Any, 8080);

            Thread listen = new Thread(Recieved);
            listen.IsBackground = true;
            listen.Start();
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

                executeCommand(data);

                // Thực thi lệnh từ client
                // Trả về kết quả cho client
                buffer = Encoding.UTF8.GetBytes(data);
                stream.Write(buffer, 0, buffer.Length);
            }
            clientSocket.Close();
            serverSocket.Stop();

        }

        
        /// <summary>
        /// Chờ nhận thông điệp được gửi từ client
        /// </summary>
        void Recieved()
        {
            serverSocket.Start();
            tcpClient = serverSocket.AcceptTcpClient();

            // Khởi động process để chuẩn bị cho việc thực thi lệnh
            // khi nhận được thông điệp từ client
           // (new Thread(startRunning)).Start();
            startRunning();

            NetworkStream stream = tcpClient.GetStream();

            while (true)
            {
                byte[] dataByte = new byte[1024];
                stream.Read(dataByte, 0, dataByte.Length);

                
                if (dataByte.Length == 0) break; // => ngắt kết nối do không nhận được dữ liệu

                string dataString = Encoding.UTF8.GetString(dataByte);
                dataString = dataString.Replace("\0", "");

                // Thực thi và gửi kết quả
                executeCommand(dataString);
            }

            // Tái khởi động lại quá trình chờ nhận thông điệp
            stream.Close();
            Recieved();
        }

        /// <summary>
        /// Gửi thông điệp cho Client
        /// </summary>
        /// <param name="message"></param>
        void Send(string message)
        {
            if (message == null)
                return;

            NetworkStream stream = tcpClient.GetStream();

            byte[] dataByte = Encoding.UTF8.GetBytes(message);
            stream.Write(dataByte, 0, dataByte.Length);
        }



        /*
         * Các hàm cho Process
         */

        Process process;
        StreamWriter streamWriter; // => tạo streamInput truyền lệnh vào cho process


        /// <summary>
        /// Khởi tạo các thông tin cần thiết cho process
        /// </summary>
        /// <returns></returns>
        ProcessStartInfo initializeProcess()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardInput = true;

            startInfo.FileName = "powershell.exe";
            startInfo.Verb = "runas";// => chạy dưới quyền adminstrator

            return startInfo;
        }

        /// <summary>
        /// Tạo process
        /// </summary>
        void setUpProcess()
        {
            process = new Process();

            // set up các thông tin cần thiết cho process
            process.StartInfo = initializeProcess();

            // ----------EventHanlder----------------
            process.ErrorDataReceived += new DataReceivedEventHandler(ErrorRecievedHandle);
            process.OutputDataReceived += new DataReceivedEventHandler(OutputRecievedHandle);
            process.Exited += new EventHandler(ExitedHandle);

            process.EnableRaisingEvents = true;
        }

        /// <summary>
        /// Khởi động process
        /// </summary>
        void startRunning()
        {
            // set up process
            setUpProcess();

            // Khởi chạy process
            process.Start();

            streamWriter = process.StandardInput;
            //streamReader = process.StandardOutput;

            //readResult();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

        }

        /*void readResult()
        {
            char[] buffer = new char[1];
            String text = "";

            while (streamReader.Read(buffer, 0, buffer.Length) != 0)
            {
                if (buffer[0] == '\n')
                {
                    Send(text);
                    AddMessage(text);

                    text = "";
                    buffer = new char[1];
                }
                
                text += new string(buffer);
                buffer = new char[1];
            }

            Thread.CurrentThread.Abort();
        }*/

        /// <summary>
        /// Thực thi command và trả về kết quả
        /// </summary>
        /// <param name="commnad"></param>
        /// <returns></returns>
        void executeCommand(String command)
        {
            if (command.Equals("Ctrl+C"))
            {
                process.CancelErrorRead();
                process.CancelOutputRead();

                process.Kill();
                process.Dispose();

                // Tạo một process mới
                //(new Thread(startRunning)).Start();
                startRunning();
                return;
            }

            // ghi lệnh vào powershell
            streamWriter.WriteLine(command);

            // Kết quả trả về được gửi thông qua các event
            // của process chạy powershell

            // * Các evernt của process
            // ErrorRecievedHandle => gửi lỗi khi chạy lệnh
            // OutputRecievedHandle => gửi kêt quả khi chạy lệnh
            // ExitedHandle => Thực hiện các công việc cần thiết sau khi lệnh hoàn tất

        }       
        
        /// <summary>
        /// Xử lý lỗi khi chạy lệnh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ErrorRecievedHandle(Object sender, DataReceivedEventArgs e)
        {
            string message = e.Data + " "; // thêm space để tránh trường hợp e.Data=null

            AddMessage(message); // => Xuất kết quả cho richTextBox của server
            Send(message); // => gửi kết quả về cho client
        }

        /// <summary>
        /// Xử lý kết quả trả về khi chạy lệnh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OutputRecievedHandle(Object sender, DataReceivedEventArgs e)
        {
            string message = e.Data + " "; // thêm space để tránh trường hợp e.Data=null

            AddMessage(message); // => Xuất kết quả cho richTextBox của server
            Send(message); // => gửi kết quả về cho client

        }

        /// <summary>
        /// Xử lý process khi process kết thúc lệnh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ExitedHandle(Object sender, EventArgs e)
        {
            process.CancelErrorRead(); // => Thoát quá trình nhận lỗi trả về khi chạy lệnh
            process.CancelOutputRead(); // => Thoát quá trinh nhận kết quả trả về

        }



        /*
         * Các hàm bổ sung
         */

        /// <summary>
        /// Giửi thông điệp về cho richTextBox của Server
        /// </summary>
        /// <param name="message"></param>
        void AddMessage(String message)
        {
            if (richTextBox1.InvokeRequired)
                richTextBox1.Invoke(new MethodInvoker(delegate ()
                {
                    AddMessage(message);
                }));
            else
            {
                richTextBox1.Text += (message + "\n");

                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
            }
        }
    }
}
