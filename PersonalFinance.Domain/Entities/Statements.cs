namespace PersonalFinance.Domain.Entities;

public class Statement
{
    public int Id { get; set; }
    public DateOnly Date {  get; set; }
    public string Item { get; set; } = default!;
    public string Category { get; set; } = default!;
    public decimal Amount { get; set; }
    public User Owner { get; set; }
    public string OwnerId {  get; set; }
}
