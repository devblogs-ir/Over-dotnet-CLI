# maha-builder

> this project create projects base on below structure.


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

#usage
1. clone project
2. in maha-builder root project create a pack:
```
dotnet pack 
```
this command create a folder with pkgs name and in this folder create a nuget package "maha-builder.1.0.0.nupkg".

3. install maha-builder tools:

```
 dotnet tool install --global --add-source .\pkgs\ maha-builder
```

4. use maha-builder tools with this ccommand:

```
  maha-builder --name "YourFolderName"
```