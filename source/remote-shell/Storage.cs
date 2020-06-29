using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace remote_shell
{
    class Storage
    {
        public static string GetIPAddress()
        {
            String address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new 
            StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }

            int first = address.IndexOf("Address: ") + 9;
            int last = address.LastIndexOf("</body>");
            address = address.Substring(first, last - first);

            return address;
        }

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
