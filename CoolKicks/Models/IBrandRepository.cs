namespace CoolKicks.Models
{
    public interface IBrandRepository
    {
        IEnumerable<Brand> GetAllBrands { get; }
    }
}
