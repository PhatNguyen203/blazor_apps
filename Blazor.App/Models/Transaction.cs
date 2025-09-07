namespace Blazor.App.Models
{
	public class Transaction
	{
		public string Type { get; set; } = string.Empty; // "Deposit" or "Withdraw"
		public decimal Amount { get; set; }
		public DateTime Time { get; set; }
	}
}
