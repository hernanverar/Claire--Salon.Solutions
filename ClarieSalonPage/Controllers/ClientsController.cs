using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ClarieSalonPage.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ClarieSalonPage.Controllers
{
    public class ClientsController : Controller
  {
    private readonly ClarieSalonPageContext _db;

        public ClientsController(ClarieSalonPageContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Clients> model = _db.ClarieSalon.ToList();
            return View(model);
        }
  }
}