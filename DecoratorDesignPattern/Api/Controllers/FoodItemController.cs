using Api.ServicesInterface;
using DTOs.Results;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/FoodItem")]
    [ApiController]
    public class FoodItemController : ControllerBase
    {
        private readonly IFoodItemService _foodItemService;
        public FoodItemController(IFoodItemService foodItemService)
        {
            _foodItemService = foodItemService;
        }

        // GET: api/<FoodItemController>
        [HttpGet]
        [Route("GetFoodItemList")]
        public async Task<IActionResult> GetFoodItemList()
        {
           var foodItemListDto = await _foodItemService.GetFoodItemList();
            return Ok(foodItemListDto);
        }

        // GET api/<FoodItemController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FoodItemController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FoodItemController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FoodItemController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
