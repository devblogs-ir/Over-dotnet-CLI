md src
md test
dotnet new sln
cd src
dotnet new console -n MyConsoleProject
dotnet new classlib -n MyClassLibProject
dotnet new webapi -n MyWebApiProject
cd ..
dotnet sln add .\src\MyClassLibProject\
dotnet sln add .\src\MyConsoleProject\
dotnet sln add .\src\MyWebApiProject\
cd test
dotnet new xunit -n MyConsoleProject.Tests
dotnet new xunit -n MyClassLibProject.Tests
dotnet new xunit -n MyWebApiProject.Tests
cd ..
dotnet sln add .\test\MyConsoleProject.Tests\
dotnet sln add .\test\MyClassLibProject.Tests\
dotnet sln add .\test\MyWebApiProject.Tests\
cd .\test\MyConsoleProject.Tests\
dotnet add package FluentAssertions
dotnet add reference ..\..\src\MyConsoleProject\
cd ..\MyClassLibProject.Tests\
dotnet add package FluentAssertions
dotnet add reference ..\..\src\MyClassLibProject\
cd ..\MyWebApiProject.Tests\
dotnet add package FluentAssertions
dotnet add reference ..\..\src\MyWebApiProject\