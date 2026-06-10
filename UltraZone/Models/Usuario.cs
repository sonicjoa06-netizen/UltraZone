using Microsoft.AspNetCore.Mvc;

namespace UltraZone.Models
{
    public class Usuario : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
