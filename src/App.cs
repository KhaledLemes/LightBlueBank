using ConsoleApp1.Interfaces.IServices;
using ConsoleApp1.Repositories;
using ConsoleApp1.Services;

namespace ConsoleApp1;

public class App 
{
    //I am adding manual DI for now.
    public void Run()
    {
        var bankAccService = new BankAccountService();
        var personService = new PersonService(bankAccService);
        
        personService.SignUp("Khaled", "Khaled", "Khaled", "20");
    }

}