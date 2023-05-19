using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ClarieSalonPage.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ClarieSalonPage.Controllers
{
  public class StylistController : Controller
  {
   private readonly ClarieSalonPageContext _db;

    public StylistsController(ClarieSalonPageContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }  
  }
}  