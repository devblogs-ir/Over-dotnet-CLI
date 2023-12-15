# Hi there 🙌

 You Can Find Me Here [linkedin](https://www.linkedin.com/in/shirin-alizadeh)
 
1. First
 ```
md sln
 ```
2. Seconde
```
md  Console dotnet new console -n Test-Packages
```
3. Third
```
md Class Library  dotnet new classlib  -n TestLib
```
4. Fourth
```
dotnet sln add .\Test-Packages\
```
5. Fifth
```
dotnet sln add .\TestLib\
```
6. sixth
```
cd Test-Packages   dotnet add reference ..\TestLib
```
7. seventh
```
dotnet pack
```
8. eighth
```
cd Test-Packages   dotnet tool install --global --add-source .\package\ Test-Packages
```