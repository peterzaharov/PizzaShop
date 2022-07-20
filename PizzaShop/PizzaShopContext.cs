using Microsoft.EntityFrameworkCore;
using PizzaShop.Model;

namespace PizzaShop
{
    public class PizzaShopContext : DbContext
    {
        public PizzaShopContext(DbContextOptions options) : base(options) { }
        public DbSet<PizzaSpecial>? Specials { get; set; }
    }
}
