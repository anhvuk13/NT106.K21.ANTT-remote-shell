using System;
using System.Windows.Forms;

namespace remote_shell
{
    public partial class Dashboard : Form
    {     
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            (new ServerForm(this, hostPort.Text)).Show();
            this.Hide();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            (new ClientForm(this, roomID.Text)).Show();
            this.Hide();
        }

        private void hostPort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnServer.PerformClick();
        }

        private void roomID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnClient.PerformClick();
        }
    }
}
