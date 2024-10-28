using System.ComponentModel.DataAnnotations;

namespace Shopping_Tutorial.Models
{
	public class CategoryModel
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage ="Yeu cau nhap ten danh muc")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Yeu cau nhap mo ta danh muc")]
		public string Description { get; set; }
		public string Slug { get; set; }
		public int Status { get; set; }
	}
}
