namespace Interceptors
{
	internal interface ICacheService
	{
		Order this[string cacheKey] { get; set; }

		bool Contains(string cacheKey);

		Order GetFromCacheByIndex(string cacheKey);

		void InsertIntoCacheByIndex(string cacheKey, Order value);
	}
}