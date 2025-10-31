using ExpenseTracker.DtoModels;
using ExpenseTracker.Models;
using ExpenseTracker.Services.Contracts;

namespace ExpenseTracker.Services
{
    public class IncomeService : IFinanceService
    {
        public FinanceOperationModel AddAsync(ExpenseDto entity)
        {
            throw new NotImplementedException();
        }

        public FinanceOperationModel DeleteAsync(ExpenseDto entity)
        {
            throw new NotImplementedException();
        }

        public IFinanceEntity ReadAll()
        {
            throw new NotImplementedException();
        }
        public FinanceOperationModel UpdateAsync(int id)
        {
            throw new NotImplementedException();
        }

        List<ExpenseDto> IFinanceService.ReadAll()
        {
            throw new NotImplementedException();
        }

        IFinanceEntity IFinanceService.ReadAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
