using System;
using System.Windows.Forms;

namespace remote_shell
{
    public partial class ServerShellWindow : Form
    {
        private ServerForm parent;
        private Button btnShell;

        public ServerShellWindow(ServerForm parent, Button btnShell)
        {
            InitializeComponent();
            this.parent = parent;
            this.btnShell = btnShell;
        }

        private void ServerShellWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            Storage.BtnEnabledInvoke(btnShell, true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            localShell.Clear();
            parent.serverShell = "";
        }

        private void localShell_TextChanged(object sender, EventArgs e)
        {
            localShell.SelectionStart = localShell.Text.Length;
            localShell.ScrollToCaret();
        }

        public void UpdateShell(string serverShell)
        {
            Storage.RichTextBoxAppend(localShell, serverShell);
        }

        private void ServerShellWindow_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void ClearShell()
        {
            btnClear.Invoke(new MethodInvoker(delegate ()
            {
                btnClear.PerformClick();
            }));
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            parent.TerminalBreak(parent);
        }
    }
}
