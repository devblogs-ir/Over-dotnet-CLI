# Hi There 👋🏼
You can find me here [linkedin](https://www.linkedin.com/in/amir-fazlali/)

## Follow these instructions:
# 1. Go to the desired location :
```
cd [target-location]
```
# 2. Create a folder with the desired name :
```
md [your-folder-name]
```
# 3. Go into [your-folder-name] directory :
```
cd [your-folder-name]
```

# 4. Create two folders called 'src' and 'test' : 
```
md src
md test
```

# 5. Go into 'src' directory :
```
cd src 
```
# 6. Create a console project :
```
dotnet new console --name [your-console-project-name]
```
# 7. Create a class library project :
```
dotnet new classlib --name [your-classlib-project-name]
```
# 8. Create a web api project :
```
dotnet new webapi --name [your-api-project-name] 
```
# 9. Go back one folder and enter the test folder :
```
cd ..
cd test
```
# 10. Create a test project for the console application :
```
dotnet new xunit --name [your-test-console-project-name] 
```
# 11. Go into [your-test-console-project-name] and install fluentAssersion package :
``` 
cd [your-test-console-project-name] 
dotnet add package FluentAssertions 
```
# 12. Referencing the test to the console application :
```
dotnet add reference ../../src/[your-console-project-name]/[your-console-project-name].csproj
```
# 13. Create a test project for the class library :
```
cd ..
dotnet new xunit --name [your-test-classlib-project-name] 
```
# 14. Go into [your-test-classlib-project-name] and install fluentAssersion package :
``` 
cd [your-test-classlib-project-name] 
dotnet add package FluentAssertions 
```
# 15. Referencing the test to the class library :
```
dotnet add reference ../../src/[your-classlib-project-name]/[your-classlib-project-name].csproj
```
# 16. Create a test project for the webapi project :
```
cd ..
dotnet new xunit --name [your-test-api-project-name] 
```
# 17. Go into [your-test-api-project-name] and install fluentAssersion package :
``` 
cd [your-test-api-project-name] 
dotnet add package FluentAssertions 
```
# 18. Referencing the test to the class library :
```
dotnet add reference ../../src/[your-api-project-name]/[your-api-project-name].csproj
```