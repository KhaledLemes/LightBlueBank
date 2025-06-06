// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

string capitalizeFirstLetter(string name)
{
    return name.Substring(0, 1).ToUpper() + name.Substring(1);
}

Console.WriteLine("Insert your first name:");
string name = Console.ReadLine();
Console.WriteLine("Insert yout surname:");
string middleName = Console.ReadLine();
Console.WriteLine("Insert your last name:");
string LastName = Console.ReadLine();
Console.WriteLine("Now please, insert your age!");
String ageToBeConverted = Console.ReadLine();
int ageConverted = int.Parse(ageToBeConverted);
Console.WriteLine("");
Console.WriteLine("");

Person person = new Person();
person.Name = name;
person.MiddleName = middleName;
person.LastName = LastName;
person.Age = ageConverted;
person.Account = new BankAccount();

/*
 The app is being currently developed to work on the terminal.
 However, I do have plans to make it work on a web app with HTML, CSS and js.
 I will be working on it in the future.
 */
Console.WriteLine("Creating account...");
Console.WriteLine("--------------------------------");
person.createAccount();

Console.WriteLine("Welcome to BlueLight bank, " + person.Name + "!");
Console.WriteLine("Your balance is $" + person.Account.Balance);
Console.WriteLine("Check below credit card and loan offers and see how much you can get!");
Console.WriteLine("");
Console.WriteLine("Credit offers:");
Console.WriteLine("Up to $" + person.Account.EligibleCreditAmount);
Console.WriteLine("Loan offers:");
Console.WriteLine("Up to $" + person.Account.EligibleLoanAmount);
Console.WriteLine("");
Console.WriteLine("Remember! The more you use our services, the better credit and loan deals you will get.");

