using MediatR;
using System.ComponentModel.DataAnnotations;

namespace PersonalFinance.Application.Users.Commands.CreateUser;

public class CreateUserCommand : IRequest<string>
{
    public string Name { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string FatherSurname { get; set; } = default!;
    public string? MotherSurname { get; set; } = default!;
    public string RFC { get; set; } = default!;
    public string CURP { get; set; } = default!;
    public string NSS { get; set; } = default!;
    public DateOnly DateOfBirth { get; set; }
    public string? Regime { get; set; }
    public string Password { get; set; } = default!;
}
