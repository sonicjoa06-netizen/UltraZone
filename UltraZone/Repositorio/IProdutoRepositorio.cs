using Microsoft.AspNetCore.Mvc;

namespace UltraZone.Properties.Repositorio
{
    public class IProdutoRepositorio : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
