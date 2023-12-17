using maha_builder;
using System.Diagnostics;

Console.WriteLine("Hey, This tool creates a sample template using dotnet CLI, please be patient...");



//Console.WriteLine("Enter the project name: ");
//string projectName = Console.ReadLine(); 
string projectName = "CLITemplate";

DotnetNativeWrapper dot = new DotnetNativeWrapper();
var res = await dot.CreateProject(projectName);

DirectoryInfo exeDirinfo = new DirectoryInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);

Console.WriteLine(res);

Console.WriteLine("=========================================================");
Console.WriteLine($"Project [{projectName}] created in directory:[{exeDirinfo.Parent.FullName}\\{projectName}]");
Console.WriteLine("=========================================================");

