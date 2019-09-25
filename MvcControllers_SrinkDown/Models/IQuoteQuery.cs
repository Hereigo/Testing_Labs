namespace MvcControllers_SrinkDown.Models
{
	public interface IQuoteQuery
	{
		LoanQuote Execute(int id);
	}
}