using System.ComponentModel.DataAnnotations;

namespace Shopping_Tutorial.Models.ViewModels
{
	public class LoginViewModel
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Lam on nhap username")]
		public string Username { get; set; }

		[DataType(DataType.Password), Required(ErrorMessage = "Lam on nhap mat khau")]
		public string Password { get; set; }
		public string ReturnUrl { get; set; }
	}
}
