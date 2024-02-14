using Jale3.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace Jale3.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;

        public HomeController(AppDbContext db)
        {
            this.db=db;
        }
        public IActionResult Index()
        {
            

            return View();
        }
    }
}
