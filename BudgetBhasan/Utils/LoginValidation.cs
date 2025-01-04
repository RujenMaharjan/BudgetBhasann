namespace BudgetBhasan.Utils;

public class LoginValidation
{
    public static bool IsValidInput(string input) => !string.IsNullOrWhiteSpace(input);
}