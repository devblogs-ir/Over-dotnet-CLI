using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maha_builder
{
    public class ArgumentSetting
    {
        public static string? ParseArgumentValue(string[] args, string argumentName)
        {
            for (int i = 0; i < args.Length - 1; i++)
            {
                if (args[i].Equals(argumentName, StringComparison.OrdinalIgnoreCase))
                {
                    return args[i + 1];
                }
            }
            return null;
        }
    }
}
