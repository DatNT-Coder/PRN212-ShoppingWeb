using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shopping_Tutorial.Models;

namespace Shopping_Tutorial.Controllers
{
	public class AccountController : Controller
	{
		private UserManager<AppUserModel> _userManager;
		private SignInManager<AppUserModel> _signInManager;
		public AccountController(SignInManager<AppUserModel> signInManager, UserManager<AppUserModel> userManager)
		{
			_signInManager = signInManager;
			_userManager = userManager;
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Create()
		{
			return View();
		}
		public async Task<IActionResult> Login()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(UserModel user)
		{
			if (ModelState.IsValid)
			{
				AppUserModel newUser = new AppUserModel { UserName = user.Username, Email = user.Email};
				IdentityResult result = await _userManager.CreateAsync(newUser);
				if(result.Succeeded)
				{
					TempData["success"] = "Dang ky thanh cong";
					return Redirect("/account");
				}
				foreach (IdentityError error in result.Errors)
				{
					ModelState.AddModelError("", error.Description);
				}
			}
			return View();

		}

	}
}
