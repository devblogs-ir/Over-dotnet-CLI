### Create basic directory structure
```bash
cd sources/
mkdir HassanTaherian
cd HassanTaherian/
mkdir src
mkdir test
touch README.md
ls
cd src/
```
### Create a console project but with wrong .net sdk version
```bash
dotnet new console -n ConsoleClient
```

### Change .net version of .net-cli
```bash
dotnet new -h
dotnet --version
cd ..
dotnet new global.json
dotnet --list-sdks
```

### Create class library and web api projects
```bash
cd src/
dotnet new -h
dotnet new list
dotnet new classlib -n Core
dotnet new webapi -n APIClient
ls
```

### Change ConsoleClient TragetFramework
```bash
dotnet -h
dotnet sdk -h
dotnet sdk check
dotnet -h
```
- Haven't found anything, so change the .csproj manually

### create test projects
```bash
cd ../test
dotnet new list
dotnet new xunit -n ConsoleClient.Tests
dotnet new xunit -n Core.Tests
dotnet new xunit -n APIClient.Tests
ls
```

### install dependencies
```bash
dotnet -h
dotnet add -h
# Find exact name of  nuget package
dotnet nuget -h
dotnet -h
dotnet list -h
dotnet list package -h
# Couldn't find realted command so googled it:)
dotnet add package -h
dotnet add ./ConsoleClient.Tests/ package FluentAssertions
dotnet add ./Core.Tests/ package FluentAssertions
dotnet add ./APIClient.Tests/ package FluentAssertions
```
# add test project's dependencies
```bash
dotnet -h
dotnet add reference -h
dotnet add ./ConsoleClient.Tests/ reference ../src/ConsoleClient/
dotnet add ./ConsoleClient.Tests/ reference ../src/APIClient/
# Accidentlly add a invalid reference to APIClient project
# Remove invalid dependency
dotnet -h
dotnet remove -h
dotnet reference ./ConsoleClient.Tests/ reference ../src/APIClient/ # not working!
dotnet remove ./ConsoleClient.Tests/ reference ../src/APIClient/*.csproj
dotnet add ./Core.Tests/ reference ../src/Core/
dotnet add ./APIClient.Tests/ reference ../src/APIClient/
```