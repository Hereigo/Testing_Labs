using System;

namespace CODE_SNIPPETS
{
	internal delegate string TaskCompletedDelegate(string taskResult);

	public class CallbackClass
	{
		public void CallbackTest()
		{
			TaskCompletedDelegate callbackDelegate = ProcessCallbackResult;

			AnotherClass anotherClass = new AnotherClass();

			anotherClass.StartNewTask(callbackDelegate);
		}

		private string ProcessCallbackResult(string callbackResult)
		{
			return callbackResult.ToUpper();
		}
	}

	internal class AnotherClass
	{
		internal void StartNewTask(TaskCompletedDelegate callbackDelegate)
		{
			// doing something long time to obtain
			System.Threading.Thread.Sleep(2000);

			string taskResult = "I am a long task rezult!";

			if (callbackDelegate != null)
			{
				//   ProcessCallbackResult(string result) - call()
				Console.WriteLine(callbackDelegate(taskResult));
			}
		}
	}
}
