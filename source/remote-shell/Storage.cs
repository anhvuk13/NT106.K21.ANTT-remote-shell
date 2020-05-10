using System.Windows.Forms;

namespace remote_shell
{
    class Storage
    {

        // Invorker
        public static void BtnEnabledInvoke(Button btn, bool flag)
        {
            btn.Invoke(new MethodInvoker(delegate ()
            {
                btn.Enabled = flag;
            }));
        }

        public static void TextBoxClear(TextBox txb)
        {
            txb.Invoke(new MethodInvoker(delegate ()
            {
                txb.Clear();
            }));
        }

        public static void RichTextBoxAppend(RichTextBox rtxb, string s)
        {
            rtxb.Invoke(new MethodInvoker(delegate ()
            {
                rtxb.AppendText(s);
            }));
        }

        public static string RichTextBoxGetText(RichTextBox rtxb)
        {
            string s = "";
            rtxb.Invoke(new MethodInvoker(delegate ()
            {
                s = rtxb.Text;
            }));
            return s;
        }
    }
}
