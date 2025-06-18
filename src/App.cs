using ConsoleApp1.Controllers;
using ConsoleApp1.DTOs;
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
        var personController = new PersonController(personService); //---------
        var personDTO = new SignUpDto();        

        //personService.SignUp("Kh", "Khaled", "lme", "91", "parede@fger.com", "123456789Dlufa!@15");
        personController.SignUp(personDTO);
    }

}