using Microsoft.AspNetCore.Mvc;
using SecurityStem.Web.Models;
using SecurityStem.Web.Services;
using System.Diagnostics;

namespace SecurityStem.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public ILoginViewModel _loginViewModel;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
           
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index(ILoginViewModel loginViewModel)
        {
            _loginViewModel = loginViewModel;

            if (ModelState.IsValid)
            {

                if (_loginViewModel.LogIn.ToUpper() == "TESTUSER")
                {

                    if (_loginViewModel.Password.ToUpper() == "PASSWORD1")
                    {
                        _loginViewModel.Challenge = 1;

                        return View("ChallengeTwo");
                    }


                }
            }

            return View();
        }

        public IActionResult ChallengeTwo()
        {


            return View();
        }

        public IActionResult ChallengeThree()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}