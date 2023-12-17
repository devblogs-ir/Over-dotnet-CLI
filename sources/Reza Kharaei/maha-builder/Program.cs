using System;
using System.IO;

if (args.Length != 1)
{
    Console.WriteLine("Enter the command completly. The <folder-name> is not specified.");
    return;
}

string folderName = args[0];

Directory.CreateDirectory(folderName);
Console.WriteLine($"folder '{folderName}' created.");

Directory.CreateDirectory(folderName + "/Src");
Console.WriteLine("folder 'Src' created.");

Directory.CreateDirectory(folderName + "/Test");
Console.WriteLine("folder 'Test' created.");

RunDotnetCommand("dotnet new sln DotNetCliExample");
Console.WriteLine("Blank Solution Created.");

RunDotnetCommand($"dotnet new console -n DotNetCliExample.Console --output {folderName}/Src/DotNetCliExample.Console");
Console.WriteLine("Console Project Created.");

RunDotnetCommand($"dotnet new classlib -n DotNetCliExample.Library --output {folderName}/Src/DotNetCliExample.Library");
Console.WriteLine("Class Library Project Created.");

RunDotnetCommand($"dotnet new webapi -n DotNetCliExample.WebApi --output {folderName}/Src/DotNetCliExample.WebApi");
Console.WriteLine("WebApi ProjectsCreated.");

RunDotnetCommand($"dotnet new xunit -n DotNetCliExample.Console.Test --output {folderName}/Test/DotNetCliExample.Console.Test");
Console.WriteLine("Console.Test Project Created.");

RunDotnetCommand($"dotnet new xunit -n DotNetCliExample.Library.Test --output {folderName}/Test/DotNetCliExample.Library.Test");
Console.WriteLine("Library.Test Project Created.");

RunDotnetCommand($"dotnet new xunit -n DotNetCliExample.WebApi.Test --output {folderName}/Test/DotNetCliExample.WebApi.Test");
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

        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();

        if (!string.IsNullOrWhiteSpace(output))
            Console.WriteLine(output);

        if (!string.IsNullOrWhiteSpace(error))
            Console.Error.WriteLine(error);
    }


