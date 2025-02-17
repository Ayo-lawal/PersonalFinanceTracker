namespace PersonalFinanceTracker.API.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Type { get; set; } // Income or Expense
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
    }
}
