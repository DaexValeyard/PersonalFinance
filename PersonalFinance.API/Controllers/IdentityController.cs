using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PersonalFinance.Application.Users.Commands.CreateUser;

namespace PersonalFinance.API.Controllers;

[ApiController]
[Route("api/identity")]
public class IdentityController(IMediator mediator) : ControllerBase
{
    [ProducesResponseType(StatusCodes.Status201Created)]
    [HttpPost("prueba")]
    [AllowAnonymous]
    public async Task<IActionResult> CreateUser(CreateUserCommand command)
    {
        var email = await mediator.Send(command);
        Console.WriteLine(command);

        return CreatedAtAction(nameof(CreateUser), new { email }, null);
    }
}
