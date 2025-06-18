using ConsoleApp1.DTOs;
using ConsoleApp1.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    private readonly IPersonService _personService;

    public PersonController(IPersonService personService)
    {
        _personService = personService;
    }

    [HttpPost]
    public IActionResult SignUp([FromBody] SignUpDto signUpDto)
    {
        //var person = _personService.SignUp(signUpDto.name, signUpDto.middleName, signUpDto.lastName, signUpDto.ageToBeConverted, signUpDto.email, signUpDto.password);
        var person = _personService.SignUp("khaled", "khaled", "khaled", "19", "parede@fome.com", "Khaled6789!");
        return Ok(person);
    }
}