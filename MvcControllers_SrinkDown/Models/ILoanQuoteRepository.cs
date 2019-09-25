namespace MvcControllers_SrinkDown.Models
{
	public interface ILoanQuoteRepository
	{
		LoanQuote GetByID(int quoteId);
		void Delete(int quoteId);
		void SaveQuote(LoanQuote quote);
	}
}