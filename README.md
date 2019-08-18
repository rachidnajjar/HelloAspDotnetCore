# HelloAspDotnetCore

Hello world for asp.net core application

sources :
    > <https://docs.microsoft.com/fr-fr/dotnet/samples-and-tutorials/>
    > <https://docs.microsoft.com/fr-fr/aspnet/core/tutorials/razor-pages/?view=aspnetcore-2.2>

1. Créer le projet :
    > dotnet new webapp

2. Approuver le certificat de développement https :
    > dotnet dev-certs https --trust

3. Ajouter un modèle de données
    - classe modèle
    - classe contexte
    - chaine de connexion
    - packages nuget :
        > dotnet add package Microsoft.EntityFrameworkCore.SQLite
        > dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
        > dotnet add package Microsoft.EntityFrameworkCore.Design

4. Inscrire le contexte de base de données dans la classe startup

5. Générer automatiquement les pages crud
    - Installez l’outil de génération automatique :
        > dotnet tool install --global dotnet-aspnet-codegenerator
    - Générer les pages crud :
        > dotnet aspnet-codegenerator razorpage -m Movie -dc HelloAspDotnetCoreContext -udl -outDir Pages/Movies --referenceScriptLibraries

6. Créer la migration initiale
    > dotnet ef migrations add InitialCreate
    > dotnet ef database update
