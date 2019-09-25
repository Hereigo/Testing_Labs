using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PaymentsAnalizer.Data;
using PaymentsAnalizer.Models;

namespace PaymentsAnalizer.Controllers
{
	public class PaymentsController : Controller
	{
		private readonly PaymentsContext _context;

		public PaymentsController(PaymentsContext context)
		{
			_context = context;
		}

		[HttpPost]
		public JsonResult IndexJson(DataTableClass responseBody)
		{
			DataTableClass test1 = responseBody;

			Microsoft.EntityFrameworkCore.Query.IIncludableQueryable<Payment, Category> paymentsContext = _context.Payments.Include(p => p.Category);

			// return Json("{\"draw\": 1,\"recordsTotal\": 3,\"recordsFiltered\": 3,\"data\":"+ Json(paymentsContext.Take(3)) +"}");

			string test2 = "{\"draw\": 1,\"recordsTotal\": 3,\"recordsFiltered\": 3,\"data\":[{\"id\":1,\"payDate\":\"2018-07-31T00:00:00\",\"amount\":1,\"description\":\"111\",\"catogoryId\":1,\"category\":{\"id\":1,\"name\":\"CDA\",\"isActive\":true}},{\"id\":2,\"payDate\":\"2018-08-07T15:00:00\",\"amount\":2345789,\"description\":\"dfh dj\",\"catogoryId\":6,\"category\":{\"id\":6,\"name\":\"ENJ\",\"isActive\":true}},{\"id\":1003,\"payDate\":\"2018-08-09T11:03:00\",\"amount\":3457,\"description\":\"eyjtjrj\",\"catogoryId\":9,\"category\":{\"id\":9,\"name\":\"HLS\",\"isActive\":true}}]}";

			string test = "{\"draw\":1,\"recordsTotal\":11,\"recordsFiltered\":11,\"data\":[[\"Airixi\",\"Satou\",\"Accountant\",\"Tokyo\",\"28th Nov 08\",\"$162,700\"],[\"Angeli\",\"Ramos\",\"Chief Executive Officer (CEO)\",\"London\",\"9th Oct 09\",\"$1,200,000\"],[\"Ashton\",\"Cox\",\"Junior Technical Author\",\"San Francisco\",\"12th Jan 09\",\"$86,000\"],[\"Bradly\",\"Greer\",\"Software Engineer\",\"London\",\"13th Oct 12\",\"$132,000\"],[\"Brendn\",\"Wagner\",\"Software Engineer\",\"San Francisco\",\"7th Jun 11\",\"$206,850\"],[\"Brielo\",\"Williamson\",\"Integration Specialist\",\"New York\",\"2nd Dec 12\",\"$372,000\"],[\"Brunos\",\"Nash\",\"Software Engineer\",\"London\",\"3rd May 11\",\"$163,500\"],[\"Caesar\",\"Vance\",\"Pre-Sales Support\",\"New York\",\"12th Dec 11\",\"$106,450\"],[\"Carata\",\"Stevens\",\"Sales Assistant\",\"New York\",\"6th Dec 11\",\"$145,600\"],[\"Cedric\",\"Kelly\",\"Senior Javascript Developer\",\"Edinburgh\",\"29th Mar 12\",\"$433,060\"]]}";

			return Json(test);
			//return test2;
		}

		// GET: Payments
		public async Task<IActionResult> Index()
		{
			Microsoft.EntityFrameworkCore.Query.IIncludableQueryable<Payment, Category> paymentsContext = _context.Payments.Include(p => p.Category);
			return View(await paymentsContext.ToListAsync());
		}

		// GET: Payments/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			Payment payment = await _context.Payments
				.Include(p => p.Category)
				.FirstOrDefaultAsync(m => m.ID == id);
			if (payment == null)
			{
				return NotFound();
			}

			return null; //  View(payment);
		}

		// GET: Payments/Create
		public IActionResult Create()
		{
			ViewData["CatogoryId"] = new SelectList(_context.Categories, "ID", "Name");
			return View();
		}

		// POST: Payments/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("ID,PayDate,Amount,Description,CatogoryId")] Payment payment)
		{
			if (ModelState.IsValid)
			{
				_context.Add(payment);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			ViewData["CatogoryId"] = new SelectList(_context.Categories, "ID", "Name", payment.CatogoryId);
			return View(payment);
		}

		// GET: Payments/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			Payment payment = await _context.Payments.FindAsync(id);
			if (payment == null)
			{
				return NotFound();
			}
			ViewData["CatogoryId"] = new SelectList(_context.Categories, "ID", "Name", payment.CatogoryId);
			return View(payment);
		}

		// POST: Payments/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("ID,PayDate,Amount,Description,CatogoryId")] Payment payment)
		{
			if (id != payment.ID)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(payment);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!PaymentExists(payment.ID))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			ViewData["CatogoryId"] = new SelectList(_context.Categories, "ID", "Name", payment.CatogoryId);
			return View(payment);
		}

		// GET: Payments/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			Payment payment = await _context.Payments
				.Include(p => p.Category)
				.FirstOrDefaultAsync(m => m.ID == id);
			if (payment == null)
			{
				return NotFound();
			}

			return null; // View(payment);
		}

		// POST: Payments/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			Payment payment = await _context.Payments.FindAsync(id);
			_context.Payments.Remove(payment);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool PaymentExists(int id)
		{
			return _context.Payments.Any(e => e.ID == id);
		}
	}
}
