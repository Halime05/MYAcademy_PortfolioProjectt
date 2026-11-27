using Microsoft.AspNetCore.Mvc;

namespace MYAcademy_PortfolioProjectt.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index() => View();
    }
}