using WebApplication15.Models;

namespace WebApplication15.GraphQL
{
    public class Subscription
    {
        [Subscribe]
        [Topic]
        public Product OnProductAdded([EventMessage] Product product) => product;
    }
}
