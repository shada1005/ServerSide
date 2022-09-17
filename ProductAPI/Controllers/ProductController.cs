using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        static List<Product> products = new List<Product> {
                new Product {
                    Id=1,
                    Name= "banana",
                    Inventory= 355
                },
                new Product {
                    Id=2,
                    Name= "apples",
                    Inventory= 432
                },
                new Product {

                    Id=3,
                    Name= "broccoli",
                    Inventory= 24
                },
                new Product {
                    Id=4,
                    Name= "Cabbage",
                    Inventory= 34
                }, 
                new Product {
                    Id=5,
                    Name= "bread",
                    Inventory= 100
                },
                new Product {
                    Id=6,
                    Name= "chocolate",
                    Inventory= 99
                },
                new Product {
                    Id=7,
                    Name= "donuts",
                    Inventory= 88
                },
                new Product {
                    Id=8,
                    Name= "coffee",
                    Inventory= 77
                },
                new Product {
                    Id=9,
                    Name= "Garlic",
                    Inventory= 66
                },
                new Product {
                    Id=10,
                    Name= "grapes",
                    Inventory= 44
                },
                new Product {
                    Id=11,
                    Name= "jalapeño",
                    Inventory= 2
                },
                new Product {
                    Id=12,
                    Name= "kiwi",
                    Inventory= 19
                },
                new Product {
                    Id=13,
                    Name= "Milk",
                    Inventory= 432
                },
                new Product {
                    Id=14,
                    Name= "Yogurt",
                    Inventory= 22
                },
                new Product {
                    Id=15,
                    Name= "Zucchini",
                    Inventory= 12
                },


        };
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return products;
        }


        [HttpPost]
        public async Task<ActionResult<List<Product>>> updateProducts([FromBody] Product product)
        {
            Product productTemp = products.Find(l => l.Id == product.Id);
            productTemp.Inventory = product.Inventory;
            productTemp.Name = product.Name;

            return products;

        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult<List<Product>>> delete(int id)
        {
            if (products.Find(l => l.Id == id) != null)
            {
                Product p = products.Find(l => l.Id == id);
                products.Remove(p);
            }
            return products;
        }




    }
}
