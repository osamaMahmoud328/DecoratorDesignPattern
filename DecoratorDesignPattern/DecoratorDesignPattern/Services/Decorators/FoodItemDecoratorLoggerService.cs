using DecoratorDesignPattern.Services.ApiConsumerService;
using DTOs.Results;
using System.Diagnostics;

namespace DecoratorDesignPattern.Services.Decorators
{
    public class FoodItemDecoratorLoggerService : IFoodItemConsumer
    {
        private readonly IFoodItemConsumer _foodItemConsumer;
        private readonly ILogger _logger;
        public FoodItemDecoratorLoggerService(IFoodItemConsumer foodItemConsumer,ILogger<FoodItemDecoratorLoggerService> logger)
        {
            _foodItemConsumer = foodItemConsumer;
            _logger = logger;
        }
        public async Task<List<FoodItemResponse>> GetFoodItemsAsync()
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            var foodItemList = await  _foodItemConsumer.GetFoodItemsAsync(); 
            stopWatch.Stop();
            _logger.LogWarning($"This Takes {stopWatch.ElapsedMilliseconds} millisecond");
            return foodItemList;    
        }
    }
}
