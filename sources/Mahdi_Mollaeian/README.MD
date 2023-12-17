# Hi, i'm mahdi
you can find me here [blog](https://www.dntips.ir/user/%d9%85%d9%87%d8%af%db%8c%20%d9%85%d9%84%d8%a7%d8%a6%db%8c%d8%a7%d9%86)
## First Exercise
```
git clone repo
cd over-dotnet-cli
cd sources
md  Mahdi_Mollaeian
cd Mahdi_Mollaeian
md  src
    cd src
    	dotnet new console -o MyApp.Console
    	dotnet new classlib -o MyApp.Lib
    	dotnet new webapi -o MyApp.Api
    md test
    	dotnet new xunit -o MyApp.Console.Test
    		dotnet add package FluentAssertions --version 6.12.0
    		dotnet add reference ..\..\src\MyApp.Console\MyApp.Console.csproj
    	dotnet new xunit -o MyApp.Lib.Test
    		dotnet add package FluentAssertions --version 6.12.0
    		dotnet add reference ..\..\src\MyApp.Lib\MyApp.Lib.csproj
    	dotnet new xunit -o MyApp.Api.Test
    		dotnet add package FluentAssertions --version 6.12.0
    		dotnet add reference ..\..\src\MyApp.Api\MyApp.Api.csproj
```