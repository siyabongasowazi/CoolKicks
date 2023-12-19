using CoolKicks.Models;
using CoolKicks.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CoolKicks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISneakerRepository _sneakerRepository;

        public HomeController(ISneakerRepository sneakerRepository)
        {
            _sneakerRepository= sneakerRepository;
        }
        public IActionResult Index()
        {
            var sneakersOfTheWeek = _sneakerRepository.SneakersOnSale;
            var homeViewModel = new HomeViewModel(sneakersOfTheWeek);
            return View(homeViewModel);
        }
    }
}
