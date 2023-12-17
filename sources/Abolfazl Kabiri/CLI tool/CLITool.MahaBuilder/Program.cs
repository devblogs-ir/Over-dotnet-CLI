
using CLITool.MahaBuilder.GrammaticalPatterns;
using CLITool.MahaBuilder.Templates;
using CommandLine;
using System.Diagnostics;
using System.Text.Json;

public class Program
{
    static string _templatePath = Path.Combine(Directory.GetCurrentDirectory(), "templates.txt");
    public static void Main(string[] args)
    {
        Template template;
        List<string> commands;
        Parser.Default.ParseArguments<TemplatePattern>(args)
        .WithParsed(options =>
        {

            if (options.CommandType.Equals("new"))
            {
                template = new Template
                {
                    Name = options.Name,
                };

                if (File.Exists(_templatePath))
                {
                    var templates = GetTemplates();
                    if (templates is not null)
                    {
                        Template buildTemplate = templates.Find(indexer => indexer.Name.Equals(options.Name));
                        if (buildTemplate is not null)
                        {
                            throw new Exception("the template has exists.");
                        }
                    }
                }

                commands = [$"md {options.Name}"];


                byte commandCounter = 1;

                while (true)
                {
                    Console.Write($"Please enter command {commandCounter} (for exit press e) : ");
                    var inputCommand = Console.ReadLine();
                    if (inputCommand.Equals("e"))
                    {
                        template.Commands = commands;
                        WriteToFile(template);
                        Console.WriteLine($"the template {options.Name} created successfully.");
                        break;
                    }
                    commands.Add(inputCommand);

                    commandCounter++;
                }

            }
            else if (options.CommandType.Equals("build"))
            {
                Template buildTemplate = GetTemplates()?.Find(indexer => indexer.Name.Equals(options.Name));
                if (buildTemplate is null)
                {
                    throw new Exception("the template was not found.");
                }
                else
                {
                    foreach (var command in buildTemplate.Commands)
                    {
                        ExecuteCommand(command);
                    }
                }
            }
            else
            {
                throw new Exception("invalid cammant type argument, please choose new or build option");
            }
        });
        WriteToFile(new Template());
    }
    public static void ExecuteCommand(string command)
    {
        var processStartInfo = new ProcessStartInfo();
        processStartInfo.FileName = "powershell.exe";
        processStartInfo.Arguments = $"-Command \"{command}\"";
        processStartInfo.UseShellExecute = false;
        processStartInfo.RedirectStandardOutput = true;

        using var process = new Process();
        process.StartInfo = processStartInfo;
        process.Start();
        string output = process.StandardOutput.ReadToEnd();
        Console.WriteLine(output);
    }

    private static void WriteToFile(Template template)
    {

        if (!File.Exists(_templatePath))
        {

            List<Template> templates = [template];
            string json = JsonSerializer.Serialize(templates);

            File.WriteAllText(_templatePath, json);
        }
        else
        {
            var templates = GetTemplates();
            templates.Add(template);
            string json = JsonSerializer.Serialize(templates);
            File.WriteAllText(_templatePath, json);
        }



    }

    public static List<Template> GetTemplates()
    {
        string text = File.ReadAllText(_templatePath);
        return JsonSerializer.Deserialize<List<Template>>(text) ?? new();
    }

}
