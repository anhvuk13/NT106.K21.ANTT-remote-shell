using System;
using System.Collections.Generic;
using System.Diagnostics; // Process, ProcessStartInfo
using System.Drawing;
using System.IO; // StreamWriter
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMDRemote
{
    public class CMD
    {
        Process process;
        //ProcessStartInfo startInfo;

        StreamWriter streamWriter;
        public StreamReader outputReader;
        public StreamReader errorReader;

        String lastDirectory;

        ProcessStartInfo InitializeInfo()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();

            // set read input, output, error
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;

            // set option
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.ErrorDialog = false;

            startInfo.FileName = "cmd.exe";
            //startInfo.WorkingDirectory = lastDirectory;

            return startInfo;
        }
        
        public void StartProcess(String command)
        {
            // create process
            
            process = new Process();
            process.StartInfo = InitializeInfo();
            process.Exited += ClearProcess_Exited;

           
            process.Start();

            streamWriter = process.StandardInput;
            errorReader = process.StandardError;
            outputReader = process.StandardOutput;

            streamWriter.WriteLine(command);

            // Lấy thư mục hiện tại
            lastDirectory = process.StartInfo.FileName;

            // ReadResult();
        }

        /*void ReadResult()
        {
            Task<String> errors = errorReader.ReadLineAsync();
            Task<String> outputs = outputReader.ReadLineAsync();

            while (!errors.IsCompleted)
                WriteOutput(errors.Result, Color.Red);

            while (!outputs.IsCompleted)
                WriteOutput(outputs.Result, Color.White);
        }

        void WriteOutput(string message, Color color);*/


        void ClearProcess_Exited(Object sender, EventArgs e)
        {
            process.CancelErrorRead();
            process.CancelOutputRead();

            streamWriter.Flush(); // clear stream

            outputReader = null;
            errorReader = null;
        }
    }
}
