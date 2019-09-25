namespace MVC_AsyncController.Models
{
	public class EmployeeViewModel
	{
		public int Id { get; set; }
		public string Firstname { get; set; }
		public string Surname { get; set; }
		public AddressViewModel Address { get; set; }
	}
}
