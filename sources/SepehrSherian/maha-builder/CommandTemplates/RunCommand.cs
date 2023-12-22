using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandTemplates
{
    public static class RunCommand
    {
        public static void Run(string command)
        {
            var processInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", $"/c {command}")
            {
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                WorkingDirectory = Environment.CurrentDirectory
            };

            var process = System.Diagnostics.Process.Start(processInfo);
            process.WaitForExit();

            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.WriteLine(process.StandardError.ReadToEnd());
        }
    }
}
