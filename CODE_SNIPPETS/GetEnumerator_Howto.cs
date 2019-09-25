using System;
using System.Collections;
using System.Collections.Generic;

namespace CODE_SNIPPETS
{
	public class GetEnumerator_Howto
	{
		public void Run()
		{
			foreach (SimpleClass item in new SimpleClassCollection())
			{
				Console.WriteLine("AutoProperty of New Class = " + item.AutoProperty);
			}
		}
	}


	internal class SimpleClass
	{
		public int AutoProperty { get; set; }
	}


	internal class SimpleClassCollection : IEnumerable<SimpleClass>
	{
		public IEnumerator<SimpleClass> GetEnumerator()
		{
			IEnumerable<SimpleClass> simpleClassesEnum =
				new List<SimpleClass>() { new SimpleClass() };

			return simpleClassesEnum.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
