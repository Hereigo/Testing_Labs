using System;

namespace CODE_SNIPPETS
{
	internal static class Program
	{
		private const int msDelay = 3000;

		private static void Main()
		{
			Console.WriteLine("\r\n = ONLY LETTERS = \r\n");
			// Console.WriteLine(TextAndRegex.REMOVE_NON_LETTERS("754$*7=))79`568 666Hel...?lo 87-World! 97~,. 8+ 76@ 5*68"));

			Console.WriteLine("\r\n = TEST GUID = \r\n");
			// Console.WriteLine($"Current Guid is valid = {TextAndRegex.IS_VALID_GUID(Guid.NewGuid().ToString())}");
			TextAndRegex.GuidShortenAsBase64Modif();

			Console.WriteLine("\r\n = TASK CALLBACK = \r\n");
			CallbackClass callBackTest = new CallbackClass();
			// callBackTest.CallbackTest();

			Console.WriteLine("\r\n = EVENTS = \r\n");
			Events myEvents = new Events();
			// myEvents.TestEvents();

			Console.WriteLine("\r\n = ACTION DELEGATE = \r\n");
			Action_Delegate delegate_TRes_Func = new Action_Delegate();
			// delegate_TRes_Func.TestSum(1, 2);

			Console.WriteLine("\r\n = JSON PARSE = \r\n");
			// JsonParse.Test();

			Console.WriteLine("\r\n = AUTO-MAPPER = \r\n");
			// AutoMapperTest amt = new AutoMapperTest();
			// amt.Run();

			Console.WriteLine("\r\n = GET_ENUMERATOR() = \r\n");
			GetEnumerator_Howto tt = new GetEnumerator_Howto();
			// tt.Run();

			Console.WriteLine("\r\n = A S Y N C = \r\n");
			AsyncDownload async = new AsyncDownload();
			// async.A_Start();

			Console.WriteLine("\r\n = T P L  = \r\n");
			TPL_Examples tpl = new TPL_Examples(msDelay);
			// Task<int> taskRunAsync = tpl.Task_Run_Async("Task_Run_Async");
			// tpl.Task_Run_And_Forget("Task_Run_And_Forget");
			// tpl.Task_Run("Task_Run");
			// tpl.Parallel_Invoke("Parallel_Invoke");
			// Console.WriteLine(taskRunAsync.Result);

			Console.WriteLine("\r\n = . . . . .  = \r\n");
			ASYNC_vs_SYNCRO test = new ASYNC_vs_SYNCRO();
			test.Start();

			Console.WriteLine("\r\n = THREADS SYNCRONIZATION  = \r\n");
			// Threads_Syncronization.MainJob();
			// Threads_Semaphore.MainJob();

			Covariance_Contravariance covar = new Covariance_Contravariance(); 
			covar.Run();
			
			Console.WriteLine();
		}
	}
}