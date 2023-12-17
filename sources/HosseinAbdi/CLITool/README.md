# maha-builde CLI Tool 
## This CLI tool create structure as bellow :
```
[Your-Name-Folder]
     - src [folder]
          - console project [x]
          - class library project [y]
          - web api project [z]
     - test [folder]
          - [[x].Tests] - xunit template - install fluentAssersion package - depend on [x] project
          - [[y].Tests] - xunit template - install fluentAssersion package - depend on [y] project
          - [[z].Tests] - xunit templatee - install fluentAssersion package - depend on [z] projct
```
# for using this tool follow this steps:
# 1- install tool 
```
dotnet tool install -global maha-builder [packageLocation] [projectName]
```
# 2- create structure by CLI Tool 
```
maha-builder --name [RootStructureName] 

# for Uninstall CLI tool 
```
dotnet tool uninstall --global maha-builder 
```
