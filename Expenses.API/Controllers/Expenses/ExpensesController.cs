using Expenses.API.Filters;
using Expenses.API.Models.Expenses;
using Expenses.API.Responses;
using Expenses.API.Services.Expenses;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel;

namespace Expenses.API.Controllers.Expenses
{
    [ApiController]
    [Route("expenses")]
    public sealed class ExpensesController : ControllerBase
    {
        private readonly IExpensesService _expensesService;

        public ExpensesController(IExpensesService expensesService)
        {
            _expensesService = expensesService;
        }

        [HttpGet]
        [Route("{id}")]
        [SwaggerResponse(200, "Object representating an expense")]
        [SwaggerResponse(400, "The id provided is missing or invalid")]
        [SwaggerResponse(404, "The id provided does not match an existing expense")]
        public IActionResult GetExpense([FromQuery] int id)
        {
            try
            {
                var expense = _expensesService.GetExpense(id);

                if (expense == null)
                {
                    return NotFound($"An expense with the id {id} was not found");
                }

                return Ok(expense);
            }
            catch
            {
                throw;
            }
        }

        [HttpGet]
        public IActionResult GetExpenses([FromQuery] GetExpensesParams getExpensesParams)
        {
            var expenses = _expensesService.GetExpenses(getExpensesParams);
            var totalRecords = _expensesService.GetExpensesCount();

            return Ok(new BaseResponse<ExpensesModel>(expenses, totalRecords));
        } 
    }
}
