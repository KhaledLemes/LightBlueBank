using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Models;

public class BankAccount
{
    private int bankAccId;
    private int personId;
    [Required]
    private int accountNumber;
    [Required]
    private decimal balance;
    [Required]
    private decimal eligibleLoanAmount;
    [Required]   
    private decimal eligibleCreditAmount;
    private Person person;
    
    //id is for the DB, acc number is for the user and transactions
    public int BankAccId { get => bankAccId; } 
    public int PersonId { get => personId; set => personId = value; }
    public int AccountNumber { get => accountNumber; set => accountNumber = value; }
    public decimal Balance { get => balance; set => balance = value; }
    public decimal EligibleLoanAmount { get => eligibleLoanAmount; set => eligibleLoanAmount = value; }
    public decimal EligibleCreditAmount { get => eligibleCreditAmount; set => eligibleCreditAmount = value; }
    public Person Person { get => person; set => person = value; }
}