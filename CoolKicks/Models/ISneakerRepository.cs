namespace CoolKicks.Models
{
    public interface ISneakerRepository
    {
        IEnumerable<Sneaker> GetAllSneakers {  get; }

        IEnumerable<Sneaker> SneakersOnSale { get; }
        Sneaker? GetSneakerByID (int sneakerID);   
    }
}
