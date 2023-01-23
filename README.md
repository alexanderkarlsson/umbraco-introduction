# Umbraco >Introdction

What to learn today?
- Install Umbraco
- Umbraco Backoffice
- Modelsbuilder
- Control(lers)

## Install Umbrco, Setup a new Umbraco

[Package Script Writer](https://psw.codeshare.co.uk/)

Run this command to make clean Umbraco 10 installation
```
# Ensure we have the latest Umbraco templates
dotnet new -i Umbraco.Templates::10.4.0
# Create solution/project
dotnet new sln --name "MySolution"
dotnet new umbraco --force -n "MyProject" --friendly-name "Administrator" --email "admin@example.com" --password "1234567890" --development-database-type SQLite
dotnet sln add "MyProject"
#Add Packages
dotnet run --project "MyProject"
#Running
```

## Show Umbraco Backoffice

### But first make some documenttypes and templates
- HomePage
- LandingPage

### Show Sections in Umbraco
- Content
- Media
- Developer
- User
- Members
- Translations

## Modelsbuilder
- Setup as a new classlibrary, MyProject.ContentModels
- Set app settings
```
"Umbraco": {
    "CMS": {
      "ModelsBuilder": {
        "ModelsMode": "SourceCodeManual",
        "ModelsDirectory": "~/../MyProject.ContentModels/Models",
        "AcceptUnsafeModelsDirectory": true,
        "ModelsNamespace": "MyProject.ContentModels.Models"
      }
    }
  }
```

## Controllers
- SurfaceController - Post
- Url Highjack controller - Routes
- UmbracoApiController - API 

## Good packages
Nuget packages
- [uSync](https://marketplace.umbraco.com/package/usync)
- [Skybrud Umbraco Redirects](https://marketplace.umbraco.com/package/skybrud.umbraco.redirects)