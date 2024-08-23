using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PersonalFinance.Domain.Entities;

public class User : IdentityUser
{
    [StringLength(40)]
    public string Name { get; set; } = default!;
    [StringLength(20)]
    public string FatherSurname { get; set; } = default!;
    [StringLength(20)]
    public string? MotherSurname { get; set; } = default!;
    [StringLength(13)]
    public string RFC { get; set; } = default!;
    [StringLength(18)]
    public string CURP { get; set; } = default!;
    [StringLength(10)]
    public string NSS { get; set; } = default!;
    public DateOnly DateOfBirth { get; set; }
    public string? Regime { get; set; } = default!;

    public List<Statement> Statements = [];
}
