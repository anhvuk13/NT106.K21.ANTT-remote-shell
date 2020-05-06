using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteShell
{
    public partial class serverForm : Form
    {
        public serverForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            clientForm frm3 = new clientForm();
            frm3.Activate();
            frm3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rtbxIPList_TextChanged(object sender, EventArgs e)
        {

        }

        private void serverForm_DragLeave(object sender, EventArgs e)
        {

        }

        private void serverForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            

           
        }
    }
}
