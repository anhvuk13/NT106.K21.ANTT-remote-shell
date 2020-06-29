using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace remote_shell
{
    public class Log
    {
        StreamWriter writer = null;
        public string pathLogFolder = null; 

        public Log(string pathFolder, string ipAccess)
        {
            pathLogFolder = pathFolder;

            DateTime timeStart = DateTime.Now;
            // tạo file có dạng: IP_random.log
            writer = new StreamWriter(File.Create(pathLogFolder + @"\" + ipAccess + '_' + (new Random()).Next().ToString() + @".log"));

            if (writer == null)
            {
                MessageBox.Show("Can't find the current log.");
                return;
            }

            writer.WriteLine(timeStart);
            writer.WriteLine("IP Access: " + ipAccess);
            writer.WriteLine("==========================START==========================");
        }

        public void _destructor()
        {
            if (writer == null)
            {
                MessageBox.Show("Can't find the current log.");
                return;
            }

            DateTime timeEnd = DateTime.Now;

            writer.WriteLine(timeEnd);
            writer.WriteLine("==========================END==========================");
            writer.Close();
        }

        public void updateLog(string newContent)
        {
            if(writer == null)
            {
                MessageBox.Show("Can't find the current log.");
                return;
            }
            writer.Write(newContent);
        }
    }
}
