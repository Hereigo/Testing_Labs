using Microsoft.AspNetCore.Mvc;
using MvcControllers_SrinkDown.Models;

namespace MvcControllers_SrinkDown.Controllers
{
	public class HomeController : Controller
	{
		private readonly ICreateQuoteCommand _createQuote;
		private readonly IDeleteQuoteCommand _deleteQuote;
		private readonly IQuoteQuery _quoteQuery;

		public HomeController(IQuoteQuery quoteQuery, ICreateQuoteCommand createQuote, IDeleteQuoteCommand deleteQuote)
		{
			_quoteQuery = quoteQuery;
			_createQuote = createQuote;
			_deleteQuote = deleteQuote;
		}

		[HttpPost, Route("api/loans/quotes/")]
		public IActionResult CreateLoanQuote(LoanQuoteRequest request)
		{
			LoanQuoteResponse loanQuoteResponse = _createQuote.Execute(request.Amount, request.CreditScore);

			return Ok(loanQuoteResponse);
		}

		[HttpPost, Route("api/loans/quotes/{id}")]
		public IActionResult DeleteQuote(int id)
		{
			_deleteQuote.Execute(id);

			return NoContent();
		}

		[HttpGet, Route("api/loans/quotes/{id}")]
		public IActionResult GetQuote(int id)
		{
			LoanQuote quote = _quoteQuery.Execute(id);

			return Ok(quote);
		}
	}
}