using Microsoft.AspNetCore.Mvc;

namespace EcoWave_GS.Controllers;

public class ContatoController
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}