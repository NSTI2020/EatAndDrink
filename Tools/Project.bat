dotnet new sln --name EatAndDrink.Web


dotnet new webapi --auth none -o EatAndDrink.WebApi


dotnet new classlib -o EatAndDrink.Domain
dotnet new classlib -o EatAndDrink.Repository


dotnet sln add EatAndDrink.Domain\EatAndDrink.Domain.csproj
dotnet sln add EatAndDrink.Repository\EatAndDrink.Repository.csproj
dotnet sln add EatAndDrink.WebApi\EatAndDrink.WebApi.csproj


dotnet add EatAndDrink.Repository\EatAndDrink.Repository.csproj reference EatAndDrink.Domain\EatAndDrink.Domain.csproj
dotnet add EatAndDrink.WebApi\EatAndDrink.WebApi.csproj reference EatAndDrink.Domain\EatAndDrink.Domain.csproj
dotnet add EatAndDrink.WebApi\EatAndDrink.WebApi.csproj reference EatAndDrink.Repository\EatAndDrink.Repository.csproj


dotnet add EatAndDrink.Repository\EatAndDrink.Repository.csproj package Pomelo.EntityFrameworkCore.MySql
dotnet add EatAndDrink.Repository\EatAndDrink.Repository.csproj package Microsoft.EntityFrameworkCore.Tools

dotnet tool install --global dotnet-ef

start angular.bat

ng new Views
pause
npm install bootstrap --save
npm i @fortawesome/fontawesome-free --save 
npm install ngx-bootstrap --save