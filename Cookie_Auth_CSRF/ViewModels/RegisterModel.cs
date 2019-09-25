using System.ComponentModel.DataAnnotations;

namespace Cookie_Auth_CSRF.ViewModels
{
	public class RegisterModel
	{
		[Required(ErrorMessage = "Age reuired.")]
		public int Age { get; set; }

		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Both passwords must be the same.")]
		public string ConfirmPassword { get; set; }

		[Required(ErrorMessage = "Email required.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password required.")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}