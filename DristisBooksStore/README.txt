Project created for St. Clair College WEB452 Assingment2
Author: Dristi Khondkar
2023-10-30 ISO 11:31
we just Recreated the project
2023-10-30 ISO 11:48

Recreating the project 
Authentication set as Individual User Account Version 5.0 and ASP.NET Core Web App (Model-View-Controller) and enable the Razor runtime complilation
created the README.MD in Github 
commented out the sslport in the lunchSetting.json at line 7 and need to remember set it back again
 //, "sslPort": 44327 // don't forgt it put it up again
 At 15:50
 Removed the option in the Startup.cs file at line 35 to set it 
 //(options => options.SignIn.RequireConfirmedAccount = true) //this code commented out for modification
 new code 
  services.AddDefaultIdentity<IdentityUser>()

  At 15:51

 Did the debugginh (HomeController line 22 to 27 IAction Index() and Privacy() methods)

  At 15:59

From Bootswatch select the Materia Theme and download the bootsstrap.css and place it in the www>bootsstrap>dist>css and rename the old file bootsstrap_old.css

Next in the wwwroot>css>cite.css codes were replaced (commented out) with the given code from blackboard
 
 At 16:06

 In the Views>Shared>_Layout.cshtml file change the name bootsstrap.min.css to bootsstraps.css

 change the _layout.cshtml to navbar-light to navbar-dark and bg-white to bg-primary

 2023-10-30 ISO 12:10

 In the Views-> Shared->_Layout.cshtml file Changed the nav class from
navbar-light to navbar dark and bg-white to bg-primary

in the _Layout.cshtm file change the a tag class at Line 22 (document said line 23? but text-dark in line 22) - remove text-dark
At 17:23
in the _Layout.cshtml file at line 43 in the footer class change from text-muted to text-white-50 bg-primary
additional style sheets added to the head section and additional scripts use in the footer section _Layout.cshtml file

At  18:24
created three new projects DristisBooks.DataAccess, DristisBooks.Models and DristisBooks.Utility
Install the Microsoft.EntityFrameWorkCore.Relational and Microsoft.EntityFrameWorkCore.SqlServer 5.0.17 version
next install Microsoft.Identity EntityFrameworkCore 5.0.17 version

At 21:32
Moved Models into DristisBooks.Models and rename the old ony(Model_v1)
Modify the Views and added Model and project references to .DataAccess and .Model file
Rename Models folder to ViewModels

Modify the Views and added Model and project references to .DataAccess and .Model file
Change the namespace of the ErrorViewModels.cs file to.Models.ViewModels

At 20:56
Rename the Models folder to viewModels

At 20:05
Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0246	The type or namespace name 'DristisBookStore' could not be found (are you missing a using directive or an assembly reference?)	DristisBooksStore	C:\Users\drist\Source\Repos\DristisBooksStore\DristisBooksStore\Views\Shared\Error.cshtml	1	Active

At 22:25
public static class SD.cs created and Modify the properties of the class

At 22:30
A Customer area added to Areas (scafolding)

At 22:34
Changed the routes in Startup.cs as outlined in the ScaffoldingReadMe.txt file in line 67
 pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");

 At 22:39
 Move the HomeController.cs to Area>Customer>Controller folder and deleted the Data and Models folders

 At 22:45
 Edit the HomeController.cs to explicitly define that the controller is in the Customer Area [Area("Customer")]
 Modify the HomeController and Move Home to Views

 At 22:56

Modify the _ViewStart.cshtml to reflect the new path
Layout = "~/Views/Shared/_Layout.cshtml";

At 23:04
Add a new Admin area in Areas and view files added and Data and Model folder deleted and Controlers folder also deleted

2023-10-31 ISO 10:47 

resume the project for the 2nd part of the assingment

At 11:01
run the add-migration AddDefaultIdentityMigration in the console and build successd but giving me an warning
-- warning is More than one DbContext was found. Specify which one to use. Use the '-Context' parameter for PowerShell commands and the '--context' parameter for dotnet commands.

Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0246	The type or namespace name 'ErrorViewModel' could not be found (are you missing a using directive or an assembly reference?)	DristisBooksStore	C:\Users\W0811195\Source\Repos\DristisBooksStore\DristisBooksStore\obj\Debug\net5.0\Razor\Views\Shared\Error.cshtml.g.cs	92	Active
Error	CS0246	The type or namespace name 'ErrorViewModel' could not be found (are you missing a using directive or an assembly reference?)	DristisBooksStore	C:\Users\W0811195\Source\Repos\DristisBooksStore\DristisBooksStore\obj\Debug\net5.0\Razor\Views\Shared\Error.cshtml.g.cs	31	Active
Error	CS0246	The type or namespace name 'ErrorViewModel' could not be found (are you missing a using directive or an assembly reference?)	DristisBooksStore	C:\Users\W0811195\Source\Repos\DristisBooksStore\DristisBooksStore\Views\Shared\Error.cshtml	1	Active

2023-01-11 at 11:36
starrtted the second part of the assingment-2
changed the appsettings.json modify the database name and saved
"Server=(localdb)\\\\mssqllocaldb;Database=aspnet-DristisBooksStore-49593084-652F-4BD6-B7D0-D11BF8D387CA;Trusted_Connection=True;MultipleActiveResultSets=true": null, //replace this code with the following

    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=DristisBooksStore;Trusted_Connection=True;MultipleActiveResultSets=true"

    At 11:40
    use the Nugat package manager to add the migration

    here come 4 errors 
    Error	CS0246	The type or namespace name 'ErrorViewModel' could not be found (are you missing a using directive or an assembly reference?)	DristisBooksStore	C:\Users\W0811195\Source\Repos\DristisBooksStore\DristisBooksStore\obj\Debug\net5.0\Razor\Views\Shared\Error.cshtml.g.cs	92	Active
   Error	CS0246	The type or namespace name 'ErrorViewModel' could not be found (are you missing a using directive or an assembly reference?)	DristisBooksStore	C:\Users\W0811195\Source\Repos\DristisBooksStore\DristisBooksStore\obj\Debug\net5.0\Razor\Views\Shared\Error.cshtml.g.cs	31	Active
  Error	CS0246	The type or namespace name 'ErrorViewModel' could not be found (are you missing a using directive or an assembly reference?)	DristisBooksStore	C:\Users\W0811195\Source\Repos\DristisBooksStore\DristisBooksStore\Views\Shared\Error.cshtml	1	Active
  so checked back and found that in the ErrorViewModel namespace was missing like the following code

     this code need to add with  DristisBooksStore.Models.ViewModels.ErrorViewModel instead I had ErrorViewModel only

     At 11:50
     add-migration AddDefaultIdentityMigration in the Nugate Package Manager console Build succeeded but giving the following red warning

 Your target project 'DristisBooksStore' doesn't match your migrations assembly 'DristisBooks.DataAccess'. Either change your target project or change your migrations assembly.
Change your migrations assembly by using DbContextOptionsBuilder. E.g. options.UseSqlServer(connection, b => b.MigrationsAssembly("DristisBooksStore")). By default, the migrations assembly is the assembly containing the DbContext.
Change your target project to the migrations project by using the Package Manager Console's Default project drop-down list, or by executing "dotnet ef" from the directory containing the migrations project.

So changed the default project from DristisBooksStore to correct default project .DataAccess and run again
now it succeessfully run and there is no build error :)
the first new migration file name entry
20231101155418_AddDefaultIdentityMigration.cs
20231101155418_AddDefaultIdentityMigration.Designer.cs

At 12:13
updated the database in the PM console 
update-database
Build Succeeded ..:)
update the database and review the update database in the toolbar view>SQL server object explorer localdb>Database>Tables

At 12:32 
created the Category.cs class from DristisBooks.Models and added the statement  using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.Linq;  //commented out this
using System.Text;
//using System.Threading.Tasks; //commented out this

and added a new class file to the >Models project and modify the code as following
  public class Category
    {
        [Key]

        public int Id { get; set; }

        [Display(Name ="Category Name")]
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }
    }
}

At 12:45 
Added the migration commend to the PM console
add-migration AddCategoryToDb

At 12:48
As the new created Migration file will be empty as it hasnt been added to the Application DB context
Updated the 20231101164520_AddCategoryToDb.Designer Migration name file and added using statement
using DristisBooks.Models; in the top along with 5 other using statements
and also added the following line of code at line 16
 public DbSet<Category> Categories { get; set; }

 At 14:03

 Added the migration but having the error
 The name 'AddCategoryToDb' is used by an existing migration.
 so delete the original and run it again 

 At 14:26
 updated the DristisBooks.DataAccess.csproj with the following code
 <ItemGroup>
		<Folder Include="Data"/>
		<Folder Include="Repository\IRepository"/>
	</ItemGroup>

    At 14:31 
   in the IRepository add a new item of type Interface and name it IRepository.cs and on the top added using System.Linq.Expressions;
  //using System.Threading.Tasks; this one commented out

  then added the following code in the IRepository.cs
    public interface IRepository<T> where T : class
    {
        T Get(int id);

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string inccludeProperties = null
            );

    updated code in the IRepository.cs for used on the Category class to do all the CRUD operations

    2023-11-03 ISO 12:04

    resume working on the BooksStore project

    updated the IRepository.cs with the following code
     void Add(T entity); //to add an entity
        void Remove(int id);  //to remove an object or category
        void Remove(T entity);   //another way to remove an object
        void RemoveRange(IEnumerable<T> entity); //remove a complete range of entities

        Methods to use for CRUD: 
        -Get item from the DB
        -List of Categories
        -Add objects
        -Remove objects
        after added the Repository class the following errors came
        Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0535	'Repository<T>' does not implement interface member 'IRepository<T>.Get(int)'	DristisBooks.DataAccess	C:\Users\drist\Source\Repos\DristisBooksStore\DristisBooks.DataAccess\Repository\Repository.cs	10	Active
Error	CS0535	'Repository<T>' does not implement interface member 'IRepository<T>.GetAll(Expression<Func<T, bool>>, Func<IQueryable<T>, IOrderedQueryable<T>>, string)'	DristisBooks.DataAccess	C:\Users\drist\Source\Repos\DristisBooksStore\DristisBooks.DataAccess\Repository\Repository.cs	10	Active
Error	CS0535	'Repository<T>' does not implement interface member 'IRepository<T>.Add(T)'	DristisBooks.DataAccess	C:\Users\drist\Source\Repos\DristisBooksStore\DristisBooks.DataAccess\Repository\Repository.cs	10	Active
Error	CS0535	'Repository<T>' does not implement interface member 'IRepository<T>.Remove(int)'	DristisBooks.DataAccess	C:\Users\drist\Source\Repos\DristisBooksStore\DristisBooks.DataAccess\Repository\Repository.cs	10	Active
Error	CS0535	'Repository<T>' does not implement interface member 'IRepository<T>.Remove(T)'	DristisBooks.DataAccess	C:\Users\drist\Source\Repos\DristisBooksStore\DristisBooks.DataAccess\Repository\Repository.cs	10	Active

At 13:29 
Implemented the Repository class in side the Repository folder and included the using statements and implemented the interface
Modify the code to create the constructor and dependency injection(DI) (from the given file)

At 14:42
created the individual repos for category and all potentiial models to be added in the future
-CategoryRepository.cs (inside the Repository folder)
-ICategoryRepository(inside IRepository and Interface class)

modify the CategoryRepository added the using statement
using DristisBooks.DataAccess.Repository.IRepository;
using DristisBooks.Models;
using System;
using System.Collections.Generic;
//using System.Linq;  //commented out
using System.Text;
//using System.Threading.Tasks; //commented out

after modifing the code the following error coming...
Severity	Code	Description	Project	File	Line	Suppression State
Error	CS7036	There is no argument given that corresponds to the required formal parameter 'db' of 'Repository<Category>.Repository(ApplicationDbContext)'	DristisBooks.DataAccess	C:\Users\drist\Source\Repos\DristisBooksStore\DristisBooks.DataAccess\Repository\CategoryRepository.cs	14	Active
Error	CS0246	The type or namespace name 'ApplicationDbContext' could not be found (are you missing a using directive or an assembly reference?)	DristisBooks.DataAccess	C:\Users\drist\Source\Repos\DristisBooksStore\DristisBooks.DataAccess\Repository\CategoryRepository.cs	13	Active

resolved the error using the following statement and update the code
using DristisBooksStore.DataAccess.Data;

in the IRepository also coming the error when try to modify so added the using statement
using DristisBooks.DataAccess.Repository.IRepository;
using DristisBooks.Models;
using DristisBooksStore.DataAccess.Data;

and there is another error

Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0535	'CategoryRepository' does not implement interface member 'ICategoryRepository.Update(Category)'	DristisBooks.DataAccess	C:\Users\drist\Source\Repos\DristisBooksStore\DristisBooks.DataAccess\Repository\CategoryRepository.cs	12	Active
and implement the interface to update the code
 public void Update(Category category)
        {
            throw new NotImplementedException();
        }

At 15:05
an error was coming as didnt used the LINQ statement...added and resolved it

At 18:27
added a new interface in he IRepository folder-ISP_Call that extends IDisposable (interface class)
for the methods T Single<T>(string procedurename, DynamicParameters param = null); added the Nugate package for Dapper auto instellicence choose the commend
Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0535	'SP_Call' does not implement interface member 'IDisposable.Dispose()'	DristisBooks.DataAccess	C:\Users\drist\Source\Repos\DristisBooksStore\DristisBooks.DataAccess\Repository\SP_Call.cs	10	Active
Error	CS0535	'SP_Call' does not implement interface member 'ISP_Call.List<T1, T2>(string, DynamicParameters)'	DristisBooks.DataAccess	C:\Users\drist\Source\Repos\DristisBooksStore\DristisBooks.DataAccess\Repository\SP_Call.cs	10	Active
Error	CS0535	'SP_Call' does not implement interface member 'ISP_Call.List<T>(string, DynamicParameters)'	DristisBooks.DataAccess	C:\Users\drist\Source\Repos\DristisBooksStore\DristisBooks.DataAccess\Repository\SP_Call.cs	10	Active
Error	CS0535	'SP_Call' does not implement interface member 'ISP_Call.OneRecord<T>(string, DynamicParameters)'	DristisBooks.DataAccess	C:\Users\drist\Source\Repos\DristisBooksStore\DristisBooks.DataAccess\Repository\SP_Call.cs	10	Active
Error	CS0535	'SP_Call' does not implement interface member 'ISP_Call.Execute(string, DynamicParameters)'	DristisBooks.DataAccess	C:\Users\drist\Source\Repos\DristisBooksStore\DristisBooks.DataAccess\Repository\SP_Call.cs	10	Active
Error	CS0535	'SP_Call' does not implement interface member 'ISP_Call.Single<T>(string, DynamicParameters)'	DristisBooks.DataAccess	C:\Users\drist\Source\Repos\DristisBooksStore\DristisBooks.DataAccess\Repository\SP_Call.cs	10	Active

At 18:00 

 installed the Dapper package from the IntelliSense 

after  that added the SP_Call.cs file in the Repository folder and select the following using statements and implement the ISP_Call interface (from intellisence)
using DristisBooks.DataAccess.Repository.IRepository;
using DristisBooksStore.DataAccess.Data;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

At 20:43
added a connectionto the database and also using statement added 

At 22:11
Added a new interface (UnitOfWork) to the IRepository folder and updated the code
 interface UnitOfWork : IDisposable
    {
        ICategoryRepository Category { get;  }
        ISP_Call SP_Call { get; }
    }

    2023-11-03 At 10:42

    resume working on the project 
    Just missed the error message in the slide and added the UnitOfWork for both IRepository and Repository
    this gave me huge truble...and finnaly added UnitOfWork:IUnitOfWork interface

    At 13:56
    Added a newMVC Controller-Empty inside Areas/Admin

    At 14:34
    added a new'Index' view to the folder (add view Razor View and search the path ~/Views/Shared/_Layout.cshtml)

