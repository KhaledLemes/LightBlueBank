using ConsoleApp1.Interfaces.IServices;
using ConsoleApp1.Models;

namespace ConsoleApp1.Services;

public class PersonService : IPersonService
{
    private readonly IBankAccountService _bankAccountService;

    public PersonService(IBankAccountService bankAccountService)
    {
        _bankAccountService = bankAccountService;
    }

    public Person? SignUp(string? name, string? middleName, string? lastName, string? ageToBeConverted)
    {
        //"Can this be converted to an int? if it does, then age = parsedAge (user input), if it does not, then age = 0"
        int age = int.TryParse(ageToBeConverted, out int parsedAge) ? parsedAge : 0;
        
        if (!IsValidName(name) || !IsValidName(middleName) || !IsValidName(lastName))
        {
            Console.WriteLine("Invalid or empty names. Please try again.");
            Console.WriteLine("Try to check for empty spaces and try again.");
            return null;
        }

        switch (age)
        {
            case <= 0: //If you check it, trying to put letters on the age field will return 0.
                Console.WriteLine("Invalid age. Please try again.");
                return null;
            case < 18:
                Console.WriteLine("You are not old enough to use our services.");
                return null;
            case >= 99:
                Console.WriteLine("Invalid age. I am sure you are not that old.");
                return null;
        }

        Person person = new Person();
        person.Name = CapitalizeFirstLetter(name!);
        person.MiddleName = CapitalizeFirstLetter(middleName!);
        person.LastName = CapitalizeFirstLetter(lastName!);
        person.Age = age;
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
        var naoTerminar = Console.ReadLine();
        return person;
    }
    string CapitalizeFirstLetter(string name)
    {
        return name.Substring(0, 1).ToUpper() + name.Substring(1);
    }

    //Uses built-in methods to check if the name is valid, contains a digit or has any spaces.
    bool IsValidName(string? str)
    {
        return !string.IsNullOrEmpty(str) && !str.Any(char.IsDigit) && !str.Any(char.IsWhiteSpace) && str.All(char.IsAsciiLetter);
    }
    
}