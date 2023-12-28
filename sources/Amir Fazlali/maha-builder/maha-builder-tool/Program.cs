using CommandLine;

static class Program
{
   static void Main(string[] args)
   {
        Parser.Default.ParseArguments<Options>(args)
        .WithParsed(o =>
        {
            if(string.IsNullOrEmpty(o.Name))
            {
                Console.WriteLine("Please enter a name for the folder !");
                return;
            }

            if(!Directory.Exists(string.Concat("C:\\maha-builder\\", o.Name)))
            {
                Directory.CreateDirectory(string.Concat("C:\\maha-builder\\", o.Name));
            }

            Environment.CurrentDirectory = string.Concat("C:\\maha-builder\\", o.Name);

            Methods.ExecuteCommands(new List<string>{
                "md src", 
                "md test", 
                "cd src", 
                "dotnet new console --name CLI-Project", 
                "dotnet new classlib --name CLI-Project.Library", 
                "dotnet new webapi --name CLI-ProjectAPI", 
                "cd ..", 
                "cd test", 
                "dotnet new xunit --name CLI-Project.Tests", 
                "cd CLI-Project.Tests", 
                "dotnet add package FluentAssertions", 
                "dotnet add reference ../../src/CLI-Project/CLI-Project.csproj",
                "cd ..",
                "dotnet new xunit --name CLI-Project.Library.Tests", 
                "cd CLI-Project.Library.Tests", 
                "dotnet add package FluentAssertions", 
                "dotnet add reference ../../src/CLI-Project.Library/CLI-Project.Library.csproj",
                "cd ..",
                "dotnet new xunit --name CLI-ProjectAPI.Tests", 
                "cd CLI-ProjectAPI.Tests", 
                "dotnet add package FluentAssertions", 
                "dotnet add reference ../../src/CLI-ProjectAPI/CLI-ProjectAPI.csproj"
            });

        });
    }
}