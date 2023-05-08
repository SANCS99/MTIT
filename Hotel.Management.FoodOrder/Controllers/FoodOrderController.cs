using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860




using System.Reflection.Metadata.Ecma335;

using Hotel.Management.FoodOrder.Data;
using Hotel.Management.FoodOrder.Services;
using Hotel.Management.FoodOrder.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hotel.Management.FoodOrder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodOrderController : ControllerBase
    {
        private readonly IFoodOrderService _foodorderService;

        public FoodOrderController(IFoodOrderService foodorderService)
        {
            _foodorderService = foodorderService ?? throw new ArgumentNullException(nameof(foodorderService));
        }


        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_foodorderService.GetFoodOrders());
        }

        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _foodorderService.GetFoodOrder(id) != null ? Ok(_foodorderService.GetFoodOrder(id)) : NoContent();
        }

       
        [HttpPost]
        public IActionResult Post([FromBody] Models.FoodOrder foodorder)
        {
            return Ok(_foodorderService.AddFoodOrder(foodorder));
        }

        
        [HttpPut]
        public IActionResult Put([FromBody] Models.FoodOrder foodorder)
        {
            return Ok(_foodorderService.UpdateFoodOrder(foodorder));
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _foodorderService.DeleteFoodOrder(id);

            return result.HasValue & result == true ? Ok($"FoodOrder with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the FoodOrder with ID:{id}.");
        }
    }
}

