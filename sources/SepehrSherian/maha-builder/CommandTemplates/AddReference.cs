using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandTemplates
{
    public static class AddReference
    {
        public static string Add(string refrencePath)
        {
            if (!string.IsNullOrEmpty(refrencePath))
            {
                var command = new StringBuilder();
                command.Append($"dotnet add reference {refrencePath}");
                return command.ToString();
            }
            else return "error";
        }
    }
}
