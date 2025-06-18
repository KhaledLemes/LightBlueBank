using System.Net.Mail;
using System.Text.RegularExpressions;

namespace ConsoleApp1.Validation;

public class UserServiceValidators
{
    //Uses built-in methods to check if the name is valid, contains a digit or has any spaces.
    public bool IsValidName(string? str)
    {
        return !string.IsNullOrEmpty(str) && !str.Any(char.IsDigit) && !str.Any(char.IsWhiteSpace) && str.All(char.IsAsciiLetter) && str.Length >= 2 && str.Length <= 25;
    }
    
    public bool IsValidEmail(string? email)
    {
        try
        {
            //Tries to instance an object of the MailAddress class, if failed, email is correct
            //Better than manually building the regex.
            var mailAddress = new MailAddress(email!);
            if (string.IsNullOrEmpty(email) || email.Any(char.IsWhiteSpace)) return false;
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
        catch (ArgumentException)
        {
            return false;
        }
    }

    public bool IsValidAge(int age)
    {
        switch (age)
        {
            case <= 0: //If you check it, trying to put letters on the age field will return 0.
                Console.WriteLine("Invalid age. Please try again.");
                return false;
            case < 18:
                Console.WriteLine("You are not old enough to use our services.");
                return false;
            case > 99:
                Console.WriteLine("Invalid age. I am sure you are not that old.");
                return false;
        }
        return true;
    }
    
    public bool IsValidPassword(string? password)
    {
        return !string.IsNullOrEmpty(password) && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit) && password.Any(char.IsPunctuation) && password.Length >= 10 && password.Length <= 23;
    }
}