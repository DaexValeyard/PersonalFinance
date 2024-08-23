using MediatR;
using PersonalFinance.Application.Statements.Dtos;

namespace PersonalFinance.Application.Statements.GetAllStatements;

public class GetAllStatementsQuery : IRequest<(IEnumerable<StatementDto>, TotalDto)>
{
}
