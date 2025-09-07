namespace Blazor.App.Models
{
	public class Wallet
	{
		public decimal Balance { get; set; } = 0;
		public List<Transaction> Transactions { get; set; } = new();
	}
}
