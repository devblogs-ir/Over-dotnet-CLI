# .Net Cli Example
> Here are examples of working with .NET CLI written by [Reza kharaeu](https://kharaei.ir)

1. Make own Foldering :
```
mkdir Reza
cd Reza
mkdir Src 
mkdir Test
```

2. Create Blank Solution :
```
dotnet new sln DotNetCliExample
```

3. Go to Src folder & Create Projects :
```
cd Src
dotnet new console -n DotNetCliExample.Console
dotnet new classlib -n DotNetCliExample.Library
dotnet new webapi -n DotNetCliExample.WebApi
```

4. Go to Test folder & Create Test Projects :
```
cd ..\Test
dotnet new xunit -n DotNetCliExample.Console.Test
dotnet new xunit -n DotNetCliExample.Library.Test
dotnet new xunit -n DotNetCliExample.WebApi.Test
```

5. inject Project References to Test Projects :
```
cd DotNetCliExample.WebApi.Test
add reference ../../Src/DotNetCliExample.WebApi 

cd ../DotNetCliExample.Console.Test
add reference ../../Src/DotNetCliExample.Console

cd ../DotNetCliExample.Library.Test
add reference ../../Src/DotNetCliExample.Library 
```

6. Finally, we should add all project created in own solution :
```
 dotnet sln add Src/DotNetCliExample.Console
 dotnet sln add Src/DotNetCliExample.Library
 dotnet sln add Src/DotNetCliExample.WebApi
 dotnet sln add Test/DotNetCliExample.Console.Test
 dotnet sln add Test/DotNetCliExample.Library.Test
 dotnet sln add Test/DotNetCliExample.WebApi.Test
 ```