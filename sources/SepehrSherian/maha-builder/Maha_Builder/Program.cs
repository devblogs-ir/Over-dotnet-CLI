
using CommandTempaltes;
using CommandTemplates;
using System;
using static System.Net.Mime.MediaTypeNames;

var folderName = ParseArgumentValue(args, "-n");

var ValidName = CheckProjectNameValidity.CheckProjectName(folderName);
if (!ValidName)
{
    Console.WriteLine("Please Entre Your Project Name!");
    Console.WriteLine("Usage: maha-builder -n  {your ProjectName}");
    return;
}
var ExistFolderName = CheckProjectNameValidity.CheckDircectory(folderName);

if (!ExistFolderName)
{
    Console.WriteLine("This Project Name is Exist!");
    return;
}


Directory.CreateDirectory(folderName);
Console.WriteLine($"Created folder '{folderName}'.");


Environment.CurrentDirectory = folderName;

Directory.CreateDirectory("src");
Directory.CreateDirectory("test");


Environment.CurrentDirectory = "src";
Console.WriteLine("Start Create Projects ...");

var ConsoleProject = NewCommand.MakeNewProject("console", "ConsoleProject");
RunCommand.Run(ConsoleProject);

var ClassLibraryProject = NewCommand.MakeNewProject("classlib", "ClassLibraryProject");
RunCommand.Run(ClassLibraryProject);

var WebAPIProject = NewCommand.MakeNewProject("webapi", "WebAPIProject");
RunCommand.Run(WebAPIProject);

// start Test
Environment.CurrentDirectory = Path.Combine(Environment.CurrentDirectory, "..");
Environment.CurrentDirectory = "test";
Console.WriteLine("Start Create Tests ...");

var ConsoleProject_Tests = NewCommand.MakeNewProject("xunit", "ConsoleProject.Tests");
RunCommand.Run(ConsoleProject_Tests);
Environment.CurrentDirectory = "ConsoleProject.Tests";

var pakage_1 = AddPackage.Add("FluentAssertions");
RunCommand.Run(pakage_1);

var ref_1 = AddReference.Add("..\\..\\src\\ConsoleProject\\.ConsoleProject.csproj");
RunCommand.Run(ref_1);

Environment.CurrentDirectory = Path.Combine(Environment.CurrentDirectory, "..");
var ClassLibraryProject_Tests = NewCommand.MakeNewProject("xunit", "ClassLibraryProject.Tests");
RunCommand.Run(ClassLibraryProject_Tests);
Environment.CurrentDirectory = "ClassLibraryProject.Tests";
var pakage_2 = AddPackage.Add("FluentAssertions");
RunCommand.Run(pakage_2);

var ref_2 = AddReference.Add("..\\..\\src\\ClassLibraryProject\\.ClassLibraryProject.csproj");
RunCommand.Run(ref_2);

Environment.CurrentDirectory = Path.Combine(Environment.CurrentDirectory, "..");
var WebAPIProject_Tests = NewCommand.MakeNewProject("xunit", "WebAPIProject.Tests");
RunCommand.Run(WebAPIProject_Tests);
Environment.CurrentDirectory = "WebAPIProject.Tests";
var pakage_3 = AddPackage.Add("FluentAssertions");
RunCommand.Run(pakage_3);

var ref_3 = AddReference.Add("..\\..\\src\\WebAPIProject\\.WebAPIProject.csproj");
RunCommand.Run(ref_3);




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