using System;

namespace Interceptors
{
	[Logs]
	public class OrderService_3_interC : IOrderService
	{
		[Logs]
		public Order GetOrder(int orderID)
		{
			Console.WriteLine("GetOrder from OrderService_3_interC");

			return new Order();
		}
	}
}