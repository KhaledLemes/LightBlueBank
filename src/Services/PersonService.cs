using ConsoleApp1.Interfaces.IServices;
using ConsoleApp1.Models;
using ConsoleApp1.Utils;
using ConsoleApp1.Validation;

namespace ConsoleApp1.Services;

public class PersonService : IPersonService
{
    private readonly IBankAccountService _bankAccountService;
    UserServiceValidators validator = new();
    Util util = new();
    

    public PersonService(IBankAccountService bankAccountService)
    {
        _bankAccountService = bankAccountService;
    }

    public Person? SignUp(string? name, string? middleName, string? lastName, string? ageToBeConverted, string? emailToValidate, string? password)
    {
        
        int age = util.ConvertAge(ageToBeConverted); //This you turn age into 0 if it is not a number or null.
        switch (true)
        {
            case true when !validator.IsValidEmail(emailToValidate):
                Console.WriteLine("Invalid email. Please try again.");
                return null;
            case true when !validator.IsValidAge(age):
                Console.WriteLine("Invalid age. Please try again.");
                return null;
            case true when !validator.IsValidName(name) || !validator.IsValidName(middleName) || !validator.IsValidName(lastName):
                Console.WriteLine("Invalid or empty names. Please try again.");
                Console.WriteLine("Try to check for empty spaces and try again.");
                return null;
            case true when !validator.IsValidPassword(password):
                Console.WriteLine("Invalid password. Please try again.");
                Console.WriteLine("Your password must contain at least one uppercase letter, one lowercase letter, one digit and one special character.");
                Console.WriteLine("Your password must be between 10 and 23 characters long.");
                return null;
            default:
                break;
        }
        
        string email = emailToValidate!;
        
        Person person = new Person();
        person.Name = util.CapitalizeFirstLetter(name!);
        person.MiddleName = util.CapitalizeFirstLetter(middleName!);
        person.LastName = util.CapitalizeFirstLetter(lastName!);
        person.Age = age;
        person.Email = email;
        person.Password = password!;
        person.Account = new BankAccount();

    /*
     The app is being currently developed to work on the terminal.
     However, I do have plans to make it work on a web app with HTML, CSS and js.
     I will be working on it in the future.
     */
        Console.WriteLine("Creating account...");
        Console.WriteLine("--------------------------------");
        _bankAccountService.CreateAccount(person);

        Console.WriteLine("Welcome to BlueLight bank, " + person.Name + "!");
        Console.WriteLine("Your balance is $" + person.Account.Balance);
        Console.WriteLine("Check below credit card and loan offers and see how much you can get!");
        Console.WriteLine("");
        Console.WriteLine("Credit offers:");
        Console.WriteLine("Up to $" + person.Account.EligibleCreditAmount);
        Console.WriteLine("Loan offers:");
        Console.WriteLine("Up to $" + person.Account.EligibleLoanAmount);
        Console.WriteLine("");
        Console.WriteLine(
            "Remember! The more you use our services, the better credit and loan deals you will get.");
        Console.WriteLine("--------------------------------");
        Console.WriteLine(person.Email);
        var naoTerminar = Console.ReadLine();
        return person;
    }

    
}