using Microsoft.EntityFrameworkCore;

namespace CoolKicks.Models
{
    public class SneakerRepository: ISneakerRepository
    {
        private readonly CoolKicksDbContext _coolKicksDbContext;

        public SneakerRepository(CoolKicksDbContext coolKicksDbContext)
        {
            _coolKicksDbContext = coolKicksDbContext;
        }
        
        public IEnumerable<Sneaker> GetAllSneakers
        {
            get
            {
                return _coolKicksDbContext.Sneakers.Include(c=> c.Brand);
            }
        }

        public IEnumerable<Sneaker> SneakersOnSale
        {
            get
            {
                return _coolKicksDbContext.Sneakers.Include(c => c.Brand).Where(p => p.IsOnSale);
            }
        }

        public Sneaker? GetSneakerByID(int sneakerID)
        {
            return _coolKicksDbContext.Sneakers.FirstOrDefault(p => p.SneakerID== sneakerID);
        }
    }
}
