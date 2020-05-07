using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace remote_shell
{
    class cmdProcess : Process
    {
        public cmdProcess()
        {
            StartInfo.FileName = "cmd";
            StartInfo.CreateNoWindow = StartInfo.RedirectStandardInput = StartInfo.RedirectStandardOutput = true;
            StartInfo.UseShellExecute = false;
            Start();
        }

        public String Execute(string command)
        {
            StandardInput.WriteLine(command);
            StandardInput.Flush();
            return StandardOutput.ReadToEnd();
        }
    }
}
