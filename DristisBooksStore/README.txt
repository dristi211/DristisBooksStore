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
