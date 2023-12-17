#Hi There 🙌
#Please run commands step by step
1 =>
```
md src
```
2 =>
```
md test
```
3 =>
```
dotnet new sln -n MyCliProjects
```
4 =>
```
cd src
```
5 =>
```
dotnet new console n- MyConsoleProj
```
6 =>
```
dotnet new classlib n- MyClassLibProj
```
7 =>
```
dotnet new webapi n- MyWebApiProj
```
8 =>
```
cd..
```
9 =>
```
dotnet sln add .\src\MyConsoleProj
```
10 =>
```
dotnet sln add .\src\MyClassLibProj
```
11 =>
```
dotnet sln add .\src\MyWebApiProj
```
12 =>
```
cd test
```
13 =>
```
dotnet new xunit -n ClassLib.Test
```
14 =>
```
dotnet new xunit -n ConsoleProj.Test
```
15 =>
```
dotnet new xunit -n WebApiProj.Test
```
16 =>
```
cd..
```
17 =>
```
dotnet sln add .\test\WebApiProj.Test
```
18 =>
```
dotnet sln add .\test\ClassLib.Test
```
19 =>
```
dotnet sln add .\test\ConsoleProj.Test
```
20 =>
```
cd test\ConsoleProj.Test
```
21 =>
```
dotnet add package FluentAssertions
```
22 =>
```
cd ..
```
23 =>
```
cd test\ClassLib.Test
```
24 =>
```
dotnet add package FluentAssertions
```
25 =>
```
cd ..
```
26 =>
```
cd test\WebApiProj.Test
```
27 =>
```
dotnet add package FluentAssertions
```
28 =>
```
dotnet add reference ..\..\src\WebApiProj.Test
```
29 =>
```
cd..
```
30 =>
```
cd ConsoleProj.Test
```
31 =>
```
dotnet add reference ..\..\src\MyConsoleProj
```
32 =>
```
cd..
```
33 =>
```
cd ClassLib.Test
```
34 =>
```
dotnet add reference ..\..\src\MyClassLibProj
```
