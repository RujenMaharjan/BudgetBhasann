namespace BudgetBhasan.Models;

public class Outflow
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string TansactionLabel { get; set; }
    public string Note { get; set; }
    public int Amount { get; set; }
    public DateTime Date { get; set; }
    public string Label { get; set; }
}