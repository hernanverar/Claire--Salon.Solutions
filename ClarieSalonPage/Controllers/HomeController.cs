using Microsoft.AspNetCore.Mvc;

namespace ClarieSalonPage.Controllers
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