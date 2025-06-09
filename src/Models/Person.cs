namespace ConsoleApp1.Models;

public class Person
{
    private int id;
    private string email;
    private string password;
    private string name;
    private string middleName;
    private string lastName;
    private int age;
    private BankAccount account;
    
    public int Id { get => id; set => id = value; } //This one will have no value for now
    public string Name { get => name; set => name = value; }
    public string MiddleName { get => middleName; set => middleName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public int Age { get => age; set => age = value; }
    public string Email { get => email; set => email = value; }
    public string Password { get => password; set => password = value; }
    public BankAccount Account  { get => account; set => account = value; }
}
