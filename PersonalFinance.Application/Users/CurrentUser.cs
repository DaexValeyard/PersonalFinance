namespace PersonalFinance.Application.Users;

public record CurrentUser(
    string Id,
    string Email,
    IEnumerable<string> Roles,
    string? RFC)
{
    public bool IsInRole(string role) => Roles.Contains(role);
}
