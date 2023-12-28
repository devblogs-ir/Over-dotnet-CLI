@echo off
REM Creating the main project folder
md MentoringFirstProject
cd MentoringFirstProject

REM Creating a solution file
dotnet new sln -n MentoringFirstProject

REM Creating Console, Class Library, and Web API Projects
md src
cd src
dotnet new console --name "ConsoleProject"
dotnet new classlib --name "ClassLibraryProject"
dotnet new webapi --name "WebApiProject"

REM Creating test projects
cd ..
md tests
cd tests

REM Console Project Test
dotnet new xunit -n "ConsoleProject.Tests"
cd "ConsoleProject.Tests"
dotnet add package FluentAssertions
dotnet add reference ../../src/ConsoleProject/ConsoleProject.csproj

REM Class Library Project Test
cd ..
dotnet new xunit -n "ClassLibraryProject.Tests"
cd "ClassLibraryProject.Tests"
dotnet add package FluentAssertions
dotnet add reference ../../src/ClassLibraryProject/ClassLibraryProject.csproj

REM Web API Project Test
cd ..
dotnet new xunit -n "WebApiProject.Tests"
cd "WebApiProject.Tests"
dotnet add package FluentAssertions
dotnet add reference ../../src/WebApiProject/WebApiProject.csproj

REM Git initialization and commit
cd ../../..
git init
git add -A
git commit -m "Initial Projects ConsoleProject, ClassLibraryProject, WebApiProject ,ConsoleProject.Tests, ClassLibraryProject.Tests, WebApiProject.Tests"
