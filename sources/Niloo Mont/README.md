# Over-dotnet-CLI
***
## Hi there 👋
Niloo Mont Here [About Me](https://www.linkedin.com/in/niloufar-mont/)
I'm a dotnet enthusiast, I'm looking for chances to boost my know-how and abilities.

#### Here's a step-by-step list of commands to create this structure:
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
dotnet new gitignore
```
4. 
```
dotnet new sln
```
5. 
```
cd src
```
6. 
```
dotnet new console -n MyConsoleProject
```
7.  
```
dotnet new classlib -n MyClassLibProject
```
8. 
```
dotnet new webapi -n MyWebApiProject
```
9. 
```
dotnet sln add .\src\MyClassLibProject\
```
10. 
```
dotnet sln add .\src\MyConsoleProject\
```
11. 
```
dotnet sln add .\src\MyWebApiProject\
```
12. 
```
cd test
```
13.  
```
dotnet new xunit -n MyConsoleProject.Tests
```
14. 
```
dotnet new xunit -n MyClassLibProject.Tests
```
15.
```
dotnet new xunit -n MyWebApiProject.Tests
```
16.
```
cd ..
```
17. 
```
dotnet sln add .\test\MyConsoleProject.Tests\
```
18. 
```
dotnet sln add .\test\MyClassLibProject.Tests\
```
19. 
```
dotnet sln add .\test\MyWebApiProject.Tests\
```
20. 
```
cd .\test\MyConsoleProject.Tests\
```
21. 
```
dotnet add package FluentAssertions
```
22. 
```
cd ..\MyClassLibProject.Tests\
```
23. 
```
dotnet add package FluentAssertions
```
24. 
```
cd ..\MyWebApiProject.Tests\
```
25. 
```
dotnet add package FluentAssertions
```
26. 
```
dotnet add reference ..\..\src\MyWebApiProject\
```
27. 
```
cd ..\MyConsoleProject.Tests\
```
28. 
```
dotnet add reference ..\..\src\MyConsoleProject\
```
29. 
```
cd ..\MyClassLibProject.Tests\
```
30. 
```
dotnet add reference ..\..\src\MyClassLibProject\
```