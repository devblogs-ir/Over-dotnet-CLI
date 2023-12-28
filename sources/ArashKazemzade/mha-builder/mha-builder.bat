@echo off
md ArashKazemzade
cd .\ArashKazemzade\
md src
cd .\src\
dotnet new sln -n Over-dotnet-CLI
dotnet new console -n Console.src
dotnet sln Over-dotnet-CLI.sln add Console.src\Console.src.csproj
dotnet new classlib -n classlibrary.src
dotnet sln Over-dotnet-CLI.sln add classlibrary.src\classlibrary.src.csproj
dotnet new classlib -n WebApplication.src
dotnet sln Over-dotnet-CLI.sln add WebApplication.src\WebApplication.src.csproj
cd ..
md tests
cd .\tests\
dotnet new xunit -n Console.Tests
dotnet sln Over-dotnet-CLI.sln add Console.Tests\Console.Tests.csproj
dotnet new xunit -n WebApi.Tests
dotnet sln Over-dotnet-CLI.sln add WebApi.Tests\WebApi.Tests.csproj
dotnet new xunit -n ClassLibrary.Tests
dotnet sln Over-dotnet-CLI.sln add ClassLibrary.Tests\ClassLibrary.Tests.csproj