﻿using System.ComponentModel.DataAnnotations;

namespace Shopping_Tutorial.Models
{
	public class BrandModel
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "Yeu cau nhap ten thuong hieu")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Yeu cau nhap mo ta thuong hieu")]
		public string Description { get; set; }
		public string Slug { get; set; }
		public int Status { get; set; }
	}
}
