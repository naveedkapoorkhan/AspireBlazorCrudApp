using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspireBlazorCrudApp.Model.Entities
{//this model is used to represent the product entity in the application.
 //each product has an Id, ProductName, Quantity, Price, Description, and CreatedAt timestamp.
 //each property show column in the database table.
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Quantity { get; set; }
       public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;


    }
}
