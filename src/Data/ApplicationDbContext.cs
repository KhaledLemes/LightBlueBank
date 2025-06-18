using ConsoleApp1.Models;
namespace ConsoleApp1.Data;
using Microsoft.EntityFrameworkCore;

//This class is purely DataBase configuration logic
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {} //No logic inside the constructor is needed
    public DbSet<Person> Users { get; set; }
    public DbSet<BankAccount> Accounts { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(p => p.PersonId);
            entity.Property(p => p.PersonId).ValueGeneratedOnAdd();
            entity.Property(p => p.Email).HasMaxLength(255);
            entity.Property(p => p.Name).IsRequired().HasMaxLength(25);
            entity.Property(p => p.MiddleName).IsRequired().HasMaxLength(25);
            entity.Property(p => p.LastName).IsRequired().HasMaxLength(25);
            entity.Property(p => p.Age).IsRequired().HasAnnotation("Range", new[] {18, 99 });
            
            
            entity.HasIndex(p => p.Email).IsUnique();
        });
        
        modelBuilder.Entity<BankAccount>(entity =>
        {
            entity.HasKey(b => b.BankAccId);
            entity.Property(b => b.BankAccId).ValueGeneratedOnAdd();
            
            entity.HasOne(b => b.Person)
                .WithOne(p => p.Account)
                .HasForeignKey<BankAccount>(b => b.PersonId).IsRequired();
            
            entity.Property(b => b.AccountNumber).IsRequired();
            entity.Property(b => b.Balance).IsRequired();
            entity.Property(b => b.EligibleLoanAmount).IsRequired();
        });
    }
}