using Microsoft.AspNetCore.Mvc;

namespace ClarieSalon.Controllers
{
    public class HomeController : Controller
{
    [HttpGet("/")]
    public ActionResult Index()
    {
        return View();
    }
}
}