using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspireBlazorCrudApp.Model.Models;
using AspireBlazorCrudApp.BL.Services;

namespace AspireBlazorCrudApp.ApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //inject the product service in the constructor to use it in the controller 
    //we will create the service later
    //i will create an interface for the service to make it more testable and maintainable
    
    public class ProductController(IProductService productService) : ControllerBase
    {
        //create an Api To return a list of products
        //add http get method
        [HttpGet]
        //return a list of products for all our Api or crud methods
        public async Task<ActionResult<BaseResponseModel>> GetProducts() 
        {
            //get the data from the serrvice we do not have service yet but we will create it later lets assume we have a service
            //to use service in the controller we need to inject it in the constructor
            //this is the topic of dependency injection we will cover it later
            var products = await productService.GetProducts();
            return Ok(new BaseResponseModel
            {
                Success = true,
                Data = products
            });
        }

    }
}
