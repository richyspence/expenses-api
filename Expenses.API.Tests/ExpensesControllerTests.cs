using Expenses.API.Controllers.Expenses;
using Expenses.API.Services.Expenses;
using FluentAssertions;

namespace Expenses.API.Tests
{
    public class ExpensesControllerTests
    {
        [Fact]
        public void ExpensesController_CanInitialize_Successfully()
        {
            // Arrange
            var expensesService = new ExpensesService();

            // Act
            var expensesController = new ExpensesController(expensesService);

            // Assert
            expensesController.Should().NotBeNull();
        }
    }
}