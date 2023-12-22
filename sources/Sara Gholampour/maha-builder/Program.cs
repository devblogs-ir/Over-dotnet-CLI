using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
if(args[0] != "maha-builder"|| args[1] != "--name")
        {
            Console.WriteLine("Usage: sara new project -n <ProjectName>");
            return;
        }

        string projectName = args[2];

        // Create a new project
        CreateProject(projectName, "classlib");
        CreateProject(projectName, "webapi");
        CreateProject(projectName, "console");
        CreateTestProject(projectName, "classlib");
        CreateTestProject(projectName, "webapi");
        CreateTestProject(projectName, "console");

        Console.WriteLine($"Projects created for '{projectName}'.");
    }

    static void CreateProject(string projectName, string projectType)
    {
        try
        {
            // Use dotnet CLI to create a new project within the "src" folder
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"new {projectType} -n {projectType} --output ../{projectName}/src/{projectType}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string errors = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    Console.WriteLine($"New {projectType} project '{projectType}' created.");
                }
                else
                {
                    Console.WriteLine($"Error creating {projectType} project: {errors}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static void CreateTestProject(string projectName, string projectType)
    {
        try
        {
            // Use dotnet CLI to create a new xUnit test project within the "test" folder
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"new xunit -n {projectName}.{projectType}.Tests --output ../{projectName}/test/{projectType}.Tests",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string errors = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    Console.WriteLine($"New xUnit test project '{projectType}.Tests' created for '{projectName}.{projectType}'.");
                    InstallFluentAssertions(projectName, projectType);
                }
                else
                {
                    Console.WriteLine($"Error creating xUnit test project: {errors}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static void InstallFluentAssertions(string projectName, string projectType)
    {
        try
        {
            // Use dotnet CLI to install FluentAssertions in the test project
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"add ../{projectName}/test/{projectType}.Tests package FluentAssertions",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string errors = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    Console.WriteLine($"FluentAssertions package installed in '{projectType}.Tests' project.");
                }
                else
                {
                    Console.WriteLine($"Error installing FluentAssertions package: {errors}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
