# Hi there! This is **Morvarid** 
## Join me on my .NET learning journey! 
You can find me [here](https://github.com/rozhaaan) 


# Exercise 1:

1. Create two directories named src and test:
```
md src
md test
```

2. Change directory to src:
```
cd .\src
```

3. Create a Console project in src:
```
dotnet new console -n SrcConsoleApp
```

4. Create a Class Library project in src:
```
dotnet new classlib -n SrcClassLib
```

5. Create a Web API project in src:
```
dotnet new webapi -n SrcWebApi
```

6. Change directory to test:
```
cd ..\test
```

7. Create a XUnit test project:
```
dotnet new xunit -n SrcConsoleApp_Test
```

8. Go to the test project directory and install fluentAssersion package:
```
cd .\SrcConsoleApp_Test\
dotnet add package FluentAssertions
``` 

9. Refer the test project to the console project: 
```
dotnet add reference ..\..\src\SrcConsoleApp\
```

10. Repeat the 6 to 9 steps for the two other projects:
```
cd ..\
dotnet new xunit -n SrcClassLib_Test
cd .\SrcClassLib_Test\
dotnet add package FluentAssertions
dotnet add reference ..\..\src\SrcClassLib\

cd ..\
dotnet new xunit -n SrcWebApi_Test
cd .\SrcWebApi_Test\
dotnet add package FluentAssertions
dotnet add reference ..\..\src\SrcWebApi\
```


# Exercise 2
1. Create a new directory and add a new Console project to it:
```
md maha-builder
dotnet new console -n maha-builder
```

2. Open the maha-builder.csproj file and add these three XML nodes:
```
<PackAsTool>true</PackAsTool>
<ToolCommandName>maha-builder</ToolCommandName>
<PackageOutputPath>./pkg</PackageOutputPath>
```

3. Create a new NuGet package:
```
dotnet pack
```

4. Install the tool from the package using *globally*
```
dotnet tool install --global --add-source .\pkg\ maha-builder
```

5. Use the new custom command:
```
maha-builder -name "Morvarid-Arab"
```