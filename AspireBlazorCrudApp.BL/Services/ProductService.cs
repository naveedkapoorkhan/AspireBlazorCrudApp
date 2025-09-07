using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspireBlazorCrudApp.Model.Entities;
using AspireBlazorCrudApp.BL.Repositories;

namespace AspireBlazorCrudApp.BL.Services
{
    // This interface defines the contract for product-related operations.
    
    public interface IProductService

    {
        // Define method signatures for product operations here
        // For example:
        // 1. Get a list of products
        // 2. Get a product by ID
        // 3. Add a new product
        // 4. Update an existing product
        // 5. Delete a product
        // Each method should return a Task to support asynchronous operations.
        
        Task<List<ProductModel>> GetProducts();
    }
    // This class implements the IProductService interface and provides concrete implementations for product-related operations.
    // It interacts with the data layer (e.g., repositories) to perform CRUD operations on products.
    // The service layer helps to separate business logic from the presentation layer (e.g., controllers) and data access layer (e.g., repositories).
    
    public class ProductService(IProductRepository productRepository) : IProductService
    {
        public Task<List<ProductModel>> GetProducts()
        {
            // This is a placeholder implementation.
            // In a real application, this method would interact with the database to retrieve product data.
            // Here, we simply return a list of sample products for demonstration purposes.
            //inject the repository in the constructor to use it in the service
            //we will create the repository later
            //return a list of products from the repository
            
            return productRepository.GetProducts();
        }

    }
}
