using System;
using System.IO;
using System.Windows.Forms;

namespace remote_shell
{
    public partial class Dashboard : Form
    {
        public string pathLogFolder = null;
        public Dashboard()
        {
            InitializeComponent();
            pathLogFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                                                + @"\Documents\remote_shell\Logs\";

            txbLogPath.Text = pathLogFolder;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            (new ServerForm(this)).Show();
            this.Hide();

            pathLogFolder = txbLogPath.Text;

            if (!Directory.Exists(pathLogFolder))
                Directory.CreateDirectory(pathLogFolder);
        }
    }
}
