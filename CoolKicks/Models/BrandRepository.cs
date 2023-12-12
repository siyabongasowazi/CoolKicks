namespace CoolKicks.Models
{
    public class BrandRepository: IBrandRepository
    {
        private readonly CoolKicksDbContext _coolKicksDbContext;

        public BrandRepository(CoolKicksDbContext coolKicksDbContext)
        {
            _coolKicksDbContext = coolKicksDbContext;
        }

        public IEnumerable<Brand> GetAllBrands => _coolKicksDbContext.Brands.OrderBy(p => p.BrandName);
    }
}
