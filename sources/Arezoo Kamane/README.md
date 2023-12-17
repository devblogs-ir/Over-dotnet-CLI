# Hi there
Im arezoo , you can find me here [linkedin](https://www.linkedin.com/in/arezoo-kamane/)

## .Net CLI Excersice 

In this exercise, we want to create project files with the help of .NET commands, and after that we use one command instead of all these commands!

2. create src directory 
```
md src
```
3. create test directory 
```
md test
```
4. change direction to src directory 
```
cd .\src\
```
5. create console project in src 
```
 dotnet new console -n ConsoleProject
```
6. create classlib project in src 
```
 dotnet new classlib -n ClassLibProject
```
7. create webapi project in src 
```
 dotnet new webapi -n WebApiProject
```
8. change direction to test directory 
```
cd ..
cd .\test\
```
9. create xunit test project for ConsoleProject
```
 dotnet new xunit -n ConsoleProject.Test
```
10. add reference to ConsoleProject and add fluentassersion package 
```
 cd .\ConsoleProject.Test\
 dotnet add reference  ..\..\src\ConsoleProject\
 dotnet add package FluentAssertions
```
11. create xunit test project for ClassLibraryProject
```
 dotnet new xunit -n ClassLibrary.Test
```
12. add reference to ClassLibrary and add fluentassersion package 
```
 cd .\ClassLibrary.Test\
 dotnet add reference  ..\..\src\ClassLibrary\
 dotnet add package FluentAssertions
```
13. create xunit test project for ClassLibraryProject 
```
 dotnet new xunit -n ClassLibrary.Test
```
14. add reference to ClassLibrary and add fluentassersion package 
```
 cd .\ClassLibrary.Test\
 dotnet add reference  ..\..\src\ClassLibrary\
 dotnet add package FluentAssertions
```

15. create xunit test project for WebApiProject 
```
 dotnet new xunit -n WebApiProject.Test
```
16. add reference to WebApiProject and add fluentassersion package 
```
 cd .\WebApiProject.Test\
 dotnet add reference  ..\..\src\WebApiProject\
 dotnet add package FluentAssertions
```


## CLI tool for creating top structure in one command 
1. Pack it 
```
dotnet pack
```
2. install package globally 
```
dotnet tool install --global --add-source .\pkg\maha-builder
```

use -n or --name as an required option for specifying project folder name. 
```
maha-builder -n FolderName
maha-builder --name FolderName
```