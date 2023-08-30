using Microsoft.AspNetCore.Mvc;

namespace Survey.Controllers;

public class SurveyController : Controller
{
    [HttpGet("/")]
    public ViewResult Index()
    {
        return View();
    }

    [HttpGet("results")]
    public ViewResult Result()
    {
        return View();
    }

    [HttpPost("process")]
    public IActionResult Process(string name, string location, string language, string comment)
    {
        ViewBag.Name = name;
        ViewBag.Location = location;
        ViewBag.Language = language;
        ViewBag.Comment = comment;
        Console.WriteLine(ViewBag.Name);
        return View("Result");
    }

}