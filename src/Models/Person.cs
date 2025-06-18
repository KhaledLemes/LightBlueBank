using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

public class Person
{
    [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    private int personId;
    
    [Required, EmailAddress]
    private string email;
    
    [Required, StringLength(60)]
    private string hashedpassword;
    
    private string name;
    
    private string middleName;
    
    private string lastName;

    [Range(18, 99)]
    private int age;
    
    [Required]   
    private Role role;
    
    [Required]  
    private BankAccount account;
    
    public int PersonId { get => personId; set => personId = value; }
    public string Name { get => name; set => name = value; }
    public string MiddleName { get => middleName; set => middleName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public int Age { get => age; set => age = value; }
    public Role Role { get => role; set => role = value; }
    public string Email { get => email; set => email = value; }
    public string Password { get => hashedpassword; set => hashedpassword = value; }
    public BankAccount Account  { get => account; set => account = value; }
}
