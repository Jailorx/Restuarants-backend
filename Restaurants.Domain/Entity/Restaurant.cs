
using System.Net.Sockets;

namespace Restaurants.Domain.Entity
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Category { get; set; } = default!;
        public bool HasDelivery {  get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public Address Address { get; set; } = new();

        public List<Dish> Dishes { get; set; } = new();
    }
}
