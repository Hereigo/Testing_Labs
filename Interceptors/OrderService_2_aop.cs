using System;

namespace Interceptors
{
	internal class OrderService_2_aop : IOrderService
	{
		[Authorize]
		[Logs]
		[Cache("GetOrder-{0}")]
		public Order GetOrder(int orderID)
		{
			return LookupOrderInDatabase(orderID);
		}

		private Order LookupOrderInDatabase(int orderID)
		{
			// just test implementation...
			int id = orderID;
			Console.WriteLine($"Lookup Order In Database by ID : {orderID}");
			return new Order();
		}
	}
}