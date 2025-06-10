using ConsoleApp1.Models;
namespace ConsoleApp1.Data;
using Microsoft.EntityFrameworkCore;

//This class is purely DataBase configuration logic
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {} //No logic inside the constructor is needed
    public DbSet<Person> Users { get; set; }
}