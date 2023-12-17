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
            CommandsSetting.ExecuteCliCommands(Commands.CreateConsoleProj);

            Console.WriteLine("Creating a new classLib project ...");
            CommandsSetting.ExecuteCliCommands(Commands.CreateClassLibProj);

            Console.WriteLine("Creating a new webapi project ...");
            CommandsSetting.ExecuteCliCommands(Commands.CreateWebApiProj);

            Environment.CurrentDirectory = Path.Combine(Environment.CurrentDirectory, "..");

            Environment.CurrentDirectory = Commands.TestDirectory;


            CommandsSetting.ExecuteCliCommands(Commands.CreateConsoleTestProj);

            Environment.CurrentDirectory = Commands.ConsoleTestProjDirectory;

            var consoleReferenceCommandToTestProj = $"{Commands.AddReference} ..\\..\\{Commands.SrcDirectory}\\{Commands.ConsoleProjDirectory}";
            
            CommandsSetting.ExecuteCliCommands(consoleReferenceCommandToTestProj);

            // Add FluentAssertions nuget package 
            CommandsSetting.ExecuteCliCommands(Commands.AddFluentAssertionPackage);

            //Go to test directory
            Environment.CurrentDirectory = Path.Combine(Environment.CurrentDirectory, "..");

            CommandsSetting.ExecuteCliCommands(Commands.CreateClassLibTestProj);
            Environment.CurrentDirectory = Commands.ClassLibTestProjDirectory;
            //Add ClassLibProject refrence to this project 
            var classLibReferenceCommandToTestProj = $"{Commands.AddReference} ..\\..\\{Commands.SrcDirectory}\\{Commands.ClassLibProjDirectory}";
            CommandsSetting.ExecuteCliCommands(classLibReferenceCommandToTestProj);

            CommandsSetting.ExecuteCliCommands(Commands.AddFluentAssertionPackage);


            Environment.CurrentDirectory = Path.Combine(Environment.CurrentDirectory, "..");

            CommandsSetting.ExecuteCliCommands(Commands.CreateWebApiTestProj);

            Environment.CurrentDirectory = Commands.WebApiTestProjDirectory;

            var webApiReferenceCommandToTestProj = $"{Commands.AddReference} ..\\..\\{Commands.SrcDirectory}\\{Commands.WebApiProjDirectory}";

            CommandsSetting.ExecuteCliCommands(webApiReferenceCommandToTestProj);

            CommandsSetting.ExecuteCliCommands(Commands.AddFluentAssertionPackage);
        }
    }
}
