using System;

namespace CODE_SNIPPETS
{
	internal class Events
	{
		public void TestEvents()
		{
			MyPublisher publisher = new MyPublisher();

			publisher.PublisherEventAction += WhenPublisherEventOccurs;
			publisher.PublisherEventHandler += Publisher_PublisherEventHandler;

			publisher.TestNumber(1);
			publisher.TestNumber(2);
			publisher.TestNumber(3);
		}

		private void Publisher_PublisherEventHandler(object sender, EventArgs e)
		{
			Console.WriteLine($"PublisherEventHandler invoked by {((MyPublisher)sender).ToString()} with number = {((MyTestArgs)e).TestNum}");
		}

		private void WhenPublisherEventOccurs(int i)
		{
			Console.WriteLine($"\r\nPublisher event has occured for number - {i}.");
		}
	}


	internal class MyTestArgs : EventArgs
	{
		public MyTestArgs(int num)
		{
			TestNum = num;
		}
		public int TestNum { get; }
	}


	internal class MyPublisher
	{
		public event Action<int> PublisherEventAction;

		public event EventHandler PublisherEventHandler;

		public void TestNumber(int num)
		{
			if (num != 2)
			{
				PublisherEventAction?.Invoke(num);
			}
			else
			{
				PublisherEventHandler?.Invoke(this, new MyTestArgs(num));
			}
		}
	}
}
