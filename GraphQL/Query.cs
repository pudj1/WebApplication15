using WebApplication15.Models;
using WebApplication15.Services;

namespace WebApplication15.GraphQL
{
    public class Query
    {
        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Product> GetProducts([Service] ProductService productService)
        {
            return productService.GetAllProducts();
        }
    }
}
