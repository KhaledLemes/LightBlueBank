namespace ConsoleApp1.Person;

public class Person
{
    private int id;
    private string email;
    private string name;
    private string middleName;
    private string lastName;
    private int age;
    public BankAccount.BankAccount account;
    
    public int Id { get => id; set => id = value; } //This one will have no value for now
    public string Name { get => name; set => name = value; }
    public string MiddleName { get => middleName; set => middleName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public int Age { get => age; set => age = value; }
    public BankAccount.BankAccount Account  { get => account; set => account = value; }
    
    //Creates the account, if the user is one of the first 50 users, they will have a balance of 100
    //This method is only temporary, for I have to add Dependency Injection to the project to have IoC.
    public void CreateAccount()
    {
        Account.Balance = 0;
        Account.EligibleLoanAmount = 0;
        Account.EligibleCreditAmount = 0;
        if (Id > 50) return; //If the user is not one of the first 50 users, the function ends.
        Account.Balance += 100;
        Console.WriteLine("Congrats! You have been given a balance of U$100 for being one of the first 50 customers.");
        Console.WriteLine("");
        Console.WriteLine("");
    }
    
}
