namespace CoolKicks.Models
{
    public class Sneaker
    {
        public int SneakerID { get; set; }  
        public string? SneakerName { get; set; } = string.Empty;
        public string? SneakerShortDescription { get; set; }
        public string? SneakerLongDescription { get; set; }
        public string? Colour {  get; set; } 
        public decimal Price { get; set; }  
        public string? ImageUrl { get; set; }    
        public string? ImageThumbnailUrl { get; set;}
        public bool IsOnSale { get; set; }  
        public bool InStock { get; set;}
        public int BrandID {  get; set; }
        public Brand Brand { get; set; } = default!;   
    }
}
