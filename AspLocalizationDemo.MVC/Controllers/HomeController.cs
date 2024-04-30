using AspLocalizationDemo.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Diagnostics;

namespace AspLocalizationDemo.MVC.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IStringLocalizer _stringLocalizer;

    public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> stringLocalizer)
    {
        _logger = logger;
        _stringLocalizer = stringLocalizer;
    }

    public IActionResult Index()
    {
        HomeIndexViewModel viewModel = new()
        {
            Message = _stringLocalizer["Message"]
        };

        return View(viewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
