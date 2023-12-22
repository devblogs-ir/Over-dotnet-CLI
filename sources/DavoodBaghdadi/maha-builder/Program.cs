

using System.Diagnostics;

public class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("maha-builder Runned!");
        ProcessStartInfo processStartInfo = new ProcessStartInfo();
        processStartInfo.FileName = "Developer Powershell for VS 2022";
        processStartInfo.RedirectStandardOutput = true;
        processStartInfo.RedirectStandardInput = true;
        processStartInfo.UseShellExecute = false;

        var dotnetCommandProcess = Process.Start(processStartInfo);
        dotnetCommandProcess.StandardInput.WriteLine("dotnet list -h");

        //dotnetCommandProcess.StandardInput.WriteLine("exit");

        dotnetCommandProcess.WaitForExit();
        dotnetCommandProcess.StandardOutput.ReadToEnd();

        // ProcessStartInfo pi = new ProcessStartInfo("stats");
        //pi.Arguments = @"dotnet new list";
        //pi.WorkingDirectory = @"C:\Coding\TestMaterial\myConsole\myfile.txt";
        //pi.UseShellExecute = false;
        //Process.Start(pi);
    }
}


