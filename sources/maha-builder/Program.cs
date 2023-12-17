// See https://aka.ms/new-console-template for more information
//Console.WriteLine("please write folderName:");
using System.Diagnostics;

try
{
    
    if (args.Length == 0)
    {
        Console.WriteLine("args is null");
        return;
    }

    string folderName = args[1];

    if (string.IsNullOrEmpty(folderName))
    {
        Console.WriteLine("FolderName is Empty");
        return;
    }

    if (Directory.Exists(folderName))
    {
        Console.WriteLine("FolderName is taken");
        return;
    }

    Directory.CreateDirectory(folderName);
    Console.WriteLine($"{folderName} created");

    Environment.CurrentDirectory = folderName;

    #region Crete src folder and its projects

    Directory.CreateDirectory("src");
    Console.WriteLine("src folder created");
    Environment.CurrentDirectory = "src";

    ExecuteCliCommand("dotnet new console -n ConsoleProject1");
    Console.WriteLine("ConsoleProject1 created");

    ExecuteCliCommand("dotnet new  classlib -n ClassLibrary1");
    Console.WriteLine("ClassLibrary1 created");

    ExecuteCliCommand("dotnet new  webapi -n WebApi1");
    Console.WriteLine("WebApi1 created");
    #endregion

    #region Back to Base folder
    Directory.SetCurrentDirectory("..\\");
    #endregion

    #region Create test folder and its projects
    Directory.CreateDirectory("test");
    Console.WriteLine("test folder created");
    Environment.CurrentDirectory = "test";

    ExecuteCliCommand(@"dotnet new xunit -n ConsoleProject1.Test");
    Environment.CurrentDirectory = "ConsoleProject1.Test";
    ExecuteCliCommand(@"dotnet add package FluentAssertions");
    ExecuteCliCommand(@"dotnet add reference ..\\..\\src\\ConsoleProject1");
    Console.WriteLine("ConsoleProject1.Test created");

    Directory.SetCurrentDirectory("..\\");
    ExecuteCliCommand(@"dotnet new xunit -n ClassLibrary1.Test");
    Environment.CurrentDirectory = "ClassLibrary1.Test";
    ExecuteCliCommand(@"dotnet add package FluentAssertions");
    ExecuteCliCommand(@"dotnet add reference ..\\..\\src\\ClassLibrary1");
    Console.WriteLine("ClassLibrary1.Test created");

    Directory.SetCurrentDirectory("..\\");
    ExecuteCliCommand(@"dotnet new xunit -n WebApi1.Tests");
    Environment.CurrentDirectory = "WebApi1.Tests";
    ExecuteCliCommand(@"dotnet add package FluentAssertions");
    ExecuteCliCommand(@"dotnet add reference ..\\..\\src\\WebApi1");
    Console.WriteLine("WebApi1.Test created");
    #endregion
}
catch (Exception e)
{
    Console.WriteLine(e.Message + "\r \n" + e.StackTrace);

}



void ExecuteCliCommand(string CommandText)
{
    var process = new Process();
    var startInfo = new ProcessStartInfo()
    {
        FileName = "cmd.exe",
        Arguments = $"/c {CommandText}", 
        UseShellExecute = false, 
        RedirectStandardOutput = true,
        RedirectStandardError = true,
        CreateNoWindow = true,
        WorkingDirectory = Environment.CurrentDirectory
    };
    process.StartInfo = startInfo;
    process.Start();
    process.WaitForExit();
    process.BeginOutputReadLine();
    process.BeginErrorReadLine();
    
}

