using HotChocolate.Subscriptions;
using WebApplication15.GraphQL;
using WebApplication15.Models;

namespace WebApplication15.Services
{
    public class ProductService
    {
        private readonly List<Product> _products = new List<Product>();
        private readonly ITopicEventSender _eventSender;

        public ProductService(ITopicEventSender eventSender)
        {
            _eventSender = eventSender;
        }

        public IQueryable<Product> GetAllProducts()
        {
            return _products.AsQueryable();
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            product.Id = _products.Count + 1;
            _products.Add(product);
            await _eventSender.SendAsync(nameof(Subscription.OnProductAdded), product);
            return product;
        }
    }
}
