using API.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "bob",
                    Email = "bob@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] { "Admin", "Member" });
            }

            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Boy Block Pattern Knitwear Sweater",
                    Description =
                        "Step up your daily style with our casual and home wear Clothes ! Featuring great and comfy designs that fit all your occasions",
                    Price = 20000,
                    PictureUrl = "https://res.cloudinary.com/delibahag/image/upload/v1639685254/Sutra/SweetShirts/G42A5079_360x_w9wxly.jpg",
                    Brand = "Sutra",
                    Type = "SweetShirts",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ho Holland Zip-Up Hoodie - Green",
                    Description = "Step up your daily style with our casual and home wear Clothes ! Featuring great and comfy designs that fit all your occasions",
                    Price = 15000,
                    PictureUrl = "https://res.cloudinary.com/delibahag/image/upload/v1639685254/Sutra/SweetShirts/G42A5074_360x_vixhrf.jpg",
                    Brand = "Sutra",
                    Type = "SweetShirts",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Casual Zipped Hooded Sweatshirt - Black",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "https://res.cloudinary.com/delibahag/image/upload/v1639685252/Sutra/SweetShirts/1_1_360x_jiy5cb.jpg",
                    Brand = "Sutra",
                    Type = "SweetShirts",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Etnies Men's Jameson 2 Eco Skate Shoe",
                    Description =
                        "The Etnies Jameson 2 Eco is a Vegan shoe that has a Foam Lite 1 insole, a midsole of egg crate construction. It is a Faux Vulc cup sole with thinly padded tongue and collar. The outsole is made from 20% recycled rubber.",
                    Price = 30000,
                    PictureUrl = "https://res.cloudinary.com/delibahag/image/upload/v1639685216/LaCoste/Shoes/42CMA0016_237_01_fkqpxu.webp",
                    Brand = "LaCosta",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Clarks Men's Tilden Walk Derby",
                    Description =
                        "Clarks is making comfortable shoes for almost 200 years. Actually not just making them, crafting and developing them.",
                    Price = 25000,
                    PictureUrl = "https://res.cloudinary.com/delibahag/image/upload/v1639685216/LaCoste/Shoes/41CMA0048_02H_01_f2lbbq.webp",
                    Brand = "LaCosta",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Typescript Entry Board",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    PictureUrl = "/images/products/sb-ts1.png",
                    Brand = "LaCosta",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Napapijri Men's Silo Ss T-Shirt",
                    Description =
                        "Unisex protective shoes series are suitable for indoor and outdoor, and suitable for people working in warehouses, shops, kitchens, buildings, factories and houses, gardens and garages/sheds. You can wear them wherever you need to protect your feet.",
                    Price = 1000,
                    PictureUrl = "https://res.cloudinary.com/delibahag/image/upload/v1639685245/Puma/T%20Shirts/puma-Black-Classics-Logo-Cotton-T-shirt_tx99uz.jpg",
                    Brand = "Puma",
                    Type = "T-Shirts",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Urban Classics Men's",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    PictureUrl = "https://res.cloudinary.com/delibahag/image/upload/v1639685247/Puma/T%20Shirts/puma-Black-Wool-Midlayer-Running-Hooded-Sweatshirt_zjcxfr.jpg",
                    Brand = "Puma",
                    Type = "T-Shirts",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Cotton Men Tshirt Pack",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "https://res.cloudinary.com/delibahag/image/upload/v1639685246/Puma/T%20Shirts/puma-Black-Maison-Kitsune-Cotton-Jersey-T-shirt_vs9wus.jpg",
                    Brand = "Puma",
                    Type = "T-Shirts",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Plush Cap",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1800,
                    PictureUrl = "https://res.cloudinary.com/delibahag/image/upload/v1639685215/LaCoste/Caps/RK4711_QMN_24_qirm4p.webp",
                    Brand = "Cucci",
                    Type = "Caps",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Printed Cap",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "https://res.cloudinary.com/delibahag/image/upload/v1639685215/LaCoste/Caps/RK4711_316_24_ve3lwa.webp",
                    Brand = "Cucci",
                    Type = "Caps",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Plain Cap",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1600,
                    PictureUrl = "https://res.cloudinary.com/delibahag/image/upload/v1639685215/LaCoste/Caps/RK4709_QPT_24_bhdwwd.webp",
                    Brand = "Cucci",
                    Type = "Caps",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Garment Shirt",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1400,
                    PictureUrl = "https://res.cloudinary.com/delibahag/image/upload/v1639685219/LaCoste/T%20Shirt/TH6709_166_24_sdq7re.webp",
                    Brand = "Town Team",
                    Type = "T-Shirts",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Serena Shirt",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    PictureUrl = "https://res.cloudinary.com/delibahag/image/upload/v1639685219/LaCoste/T%20Shirt/YH9852_W86_24_euldps.webp",
                    Brand = "Town Team",
                    Type = "T-Shirts",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ravin Basic T-Shirt",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18999,
                    PictureUrl = "https://res.cloudinary.com/delibahag/image/upload/v1639685219/LaCoste/T%20Shirt/TH9654_CCA_24_nrnu9y.webp",
                    Brand = "Town Team",
                    Type = "T-Shirts",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "ReeBok Shoes",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 19999,
                    PictureUrl = "https://res.cloudinary.com/delibahag/image/upload/v1639685220/Town%20Team/Shoes/5_e61745aa-9942-4082-80c6-216b80a7dcae_280x_a9p7o3.jpg",
                    Brand = "Prada",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Strips Light Shoes",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 15000,
                    PictureUrl = "https://res.cloudinary.com/delibahag/image/upload/v1639685217/Town%20Team/Shoes/1_d764070d-ca91-4a52-8a20-d86f0e11b7bc_280x_lxhb7s.jpg",
                    Brand = "Prada",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Converse Chuck Shoes",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "https://res.cloudinary.com/delibahag/image/upload/v1639685214/Town%20Team/Shoes/1..._280x_fhwmdb.jpg",
                    Brand = "Prada",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
            };

            foreach (var product in products)
                context.Products.Add(product);

            await context.SaveChangesAsync();
        }
    }
}
