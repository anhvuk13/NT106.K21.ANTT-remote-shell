﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remote_shell
{
    class Terminal
    {
        private ServerForm parent;
        private Process process = null;
        private StreamWriter writer = null;
        
        public Terminal(ServerForm parent)
        {
            this.parent = parent;

            process = new Process();
            process.StartInfo = initializeProcess();

            process.ErrorDataReceived += new DataReceivedEventHandler(OutputReceivedHandle);
            process.OutputDataReceived += new DataReceivedEventHandler(OutputReceivedHandle);
            process.Exited += new EventHandler(ExitedHandle);

            process.EnableRaisingEvents = true;
        }

        private void __destructor()
        {
            try
            {
                process.CancelErrorRead();
                process.CancelOutputRead();
            } catch { }
            if (writer != null) writer.Close();
            writer = null;

            process.Kill();
            process.Dispose();
        }

        private ProcessStartInfo initializeProcess()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardInput = true;

            startInfo.FileName = "powershell.exe";
            startInfo.Verb = "runas";// => chạy dưới quyền adminstrator

            return startInfo;
        }

        public void Start()
        {
            process.Start();
            writer = process.StandardInput;
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }

        public void Stop()
        {
            __destructor();
        }

        public void executeCommand(String command)
        {
            if (command.Equals("Ctrl+C")) __destructor();
            else writer.WriteLine(command);
        }

        private void OutputReceivedHandle(Object sender, DataReceivedEventArgs e)
        {
            parent.ShellOutputReturn(e.Data); 
        }

        private void ExitedHandle(Object sender, EventArgs e)
        {
            __destructor();
        }
    }
}