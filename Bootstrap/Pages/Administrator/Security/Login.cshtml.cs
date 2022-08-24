namespace Bootstrap.Pages.Administrator.Security
{
	public class LoginModel : Infrastructure.BasePageModel
	{
		public LoginModel() : base()
		{
			ViewModel = new();
		}
		[Microsoft.AspNetCore.Mvc.BindProperty]
		public ViewModels.Security.LoginViewModel ViewModel { get; set; }
		public void OnGet()
		{
		}
		public void OnPost()
		{
			if (ModelState.IsValid == false)
			{
				return;
			}
		}
	}
}
