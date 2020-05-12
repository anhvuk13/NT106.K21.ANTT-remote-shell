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
        NetworkStream stream = null;

        public clientForm()
        {
            InitializeComponent();
            clientSocket = new TcpClient();
            clientSocket.Connect(IPAddress.Parse("127.0.0.1"), 8080);

            stream = clientSocket.GetStream();


            refeshPath();
        }

        
        private void request(string command)
        {

            //rtxbShellOutput.Text += $"❯ {command}\n";

            byte[] buffer = Encoding.UTF8.GetBytes(command);
            stream.Write(buffer, 0, buffer.Length);

            buffer = new byte[1024];
            int byteCount = stream.Read(buffer, 0, buffer.Length);

            string output = Encoding.UTF8.GetString(buffer, 0, byteCount);
            output = output.Replace("\r", "");

            if (byteCount > 0) rtxbShellOutput.Text += $"{output}";

            refeshPath();
        }


        // input start: vị trí mà người dùng nhập lệnh
        int inputStart = 0;

        /// <summary>
        /// Lấy path của thư hiện tại mà người dùng đang giao tiếp
        /// </summary>
        void refeshPath()
        {
            byte[] buffer = Encoding.UTF8.GetBytes("pwd");
            stream.Write(buffer, 0, buffer.Length);

            buffer = new byte[1024];
            stream.Read(buffer, 0, buffer.Length);

            string path = Encoding.UTF8.GetString(buffer);
            path = path.Replace("\n", "").Replace("\0", "").Replace("Path", "");
            path = path.Replace("-", "").Replace("\r", "").Trim();

            rtxbShellOutput.Text += (path + "> ");

            // Lấy vị trí cho phép người dùng nhập lệnh
            // Vị trí đó là ở cuối chuỗi cửa rtxbShellOutput
            inputStart = rtxbShellOutput.Text.Length;
            rtxbShellOutput.SelectionStart = rtxbShellOutput.Text.Length;
        }

        private void rtxbShellOutput_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(e.KeyChar == (Char)Keys.Enter)
            {
                // Lấy chuỗi vừa nhập
                // việc trừ thêm 1 là để bỏ đi kí tự xuống dòng khi enter
                // 'rtxbShellOutput.SelectionStart- inputStart-1' là độ dài của đoạn vừa nhập
                string command = rtxbShellOutput.Text.Substring(inputStart, rtxbShellOutput.SelectionStart- inputStart-1);

                switch (command)
                {
                    case "clear":
                    case "cls":
                        rtxbShellOutput.Clear();
                        refeshPath();
                        break;
                    default:
                        request(command);
                        break;
                }

                // đưa con trỏ xuống cuối hàng
                rtxbShellOutput.SelectionStart = rtxbShellOutput.Text.Length;
            }
        }

        /// <summary>
        /// Không cho người dùng chỉnh sửa các text
        /// ở vị trí trước vị trí của inputStart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtxbShellOutput_KeyDown(object sender, KeyEventArgs e)
        {
            // kiểm tra xem con trỏ hiện tại có nằm trong cùng ko được phép ghi
            // richTextBox xử lý các trường hợp nhấn key trong keyDown trước khi gọi keyPress
            // do đó việc kiểm tra phải nằm trong KeyDown
            if (rtxbShellOutput.SelectionStart <= inputStart)
                e.Handled = true;
        }
    }
}
