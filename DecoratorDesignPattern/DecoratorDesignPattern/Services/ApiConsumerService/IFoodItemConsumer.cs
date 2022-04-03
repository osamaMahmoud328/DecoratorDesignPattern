using DTOs.Results;

namespace DecoratorDesignPattern.Services.ApiConsumerService
{
    public interface IFoodItemConsumer
    {
        Task<List<FoodItemResponse>> GetFoodItemsAsync();
    }
}
