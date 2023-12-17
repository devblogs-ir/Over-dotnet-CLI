using CommandLine;
using mha_builder;
using System.Diagnostics;


CommandLine.Parser.Default.ParseArguments<Options>(args)
    .WithParsed(RunOptions)
    .WithNotParsed(HandleParseError);

static void RunOptions(Options opts)
{
    string path = Path.Combine(Directory.GetCurrentDirectory(), opts.Name);
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
        Console.WriteLine($"Folder '{opts.Name}' created.");
        string sourceFile = Path.Combine(Directory.GetCurrentDirectory(), "myCommands.bat");
        string destinationFile = Path.Combine(path, "myCommands.bat");
        try
        {
            File.Copy(sourceFile, destinationFile, overwrite: true);
            Console.WriteLine("Batch file copied successfully.");
            ProcessStartInfo startInfo = new()
            {
                FileName = "cmd",
                Arguments = "/c \"myCommands.bat\"",
                WorkingDirectory = path,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
            };

            var proc = Process.Start(startInfo);
            ArgumentNullException.ThrowIfNull(proc);
            string output = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit();
            if (proc.ExitCode != 0)
            {
                Console.WriteLine($"Something went wrong! " +
                    $"Error code: {proc.ExitCode}, Error message: {output}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            if (File.Exists(destinationFile))
            {
                File.Delete(destinationFile);
            }
        }
    }
    else
    {
        Console.WriteLine($"Folder '{opts.Name}' already exists.");
    }
}
static void HandleParseError(IEnumerable<Error> errs)
{
    Console.WriteLine(errs.ToString());
}