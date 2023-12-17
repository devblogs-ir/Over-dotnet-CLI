# Welcome to the project!

Let's get in touch [here][myLinkedIn]!


# Here are the steps you need to follow to build a .NET tool using CLI commands.
## Launch Project

1. Create a new folder named `Nazanin-Abbasi` using the command `md Nazanin-Abbasi`.
2. Create a `README.md` file using the command `echo > README.md`.
3. Create a new directory named `src` using the command `md src`.
4. Navigate to the created folder using the command `cd src`.
5. Add a blank solution using the command `dotnet new sln -n NazaninBuilder`.
6. Create a new console project using the command `dotnet new console -n Builder.Console`.
7. Add the console app to the solution using the command `dotnet sln add .\Builder.Console\Builder.Console.csproj`.

## Develop Project

8. Pack the project using the command `dotnet pack`.
9. Install the package using the command `dotnet tool install --global --add-source .\Builder.Console\nupkg\ Builder.Console`.

### Tool

10. Create a new directory named `src` using the command `md src`.
11. Navigate to the created folder using the command `cd src`.
12. Add a blank solution using the command `dotnet new sln -n NazaninBuilder`.
13. Create a new console project using the command `dotnet new console -n [ConsoleProject-name]`.
14. Create a new Class Library using the command `dotnet new classlib -n ClassLibrary.Cli`.
15. Create a new webapi project using the command `dotnet new webapi -n WebApi.Cli`.
16. Add a new directory named `test` using the command `md test`.
17. Navigate to the test directory using the command `cd [path]`.
18. Create a new xunit test project using the command `dotnet new xunit -n [x.tests]`.
19. Create a new xunit test project using the command `dotnet new xunit -n [y.tests]`.
20. Create a new xunit test project using the command `dotnet new xunit -n [z.tests]`.
21. Add the created projects to the solution using the command `dotnet sln add (ls -r **/*.csproj)`.
22. Navigate to root then build the project using the command `dotnet build`.
23. Add reference to the project tests by navigating to the target folder and using the command `dotnet add reference [source path]`.

[myLinkedIn]: <https://www.linkedin.com/in/nazanin-abbasi/>