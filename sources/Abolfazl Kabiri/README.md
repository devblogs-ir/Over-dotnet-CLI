# Hi there 👋

Here are examples of working with .NET CLI written by experts.
You can find me here [Blog](https://www.linkedin.com/in/abolfazl-kabiri-64a018108/)
# Exercises
## 1 - Create this structure by using the existing commands and put them into the `readme.md` file.

```
[Your-Name-Folder]
     - src [folder]
          - console project [x]
          - class library project [y]
          - web api project [z]
     - test [folder]
          - [[x].Tests] - xunit template - install fluentAssersion package - depend on [x] project
          - [[y].Tests] - xunit template - install fluentAssersion package - depend on [y] project
          - [[z].Tests] - xunit templatee - install fluentAssersion package - depend on [z] project
```



# Exercise answer


1. 
```
md src
```
2. 
```
md test
```
3. 
```
dotnet new sln -n dotnet-CLI
```
4. 
```
cd src
```
5.
```
dotnet new console n- dotnet-CLI.Console
```
6.
```
dotnet new classlib n- dotnet-CLI.ClassLibrary
```
7.
```
dotnet new webapi n- dotnet-CLI.WebApi
```
8.
```
cd..
```
9.
```
dotnet sln add .\src\dotnet-CLI.Console
```
10.
```
dotnet sln add .\src\dotnet-CLI.ClassLibrary
```
11.
```
dotnet sln add .\src\dotnet-CLI.WebApi
```
12.
```
cd test
```
13.
```
dotnet new xunit -n dotnet-CLI.Console.Tests
```
14.
```
dotnet new xunit -n dotnet-CLI.ClassLibrary.Tests
```
15.
```
dotnet new xunit -n dotnet-CLI.WebApi.Tests
```
16.
```
cd..
```
17.
```
dotnet sln add .\test\dotnet-CLI.Console.Tests
```
18.
```
dotnet sln add .\test\dotnet-CLI.ClassLibrary.Tests
```
19.
```
dotnet sln add .\test\dotnet-CLI.WebApi.Tests
```
20.
```
cd test\dotnet-CLI.ClassLibrary.Tests
```
21.
```
dotnet add package FluentAssertions --version 6.12.0
```
22.
```
cd ..
```
23.
```
cd dotnet-CLI.Console.Tests
```
24.
```
dotnet add package FluentAssertions --version 6.12.0
```
25.
```
cd ..
```
26.
```
cd dotnet-CLI.WebApi.Tests
```
27.
```
dotnet add package FluentAssertions --version 6.12.0
```
28.
```
dotnet add reference ..\..\src\dotnet-CLI.WebApi
```
29.
```
cd..
```
30.
```
cd dotnet-CLI.Console.Tests
```
31.
```
dotnet add reference ..\..\src\dotnet-CLI.Console
```
32.
```
cd..
```
33.
```
cd dotnet-CLI.ClassLibrary.Tests
```
34.
```
dotnet add reference ..\..\src\dotnet-CLI.ClassLibrary
```
