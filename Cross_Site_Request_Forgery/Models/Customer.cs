using System.ComponentModel.DataAnnotations;

namespace Cross_Site_Request_Forgery.Models
{
	public class Customer
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Name Required!")]
		public string Name { get; set; }
	}
}