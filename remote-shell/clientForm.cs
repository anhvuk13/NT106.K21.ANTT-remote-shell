using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace remote_shell
{
    public partial class clientForm : Form
    {
        private TcpClient clientSocket = null;
        //NetworkStream stream = null;

        public clientForm()
        {
            InitializeComponent();
            clientSocket = new TcpClient();
            clientSocket.Connect(IPAddress.Parse("127.0.0.1"), 8080);


            Thread listen = new Thread(Recieved);
            listen.IsBackground = true;
            listen.Start();


        }

    //===============================================================
    /*
     * Các hàm thực hiện chức năng của client
     */
        void Recieved()
        {
            NetworkStream stream = clientSocket.GetStream();

            while (true)
            {
                byte[] dataByte = new byte[1024];
                int len = stream.Read(dataByte, 0, dataByte.Length);

                if (len == 0) break; // => ngắt kết nối => không nhận được dữ liệu

                string dataString = Encoding.UTF8.GetString(dataByte);
                AddMessage(dataString);
            }

            int l = 0;
        }

        void Send(string message)
        {
            NetworkStream stream = clientSocket.GetStream();

            byte[] dataByte = Encoding.UTF8.GetBytes(message);
            stream.Write(dataByte, 0, dataByte.Length);
        }



    //==================================================================
    /*
     * Các hàm bộ sung
     */
        void AddMessage(string message)
        {
            message = message.Replace("\0", "");
            if (rtxbShellOutput.InvokeRequired)
                rtxbShellOutput.Invoke(new MethodInvoker(delegate ()
                {
                    AddMessage(message);
                }));

            else
            {
                rtxbShellOutput.Text += (message + "\n");

                rtxbShellOutput.SelectionStart = rtxbShellOutput.Text.Length; // đưa con trỏ xuống cuối richTextBox
                rtxbShellOutput.ScrollToCaret(); // Tự động scroll khi có nhiều dòng
                
            }
        }

        /// <summary>
        /// Xử lý command trong textBox khi nhấn Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbShellCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                string command = txbShellCommand.Text;

                switch (command)
                {
                    case "clear":
                    case "cls":
                        rtxbShellOutput.Clear();
                        break;
                    default:
                        Send(command);
                        break;
                }

                txbShellCommand.Clear();
            }
        }


        /// <summary>
        /// Xử lý việc người dùng nhấn Ctrl+C
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbShellCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
                Send("Ctrl+C");
        }
    }
}
