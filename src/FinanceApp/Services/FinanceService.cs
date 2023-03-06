namespace FinanceApp.Services
{
    public class FinanceService
    {
        public IEnumerable<string> GetTransactionTypes()
        {
            return new List<string>
            {
                "All",
                "Income",
                "Expense"
            };
        }
    }
}
