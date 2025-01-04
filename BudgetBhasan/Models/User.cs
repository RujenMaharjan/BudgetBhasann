using SQLite;

namespace BudgetBhasan.Models;

public class User
{
    [PrimaryKey]
    public Guid Id { get; set; }= Guid.NewGuid();
    public string Username { get; set; }
    public string Password { get; set; }
    public int Balance { get; set; }
    public string email { get; set; }
    public string prefferedCurrency { get; set; }
}
