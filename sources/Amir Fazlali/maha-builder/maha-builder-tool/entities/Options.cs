using CommandLine;

public class Options
{
    [Option('n', "name", Required = false, HelpText = "Set folder name for projects.")]
    public string? Name {get; set;}
}