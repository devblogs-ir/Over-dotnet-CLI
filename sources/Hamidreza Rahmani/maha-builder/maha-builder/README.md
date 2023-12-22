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