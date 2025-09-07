using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspireBlazorCrudApp.Model.Entities;

namespace AspireBlazorCrudApp.Database.Data
{
    /*
    this class is used to interact with the database using Entity Framework Core.
    it inherits from DbContext, which is the primary class for interacting with the database in EF Core.
    you can define DbSet properties here to represent tables in the database.
    for example, you might have a DbSet<ProductModel> Products { get; set; } to represent a products table.
    you would also typically configure the database connection string and other options in this class.
    this class is essential for performing CRUD operations on the database.
    */
    public class AppDbContext : DbContext
    {
        // Constructor that accepts DbContextOptions and passes them to the base DbContext class
        // this allows for configuration of the context, such as specifying the database provider and connection string.
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
            Database.EnsureCreated(); // Ensure the database is created
            
        }
        // Define DbSet properties for your entities here
        // public DbSet<ProductModel> Products { get; set; }
        public DbSet<ProductModel> Products { get; set; }

    }
}
