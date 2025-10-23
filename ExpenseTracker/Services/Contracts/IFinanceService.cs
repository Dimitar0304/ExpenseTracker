using ExpenseTracker.DtoModels;
using ExpenseTracker.Models;

namespace ExpenseTracker.Services.Contracts
{
    public interface IFinanceService
    {
        FinanceOperationModel AddAsync(ExpenseDto entity);
        FinanceOperationModel DeleteAsync(ExpenseDto entity);
        IFinanceEntity ReadAsync(int id);
        FinanceOperationModel UpdateAsync(int id);
    }
}
