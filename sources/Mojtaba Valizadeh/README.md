# Hi There
I'm mojtaba.You can find me in here [blog](https://www.linkedin.com/in/mojtaba-valizade/).
In the below I've documented the steps taken to develop this project.
1. Create a directory named 'src.'" 
```
md src
```
2. Create a directory named 'test.'" 
```
md test
``` 
3. Create a console project in src dir.
```
cd .\src\
 dotnet new console -n ConsoleProject
``` 

4. Create a class library project in src dir.
```
 dotnet new classlib -n ClassLibProject
``` 
5. Create a webapi project in src dir.
```
 dotnet new webapi -n WebApiProject
``` 
6. go to test folder and create test project for console project
```
 cd ..
 cd .\test\
 dotnet new xunit -n ConsoleProject.Test
 cd .\ConsoleProject.Test\
 dotnet add reference  ..\..\src\ConsoleProject\
 dotnet add package FluentAssertions
``` 
7. go to test folder and create test project for classlib project
```
 cd ..
 dotnet new xunit -n ClassLibProject.Test
 cd .\ClassLibProject.Test\
  dotnet add reference  ..\..\src\ClassLibProject\
  dotnet add package FluentAssertions
``` 