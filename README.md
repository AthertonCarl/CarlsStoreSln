# CarlsStoreSln
Adam Freemans Sports Store Demo

## Created Project

    dotnet new globaljson --sdk-version 3.1.401 --output CarlsStoreSln/OutdoorWorld
    dotnet new web --no-https --output CarlsStoreSln/OutdoorWorld --framework netcoreapp3.1
    dotnet new sln -o CarlsStoreSln
    dotnet sln CarlsStoreSln add CarlsStoreSln/OutdoorWorld
    dotnet new xunit -o CarlsStoreSln/OutdoorWorld.Tests --framework netcoreapp3.1
    dotnet sln CarlsStoreSln add CarlsStoreSln/OutdoorWorld.Tests
    dotnet add CarlsStoreSln/OutdoorWorld.Tests reference CarlsStoreSln/OutdoorWorld

## ScreenShots

![ScreenShot 1](https://github.com/AthertonCarl/CarlsStoreSln/blob/master/ScreenShots/SportStoreImage1.PNG)
![ScreenShot 2](https://github.com/AthertonCarl/CarlsStoreSln/blob/master/ScreenShots/SportStoreImage2.PNG)
![ScreenShot 3](https://github.com/AthertonCarl/CarlsStoreSln/blob/master/ScreenShots/SportStoreImage3.PNG)
![ScreenShot 4](https://github.com/AthertonCarl/CarlsStoreSln/blob/master/ScreenShots/SportStoreImage4.PNG)

## Entity Framework Questions

What is Entity Framework?  

    Entity Framework is an Object Relational Mapper which is a type of tool that simplifies 
    mapping between objects to increase the developer’s productivity by reducing the redundant 
    task of persisting the data used in the applications.

What is a Connection String?  

    The connection string contains the information that the provider needs to know to be able to 
    establish a connection to the database or the data file.

What is a Database Context?  

    The context class is used to query or save data to the database. It is also used to configure 
    domain classes, database related mappings, change tracking settings, caching, transaction and more.

What is a Model Repository?  

    The Model repository is a relational database that stores the metadata for projects and folders.  

Migration vs Scaffolding?  

    Scaffolding is a code generation framework for ASP.NET Web applications. You add scaffolding 
    to your project when you want to quickly add code that interacts with data models. Using scaffolding 
    can reduce the amount of time to develop standard data operations in your project.  
    The Migrations feature enables you to change the data model and deploy your changes to production by 
    updating the database schema without having to drop and re-create the database. 

Seeding the database  

    Data seeding is the process of populating a database with an initial set of data. 
