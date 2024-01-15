using Microsoft.AspNetCore.Identity;

namespace ToDoList.Models
{
	public class Users : IdentityUser
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
	}
}
