using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("/Home/AboutUs");
        }

        public string AboutUs()
        {
            return "this is AboutUs ";
        }
    }
}
