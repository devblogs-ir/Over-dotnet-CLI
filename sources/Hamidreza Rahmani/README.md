# Hi There
I'm Hamidreza.You can find me in here [blog](https://www.linkedin.com/in/hamidreza-rahmani-67730a198/).

 
## Please follow this instruction To make the Project:


# 1- Make  Source And Test Directory 
```
md src
md test
* in Linux operating system use "mkdir" command 
```

# 2- make  Console Project 
```
cd src 
dotnet new console -n ConsoleProject
```
# 3- Make Class Library Project 
```
dotnet new classlib --n classLibraryProject
```

# 4- Make Web Api Project 
```
dotnet new webapi -n webApiProject 
```

# 5- change directory to test 
```
cd..
cd test
```
# 6- Make console test project
```
dotnet new xunit --name ConsoleProjectTest 
```
# 7- install FluentAssertions Package 
``` 
cd consoleprojectTest 
dotnet add package FluentAssertions 
```
# 8- add reference to ConsoleProject 
```
dotnet add reference ../../src/ConsoleProject/consoleProject.csproj
```

# 9-- Make classLibrary test project
```
cd..
dotnet new xunit --name classLibraryProjectTest 
```
# 10- add reference to classLibraryProject
```
cd classLibraryProjectTest 
dotnet add package FluentAssertions
dotnet add reference ../../src/classLibraryProject/classLibraryProject.csproj 
```

# 11-- Make webApiProjectTest test project
```
cd..
dotnet new xunit --name webApiProjectTest  
```

# 12- add reference to webApiProject 
```
cd webApiProjectTest 
dotnet add package FluentAssertions 
dotnet add reference ../../src/webApiProject/webApiProject.csproj 
```







