using Microsoft.AspNetCore.Mvc;

namespace UltraZone.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
