namespace ConsoleApp1.Models;

public class BankAccount
{
    private int id;
    private int accountNumber;
    private decimal balance;
    private decimal eligibleLoanAmount;
    private decimal eligibleCreditAmount;
    
    //id is for the DB, acc number is for the user and transactions
    public int Id { get => id; } 
    public int AccountNumber { get => accountNumber; set => accountNumber = value; }
    public decimal Balance { get => balance; set => balance = value; }
    public decimal EligibleLoanAmount { get => eligibleLoanAmount; set => eligibleLoanAmount = value; }
    public decimal EligibleCreditAmount { get => eligibleCreditAmount; set => eligibleCreditAmount = value; }
}