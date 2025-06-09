using ConsoleApp1.Models;

namespace ConsoleApp1.Interfaces.IServices;

public interface IPersonService
{
    Person? SignUp(string? name, string? middleName, string? lastName, string? ageToBeConverted);
}