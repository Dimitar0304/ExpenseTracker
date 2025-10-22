namespace ExpenseTracker.Models
{
    public interface IFinanceEntity
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public string Summary { get; set; }
        public DateTime Date { get; set; }
    }
}
