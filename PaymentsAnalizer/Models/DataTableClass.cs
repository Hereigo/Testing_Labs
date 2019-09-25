namespace PaymentsAnalizer.Models
{
	public class DataTableClass
	{
		public int Draw { get; set; }

		public Column[] Columns { get; set; }

		public Order[] Order { get; set; }

		public int Start { get; set; }

		public int Length { get; set; }

		public Search Search { get; set; }
	}

	public class Search
	{
		public bool Regex { get; set; }
		public string Value { get; set; }
	}

	public class Order
	{
		public string Dir { get; set; }
		public int Column { get; set; }
	}

	public class Column
	{
		public int Data { get; set; }

		public string Name { get; set; }

		public bool Searchable { get; set; }

		public bool Orderable { get; set; }

		public Search Search { get; set; }
	}

	public enum Direction
	{
		asc, desc
	}
}
