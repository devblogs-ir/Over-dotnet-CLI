using System;
using System.Diagnostics;

SetForegroundConsoleColorGreen();
PrintBanner();
ResetForegroundConsoleColor();

var solutionNameOptionInputSyntax = "--name";

var requiredNumberOfArguments = 2;

if (args.Length < 2)
{
    PrintError($"Invalid Operation. Enter solution name like this:" +
        $" {solutionNameOptionInputSyntax} \"YourSolutionName\"");
    TerminateProgram();
}

if (args.Length > requiredNumberOfArguments)
{
    PrintError("Too many arguments!");
    TerminateProgram();
}

var solutionKeywordOption = args[0].ToLower();
var solutionName = args[1].Replace(" ","");

if (string.IsNullOrEmpty(solutionKeywordOption) ||
    solutionKeywordOption != solutionNameOptionInputSyntax)
{
    PrintError($"Enter solution option correctly please. Enter solution " +
        $"option like this: {solutionNameOptionInputSyntax}");
    TerminateProgram();
}

if (string.IsNullOrEmpty(solutionName))
{
    PrintError("Enter solution name please. Solution name could not be null or" +
        " empty");
    TerminateProgram();
}

SetForegroundConsoleColorGreen();
Console.WriteLine("Let's execute the commands:");
ResetForegroundConsoleColor();

var currentDirectory = Directory.GetCurrentDirectory();
var batchFileName = "CLICommnds.bat";
string batchFilePath = Path.Combine(currentDirectory, batchFileName);

if (!File.Exists(batchFilePath))
{
    Console.WriteLine("Batch file not found.");
    return;
}


try
{
    ProcessStartInfo processStartInfo = new ProcessStartInfo
    {
        FileName = "cmd.exe",
        RedirectStandardError = true,
        CreateNoWindow = true,
        WorkingDirectory = currentDirectory,
        RedirectStandardOutput = true,
        UseShellExecute = false,
        Arguments = $"/c \"{batchFilePath}\" \"{solutionName}\"",
    };

    var process = Process.Start(processStartInfo);

    string output = process!.StandardOutput.ReadToEnd();
    process.WaitForExit();
    
}
catch (Exception)
{
    Console.WriteLine("Something went wrong :(");
    throw;
}

SetForegroundConsoleColorGreen();
Console.WriteLine("Enerything is done");
ResetForegroundConsoleColor();

static void TerminateProgram()
{
    Environment.Exit(1);
}

static void PrintBanner()
{
    Console.WriteLine("""
                         /$$                         /$$                 /$$ /$$       /$$                    
                        | $$                        | $$                |__/| $$      | $$                    
 /$$$$$$/$$$$   /$$$$$$ | $$$$$$$   /$$$$$$         | $$$$$$$  /$$   /$$ /$$| $$  /$$$$$$$  /$$$$$$   /$$$$$$ 
| $$_  $$_  $$ /$$__  $$| $$__  $$ |____  $$ /$$$$$$| $$__  $$| $$  | $$| $$| $$ /$$__  $$ /$$__  $$ /$$__  $$
| $$ \ $$ \ $$| $$  \ $$| $$  \ $$  /$$$$$$$|______/| $$  \ $$| $$  | $$| $$| $$| $$  | $$| $$$$$$$$| $$  \__/
| $$ | $$ | $$| $$  | $$| $$  | $$ /$$__  $$        | $$  | $$| $$  | $$| $$| $$| $$  | $$| $$_____/| $$      
| $$ | $$ | $$|  $$$$$$/| $$  | $$|  $$$$$$$        | $$$$$$$/|  $$$$$$/| $$| $$|  $$$$$$$|  $$$$$$$| $$      
|__/ |__/ |__/ \______/ |__/  |__/ \_______/        |_______/  \______/ |__/|__/ \_______/ \_______/|__/      
                                                                                                              
                                                                                                              
                                                                                                              
""");
}

static void SetForegroundConsoleColorRed()
{
    Console.ForegroundColor = ConsoleColor.Red;
}

static void SetForegroundConsoleColorGreen()
{
    Console.ForegroundColor = ConsoleColor.Green;
}

static void ResetForegroundConsoleColor()
{
    Console.ResetColor();
}

static void PrintError(string errorMessage)
{
    SetForegroundConsoleColorRed();
    Console.WriteLine(errorMessage);
    ResetForegroundConsoleColor();
}
