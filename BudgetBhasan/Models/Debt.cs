using SQLite;

namespace BudgetBhasan.Models;

public class Debt
{
    [PrimaryKey]
    public Guid debtId { get; set; } = Guid.NewGuid();
    public string TakenFrom { get; set; }
    public int Amount { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime DateTaken { get; set; }
    public string IsPaid { get; set; } 
}
