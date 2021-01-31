using Microsoft.AspNetCore.Mvc;

namespace Expending_Card.Controllers
{
    public class CatalogCardController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}