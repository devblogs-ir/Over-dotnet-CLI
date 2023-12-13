# Over-dotnet-CLI


## 1- build a project with this structure

```
---- [your-solution-name]
     - src [folder]
          - console project [x]
          - class library project [y]
          - web api application [z]
     - test [folder]
          - [x].Tests - xunit template - install fluentAssersion package - depend on [x] project
          - [y].Tests - xunit template - install fluentAssersion package - depend on [y] project
          - [z].Tests - xunit templatee - install fluentAssersion package - depend on [z] project
```

## 2- build CLI tool for creating top structure in one command

### like this
```
> maha-builder
```

