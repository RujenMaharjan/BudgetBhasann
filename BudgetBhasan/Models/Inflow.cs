namespace BudgetBhasan.Models;

public class Inflow
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string TansactionTitle { get; set; }
    public string Note { get; set; }
    public string Label { get; set; }
    public int Amount { get; set; }
    public DateTime Date { get; set; }
}