// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleApp1.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

//Configures the database, I will be using MySQL
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));

//The program class is designed specifically only to run the app.
//We will not be find anything else here.
App app = new();
app.Run();
