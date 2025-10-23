using ExpenseTracker.Models;

namespace ExpenseTracker.DtoModels
{
    public class ExpenseDto : IFinanceEntity
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public string Summary { get; set; }
        public DateTime Date { get; set; }
    }
}
