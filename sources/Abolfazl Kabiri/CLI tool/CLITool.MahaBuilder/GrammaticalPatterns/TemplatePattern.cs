using CommandLine;

namespace CLITool.MahaBuilder.GrammaticalPatterns
{
    public class TemplatePattern
    {
        [Option(shortName: 'c', longName: "commandtype", HelpText = "the commands : new = new template, build = build template", Required = true)]
        public required string CommandType { get; set; }

        [Option(shortName: 'n', longName: "name", HelpText = "the name of your template", Required = true)]
        public required string Name { get; set; }
    }
}
