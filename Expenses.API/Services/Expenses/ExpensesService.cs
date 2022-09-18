using Expenses.API.Enums;
using Expenses.API.Filters;
using Expenses.API.Models.Expenses;

namespace Expenses.API.Services.Expenses
{
    public sealed class ExpensesService : IExpensesService
    {
        // TODO: Replace this with functionality to access a database.
        private readonly List<ExpensesModel> _expensesDataSet = new()
        {
            new ExpensesModel()
            {
                Id = 1,
                Name = "Work Pay",
                ExpenseType = ExpenseType.Addition,
                Value = 3000.00,
                CreatedDate = DateTime.Today,
            },
            new ExpensesModel()
            {
                Id = 2,
                Name = "Mortgage",
                ExpenseType = ExpenseType.Subtraction,
                Value = 500.00,
                CreatedDate = DateTime.Today,
            },
            new ExpensesModel()
            {
                Id = 3,
                Name = "Water Bill",
                ExpenseType = ExpenseType.Subtraction,
                Value = 25.00,
                CreatedDate = DateTime.Today,
            },
            new ExpensesModel()
            {
                Id = 4,
                Name = "Gas & Electric",
                ExpenseType = ExpenseType.Subtraction,
                Value = 200,
                CreatedDate = DateTime.Today,
            },
            new ExpensesModel()
            {
                Id = 5,
                Name = "Netflix",
                ExpenseType = ExpenseType.Subtraction,
                Value = 12.50,
                CreatedDate = DateTime.Today,
            },
            new ExpensesModel()
            {
                Id = 6,
                Name = "Side Work",
                ExpenseType = ExpenseType.Addition,
                Value = 750.00,
                CreatedDate = DateTime.Today,
            },
            new ExpensesModel()
            {
                Id = 7,
                Name = "Car Finance",
                ExpenseType = ExpenseType.Subtraction,
                Value = 300.00,
                CreatedDate = DateTime.Today,
            },
            new ExpensesModel()
            {
                Id = 8,
                Name = "Family Meal",
                ExpenseType= ExpenseType.Subtraction,
                Value = 80.80,
                CreatedDate = DateTime.Today,
            },
            new ExpensesModel()
            {
                Id = 9,
                Name = "Fuel",
                ExpenseType = ExpenseType.Subtraction,
                Value = 90.00,
                CreatedDate = DateTime.Today,
            },
        };

        public ExpensesService()
        {
        }

        public ExpensesModel GetExpense(int id)
        {
            return _expensesDataSet.FirstOrDefault(x => x.Id == id);
        }

        public List<ExpensesModel> GetExpenses(GetExpensesParams getExpensesParams)
        {
            return _expensesDataSet
                .Skip(getExpensesParams.Skip)
                .Take(getExpensesParams.Take).ToList();
        }

        public int GetExpensesCount() => _expensesDataSet.Count;
    }
}
