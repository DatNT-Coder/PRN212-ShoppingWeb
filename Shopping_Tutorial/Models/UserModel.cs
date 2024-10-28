using System.ComponentModel.DataAnnotations;

namespace Shopping_Tutorial.Models
{
	public class UserModel
	{
		public int Id { get; set; }
		[Required(ErrorMessage ="Lam on nhap username")]
		public string Username { get; set; }
		[Required(ErrorMessage = "Lam on nhap email"), EmailAddress]
		public string Email { get; set; }
		[DataType(DataType.Password),Required(ErrorMessage ="Lam on nhap mat khau")]
		public string Password { get; set; }
	}
}
