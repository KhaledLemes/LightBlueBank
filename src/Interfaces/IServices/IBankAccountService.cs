using ConsoleApp1.Models;

namespace ConsoleApp1.Interfaces.IServices;

public interface IBankAccountService
{
    public void CreateAccount(Person person);
}