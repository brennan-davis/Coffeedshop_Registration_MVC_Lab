using CoffeeshopRegistrationMVCLab.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeshopRegistrationMVCLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CoffeeshopUsersContext context = new CoffeeshopUsersContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult RegisterUser()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddUserToDb(CoffeeshopUser user)
        {
            context.CoffeeshopUsers.Add(user);
            context.SaveChanges();

            return RedirectToAction("GetUserInfo");
        }

        public IActionResult GetUserInfo()
        {
            int indexOfUser = context.CoffeeshopUsers.ToList().Count - 1;
            CoffeeshopUser user = context.CoffeeshopUsers.ToList()[indexOfUser];
            return View("WelcomeUser", user);
        }
    }
}