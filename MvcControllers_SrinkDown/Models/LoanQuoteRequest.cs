namespace MvcControllers_SrinkDown.Models
{
	public class LoanQuoteRequest
	{
		public decimal Amount { get; internal set; }
		public int CreditScore { get; internal set; }
	}
}