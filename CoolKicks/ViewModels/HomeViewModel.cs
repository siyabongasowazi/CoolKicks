using CoolKicks.Models;

namespace CoolKicks.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Sneaker> SneakersOfTheWeek { get; }

        public HomeViewModel(IEnumerable<Sneaker> sneakersOfTheWeek) 
        { 
            SneakersOfTheWeek = sneakersOfTheWeek;
        }
    }
}
