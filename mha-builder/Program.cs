using System.Diagnostics;

if (args.Length > 0 && args[0] == "--name")
{
    if (args.Length > 1 && args[1]!=null)
    {
        string folderName = args[1];
        string path = Path.Combine(Directory.GetCurrentDirectory(), folderName);

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Console.WriteLine($"Folder '{folderName}' created.");
            string sourceFile = Path.Combine(Directory.GetCurrentDirectory(), "myCommands.bat");
            string destinationFile = Path.Combine(path, "myCommands.bat");
            try
            {
                File.Copy(sourceFile, destinationFile, overwrite: true);
                Console.WriteLine("Batch file copied successfully.");
            }
            catch {
                Console.WriteLine("Copying batch file failed.");
            }
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
            await proc.WaitForExitAsync();
            if (proc.ExitCode != 0)
            {
                Console.WriteLine($"Something went wrong! " +
                    $"Error code: {proc.ExitCode}, Error message: {output}");
            }
        }
        else
        {
            Console.WriteLine($"Folder '{folderName}' already exists.");
        }
    }
    else
    {
        Console.WriteLine("Please provide a name for the folder.");
    }
}
else
{
    Console.WriteLine("Invalid command. Usage: mha-builder --name \"Some Name\"");
}