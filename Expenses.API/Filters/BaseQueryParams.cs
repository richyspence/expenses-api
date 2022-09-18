namespace Expenses.API.Filters
{
    public class BaseQueryParams
    {
        public int Take { get; set; } = 5;

        public int Skip { get; set; } = 0;
    }
}
