namespace Expenses.API.Responses
{
    public class BaseResponse<ExpensesModel>
    {
        public BaseResponse(IList<ExpensesModel> data, int totalItems)
        {
            Data = data;
            TotalItems = totalItems;
        }

        public int TotalItems { get; set; }

        public IList<ExpensesModel> Data { get; set; }
    }
}
