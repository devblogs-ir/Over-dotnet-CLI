using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maha_builder
{
    public class DotnetNativeWrapper
    {
        public string GetCommands() => "md project_name\r\ncd project_name\r\ndotnet new sln -n project_name\r\nmd src\r\nmd test\r\ncd src\r\ndotnet new console -n project_name\r\ndotnet new classlib -n project_nameLib\r\ndotnet new webapi -n project_nameApi\r\ncd ../test\r\ndotnet new xunit -n Test.project_name\r\ncd ./Test.project_name\r\ndotnet add package FluentAssertions --version 7.0.0-alpha.3\r\ndotnet add reference ../../src/project_name/\r\ncd ..\r\ndotnet new xunit -n Test.project_nameApi\r\ncd ./Test.project_nameApi\r\ndotnet add package FluentAssertions --version 7.0.0-alpha.3\r\ndotnet add reference ../../src/project_nameApi/\r\ncd ..\r\ndotnet new xunit -n Test.project_nameLib\r\ncd ./Test.project_nameLib\r\ndotnet add package FluentAssertions --version 7.0.0-alpha.3\r\ndotnet add reference ../../src/project_nameApi/ \r\ncd ../..\r\ndotnet sln project_name.sln add ./src/project_name\r\ndotnet sln project_name.sln add ./src/project_nameApi\r\ndotnet sln project_name.sln add ./src/project_nameLib\r\ndotnet sln project_name.sln add ./test/Test.project_name\r\ndotnet sln project_name.sln add ./test/Test.project_nameApi\r\ndotnet sln project_name.sln add ./test/Test.project_nameLib";
       
        public async Task<string> CreateProject(string projectName)
        { 
            //DirectoryInfo exeDirinfo = new DirectoryInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //string batFilePath= exeDirinfo.Parent?.Parent?.Parent?.Parent?.FullName + "\\commands.bat";

            //if (!File.Exists(batFilePath))
            //    throw new Exception("commands.bat file not found");

            string batFileContent = GetCommands();
            string modifiedBatFileContent = batFileContent
                .Replace("project_name", projectName);
               
            string tempBatFilePath = Path.GetTempFileName();
            tempBatFilePath += ".bat";
            File.WriteAllText(tempBatFilePath, modifiedBatFileContent);

            ProcessStartInfo startInfo = new()
            {
                FileName = "cmd",
                Arguments = $"/c \"{tempBatFilePath}\"",
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
            };

            var proc = Process.Start(startInfo);

            ArgumentNullException.ThrowIfNull(proc);

            string output = proc.StandardOutput.ReadToEnd();
            await proc.WaitForExitAsync();

            return output;
        }
    }
    
}
