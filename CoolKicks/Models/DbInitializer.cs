using static System.Net.WebRequestMethods;

namespace CoolKicks.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            CoolKicksDbContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<CoolKicksDbContext>();

            if (!context.Brands.Any())
            {
                context.Brands.AddRange(Brands.Select(c => c.Value));
            }

            if (!context.Sneakers.Any())
            {
                context.AddRange
                (
                   new Sneaker
                   {
                       SneakerName = "Air Max 90",
                       SneakerShortDescription = "Iconic Nike sneaker",
                       SneakerLongDescription = "The Air Max 90 is a classic Nike sneaker known for its comfort and style.",
                       Colour = "Black/White",
                       Price = 1500M,
                       IsOnSale = false,
                       InStock = true,
                       Brand = Brands["Nike"],
                       ImageUrl = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/cd83452d-3a6c-4742-9129-3693e06a26e2/air-jordan-1-low-shoes-v2kdOZ.png",
                       ImageThumbnailUrl = "https://assets.adidas.com/images/w_275,f_auto,q_auto/b65b3e16fb5043dea4c3acc2015e1cc1_9366/H67360_01_standard.jpg"
                },
                new Sneaker
                {
                    SneakerName = "Superstar",
                    SneakerShortDescription = "Iconic Adidas sneaker",
                    SneakerLongDescription = "The Superstar is a classic Adidas sneaker known for its shell toe design.",
                    Colour = "White/Black",
                    Price = 1199.99M, // Random price in ZAR
                    IsOnSale = true,
                    InStock = true,
                    Brand = Brands["Adidas"],
                    ImageUrl = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/cd83452d-3a6c-4742-9129-3693e06a26e2/air-jordan-1-low-shoes-v2kdOZ.png",
                    ImageThumbnailUrl = "https://assets.adidas.com/images/w_275,f_auto,q_auto/b65b3e16fb5043dea4c3acc2015e1cc1_9366/H67360_01_standard.jpg"    },
                new Sneaker
                {
                    SneakerName = "Clyde",
                    SneakerShortDescription = "Classic Puma sneaker",
                    SneakerLongDescription = "The Clyde is a Puma classic, known for its basketball heritage and style.",
                    Colour = "Red/White",
                    Price = 1299.99M, // Random price in ZAR
                    IsOnSale = false,
                    InStock = true,
                    Brand = Brands["Puma"],
                    ImageUrl = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/cd83452d-3a6c-4742-9129-3693e06a26e2/air-jordan-1-low-shoes-v2kdOZ.png",
                    ImageThumbnailUrl = "https://assets.adidas.com/images/w_275,f_auto,q_auto/b65b3e16fb5043dea4c3acc2015e1cc1_9366/H67360_01_standard.jpg"
                },
                    new Sneaker
                    {
                        SneakerName = "Classic Leather",
                        SneakerShortDescription = "Timeless Reebok sneaker",
                        SneakerLongDescription = "The Classic Leather is a Reebok sneaker known for its timeless design.",
                        Colour = "Blue/Gum",
                        Price = 1099.99M, // Random price in ZAR
                        IsOnSale = true,
                        InStock = true,
                        Brand = Brands["Reebok"],
                        ImageUrl = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/cd83452d-3a6c-4742-9129-3693e06a26e2/air-jordan-1-low-shoes-v2kdOZ.png",
                    ImageThumbnailUrl = "https://assets.adidas.com/images/w_275,f_auto,q_auto/b65b3e16fb5043dea4c3acc2015e1cc1_9366/H67360_01_standard.jpg"
                },
                    new Sneaker
                    {
                        SneakerName = "574",
                        SneakerShortDescription = "Comfortable New Balance sneaker",
                        SneakerLongDescription = "The 574 is a New Balance sneaker known for its comfort and versatility.",
                        Colour = "Grey/Navy",
                        Price = 1200M, // Random price in ZAR
                        IsOnSale = false,
                        InStock = false, // Example with out of stock
                        Brand = Brands["New Balance"],
                        ImageUrl = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/cd83452d-3a6c-4742-9129-3693e06a26e2/air-jordan-1-low-shoes-v2kdOZ.png",
                    ImageThumbnailUrl = "https://assets.adidas.com/images/w_275,f_auto,q_auto/b65b3e16fb5043dea4c3acc2015e1cc1_9366/H67360_01_standard.jpg"
                },
                    new Sneaker
                    {
                        SneakerName = "Zoom Pegasus 38",
                        SneakerShortDescription = "Versatile Nike running shoe",
                        SneakerLongDescription = "The Zoom Pegasus 38 is a popular Nike running shoe known for its versatility.",
                        Colour = "Blue/Pink",
                        Price = 1599.99M, // Random price in ZAR
                        IsOnSale = true,
                        InStock = true,
                        Brand = Brands["Nike"],
                        ImageUrl = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/cd83452d-3a6c-4742-9129-3693e06a26e2/air-jordan-1-low-shoes-v2kdOZ.png",
                    ImageThumbnailUrl = "https://assets.adidas.com/images/w_275,f_auto,q_auto/b65b3e16fb5043dea4c3acc2015e1cc1_9366/H67360_01_standard.jpg"
                },
                    new Sneaker
                    {
                        SneakerName = "Ultraboost",
                        SneakerShortDescription = "Adidas running innovation",
                        SneakerLongDescription = "The Ultraboost is a revolutionary Adidas running shoe with responsive cushioning.",
                        Colour = "Black/Grey",
                        Price = 1399.98M, // Random price in ZAR
                        IsOnSale = false,
                        InStock = true,
                        Brand = Brands["Adidas"],
                        ImageUrl = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/cd83452d-3a6c-4742-9129-3693e06a26e2/air-jordan-1-low-shoes-v2kdOZ.png",
                    ImageThumbnailUrl = "https://assets.adidas.com/images/w_275,f_auto,q_auto/b65b3e16fb5043dea4c3acc2015e1cc1_9366/H67360_01_standard.jpg"
                },
                    new Sneaker
                    {
                        SneakerName = "Puma Future Rider",
                        SneakerShortDescription = "Futuristic style from Puma",
                        SneakerLongDescription = "The Future Rider from Puma offers a modern and futuristic style for the fashion-forward.",
                        Colour = "White/Orange",
                        Price = 1300M, // Random price in ZAR
                        IsOnSale = true,
                        InStock = true,
                        Brand = Brands["Puma"],
                        ImageUrl = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/cd83452d-3a6c-4742-9129-3693e06a26e2/air-jordan-1-low-shoes-v2kdOZ.png",
                    ImageThumbnailUrl = "https://assets.adidas.com/images/w_275,f_auto,q_auto/b65b3e16fb5043dea4c3acc2015e1cc1_9366/H67360_01_standard.jpg"
                },
                    new Sneaker
                    {
                        SneakerName = "Reebok Nano X",
                        SneakerShortDescription = "Cross-training excellence",
                        SneakerLongDescription = "The Reebok Nano X is designed for cross-training enthusiasts seeking top-notch performance.",
                        Colour = "Black/Red",
                        Price = 1999.90M, // Random price in ZAR
                        IsOnSale = false,
                        InStock = true,
                        Brand = Brands["Reebok"],
                        ImageUrl = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/cd83452d-3a6c-4742-9129-3693e06a26e2/air-jordan-1-low-shoes-v2kdOZ.png",
                    ImageThumbnailUrl = "https://assets.adidas.com/images/w_275,f_auto,q_auto/b65b3e16fb5043dea4c3acc2015e1cc1_9366/H67360_01_standard.jpg"
                },
                    new Sneaker
                    {
                        SneakerName = "New Balance 990v5",
                        SneakerShortDescription = "Classic comfort redefined",
                        SneakerLongDescription = "The New Balance 990v5 redefines classic comfort with modern design and advanced technology.",
                        Colour = "Grey/Castlerock",
                        Price = 1599.99M, // Random price in ZAR
                        IsOnSale = false,
                        InStock = true,
                        Brand = Brands["New Balance"],
                        ImageUrl = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/cd83452d-3a6c-4742-9129-3693e06a26e2/air-jordan-1-low-shoes-v2kdOZ.png",
                    ImageThumbnailUrl = "https://assets.adidas.com/images/w_275,f_auto,q_auto/b65b3e16fb5043dea4c3acc2015e1cc1_9366/H67360_01_standard.jpg"
                },
                    new Sneaker
                    {
                        SneakerName = "Nike Blazer Mid '77",
                        SneakerShortDescription = "Vintage vibes with Nike",
                        SneakerLongDescription = "The Nike Blazer Mid '77 offers vintage vibes and timeless style with modern comfort.",
                        Colour = "Sail/Black",
                        Price = 1399.97M, // Random price in ZAR
                        IsOnSale = true,
                        InStock = true,
                        Brand = Brands["Nike"],
                        ImageUrl = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/cd83452d-3a6c-4742-9129-3693e06a26e2/air-jordan-1-low-shoes-v2kdOZ.png",
                    ImageThumbnailUrl = "https://assets.adidas.com/images/w_275,f_auto,q_auto/b65b3e16fb5043dea4c3acc2015e1cc1_9366/H67360_01_standard.jpg"
                },
                    new Sneaker
                    {
                        SneakerName = "Adidas Stan Smith",
                        SneakerShortDescription = "Timeless Adidas classic",
                        SneakerLongDescription = "The Adidas Stan Smith is a timeless classic that never goes out of style, offering a clean and minimalist look.",
                        Colour = "White/Green",
                        Price = 1199.98M, // Random price in ZAR
                        IsOnSale = false,
                        InStock = true,
                        Brand = Brands["Adidas"],
                        ImageUrl = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/cd83452d-3a6c-4742-9129-3693e06a26e2/air-jordan-1-low-shoes-v2kdOZ.png",
                    ImageThumbnailUrl = "https://assets.adidas.com/images/w_275,f_auto,q_auto/b65b3e16fb5043dea4c3acc2015e1cc1_9366/H67360_01_standard.jpg"
                    }

                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Brand>? brands;

        public static Dictionary<string, Brand> Brands
        {
            get
            {
                if (brands == null)
                {
                    var genresList = new Brand[]
                    {
                        new Brand { BrandName = "Nike" },
                        new Brand { BrandName = "Adidas" },
                        new Brand { BrandName = "Puma" },
                        new Brand { BrandName = "Reebok" },
                        new Brand { BrandName = "New Balance" }
                    };

                    brands = new Dictionary<string, Brand>();

                    foreach (Brand genre in genresList)
                    {
                        brands.Add(genre.BrandName, genre);
                    }
                }

                return brands;
            }
        }
    }
}
