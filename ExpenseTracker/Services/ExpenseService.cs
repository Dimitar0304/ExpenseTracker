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
            entity.Date = DateTime.Now;
            string json = JsonSerializer.Serialize(entity, new JsonSerializerOptions() { WriteIndented = true });
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
