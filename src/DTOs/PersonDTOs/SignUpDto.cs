namespace ConsoleApp1.DTOs;

public record SignUpDto
{
    public string name { get; init; }
    public string middleName { get; init; }
    public string lastName { get; init; }
    public string ageToBeConverted { get; init; }
    public string email { get; init; }
    public string password { get; init; }
}