

#NuGet Packages
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design

Microsoft.AspNetCore.Identity.EntityFramework //Microsoft.Extensions.Identity.Core   //Microsoft.AspNetCore.Identity
Microsoft.AspNetCore.Identity.EntityFramework






#Developer PowerShell 
##in search Developer PowerShell
PS C:\Projects\RunGroopWebApp> cd .\RunGroopWebApp\
PS C:\Projects\RunGroopWebApp\RunGroopWebApp> dotnet run seeddata

#or https://marketplace.visualstudio.com/items?itemName=AdamRDriscoll.PowerShellToolsVS2022
download and install, and VIEW -> Terminal, i jest!


#install dotnet tool
dotnet tool install --global dotnet-ef
.NET 6
dotnet tool install --global dotnet-ef --version 6.*


#Database
*create dabase in SSMS, copy connettion string from SQL Server Object Explorer -? propoeries of DB and in the right down corner connection string...

##PowerShell dotnet tool
cd .\IdentityAppMVC\
dotnet ef migrations add init
dotnet ef database update


##PM
Add-Migration InitialCreate
Update-Database