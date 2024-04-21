using System.ComponentModel.DataAnnotations;

namespace MVCWebApp.ViewModels;

public class SignInViewModel
{
	[Required(ErrorMessage = "Enter a valid E-mail")]
	[Display(Name = "E-mail address", Prompt = "Enter your e-mail address")]
	[DataType(DataType.EmailAddress)]
	public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Enter a valid password")]
    [Display(Name = "Password", Prompt = "Enter your password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Display(Name = "Remember me", Prompt = "Remember me")]
    public bool IsPresistent { get; set; }
}
