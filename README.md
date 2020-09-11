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
ScreenShot 1  
![ScreenShot 1](https://github.com/AthertonCarl/CarlsStoreSln/blob/master/ScreenShots/SportStoreImage1.PNG)
