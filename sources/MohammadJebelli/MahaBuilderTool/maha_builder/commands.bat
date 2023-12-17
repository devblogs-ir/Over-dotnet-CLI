md project_name
cd project_name
dotnet new sln -n project_name
md src
md test
cd src
dotnet new console -n project_name
dotnet new classlib -n project_nameLib
dotnet new webapi -n project_nameApi
cd ../test
dotnet new xunit -n Test.project_name
cd ./Test.project_name
dotnet add package FluentAssertions --version 7.0.0-alpha.3
dotnet add reference ../../src/project_name/
cd ..
dotnet new xunit -n Test.project_nameApi
cd ./Test.project_nameApi
dotnet add package FluentAssertions --version 7.0.0-alpha.3
dotnet add reference ../../src/project_nameApi/
cd ..
dotnet new xunit -n Test.project_nameLib
cd ./Test.project_nameLib
dotnet add package FluentAssertions --version 7.0.0-alpha.3
dotnet add reference ../../src/project_nameApi/ 
cd ../..
dotnet sln project_name.sln add ./src/project_name
dotnet sln project_name.sln add ./src/project_nameApi
dotnet sln project_name.sln add ./src/project_nameLib
dotnet sln project_name.sln add ./test/Test.project_name
dotnet sln project_name.sln add ./test/Test.project_nameApi
dotnet sln project_name.sln add ./test/Test.project_nameLib
