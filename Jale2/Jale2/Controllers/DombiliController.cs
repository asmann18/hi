using Jale2.DAL;
using Jale2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jale2.Controllers
{
    public class DombiliController : Controller
    {
        private readonly AppDbContext db;

        public DombiliController(AppDbContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            List<Jale>  jales=db.Jales.ToList();
            return View(jales);
        }
    }
}
