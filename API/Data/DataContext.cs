
using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Data;


public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new List<Product>
            {
                new Product{ Id=1, Name="Iphone 15" , Description="Telefon açıklaması" , ImageUrl="1.jpg" , Price=7000, IsActive=true, Stock=100},

                new Product{ Id=2, Name="Iphone 16" , Description="Telefon açıklaması" , ImageUrl="2.jpg" , Price=8000, IsActive=true, Stock=100},

                new Product{ Id=3, Name="Iphone 16 Pro" , Description="Telefon açıklaması" , ImageUrl="3.jpg" , Price=9000, IsActive=false, Stock=100},

                new Product{ Id=4, Name="Iphone 16 Pro Max" , Description="Telefon açıklaması" , ImageUrl="4.jpg" , Price=10000, IsActive=true, Stock=100}

                
            }


        );
    }
}

