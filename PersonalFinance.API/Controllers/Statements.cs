using MediatR;
using Microsoft.AspNetCore.Mvc;
using PersonalFinance.Application.Statements.Dtos;
using PersonalFinance.Application.Statements.GetAllStatements;

namespace PersonalFinance.API.Controllers;

[ApiController]
[Route("api/statements")]
public class Statements(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<(IEnumerable<StatementDto>, TotalDto)>> GetAllAsync(GetAllStatementsQuery query)
    {
        var statements = await mediator.Send(query);

        return Ok(statements);
    }
}
