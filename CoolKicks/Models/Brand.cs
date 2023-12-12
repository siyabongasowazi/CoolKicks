namespace CoolKicks.Models
{
    public class Brand
    {
        public int BrandID { get; set; }    
        public string? BrandName { get; set; } = string.Empty;
        public string? BrandDescription { get; set; }
        public List<Sneaker>? SneakerList { get; set;}

    }
}
