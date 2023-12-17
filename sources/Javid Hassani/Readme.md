# Hi there 👋

### Im Javid Hassani you can find me [here](https://www.linkedin.com/in/javid-hassani/)

##### this read me helps you to create a new dotnet project structure via dotnet-cli

## Step 1: Create a Solution
```bash
dotnet new sln -n SolutionName
```

## Step 2: Create a Console Application
```bash 
dotnet new console --name console-name
```

## Step 3: Create a Class Library 
```bash 
dotnet new classlib --name class-library-name
```
## Step 4: Createing Test Projects
```bash
#create a directory for tests
mkdir tests

# create test projects
dotnet new xunit Console.Tests
dotnet new xunit WebApi.Tests
dotnet new xunit ClassLibrary.Tests
```

## Step 5: adding nuget package to test projects
you can use this command to add any packages or project refrences to any project
to apply this command you first need to go to the project directory,
then run this command: 
```bash 
# for adding nuget packages
dotnet add package package-name or id

# for adding project refrence
dotnet add refrence address-of-project-you-want-to-add-the-refrence
```

```bash 
# move to each project directory then run the following command
dotnet add package FluentAssertions
# to add an specific version use --version <value> option

