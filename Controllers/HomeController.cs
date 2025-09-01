using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolie.Models;
using Portfolie.Persistence;

namespace Portfolie.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ProfileRepository profileRepository = new ProfileRepository();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(string language)
    {
        // Default to EN if language is null or not found
        var profileLanguage = profileRepository.GetProfileByLanguage(language);
        if (profileLanguage == null)
        {
            profileLanguage = profileRepository.GetProfileByLanguage("EN");
        }
        return View(profileLanguage);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
