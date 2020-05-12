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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            (new ServerForm(this)).Show();
            this.Hide();
        }
    }
}
