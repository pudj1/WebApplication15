using WebApplication15.Models;
using WebApplication15.Services;

namespace WebApplication15.GraphQL
{
    public class Mutation
    {
        public async Task<Product> CreateProductAsync(Product input, [Service] ProductService productService)
        {
            return await productService.CreateProductAsync(input);
        }
    }
}
