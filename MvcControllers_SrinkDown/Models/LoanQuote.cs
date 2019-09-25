using System;

namespace MvcControllers_SrinkDown.Models
{
	public class LoanQuote
	{
		private readonly int creditScore;

		public LoanQuote(decimal amount, int creditScore)
		{
			this.Amount = amount;
			this.creditScore = creditScore;
		}

		public decimal Amount { get; internal set; }
		public string Decision { get; internal set; }
		public int InterestRate { get; internal set; }

		internal void CalculateLoanTerms()
		{
			throw new NotImplementedException();
		}
	}
}