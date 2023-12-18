using System;
using System.IO;

if (args.Length != 1)
{
    Console.WriteLine("Enter the command completly. The <folder-name> is not specified.");
    return;
}

string folderName = args[0];

string directoryPath = Directory.GetCurrentDirectory();
string ProjectRootDirectory = Path.Combine(directoryPath, folderName);
     
Directory.CreateDirectory(ProjectRootDirectory);
Console.WriteLine($"folder '{folderName}' created.");

string srcFolderPath = Path.Combine(ProjectRootDirectory, "src");
Directory.CreateDirectory(srcFolderPath);
Console.WriteLine("folder 'Src' created.");

string testFolderPath = Path.Combine(ProjectRootDirectory, "test");
Directory.CreateDirectory(testFolderPath);
Console.WriteLine("folder 'Test' created."); 

RunDotnetCommand($"dotnet new sln -n DotNetCliExample --output {ProjectRootDirectory}");
Console.WriteLine("Blank Solution Created.");

RunDotnetCommand($"dotnet new console -n DotNetCliExample.Console --output {srcFolderPath}/DotNetCliExample.Console");
Console.WriteLine("Console Project Created.");

RunDotnetCommand($"dotnet new classlib -n DotNetCliExample.Library --output {srcFolderPath}/DotNetCliExample.Library");
Console.WriteLine("Class Library Project Created.");

RunDotnetCommand($"dotnet new webapi -n DotNetCliExample.WebApi --output {srcFolderPath}/DotNetCliExample.WebApi");
Console.WriteLine("WebApi ProjectsCreated.");

RunDotnetCommand($"dotnet new xunit -n DotNetCliExample.Console.Test --output {testFolderPath}/DotNetCliExample.Console.Test");
Console.WriteLine("Console.Test Project Created.");

RunDotnetCommand($"dotnet new xunit -n DotNetCliExample.Library.Test --output {testFolderPath}/DotNetCliExample.Library.Test");
Console.WriteLine("Library.Test Project Created.");

RunDotnetCommand($"dotnet new xunit -n DotNetCliExample.WebApi.Test --output {testFolderPath}/DotNetCliExample.WebApi.Test");
Console.WriteLine("WebApi.Test Project Created.");

Console.WriteLine("MahaBuilder completed successfully.");


// Local Method for Run Dot Net Commands :
static void RunDotnetCommand(string CliCommandString)
{
    var process = new System.Diagnostics.Process
    {
        StartInfo = new System.Diagnostics.ProcessStartInfo
        {
            FileName = "dotnet",
            Arguments = CliCommandString,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        }
    };

    process.Start();
    process.WaitForExit();

    string error = process.StandardError.ReadToEnd();
    if (!string.IsNullOrWhiteSpace(error))
        Console.Error.WriteLine(error);
}

