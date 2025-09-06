using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolie.Models;
using Portfolie.Persistence;

namespace Portfolie.Controllers;

public class HomeController : Controller
{

    private readonly ProfileRepository profileRepository = new ProfileRepository();

    public IActionResult Index(string language)
    {
        var profileLanguage = profileRepository.GetProfileByLanguage(language);
        if (profileLanguage == null)
        {
            profileLanguage = profileRepository.GetProfileByLanguage("DK");
            language = "DK";
        }

        ViewData["CurrentLanguage"] = language ?? "EN";

        return View(profileLanguage);
    }
}
