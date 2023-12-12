using CoolKicks.Models;

namespace CoolKicks.ViewModels
{
    public class SneakerListViewModel
    {
        public IEnumerable<Sneaker> Sneakers { get; }
        public string? CurrentBrand { get; }

        public SneakerListViewModel (IEnumerable<Sneaker> sneakers, string? currentBrand)
        {
            Sneakers = sneakers;
            CurrentBrand = currentBrand;
        }
    }
}
