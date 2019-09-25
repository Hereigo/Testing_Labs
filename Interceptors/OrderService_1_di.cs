using System;

namespace Interceptors
{
	internal class OrderService_1_di : IOrderService
	{
		private readonly IAuthorizationService _auth;
		private readonly ILoggerService _logger;
		private readonly ICacheService _cache;

		public OrderService_1_di(IAuthorizationService auth, ILoggerService logger, ICacheService cache)
		{
			_auth = auth ?? throw new ArgumentNullException(nameof(auth));
			_logger = logger ?? throw new ArgumentNullException(nameof(logger));
			_cache = cache ?? throw new ArgumentNullException(nameof(cache));
		}

		public Order GetOrder(int orderID)
		{
			_auth.AssertPermission("GetOrder");

			_logger.LogInfo("GetOrder:{0}", orderID);

			string cacheKey = string.Format("GetOrder-{0}", orderID);

			if (_cache.Contains(cacheKey))
				return (Order)_cache[cacheKey];

			Order order = LookupOrderInDatabase(orderID);

			_cache[cacheKey] = order;

			return order;
		}

		private Order LookupOrderInDatabase(int orderID)
		{
			// just test implementation...
			int id = orderID;
			return new Order();
		}
	}
}
