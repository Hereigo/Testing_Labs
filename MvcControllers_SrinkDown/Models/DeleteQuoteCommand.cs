namespace MvcControllers_SrinkDown.Models
{
	public class DeleteQuoteCommand : IDeleteQuoteCommand
	{
		private readonly ILoanQuoteRepository _loanQuoteRepository;

		public DeleteQuoteCommand(ILoanQuoteRepository repository)
		{
			_loanQuoteRepository = repository;
		}

		public void Execute(int quoteId)
		{
			_loanQuoteRepository.Delete(quoteId);
		}
	}
}
