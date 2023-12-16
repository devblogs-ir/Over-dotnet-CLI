## Hi there 
## this repo implement the structure of a project as bellow and then make a CLI Tool Named "FirstProject" that create the entire project automatically by a command.
## Follow this instruction To make the Project:
# 1- Git Initialation :
```
git init 
```
# 2- Make Root Directory of structur that hold source and Test directorys 
```
md "HosseinAbdi"
```
# 3- Go into HosseinAbdi Directory 
```
cd "hosseinAbdi"
```

# 4- Make  Source And Test Directory 
```
md "src"
md "test"
```

# 5- make  Console Project in src folder 
```
cd src 
dotnet new console --name "ConsoleProject"
```

# 6- stage and Commit "Creating Console Project"
```
git add -A
git commit "Console Project Created"
```

# 7- Make Class Library Project 
```
dotnet new classlib --name classLibraryProject
```
# 8- stage changes and commit 
```
git add -A 
git commit -m "class Library Project Created"
```
# 9- Make Web Api Project 
```
dotnet new webapi --name webApiProject 
```
# 10- stage changes and commit 
```
git add -A 
git commit -m "Web Api Project Created"
```
# 11- change directory to test for making test Projects
```
cd..
cd test
```
# 12- Make test project for console application 
```
dotnet new xunit --name ConsoleProjectTest 
```
# 13- install FluentAssertions Package 
``` 
cd consoleprojectTest 
dotnet add package FluentAssertions 
```
# 14- depend test Project to ConsoleProject 
```
dotnet add reference ../../src/ConsoleProject/consoleProject.csproj
```
# 15- stage changes and commit 
```
git add -A
git commit -m "test project for ConsoleProject Created then add fluentAssertions Package and depend to console Project"
```
# 16- make test project for class library project 
```
cd..
dotnet new xunit --name classLibraryProjectTest 
```
# 17- install FluentAssertions package and depend testproject to classLibraryProject
```
dotnet add package FluentAssertions
dotnet add reference ../../src/classLibraryProject/classLibraryProject.csproj 
```
# 18- stage changes and commit 
``` 
git add -A
git commit -m "test Project for class Library Project Created then add FluentAssertions package and depend to classLibraryProject"
``` 
# 19- make test project for web Api project 
```  
dotnet new xunit --name webApiProjectTest 
``` 
# 20- install FlunetAssertions Package and depend test to webApiProject 
``` 
dotnet add package FluentAssertions 
dotnet add reference ../../src/webApiProject/webApiProject.csproj 
``` 
# 21- stage changes and Commit 
```  
git add -A 
git commit "git 



