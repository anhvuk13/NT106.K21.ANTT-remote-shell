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

            // khởi tạo powershell
            setUpPowershell();
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
                String result = executeCommand(data);

                // Trả về kết quả cho client
                buffer = Encoding.UTF8.GetBytes(result);
                stream.Write(buffer, 0, buffer.Length);
            }
            clientSocket.Close();
            serverSocket.Stop();
        }


        PowerShell powerShell;

        public Runspace CreateRunspace { get; private set; }

        /// <summary>
        /// Khởi tạo các giá trị ban đầu cho powershell
        /// </summary>
        void setUpPowershell()
        {
            // Hiện tại chỉ có như vậy thôi
            powerShell = PowerShell.Create();
        }


        /// <summary>
        /// Thực thi command và trả về kết quả
        /// </summary>
        /// <param name="commnad"></param>
        /// <returns></returns>
        String executeCommand(String commnad)
        {
            
            powerShell.AddScript(commnad);
            String result = " ";

            // Lấy kết quả trả về
            var resultList = powerShell.Invoke().ToArray();
            foreach (PSObject item in resultList)
                result += (item.ToString() + '\n');

            // Lấy lỗi trả về trong trường hợp lệnh sai
            var error = powerShell.Streams.Error;
            foreach(ErrorRecord item in error)
                result += (item.ToString() + '\n');

            // clear các thông tin vừa nhận được
            // để tránh việc thông tin được lưu vào buffer
            // được thêm vào lần chạy sau => lặp lại kết quả của lần trước
            powerShell.Streams.Error.Clear();
            powerShell.Streams.Warning.Clear();
            powerShell.Commands.Clear();
            

            return result;
        }
        
    }
}
