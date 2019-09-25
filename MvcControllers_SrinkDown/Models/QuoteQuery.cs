namespace MvcControllers_SrinkDown.Models
{
	public class QuoteQuery : IQuoteQuery
	{
		private ILoanQuoteRepository _loanQuoteRepository;

		public QuoteQuery(ILoanQuoteRepository repository)
		{
			_loanQuoteRepository = repository;
		}

		public LoanQuoteResponse Execute(int quoteId)
		{
			LoanQuote quote = _loanQuoteRepository.GetByID(quoteId);

			var response = new LoanQuoteResponse();
			response.Amount = quote.Amount;
			response.RequestStatus = quote.Decision;
			response.InterestRate = quote.InterestRate;

			return response;
		}

		LoanQuote IQuoteQuery.Execute(int id)
		{
			throw new System.NotImplementedException();
		}
	}
}
