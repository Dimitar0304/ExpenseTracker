namespace ExpenseTracker.DtoModels
{
    public class FinanceOperationModel
    {
        public bool IsHappen { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
    }
}
