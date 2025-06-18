using ConsoleApp1.Data;
using ConsoleApp1.Models;

namespace ConsoleApp1.Repositories;

public class PersonRepository
{
    private readonly ApplicationDbContext _dbContext;
    public void CreateAccount(Person person)
    {
        _dbContext.Users.Add(person);
    }
}