using ExpenseTracker.DtoModels;
using ExpenseTracker.Models;
using ExpenseTracker.Services.Contracts;
using System.Text;
using System.Text.Json;

namespace ExpenseTracker.Services
{
    public class ExpenseService : IFinanceService
    {
        private string filePath = "wwwroot/data/Expenses.json";
        public FinanceOperationModel AddAsync(ExpenseDto entity)
        {
            StringBuilder expense = new StringBuilder();
            expense.AppendLine(entity.Id.ToString());
            expense.Append(entity.Date.ToString());
            expense.Append(entity.Amount.ToString());
            expense.Append(entity.Type);
            expense.Append(entity.Summary);
            string json = JsonSerializer.Serialize(expense, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(filePath, json);

            return new FinanceOperationModel()
            {
                IsHappen = true
            };
        }

        public FinanceOperationModel DeleteAsync(ExpenseDto entity)
        {
            throw new NotImplementedException();
        }

        public IFinanceEntity ReadAsync(int id)
        {
            throw new NotImplementedException();
        }

        public FinanceOperationModel UpdateAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
