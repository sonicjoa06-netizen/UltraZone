using Microsoft.AspNetCore.Mvc;

namespace UltraZone.Properties.Repositorio
{
    public class IUsuarioRepositorio : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
