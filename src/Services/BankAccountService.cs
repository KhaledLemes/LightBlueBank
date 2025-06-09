using ConsoleApp1.Interfaces.IRepositories;
using ConsoleApp1.Interfaces.IServices;
using ConsoleApp1.Models;

namespace ConsoleApp1.Services;

public class BankAccountService : IBankAccountService
{
    //Creates the account, if the user is one of the first 50 users, they will have a balance of 100
    //This method is only temporary, for I have to add Dependency Injection to the project to have IoC.
    public void CreateAccount(Person person)
    {
        person.Account.Balance = 0;
        person.Account.EligibleLoanAmount = 0;
        person.Account.EligibleCreditAmount = 0;
        if (person.Id > 50) return; //If the user is not one of the first 50 users, the function ends.
        person.Account.Balance += 100;
        Console.WriteLine("Congrats! You have been given a balance of U$100 for being one of the first 50 customers.");
        Console.WriteLine("");
        Console.WriteLine("");
    }
}