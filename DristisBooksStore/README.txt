﻿Project created for St. Clair College WEB452 Assingment2
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

    2023-11-04 ISO 12:07 resume working 

    In _Layout.cshtml moved the Category link to the content management drop-down
    <a class="dropdown-item" asp-area="Admin" asp-controller="Category" asp-action="Index">Category</a>

    At 12:50 
   created the Category js file in the DristisBooksStore>wwwroot>js>Category.js file and  added the given script to that file 
   In the Index.cshtm file added the @section call to the category.js script 
   At 12:53
   applied the code to activate the "edit" and "Delete" buttons and "Create New Category" using the Upsert action
   added the IAction result to the controller and added a View in the Areas>admin>Views>Category>Upsert by adding a Rezor View scaffolding and the path 
   selected as ~/Views/Shared/_Layout.cshtml

   At 17:42
   created a partial view for the EDIT|BACK in the general Views>Shared folder and added the asp-action in the _CreateAndBackToListButton

   At 17:52 
   the following asp-action code was added the _CreateAndBackToListButton
   <div class="row">
    <div class="col">
        <button type="submit" class="btn btn-primary form-control">Create</button>
    </div>
    <div class="col">
        <a asp-action="Index" class="btn btn-success form-control">Back to List</a>
    </div>
</div>

At 18:03
another partial view was added in the Views>Shared folder _EditAndBackToListButton (Razor partial view)
added the @model razor statement in the 

At 18:33
 Modified the Upsert.cshtml file and add asp-action="Upsert" in the Index.cshtml (Views>Category>Index.cshtml) file

 2023-11-05 ISO 13:40

 Added the @section call to Scripts to validate input on the client side
 @section Script {
<partial name="_ValidationScriptsPartial" />
}

while test the application the following exception handling error occured
An unhandled exception occurred while processing the request.
NotImplementedException: The method or operation is not implemented.
DristisBooksStore.Areas.Admin.Controllers.CategoryController.op_Implicit(Category v) in CategoryController.cs, line 56

            
it was typo and instead of Category category = new Category();  I type CategoryController...:(

now came another handling error
InvalidOperationException: The following sections have been defined but have not been rendered by the page at '/Views/Shared/_Layout.cshtml': 'Script'. To ignore an unrendered section call IgnoreSection("sectionName").

At 15:26

created an Upsert POST action method in the CategoryController.cs

At 15:43
added the API (Application Programming Interface) call for HTTPDelete in the CategoryController.cs(Area>Admin>CategoryController)
[HttpDelete]

        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Category.Get(id);
            if(objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Category.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }

        At 16:08 
        added the delete functionality in category.js with including the onclick event to the Delete function
        added the Delete(url) function code

   

2023-11-06 ISO 14:54
there was an error coming 
InvalidOperationException: The following sections have been defined but have not been rendered by the page at '/Views/Shared/_Layout.cshtml': 'Script'. To ignore an unrendered section call IgnoreSection("sectionName").

OMG...in the Index.cshtml file there was a typo I wrote Scrpit instead of Scripts...and there you go....
Finnay correct layout is coming but saying cannot connect to the database so run the commend 
update-database
and now all is well....now it is running well

2023-11-21 ISO 10:22

Started working with the Part3 (Section1)

At 10:25 Created the Created the CoverType cs file in the DristisBooksStore.Model folder and ID and Name

At 10:29
Created CoverType Repository in the Repository folder

AT 10:53
Created CoverTypeRepository.cs class in Repository folder and IRepository folder ICoverType interfae class

At 14:55
Created the CoverType Controller.cs in the Area>Admin and In the Views folder add CoverType folder and Index.cshtml and Upsert.cshtml created

At 5:37
Your target project 'DristisBooksStore' doesn't match your migrations assembly 'DristisBooks.DataAccess'. Either change your target project or change your migrations assembly.
Change your migrations assembly by using DbContextOptionsBuilder. E.g. options.UseSqlServer(connection, b => b.MigrationsAssembly("DristisBooksStore")). By default, the migrations assembly is the assembly containing the DbContext.
Change your target project to the migrations project by using the Package Manager Console's Default project drop-down list, or by executing "dotnet ef" from the directory containing the migrations project.

Changed the Default project and run the ,Migration again

2023-11-17 ISO 9:26
Resume working on the Bookstoreproject Assingment2-part2(section2)

For the Productcs file while adding the code I am confused should I add ForeignKey as CategoryId for CoverType or CoverTypeId??   for now kept as it is in the given code

 [Required]
        public int CoverTypeId { get; set; }                  //Foreign key reference
        [ForeignKey("CoverTypeId")]
        public CoverType CoverType { get; set; }

        At 9:58 

        References to the new Products piece to the database in the ApplicationDbContext.cs file added the  
        public DbSet<Product> Products { get; set; }     //adding products to the DB

        At 10:03

        Added the migration AddProductToDb

       New Migration folder timestamp: 20231117150253_AddProductToDb.cs
                                      20231117150253_AddProductToDb.Designer


   At 10:12 updated the Product class so Title, ISBN and Author are [Required]field and creat a new migration(AddValidation To Product) and update the the database
                                      Migration done successfully but given the following warning
                                      An operation was scaffolded that may result in the loss of data. Please review the migration for accuracy.

  At 10:36 added the  following code to the ProductRepository 
                                          if (product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;                 //addd the check for ImageUrl
                }
            
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Author = product.Author;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId;

                //_db.SaveChanges();                  //as instructed to remove
            }
        }

At 10:38
 modified the code and add Product to UnitOfWork and IUnitOfWork

 there was an error coming due to not added the Update method in the IProductRepository file

 At 14:11

 Created the ProductController and Modified the ProductController with the following code

 [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;               //to upload images on the server inside wwwroot

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

installed the package "Microsoft.AspNetCore.Mvc.ViewFeatures package from the ProductVM.cs (Intellisence suggestion latest virson)

At 16:14 
Created and modified the ProductController

2023-11-18 ISO 11:53

Modified the ProductController so the IActionResultUpsert calls to the ProductVM view Model, included the using statement to the ViewModeld folder amd Microsoft.Asp.NetCore.Mvc.Rendering
 Modified the API call to include the Category and CoverType properties

 public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Product.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Product.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }

        
At 12:25
Added an Index view (Admin>Views>Product) Razorview (not empty one) and scaffolding with the _layout path selected and  modified the code according to Category Index.cshtml file

At 12:37 
created the modified the Upsert +.cshtml in Product
Created and Modified the Upsert file (code given blackboard)

At 13:07
created the tiny.cloud accoount and using the API key provided(?) initialize and added a function to validate the input and if emty display a sweet alert

2023-11-20 ISO 15:30

While running the code there is the following handling error coming
System.InvalidOperationException
  HResult=0x80131509
  Message=An error was generated for warning 'Microsoft.EntityFrameworkCore.Query.InvalidIncludePathError': Unable to find navigation ' CoverType' specified in string based include path ' CoverType'. This exception can be suppressed or logged by passing event ID 'CoreEventId.InvalidIncludePathError' to the 'ConfigureWarnings' method in 'DbContext.OnConfiguring' or 'AddDbContext'.
  Source=Microsoft.EntityFrameworkCore

  2023-11-21 ISO 10:22
  Just after the marking done modified the ProductController

  2023-11-22 ISO 11:00 started the Part=4 of the assingment

  2023-11-23 ISO 17:12

  Updated all pages but database showing error

 2023-11-20 ISO 15:30

While running the code there is the following handling error coming
System.InvalidOperationException
  HResult=0x80131509
  Message=An error was generated for warning 'Microsoft.EntityFrameworkCore.Query.InvalidIncludePathError': Unable to find navigation ' CoverType' specified in string based include path ' CoverType'. This exception can be suppressed or logged by passing event ID 'CoreEventId.InvalidIncludePathError' to the 'ConfigureWarnings' method in 'DbContext.OnConfiguring' or 'AddDbContext'.
  Source=Microsoft.EntityFrameworkCore

  2023-11-21 ISO 10:22
  Just after the marking done modified the ProductController

  2023-11-22 ISO 11:00 started the Part=4 of the assingment

  2023-11-23 ISO 17:12

  Updated all pages but database showing error

  2023-111-25 ISO 16:34

  startted working and trying to find out the error coming.. the page is not showing..

  migration was added for uodated price tag

  add-migration AddPriceToDb

  migration done but the page is not coming throwing the following error

  Exception thrown: 'Microsoft.Data.SqlClient.SqlException' in Microsoft.EntityFrameworkCore.Relational.dll
An exception of type 'Microsoft.Data.SqlClient.SqlException' occurred in Microsoft.EntityFrameworkCore.Relational.dll but was not handled in user code
Invalid column name 'Price'.
Invalid column name 'Price100'.
Invalid column name 'Price50'.

The program '[31312] iisexpress.exe' has exited with code -1 (0xffffffff).

2023-11-27 ISO 10:26

resume working on assingment part4...added the CategoryVM.cs and modifieying the SD.cs but having error and page is unavailable.....

at15:38 droped the Category table as no data was showing and void
20231101180003_AddCategoryToDb
20231101180754_AddDefaultIdentityMigration
20231123213954__AddCoverTypeToDb
20231127161536_AddPriceToDb

At 16:32
Added the migration again

At 18:13

The page is showing and table are showing but can't add the price and coverType

At 18:38
Created the CoverType and try to populate the table but not working....):

2023-11-28 ISO 8:09

It was success that I manage to add list items on the page and also added the table

At 11:20 
There was an error in the CoverTypeController that was giving the error, also the %Width of the page size was hindering the images

2023-12-04 ISO 14:31

Trying to find out why the home page with the image is not showing after login to a new system...

I am going to try to diploy to azure..

2023-12-05 ISO 11:03

Tried for the Azure deployment of the app but without luck..):

Its not showing the Subscription name and App service instance page to create the Subscription

