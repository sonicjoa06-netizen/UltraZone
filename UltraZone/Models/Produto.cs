using Microsoft.AspNetCore.Mvc;

namespace UltraZone.Models
{
    public class Produto : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
