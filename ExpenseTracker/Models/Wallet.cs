using ExpenseTracker.Models.FinanceEnities;

namespace ExpenseTracker.Models
{
    public class Wallet
    {
        public decimal Amount { get; set; }

        public List<Expense> Expenses { get; set; } = new List<Expense>();
        public List<Income> Incomes { get; set; } = new List<Income>();
    }
}
