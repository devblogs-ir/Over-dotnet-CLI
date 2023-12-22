using System.Diagnostics;
using System.Text;

public static class Methods
{
    public static void ExecuteCommands(List<string> commands)
    {
        foreach (string command in commands)
        {
            string[] identifier = command.Split(' ');
            if(identifier[0] == "cd")
            {
                if(identifier[1] == "..")
                {
                    string envStr = string.Empty;
                    List<string> env = Environment.CurrentDirectory.Split("\\").ToList();

                    env.RemoveAt(env.Count - 1);

                    foreach(var val in env)
                    {
                        envStr += val + "\\";
                    }

                    envStr = envStr.Remove(envStr.Length - 1, 1);

                    Environment.CurrentDirectory = envStr;
                }
                else
                {
                    Environment.CurrentDirectory += $"\\{identifier[1]}";
                }
            }
            else
            {
                Stopwatch stopwatch = Stopwatch.StartNew();

                StringBuilder outputBuilder = new StringBuilder();
                StringBuilder errorBuilder = new StringBuilder();

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = $"/c {command}";
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.WorkingDirectory = Environment.CurrentDirectory;

                Process process = new Process();
                process.StartInfo = startInfo;

                process.OutputDataReceived += (sender, args) => { if (args.Data != null) outputBuilder.AppendLine(args.Data); };
                process.ErrorDataReceived += (sender, args) => { if (args.Data != null) errorBuilder.AppendLine(args.Data); };

                process.Start();

                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                process.WaitForExit();

                while (!process.HasExited)
                {
                    Task.Delay(100).Wait();
                }

                string output = outputBuilder.ToString();
                string error = errorBuilder.ToString();

                if (!Directory.Exists("C:\\maha-builder\\logs"))
                    Directory.CreateDirectory("C:\\maha-builder\\logs");

                if (!string.IsNullOrEmpty(output))
                    System.IO.File.WriteAllText($"C:\\maha-builder\\logs\\outputLog_{string.Concat(DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString(), DateTime.Now.Hour.ToString(), DateTime.Now.Minute.ToString(), DateTime.Now.Second.ToString(), DateTime.Now.Millisecond.ToString())}.txt", output);

                if (!string.IsNullOrEmpty(error))
                    System.IO.File.WriteAllText($"C:\\maha-builder\\logs\\errorLog_{string.Concat(DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString(), DateTime.Now.Hour.ToString(), DateTime.Now.Minute.ToString(), DateTime.Now.Second.ToString(), DateTime.Now.Millisecond.ToString())}.txt", error);

                stopwatch.Stop();

                TimeSpan ts = stopwatch.Elapsed;
                string timeWaiting = string.Format("{0}:{1}", Math.Floor(ts.TotalMinutes), ts.ToString("ss\\.ff"));

                if (string.IsNullOrEmpty(error))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Commands completed successfully ({timeWaiting}).");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Output Message : ");
                    Console.WriteLine(output);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error ... (CHECK LOGS) ({timeWaiting}).");
                }
            }
        }
    }
}