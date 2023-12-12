namespace CoolKicks.Models
{
    public class MockBrandRepository : IBrandRepository
    {
        public IEnumerable<Brand> GetAllBrands =>
            new List<Brand>
            {
                new Brand{BrandID = 1, BrandName="Nike", BrandDescription = "Just Do It"},
                new Brand{BrandID = 2, BrandName="Adidas", BrandDescription = "Yeezy forever"},
                new Brand{BrandID = 3, BrandName="Puma", BrandDescription = "We are just cats"},
            };

    }
}
