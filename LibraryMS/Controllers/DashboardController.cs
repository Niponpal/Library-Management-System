
using Microsoft.AspNetCore.Mvc;

namespace LibraryMS.Controllers;

public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
