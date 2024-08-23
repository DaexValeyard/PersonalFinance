namespace PersonalFinance.Application.Statements.Dtos;

public class TotalDto
{
    public DateOnly Month {  get; set; }
    public decimal Income { get; set; }
    public decimal Expenses { get; set; }
    public decimal Total { get; set; }
}
