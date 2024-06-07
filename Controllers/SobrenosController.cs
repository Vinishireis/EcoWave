using Microsoft.AspNetCore.Mvc;

namespace EcoWave_GS.Controllers;

public class SobrenosController
{
    public class SobrenosController : Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}