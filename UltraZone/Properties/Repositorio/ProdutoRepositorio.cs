using Microsoft.AspNetCore.Mvc;

namespace UltraZone.Properties.Repositorio
{
    public class ProdutoRepositorio : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
