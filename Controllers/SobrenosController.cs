using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using EcoWave_GS.Models;

namespace EcoWave_GS.Controllers;

public class SobrenosController
{
    public class AboutUsController : Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}