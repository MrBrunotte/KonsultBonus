# KonsultBonus ASP.NET Core Web APP (MVC)

## Packages used
 - Microsoft.EntityFrameworkCore (5.0.4)
 - Microsoft.EntityFrameworkCore.Sqlite (5.0.4)
 - Microsoft.EntityFrameworkCore.SqlServer (5.0.4)
 - Microsoft.EntityFrameworkCore.Tools (5.0.4)
 - Microsoft.VisualStudio.Web.CodeGeneration.Design (5.0.2)

### Migration
[Entity Framework Core](https://www.entityframeworktutorial.net/efcore/entity-framework-core-migration.aspx)

The commands used in the "Package Manager Console" are:
- **Adding a Migration:** add-migration KonsulterDB
- **Creating or Updating the Database:** Update-Database 

### Connection string & Database name
1. Go to Tools -> Connect to Database...
2. Choose "Microsoft SQL Server
3. Refrecsh to find the Server Name
4. Choose localDB
5. Select databaseName (KonsulterDB)
6. Test Connection
7. Go to Server Explorer and right-click on the database choose Properties
8. Copy the Connection String (Data Source=(localdb)\MSSQLLocalDB......)
9. Go to Appsettings.json
10. add new variable: ConnectionStrings
11. Give it a value "KonsulterDB"
12. 

### Scaffolding command
1. Go to Tools and chose "Nuget Package Manager -> Package Manager console
2. Paste the Scaffold command
 Scaffold-DbContext {-Connection-string-in-quotations-} Microsoft.EntityFrameWorkCore.SqlServer -outputdir Repository/Models -context {-databasename-}DbContext  -contextdir Repository -DataAnnotations -Force
3. Replace the {-Connection-string-in-quotations-} with the "ConnectionString" and replace the {-databasename-} with KonsulterDB (or your chosen name)
4. Press enter to build

### The commands used in the "Package Manager Console" are:
- **Adding a Migration:** add-migration KonsulterDB
- **Creating or Updating the Database:** Update-Database 
