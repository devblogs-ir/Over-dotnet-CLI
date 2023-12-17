using CommandLine;

namespace mha_builder
{
    public class Options
    {
        [Option("name", Required = true)]
        public string Name { get; set; }
    }
}
