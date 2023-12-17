# maha-builder CLI Tool 
### this toll creates a sample project set with this structure:
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
# steps to use this tool:
# 1- Install 
```
dotnet tool install --global --add-source [package_path] maha_builder
```
# 2- Run
```
maha_builder 
```
By running the tool it creates the template project in the executing directory and lets you inform
# 3- Uninstall
```
dotnet tool uninstall --global maha_builder 
```
