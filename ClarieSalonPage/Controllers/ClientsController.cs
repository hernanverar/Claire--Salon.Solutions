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
            List<Client> model = _db.Clients
                                .Include(Client => Client.Stylist)
                                .ToList();
            return View(model);
        }
  }
}