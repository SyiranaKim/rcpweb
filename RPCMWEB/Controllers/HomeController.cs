using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // Could pass data to your Index view
        return View();
    }

    // Add actions for your other views/models
    public IActionResult HappeningBoards()
    {
        // Return HappeningBoards view with data
        return View();
    }

    public IActionResult HSSEStatistics()
    {
        // Return HSSE statistics view
        return View();
    }
}