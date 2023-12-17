# dotnet-CLI 

> You can find me in [likned in](https://linkedin.com/in/fatemeh-vahdati-259235b5) 

**Using .Net CLI (Command Line)**

1. create src folder
``` 
mkdir src 
cd src

``` 
2. create a console project
```
dotnet new console -n ConsoleProject1
```
3. create a class library
```
dotnet new  classlib -n ClassLibrary1
```
4. create a web api project
```
dotnet new  webapi -n WebApi1 

```
5. back to base folder
```
cd ..
```
6. create test folder
```
mkdir test
cd test
```
7. create xunit template (ConsoleProject1.Test) and its references
```
dotnet new xunit -n ConsoleProject1.Test  
cd ConsoleProject1.Test
dotnet add package FluentAssertions
dotnet add reference ../../src/ConsoleProject1
```
8. create xunit template (ClassLibrary1.Test) and its references 
```
dotnet new xunit -n ClassLibrary1.Test
cd ClassLibrary1.Test
dotnet add package FluentAssertions
dotnet add reference ../../src/ClassLibrary1
```
9. create xunit template (WebApi1.Tests) and its references 
```
dotnet new xunit -n WebApi1.Tests
cd WebApi1.Tests
dotnet add package FluentAssertions
dotnet add reference ../../src/WebApi1
```
