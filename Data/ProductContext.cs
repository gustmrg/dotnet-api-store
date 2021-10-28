using Microsoft.EntityFrameworkCore;
using StoreWebApi.Models;

namespace StoreWebApi.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) 
            : base(options)
        {

        }

        public  DbSet<Product> Products { get; set; }
    }
}
