using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Diagnostics;

namespace remote_shell
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            (new serverForm()).Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            (new clientForm()).Show();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("remote-shell");
            foreach(Process item in processes)
            {
                item.Kill();
                item.WaitForExit();
                item.Dispose();
            }
        }
    }
}
