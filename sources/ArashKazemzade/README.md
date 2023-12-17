# Hello to you
* this read me helps you to create a new .NET project :
## Part One : You can use the following commands one by one
### 1: Create a Solution
```bash
#create a directory for src
md ArashKazemzade
cd .\ArashKazemzade\
md src
cd .\src\
dotnet new sln -n Over-dotnet-CLI
```
### 2: Create a Console Application
```bash 
dotnet new console -n Console.src
```
### 3: Create a Class Library 
```bash 
dotnet new classlib -n classlibrary.src
```
### 4: Create a Web API App
```bash 
dotnet new classlib -n WebApplication.src
```
### 5: Createing Test Projects
```bash
cd ..
md tests
cd .\tests\
dotnet new xunit -n Console.Tests
dotnet new xunit -n WebApi.Tests
dotnet new xunit -n ClassLibrary.Tests
```
## Part two : You can run all commands at once by running the mha-builder.bat in the mha-builder folder