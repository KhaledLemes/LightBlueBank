namespace ConsoleApp1;

public class BankAccount
{
    private string accountNumber; //This one will be made when setting the DB
    private decimal balance;
    private decimal eligibleLoanAmount;
    private decimal eligibleCreditAmount;
    
    public decimal Balance { get => balance; set => balance = value; }
    public decimal EligibleLoanAmount { get => eligibleLoanAmount; set => eligibleLoanAmount = value; }
    public decimal EligibleCreditAmount { get => eligibleCreditAmount; set => eligibleCreditAmount = value; }


}