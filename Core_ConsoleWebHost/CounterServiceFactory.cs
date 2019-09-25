namespace Core21_ConsoleWebHost
{
	public class CounterServiceFactory
	{
		protected internal ICounterService _counterSercive { get; }

		public CounterServiceFactory(ICounterService counterSercive)
		{
			_counterSercive = counterSercive;
		}
	}
}