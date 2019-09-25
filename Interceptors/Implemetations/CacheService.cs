using System;

namespace Interceptors
{
	public class CacheService : ICacheService
	{
		public Order this[string cacheKey] { get => new Order(); set => InsertIntoCacheByIndex(cacheKey, null); }

		public bool Contains(string cacheKey)
		{
			return true;
		}

		public Order GetFromCacheByIndex(string cacheKey)
		{
			Console.WriteLine("Get Order From Cache...");
			return new Order();
		}

		public void InsertIntoCacheByIndex(string cacheKey, Order value)
		{
			Console.WriteLine("Order Inserted...");
		}
	}
}
