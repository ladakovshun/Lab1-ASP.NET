using static System.Net.WebRequestMethods;
using WebApplication2.Controllers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/company", () => 
{
    var company = new Company
    {
        Name = "Global Logic",
        Address = "Kyiv, Ukraine",
        Employees = 345
    };
    return Results.Json(company);
});

app.MapGet("/random", () => 
{
    var random = new Random();
    int randomNumber = random.Next(0, 101);
    return Results.Text($"Random number: {randomNumber}");
});

app.Run();
