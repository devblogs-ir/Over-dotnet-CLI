
# Great to you
## this read me helps you to create a new dotnet project
## 1: Create a Solution
```bash
#create a directory for src
mkdir src
cd .\src\
#create a sln in src
dotnet new sln -n Over-dotnet-CLI
```
## 2: Create a Console Application
```bash 
dotnet new console -n ConsoleAppForOver-dotnet-CLI
```
## 3: Create a Class Library 
```bash 
dotnet new classlib -n class-library-name
```
## 4: Create a Web API Application 
```bash 
dotnet new classlib -n WebApplicationOver-dotnet-CLI
```
## 5: Createing Test Projects
```bash
#create a directory for tests
mkdir tests
cd .\tests\
# create test projects
dotnet new xunit Console.Tests
dotnet new xunit WebApi.Tests
dotnet new xunit ClassLibrary.Tests
```
## 6: adding Nuget package to test projects: 
```bash 
# create a directory for mha-builder
mkdir mha-builder cd .\mha-builder\

# for adding nuget packages
dotnet add package package-name or id

# for adding project refrence
dotnet add refrence address-of-project-you-want-to-add-the-refrence

# move to each project directory then run the following command
dotnet add package FluentAssertions
```