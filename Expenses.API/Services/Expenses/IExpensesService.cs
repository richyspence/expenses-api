using Expenses.API.Filters;
using Expenses.API.Models.Expenses;

namespace Expenses.API.Services.Expenses
{
    public interface IExpensesService
    {
        ExpensesModel GetExpense(int id);

        List<ExpensesModel> GetExpenses(GetExpensesParams getExpensesParams);

        int GetExpensesCount();
    }
}
