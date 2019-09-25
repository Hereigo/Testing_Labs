namespace MvcControllers_SrinkDown.Models
{
	public class LoanQuoteResponse : ILoanQuoteRepository
	{
		public LoanQuoteResponse()
		{
		}

		public decimal Amount { get; internal set; }
		public int InterestRate { get; internal set; }
		public string RequestStatus { get; internal set; }

		public void Delete(int quoteId)
		{
			throw new System.NotImplementedException();
		}

		LoanQuote ILoanQuoteRepository.GetByID(int quoteId)
		{
			throw new System.NotImplementedException();
		}

		public void SaveQuote(LoanQuote quote)
		{
			throw new System.NotImplementedException();
		}
	}
}