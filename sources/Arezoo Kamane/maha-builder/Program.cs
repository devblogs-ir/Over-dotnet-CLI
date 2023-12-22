using System;
using System.Diagnostics;
using CommandLine;
using Error = CommandLine.Error;

partial class Program
{
    private static string folderName;
    static void Main(string[] args)
    {

        Parser.Default.ParseArguments<Options>(args)
            .WithParsed(RunOptions)
            .WithNotParsed(HandleParseError);

        Directory.CreateDirectory(folderName);

        Environment.CurrentDirectory = folderName;
        string baseDirectory = Environment.CurrentDirectory;

        Directory.CreateDirectory("src");
        Directory.CreateDirectory("test");


        string srcDirectory = Path.Combine(baseDirectory, "src");

        ExecuteCommand("dotnet", "new console -n ConsoleProject", srcDirectory);
        ExecuteCommand("dotnet", "new classlib -n ClassLibProject", srcDirectory);
        ExecuteCommand("dotnet", "new webapi -n WebApiProject", srcDirectory);



        string testDirectory = Path.Combine(baseDirectory, "test");

        ExecuteCommand("dotnet", "new xunit -n ConsoleProject.Test", testDirectory);
        ExecuteCommand("dotnet", "dotnet add reference ..\\..\\src\\ConsoleProject", Path.Combine(testDirectory, "ConsoleProject.Test"));
        ExecuteCommand("dotnet", "add package FluentAssertions", Path.Combine(testDirectory, "ConsoleProject.Test"));


        ExecuteCommand("dotnet", "new xunit -n ClassLibProject.Test", testDirectory);
        ExecuteCommand("dotnet", "dotnet add reference ..\\..\\src\\ClassLibProject", Path.Combine(testDirectory, "ClassLibProject.Test"));
        ExecuteCommand("dotnet", "add package FluentAssertions", Path.Combine(testDirectory, "ClassLibProject.Test"));

        ExecuteCommand("dotnet", "new xunit -n WebApiProject.Test", testDirectory);
        ExecuteCommand("dotnet", "dotnet add reference ..\\..\\src\\WebApiProject", Path.Combine(testDirectory, "WebApiProject.Test"));
        ExecuteCommand("dotnet", "add package FluentAssertions", Path.Combine(testDirectory, "WebApiProject.Test"));

    }

    static void RunOptions(Options opts)
    {
        folderName = opts.FolderName;
    }

    static void HandleParseError(IEnumerable<Error> errors)
    {
        Console.WriteLine("Failed to parse command line options.");
    }

    static void ExecuteCommand(string command, string arguments, string workingDirectory)
    {
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = command,
            Arguments = arguments,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
            WorkingDirectory = workingDirectory
        };

        using (Process process = new Process { StartInfo = psi })
        {
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            process.WaitForExit();

            Console.WriteLine($"Command: {command} {arguments}");

            Console.WriteLine(output);
            Console.WriteLine(error);

            Console.WriteLine($"Exit Code: {process.ExitCode}");
        }
    }
}
class Options
{
    [Option('n', "name", Required = true, HelpText = "Folder name")]
    public string FolderName { get; set; }

}

