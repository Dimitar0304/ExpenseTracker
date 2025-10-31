using ExpenseTracker.DtoModels;
using ExpenseTracker.Models;
using ExpenseTracker.Models.FinanceEnities;
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
            List<ExpenseDto> expenses = new();
            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    try
                    {
                        expenses = JsonSerializer.Deserialize<List<ExpenseDto>>(existingJson) ?? new();
                    }
                    catch
                    {
                        
                        expenses = new();
                    }
                }
            }
            expenses.Add(entity);

            string json = JsonSerializer.Serialize(expenses, new JsonSerializerOptions { WriteIndented = true });
            Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);
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

        public List<ExpenseDto> ReadAll()
        {
            List<ExpenseDto> expenses = new();
            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    try
                    {
                        expenses = JsonSerializer.Deserialize<List<ExpenseDto>>(existingJson) ?? new();
                    }
                    catch
                    {

                        expenses = new();
                    }
                }
                return expenses;
            }
            return new List<ExpenseDto>();
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
