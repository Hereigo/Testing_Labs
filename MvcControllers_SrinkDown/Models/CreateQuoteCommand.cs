namespace MvcControllers_SrinkDown.Models
{
	public class CreateQuoteCommand : ICreateQuoteCommand
	{
		private readonly ILoanQuoteRepository _loanQuoteRepository;

		public CreateQuoteCommand(ILoanQuoteRepository repository)
		{
			_loanQuoteRepository = repository;
		}

		public LoanQuoteResponse Execute(decimal amount, int creditScore)
		{
			LoanQuote quote = new LoanQuote(amount, creditScore);

			quote.CalculateLoanTerms();

			_loanQuoteRepository.SaveQuote(quote);

			LoanQuoteResponse response = new LoanQuoteResponse();
			response.Amount = quote.Amount;
			response.RequestStatus = quote.Decision;
			response.InterestRate = quote.InterestRate;

			return response;
		}
	}
}
