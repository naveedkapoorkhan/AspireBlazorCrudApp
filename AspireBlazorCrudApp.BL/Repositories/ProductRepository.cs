using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspireBlazorCrudApp.Database.Data;
using AspireBlazorCrudApp.Model.Entities;
using Microsoft.EntityFrameworkCore;


namespace AspireBlazorCrudApp.BL.Repositories
{
    //that is the flow we get data from database controller->service->repository->dbcontext
    public interface IProductRepository
    {
        Task<List<ProductModel>> GetProducts();
    }
    public class ProductRepository(AppDbContext DbContext) : IProductRepository
    {
        public Task<List<ProductModel>> GetProducts() 
        {
            //Using the injected DbContext to query the database
            return DbContext.Products.ToListAsync();
        }
    }
}
