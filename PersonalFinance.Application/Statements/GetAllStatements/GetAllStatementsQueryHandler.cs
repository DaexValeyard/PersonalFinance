using MediatR;
using Microsoft.Extensions.Logging;
using PersonalFinance.Application.Statements.Dtos;
using PersonalFinance.Application.Users;

namespace PersonalFinance.Application.Statements.GetAllStatements;

public class GetAllStatementsQueryHandler(ILogger<GetAllStatementsQueryHandler> logger,
    IUserContext userContext) : IRequestHandler<GetAllStatementsQuery, (IEnumerable<StatementDto>, TotalDto)>
{
    public Task<(IEnumerable<StatementDto>, TotalDto)> Handle(GetAllStatementsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
