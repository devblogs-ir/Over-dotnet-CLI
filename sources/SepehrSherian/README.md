## Hi Everyone 👋

## Route Of My Operation For Make below Structure

```
[Your-Name-Folder]
     - src [folder]
          - console project [x]
          - class library project [y]
          - web api project [z]
     - test [folder]
          - [[x].Tests] - xunit template - install fluentAssersion package - depend on [x] project
          - [[y].Tests] - xunit template - install fluentAssersion package - depend on [y] project
          - [[z].Tests] - xunit templatee - install fluentAssersion package - depend on [z] project

```

## 1. In Specific Directory Make Main Folder:

```
md SepehrSherian
```

## 2. Go Into Main Folder and Make src and test Folders:

```
cd SepehrSherian
md src
md test
```

## 3. Go Into src Folder and Make Projects:

```
cd src
dotnet new console -n CLI_ConsoleProject
dotnet new classlib -n CLI_ClassLibraryProject
dotnet new webapi -n CLI_WebAPIProject
```
## 5. Go Into test Folder and Make Test Project and Add Package:

1. CLI_ConsoleProject.Tests:

```
dotnet new xunit -n CLI_ConsoleProject.Tests
```

go into CLI_ConsoleProject.Tests and add packge and depend on CLI_ConsoleProject:

```
cd CLI_ConsoleProject.Tests
dotnet add package FluentAssertions
dotnet add reference ../../src/CLI_ConsoleProject/CLI_ConsoleProject.csproj 
```

2. CLI_ClassLibraryProject.Tests:

```
dotnet new xunit -n CLI_ClassLibraryProject.Tests
```

go into CLI_ClassLibraryProject.Tests and add packge and depend on CLI_ClassLibraryProject:

```
cd CLI_ClassLibraryProject.Tests
dotnet add package FluentAssertions
dotnet add reference ../../src/CLI_ClassLibraryProject/CLI_ClassLibraryProject.csproj 
```

3. CLI_WebAPIProject.Tests:

```
dotnet new xunit -n CLI_WebAPIProject.Tests
```

go into CLI_WebAPIProject.Tests and add packge and depend on CLI_WebAPIProject:

```
cd CLI_WebAPIProject.Tests
dotnet add package FluentAssertions
dotnet add reference ../../src/CLI_WebAPIProject/CLI_WebAPIProject.csproj 
```



## 6. Commit