using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CommandTemplates
{
    public static class CheckProjectNameValidity
    {
        public static bool CheckProjectName(string folderName)
        {
            if (string.IsNullOrEmpty(folderName))
            {
                
                return false;
            }
            return true;
        }
        public static bool CheckDircectory(string folderName)
        {
            if (Directory.Exists(folderName))
            {
                return false;
            }
            return true;
        }
    }
}
