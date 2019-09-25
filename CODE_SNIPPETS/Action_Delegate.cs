using System;

namespace CODE_SNIPPETS
{
	public delegate TResult Func<in T, out TResult>(T arg);

	public class Action_Delegate
	{
		private Action<int, int> summaryAction;

		public void TestSum(int a, int b)
		{
			summaryAction += SummaryMethod;
			summaryAction += SummaryMethod;
			summaryAction += SummaryMethod;

			summaryAction(a, b);
		}

		private static void SummaryMethod(int arg1, int arg2)
		{
			Console.WriteLine(arg1 + arg2);
		}
	}
}
