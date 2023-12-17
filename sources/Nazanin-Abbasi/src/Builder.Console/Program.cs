using System.Diagnostics;

var folderName = args.AsQueryable().FirstOrDefault();

if (string.IsNullOrWhiteSpace(folderName))
{
    Console.Write("Please provide a folder name: ");

    folderName = Console.ReadLine();
}

string currentPath = AppDomain.CurrentDomain.BaseDirectory;


string[] cmds = {
    $"new sln -n Maha-builder -o {currentPath}{folderName}\\",

    $"new console -n Console -o {currentPath}{folderName}\\src\\Console",
    $"new classlib -n ClassLib -o {currentPath}{folderName}\\src\\Library",
    $"new webapi -n WebApi -o {currentPath}{folderName}\\src\\Web",

    $"new xunit -n Console.Tests -o {currentPath}{folderName}\\test\\Console",
    $"new xunit -n ClassLib.Tests -o {currentPath}{folderName}\\test\\Library",
    $"new xunit -n WebApi.Tests -o {currentPath}{folderName}\\test\\Web",

    $"sln {currentPath}{folderName}\\Maha-builder.sln add (ls -r **/*.csproj)",

    $"build {currentPath}{folderName}",

    $"add {currentPath}{folderName}\\test\\Console package FluentAssertions",
    $"add {currentPath}{folderName}\\test\\Library package FluentAssertions",
    $"add {currentPath}{folderName}\\test\\Web package FluentAssertions"
};

foreach (var cmd in cmds)
{
    ProcessStartInfo startInfo = new ProcessStartInfo
    {
        FileName = "dotnet",
        Arguments = cmd,
        RedirectStandardOutput = true,
        UseShellExecute = false,
        CreateNoWindow = true
    };

    using (Process process = new Process { StartInfo = startInfo })
    {
        process.Start();
        string output = process.StandardOutput.ReadToEnd();
        Console.WriteLine("Done: " + output);
    }
}

