using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using Serilog;

namespace mvc.Controllers;

public class HomeController : Controller
{
    private readonly Serilog.Core.Logger _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = new LoggerConfiguration()
            .WriteTo.File("./log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();
    }

    public IActionResult Index()
    {
        return View();
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
