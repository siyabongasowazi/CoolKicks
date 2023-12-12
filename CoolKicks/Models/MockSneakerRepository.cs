using System.IO.Pipelines;

namespace CoolKicks.Models
{
    public class MockSneakerRepository: ISneakerRepository
    {
        
            private readonly IBrandRepository _brandRepository = new MockBrandRepository();

            public IEnumerable<Sneaker> GetAllSneakers=>
                new List<Sneaker>
                {
                new Sneaker {SneakerID = 1, SneakerName="Jordan 1 Low", Price=2399.97M, SneakerShortDescription="Lorem Ipsum", SneakerLongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Brand = _brandRepository.GetAllBrands.ToList()[0],ImageThumbnailUrl="https://static.nike.com/a/images/t_default/u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/b20c67eb-6f93-4143-b36f-3627af6994d5/air-jordan-1-low-shoes-v2kdOZ.png", InStock=true, IsOnSale=false, ImageUrl="https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/cd83452d-3a6c-4742-9129-3693e06a26e2/air-jordan-1-low-shoes-v2kdOZ.png"},
                new Sneaker {SneakerID = 2, SneakerName="NiteBall", Price=2499.99M, SneakerShortDescription="Lorem Ipsum", SneakerLongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Brand = _brandRepository.GetAllBrands.ToList()[1],ImageUrl="https://assets.adidas.com/images/w_1880,f_auto,q_auto/b65b3e16fb5043dea4c3acc2015e1cc1_9366/H67360_01_standard.jpg", InStock=true, IsOnSale=false, ImageThumbnailUrl="https://assets.adidas.com/images/w_275,f_auto,q_auto/b65b3e16fb5043dea4c3acc2015e1cc1_9366/H67360_01_standard.jpg"},
                new Sneaker {SneakerID = 3, SneakerName="Airforce 1", Price=2199.97M, SneakerShortDescription="Lorem Ipsum", SneakerLongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Brand = _brandRepository.GetAllBrands.ToList()[0],ImageUrl="https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/b7d9211c-26e7-431a-ac24-b0540fb3c00f/air-force-1-07-shoes-rWtqPn.png", InStock=true, IsOnSale=true, ImageThumbnailUrl="https://static.nike.com/a/images/t_default/e6da41fa-1be4-4ce5-b89c-22be4f1f02d4/air-force-1-07-shoes-rWtqPn.png"},
                new Sneaker {SneakerID = 4, SneakerName="RSX 2021", Price=1999.98M, SneakerShortDescription="Lorem Ipsum", SneakerLongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Brand = _brandRepository.GetAllBrands.ToList()[2],ImageUrl="https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa/global/390025/01/fnd/ZAF/w/1000/h/1000/fmt/png", InStock=true, IsOnSale=true, ImageThumbnailUrl="https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_68,h_68/global/390025/01/sv01/fnd/ZAF/fmt/png"}
                };

            public IEnumerable<Sneaker> SneakersOnSale
        {
                get
                {
                    return GetAllSneakers.Where(p => p.IsOnSale);
                }
            }

            public Sneaker? GetSneakerByID(int sneakerID) => GetAllSneakers.FirstOrDefault(p => p.SneakerID == sneakerID);

            public IEnumerable<Sneaker> SearchSneakers(string searchQuery)
            {
                throw new NotImplementedException();
            }
    }
}
