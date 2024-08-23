namespace PersonalFinance.Application.Statements.Dtos;

public class StatementDto
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public string Item { get; set; } = default!;
    public string Category { get; set; } = default!;
    public decimal Amount { get; set; }

    // TODO: Terminar DTO y ver como calcular los totales mensuales
}
