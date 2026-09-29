using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.data1 = "WelcomeMamun";
            ViewBag.data2 = 25;
            ViewBag.data3 = DateTime.Now.ToShortDateString();

            ViewData["MyName"] = "Abdul Quader Mamun";
            ViewBag.data6 = "WelcomeMamun";

            string[] arr = { "Abdul", "Quader", "Mamun" };
            ViewBag.data4 = arr;

            ViewBag.data5 = new List<string>()
            {
                "Cricket","Football","Hockey"
            };

            //View Data
            //ViewData["data1"] = "WelcomwMamun";
            //ViewData["data2"] = 25;
            //ViewData["data3"] = DateTime.Now.ToLongDateString();

            //string[] arr = {"Abdul","Quader","Mamun"};
            //ViewData["data4"] = arr;

            //ViewData["data5"] = new List<string>() 
            //{
            //    "Cricket","Football","Hockey"
            //};

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public string Display()
        {
            return "Welcome to Mamun";
        }

        public int DisplayId(int id)
        {
            return id;
        }
    }
}
