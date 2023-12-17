cd HosseinAbdi\src
dotnet new console  --name consoleProject
dotnet new classlib --name classLibraryProject
dotnet new webapi   --name webApiProject
cd ..
cd test
dotnet new xunit -n consoleProject.Tests
dotnet new xunit -n classLibraryProject.Tests
dotnet new xunit -n webApiProject.Tests

cd consoleProject.Tests
dotnet add package FluentAssertions
dotnet add reference ..\..\src\consoleProject\

cd ..
cd classLibraryProject.Tests
dotnet add package FluentAssertions
dotnet add reference ..\..\src\classLibraryProject\

cd ..
cd webApiProject.Tests
dotnet add package FluentAssertions
dotnet add reference ..\..\src\webApiProject\