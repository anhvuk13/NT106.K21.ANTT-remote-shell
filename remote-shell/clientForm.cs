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


using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Collections.ObjectModel;

namespace remote_shell
{
    public partial class clientForm : Form
    {
        private TcpClient clientSocket = null;
        NetworkStream stream = null;

        WSManConnectionInfo connectionInfo;

        void Test()
        {
            Uri uri = new Uri("http://127.0.0.1:5895/wsman");
            connectionInfo = new WSManConnectionInfo(uri);

            Runspace runspace = RunspaceFactory.CreateRunspace(connectionInfo);
            runspace.Open();

            using(var ps = PowerShell.Create())
            {
                ps.Runspace = runspace;
                ps.Commands.AddCommand("diskpart");

                Collection<PSObject> result = ps.Invoke();

                foreach (var item in result)
                    rtxbShellOutput.Text += item.ToString();
            }
        }

        public clientForm()
        {
            InitializeComponent();
            /*clientSocket = new TcpClient();
            clientSocket.Connect(IPAddress.Parse("127.0.0.1"), 8080);

            stream = clientSocket.GetStream();*/
            Test();
        }

        
        private void request(string command)
        {
            rtxbShellOutput.Text += $"❯ {command}\n";

            byte[] buffer = Encoding.UTF8.GetBytes(command);
            stream.Write(buffer, 0, buffer.Length);

            buffer = new byte[1024];
            int byteCount = stream.Read(buffer, 0, buffer.Length);

            string output = Encoding.UTF8.GetString(buffer, 0, byteCount);
            if (byteCount > 0) rtxbShellOutput.Text += $"{output}\n";

            txbShellCommand.Clear();
        }

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
                        request(command);
                        break;
                }
                txbShellCommand.Clear();
            }
        }
    }
}
