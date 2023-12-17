using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandTemplates
{
    public static class NewCommand
    {

        public static string MakeNewFolder(string FolderName)
        {
            if (!string.IsNullOrEmpty(FolderName))
            {
                var command = new StringBuilder();
                command.Append($"md {FolderName}");
                return command.ToString();
            }
            else return "error";
        }
        public static string MakeNewProject(string ProjectType, string ProjectName)
        {
            if (!string.IsNullOrEmpty(ProjectType) || !string.IsNullOrEmpty(ProjectName))
            {
                var command = new StringBuilder();
                command.Append($"dotnet new {ProjectType} -n {ProjectName}");
                return command.ToString();
            }
            else return "error";
        }
    }
}
