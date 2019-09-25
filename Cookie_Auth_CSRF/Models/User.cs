using System.Collections.Generic;

namespace Cookie_Auth_CSRF.Models
{
	public class Role
	{
		public Role()
		{
			Users = new List<User>();
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public List<User> Users { get; set; }
	}

	public class User
	{
		public int Age { get; set; }

		public string Email { get; set; }

		public int Id { get; set; }

		public string Password { get; set; }

		public Role Role { get; set; }

		public int? RoleId { get; set; }
	}
}
