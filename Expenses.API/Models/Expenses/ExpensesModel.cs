using Expenses.API.Enums;

namespace Expenses.API.Models.Expenses
{
    public sealed class ExpensesModel
    {
        public ExpensesModel()
        {
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public double Value { get; set; }

        public ExpenseType ExpenseType { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
