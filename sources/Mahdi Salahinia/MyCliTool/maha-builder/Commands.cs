using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maha_builder
{
    public class Commands
    {
        public const string SrcDirectory = "src";
        public const string TestDirectory = "test";

        public const string ConsoleProjDirectory = "ConsoleProject";
        public const string ClassLibProjDirectory = "ClassLibProject";
        public const string WebApiProjDirectory = "WebApiProject";

        public const string ConsoleTestProjDirectory = "ConsoleProject.Test";
        public const string ClassLibTestProjDirectory = "ClassLibProject.Test";
        public const string WebApiTestProjDirectory = "WebApiProject.Test";

        public const string AddReference = "dotnet add reference";
        public const string AddFluentAssertionPackage = "dotnet add package FluentAssertions";

        public const string CreateConsoleProj = "dotnet new console -n ConsoleProject";
        public const string CreateClassLibProj = "dotnet new classlib -n ClassLibProject";
        public const string CreateWebApiProj = "dotnet new webapi -n WebApiProject";

        public const string CreateConsoleTestProj = "dotnet new xunit -n ConsoleProject.Test";
        public const string CreateClassLibTestProj = "dotnet new xunit -n ClassLibProject.Test";
        public const string CreateWebApiTestProj = "dotnet new xunit -n WebApiProject.Test";
    }
}
