md ArashKazemzade
cd .\ArashKazemzade\
md src
cd .\src\
dotnet new sln -n Over-dotnet-CLI
dotnet new console -n Console.src
dotnet new classlib -n classlibrary.src
dotnet new classlib -n WebApplication.src
cd ..
md tests
cd .\tests\
dotnet new xunit -n Console.Tests
dotnet new xunit -n WebApi.Tests
dotnet new xunit -n ClassLibrary.Tests
