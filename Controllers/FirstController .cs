using Microsoft.AspNetCore.Mvc;

namespace VANTAN_AUTO.Controllers
{
    public class FirstController : Controller
    {
            public IActionResult Index()
            {
                return View();
            }
        }
    }

