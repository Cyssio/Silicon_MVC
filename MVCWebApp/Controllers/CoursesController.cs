using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCWebApp.ViewModels;
using Newtonsoft.Json;

namespace MVCWebApp.Controllers;

[Authorize]
public class CoursesController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
