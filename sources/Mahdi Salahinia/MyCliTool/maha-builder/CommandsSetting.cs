using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maha_builder
{
    public class CommandsSetting
    {
        public static void ExecuteCliCommands(string command)
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
            process?.WaitForExit();

            Console.WriteLine(process?.StandardOutput.ReadToEnd());
            Console.WriteLine(process?.StandardError.ReadToEnd());
        }

        public static void WriteCommands(string folderName)
        {
            Directory.CreateDirectory(folderName);

            Console.WriteLine($"Created folder '{folderName}'.");

            Environment.CurrentDirectory = folderName;

            Directory.CreateDirectory(Commands.SrcDirectory);

            Directory.CreateDirectory(Commands.TestDirectory);

            Environment.CurrentDirectory = Commands.SrcDirectory;

            Console.WriteLine("Creating a new console project ...");
            ExecuteCliCommands(Commands.CreateConsoleProj);

            Console.WriteLine("Creating a new classLib project ...");
            ExecuteCliCommands(Commands.CreateClassLibProj);

            Console.WriteLine("Creating a new webapi project ...");
            ExecuteCliCommands(Commands.CreateWebApiProj);

            Environment.CurrentDirectory = Path.Combine(Environment.CurrentDirectory, "..");

            Environment.CurrentDirectory = Commands.TestDirectory;


            ExecuteCliCommands(Commands.CreateConsoleTestProj);

            Environment.CurrentDirectory = Commands.ConsoleTestProjDirectory;

            var consoleReferenceCommandToTestProj = $"{Commands.AddReference} ..\\..\\{Commands.SrcDirectory}\\{Commands.ConsoleProjDirectory}";
            
            ExecuteCliCommands(consoleReferenceCommandToTestProj);

            ExecuteCliCommands(Commands.AddFluentAssertionPackage);

            Environment.CurrentDirectory = Path.Combine(Environment.CurrentDirectory, "..");

            ExecuteCliCommands(Commands.CreateClassLibTestProj);

            Environment.CurrentDirectory = Commands.ClassLibTestProjDirectory;

            var classLibReferenceCommandToTestProj = $"{Commands.AddReference} ..\\..\\{Commands.SrcDirectory}\\{Commands.ClassLibProjDirectory}";
            
            ExecuteCliCommands(classLibReferenceCommandToTestProj);

            ExecuteCliCommands(Commands.AddFluentAssertionPackage);


            Environment.CurrentDirectory = Path.Combine(Environment.CurrentDirectory, "..");

            ExecuteCliCommands(Commands.CreateWebApiTestProj);

            Environment.CurrentDirectory = Commands.WebApiTestProjDirectory;

            var webApiReferenceCommandToTestProj = $"{Commands.AddReference} ..\\..\\{Commands.SrcDirectory}\\{Commands.WebApiProjDirectory}";

            ExecuteCliCommands(webApiReferenceCommandToTestProj);

            ExecuteCliCommands(Commands.AddFluentAssertionPackage);
        }
    }
}
