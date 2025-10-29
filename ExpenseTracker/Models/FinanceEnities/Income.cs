
namespace ExpenseTracker.Models.FinanceEnities
{
    public class Income : IFinanceEntity
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; } = null!;
        public string Summary { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
