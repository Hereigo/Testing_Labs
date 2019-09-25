namespace MvcControllers_SrinkDown.Models
{
	public interface ICreateQuoteCommand
	{
		LoanQuoteResponse Execute(decimal amount, int creditScore);
	}
}