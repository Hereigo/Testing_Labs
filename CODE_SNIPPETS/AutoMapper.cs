using AutoMapper;

namespace CODE_SNIPPETS
{
	internal class AutoMapperTest
	{
		public void Run()
		{
			MapperConfiguration mapConfig =
				new MapperConfiguration(cfg => cfg.CreateMap<Source, Destination>());

			IMapper mapper = mapConfig.CreateMapper();

			Source source = new Source();

			Destination destina = mapper.Map<Source, Destination>(source);

			System.Console.WriteLine("id. - " + destina.ID);
			System.Console.WriteLine("ok? - " + destina.ISOKAY);
			System.Console.WriteLine("mr. - " + destina.NAME);
			System.Console.WriteLine("mr. - " + destina.DESTINA_ONLY);
		}
	}

	internal class Destination
	{
		public int DESTINA_ONLY { get; set; }
		public int ID { get; set; }
		public bool ISOKAY { get; set; }
		public string NAME { get; set; }
	}

	internal class Source
	{
		public Source()
		{
			Id = 111;
			Name = "Alex";
			IsOkay = true;
			SourceOnly = 222;
		}

		public int Id { get; set; }
		public bool IsOkay { get; set; }
		public string Name { get; set; }
		public int SourceOnly { get; set; } // Ignored by default
	}
}
