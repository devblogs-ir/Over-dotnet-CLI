
//Get name of folder
var folderName = ParseArgumentValue(args, "--name");
//Error if name s null
if (folderName == null)
{
    Console.WriteLine("Error: The --name argument is missing or invalid.");
    Console.WriteLine("Usage: maha-builder --name \"YourName\"");
    return;
}

if (Directory.Exists(folderName))
{
    Console.WriteLine($"The folder '{folderName}' already exists.");
    return;
}

Directory.CreateDirectory(folderName);
Console.WriteLine($"Created folder '{folderName}'.");

// Change to the new directory
Environment.CurrentDirectory = folderName;
    
//Create src and test directory
Directory.CreateDirectory("src");
Directory.CreateDirectory("test");
    
// Change to the src directory
Environment.CurrentDirectory = "src";
    
// Create a new console project
Console.WriteLine("Creating a new console project ...");
ExecuteDotnetCommand("dotnet new console -n ConsoleProject");
    
// Create a new classlibrary project
Console.WriteLine("Creating a new classLib project ...");
ExecuteDotnetCommand("dotnet new classlib -n ClassLibProject");
    
// Create a new webapi project
Console.WriteLine("Creating a new webapi project ...");
ExecuteDotnetCommand("dotnet new webapi -n WebApiProject");
    
// Move to base directory
Environment.CurrentDirectory=Path.Combine(Environment.CurrentDirectory, "..");
    
// Change to the test directory
Environment.CurrentDirectory = "test";

#region Create test project for console application

ExecuteDotnetCommand("dotnet new xunit -n ConsoleProject.Test");
    
Environment.CurrentDirectory = "ConsoleProject.Test";
//Add ConsoleProject refrence to this project 
var  referenceCommand = "dotnet add reference ..\\..\\src\\ConsoleProject";
ExecuteDotnetCommand(referenceCommand);
    
// Add FluentAssertions nuget package 
ExecuteDotnetCommand("  dotnet add package FluentAssertions");
#endregion
#region Create test project for classlib
//Go to test directory
Environment.CurrentDirectory=Path.Combine(Environment.CurrentDirectory, "..");
    
ExecuteDotnetCommand("dotnet new xunit -n ClassLibProject.Test");
Environment.CurrentDirectory = "ClassLibProject.Test";
//Add ClassLibProject refrence to this project 
referenceCommand = "dotnet add reference ..\\..\\src\\ClassLibProject";
ExecuteDotnetCommand(referenceCommand);
    
// Add FluentAssertions nuget package 
ExecuteDotnetCommand("  dotnet add package FluentAssertions");
#endregion
    
#region Create test project for webapi 
//Go to test directory
Environment.CurrentDirectory=Path.Combine(Environment.CurrentDirectory, "..");
ExecuteDotnetCommand("dotnet new xunit -n WebApiProject.Test");
Environment.CurrentDirectory = "WebApiProject.Test";
//Add WebApiProject refrence to this project 
referenceCommand = "dotnet add reference ..\\..\\src\\WebApiProject";
ExecuteDotnetCommand(referenceCommand);
    
// Add FluentAssertions nuget package 
ExecuteDotnetCommand("  dotnet add package FluentAssertions");
#endregion
  
    

static void ExecuteDotnetCommand(string command)
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
static string? ParseArgumentValue(string[] args, string argumentName)
{
    for (int i = 0; i < args.Length - 1; i++)
    {
        if (args[i].Equals(argumentName, StringComparison.OrdinalIgnoreCase))
        {
            return args[i + 1];
        }
    }
    return null;
}
