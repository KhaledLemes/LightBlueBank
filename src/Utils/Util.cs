namespace ConsoleApp1.Utils;

public class Util
{
    public int ConvertAge(string? ageToBeConverted)
    {
        //"Can this be converted to an int? if it does, then age = parsedAge (user input), if it does not, then age = 0"
        int age = int.TryParse(ageToBeConverted, out int parsedAge) ? parsedAge : 0;
        return age;
    }
    
    public string CapitalizeFirstLetter(string name)
    {
        return name.Substring(0, 1).ToUpper() + name.Substring(1);
    }
}