# Hi There


1. Create a solution named 'MyProject' 
```
dotnet new sln -n MyProject
```
2. Create a directory named 'src.'" 
```
md src
```
3. Create a directory named 'test.'" 
```
md test
``` 
4. Create a console project in src dir.
```
cd .\src\
 dotnet new console -n ConsoleProject
``` 

5. Create a class library project in src dir.
```
 dotnet new classlib -n ClassLibProject
``` 
6. Create a webapi project in src dir.
```
 dotnet new webapi -n WebApiProject
``` 
7. go to test folder and create test project for console project
```
 cd ..
 cd .\test\
 dotnet new xunit -n ConsoleProject.Test
 cd .\ConsoleProject.Test\
 dotnet add reference  ..\..\src\ConsoleProject\
 dotnet add package FluentAssertions
``` 
8. go to test folder and create test project for classlib project
```
 cd ..
 dotnet new xunit -n ClassLibProject.Test
 cd .\ClassLibProject.Test\
  dotnet add reference  ..\..\src\ClassLibProject\
  dotnet add package FluentAssertions
```
9. go to test folder and create test project for classlib project
```
 cd ..
 dotnet new xunit -n WebApiProject.Test
 cd .\WebApiProject.Test\
 dotnet add reference  ..\..\src\WebApiProject\
 dotnet add package FluentAssertions
```
10. add all projects to solution
```
 cd ../..
 dotnet sln add .\src\ClassLibProject\
dotnet sln add .\src\ConsoleProject\ 
 dotnet sln add .\src\WebApiProject\ 
 dotnet sln add .\test\ClassLibProject.Test\
 dotnet sln add .\test\ConsoleProject.Test\ 
 dotnet sln add .\test\WebApiProject.Test\ 
```