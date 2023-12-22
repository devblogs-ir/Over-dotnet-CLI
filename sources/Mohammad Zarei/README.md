# Setting Up Your .NET Solution 🚀

## Hello there! 👋

Welcome to a straightforward guide for setting up your .NET solution with the dotnet CLI. Let's simplify your project organization!

### Step 1: Create Solution 📦

Start by giving life to your solution named `MySolution`:

```sh
dotnet new sln -n "MySolution"
```

### Step 2: Organize Your Workspace 📂

Create two essential directories, `src` for your source code and `test` for testing:

```sh
mkdir "src"
mkdir "test"
```

### Step 3: Dive Into The Source Code 📁

Navigate into the `src` directory:

```sh
cd src/
```

### Step 4: Bring Projects To Life 🚀

Now, let's create some projects! Starting with a `console` project:

```sh
dotnet new console -n "ConsoleProject"
```

Next, a `classlib` project:

```sh
dotnet new classlib -n "ClassLibProject"
```

And a fantastic `webapi` project:

```sh
dotnet new webapi -n "WebApiProject"
```

### Step 5: Move to Testing Grounds 🧪

Transition smoothly to the `test` directory:

```sh
cd ../test
```

### Step 6: Let's Test! 🧾

Create create `test` projects:

```sh
dotnet new xunit -n "ConsoleProject.Tests"
dotnet new xunit -n "ClassLibProject.Tests"
dotnet new xunit -n "WebApiProject.Tests"
```

### Step 7: Let's Assemble The Solution 📂

Now, let's gather all these amazing projects under one roof:

```sh
cd ../
dotnet sln add src/ConsoleProject
dotnet sln add src/ClassLibProject
dotnet sln add src/WebApiProject
dotnet sln add Test/ConsoleProject.Tests
dotnet sln add Test/ClassLibProject.Tests
dotnet sln add Test/WebApiProject.Tests
```

### Step 8: Power Up with Packages and References 🚀

Let's enhance projects by adding some magic

#### ConsoleProject.Tests

```sh
cd test/ConsoleProject.Tests/
dotnet add package FluentAssertions
dotnet add reference ../../src/ConsoleProject
cd ../
```

#### ClassLibProject.Tests

```sh
cd ClassLibProject.Tests/
dotnet add package FluentAssertions
dotnet add reference ../../src/ClassLibProject
cd ../
```

#### WebApiProject.Tests

```sh
cd WebApiProject.Tests/
dotnet add package FluentAssertions
dotnet add reference ../../src/WebApiProject
cd ../
```

Tada! Your .NET solution is now beautifully organized and ready for your coding adventures. Feel free to customize project names and directories as you like. Happy coding! 🚀✨