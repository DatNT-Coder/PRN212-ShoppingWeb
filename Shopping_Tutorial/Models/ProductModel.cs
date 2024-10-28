using Shopping_Tutorial.Repository.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_Tutorial.Models
{
	public class ProductModel
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Yeu cau nhap ten san pham")]
		public string Name { get; set; }

		public string Slug {  get; set; }

		[Required(ErrorMessage = "Yeu cau nhap mo ta san pham")]
		public string Description { get; set; }

		[Required(ErrorMessage = "Yeu cau nhap gia san pham")]
		[Range(0.01, double.MaxValue)]
		[Column(TypeName ="decimal(8, 2)")]
		public decimal Price { get; set; }
        [Required, Range(1, int.MaxValue,ErrorMessage = "Chon 1 thuong hieu")]
        public int BrandId { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "Chon 1 danh muc")]
        public int CategoryId { get; set; }

		public CategoryModel Category { get; set; }
		public BrandModel Brand { get; set; }

		public string Image { get; set; }
		[NotMapped]
		[FileExtension]
		public IFormFile? ImageUpLoad { get; set; }
	}
}
