using Microsoft.AspNetCore.Mvc;

namespace TP01.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome()
        {
            return "welcome to my first ASP.Net core MVC Application";
        }
     /*   public string WelcomeX(string name)
        {
             if (name == null)
            {
                return "Welcome to my first Core MVC Application ";


            } else
            {
                return name + ",Welcome to my first Core MVC Application";
            }
        } */
     public IActionResult Welcomex(string name)
        {
            if (name == null)
            {
                ViewBag.message = "welcome to my first APP";
            } else
            {
                ViewBag.message = name + ",Welcome to my firstApp";
            }
            return View(); 
        }
        public IActionResult Max(int value1 , int value2)
        {
            ViewBag.max= Math.Max(value1, value2);
            ViewBag.v1 = value1;
            ViewBag.v2 = value2;
            return View();
        }
       
    }
}
