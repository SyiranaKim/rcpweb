using Microsoft.AspNetCore.Mvc;

namespace RPCMWEB.Controllers
{
    public class WidgetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
