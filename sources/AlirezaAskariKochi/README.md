# Mentoring First Project
[![N|Solid](https://wakeupandcode.com/wp-content/uploads/2019/03/C.NET_-1024x384-1.png)](https://wakeupandcode.com/csharp-resources/)
## _Welcome to our first ASP.NET Project!_
This initiative focuses on leveraging the Command Line Interface (CLI) to develop a robust ASP.NET application. Our goal is to create an efficient and user-friendly platform using the latest ASP.NET technologies.

If you have any questions or need further information, please feel free to reach out. You can contact me directly via [email](Alireza_Askari_Kochi@outlook.com), or connect with me on [LinkedIn](https://www.linkedin.com/in/alireza-askari-kochi-2274475a/) for a more detailed discussion.

Additionally, I encourage you to explore my other projects on [GitHub](https://github.com/AlirezaAskariKochi), where I share various works that might interest you. Your feedback and contributions to those projects are always welcome!

---
# Folow below cods step by step to creat the project
1. Creat a folder
```
md MentoringFirstProject
cd MentoringFirstProject
```
2. creat an soluition 
```
dotnet new sln -n MentoringFirstProject
```

3. Create Console Project in src folder:
```
md src
cd src
dotnet new console --name "ConsoleProject"
```
4. Create Class Library Project in src folder:
```
dotnet new classlib --name ClassLibraryProject
```
5. Create Web API Project in src folder:
```
dotnet new webapi --name WebApiProject
```
# _Test_
6. Create Test Projects:
```
cd ../MentoringFiorstProject
md tests
cd tests
```

>a. Console Project Test:
```
dotnet new xunit -n "ConsoleProject.Tests"
cd "ConsoleProject.Tests"
dotnet add package FluentAssertions
dotnet add reference ../../src/ConsolProject/ConsolProject.csproj
```

>b. Class Library Project Test:
```
cd ..
dotnet new xunit -n ClassLibraryProject.Tests
cd ClassLibraryProject.Tests
dotnet add package FluentAssertions
dotnet add reference ../../src/ClassLibraryProject/ClassLibraryProject.csproj
```
> c. Web API Project Test:
```
cd ..
dotnet new xunit -n WebApiProject.Tests
cd WebApiProject.Tests
dotnet add package FluentAssertions
dotnet add reference ../../src/WebAiProject/WebAiProject.csproj
```

6. Git Commit - Initial Projects:
```
git add -A
git commit -m "Initial Projects ConsoleProject, ClassLibraryProject, WebApiProject ,ConsoleProject.Tests, ClassLibraryProject.Tests, WebApiProject.Tests"
```