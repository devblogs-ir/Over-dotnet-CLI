
using System.Diagnostics;
using System.IO;
using static System.Console;

public class Program
{
    public static  void Main(string[] args)
    {
     if(args.Length==0)
     {
        WriteLine("Invalid Input!!!,please try again.");
        return;
     }  
     
     string folderName=args[1];  
     string directoryPath=Directory.GetCurrentDirectory();
     string ProjectRootDirectory=Path.Combine(directoryPath,folderName);
     Directory.CreateDirectory(ProjectRootDirectory);
     string srcFolderPath=Path.Combine(ProjectRootDirectory,"src");
     string testFolderPath=Path.Combine(ProjectRootDirectory,"test");
     Directory.CreateDirectory(srcFolderPath);
     Directory.CreateDirectory(testFolderPath);

      ProcessStartInfo startInfo = new()
    {
        FileName = "cmd",
        Arguments = "/c \"commands.bat\"",
        CreateNoWindow = true,
        RedirectStandardOutput = true,
        RedirectStandardError = true,
    };
    
    var proc = Process.Start(startInfo);
    ArgumentNullException.ThrowIfNull(proc);
    string output = proc.StandardOutput.ReadToEnd();
    proc.WaitForExitAsync();
    }
}
    
     
    

    

   



