using CoolKicks.Models;
using CoolKicks.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CoolKicks.Controllers
{
    public class SneakerController : Controller
    {
        private readonly ISneakerRepository _sneakerRepository;
        private readonly IBrandRepository _brandRepository; 

        public SneakerController(ISneakerRepository sneakerRepository, IBrandRepository brandRepository)
        {
            _sneakerRepository = sneakerRepository;
            _brandRepository = brandRepository;
        }
        
        public IActionResult List() 
        {
            SneakerListViewModel sneakerListViewModel = new SneakerListViewModel(_sneakerRepository.GetAllSneakers, "Trending Kicks");
            return View(sneakerListViewModel);  
        }

        public IActionResult Details(int id) 
        {
            var sneaker = _sneakerRepository.GetSneakerByID(id);
            if(sneaker == null) 
                return NotFound();
            return View(sneaker);
        }
    }
}
