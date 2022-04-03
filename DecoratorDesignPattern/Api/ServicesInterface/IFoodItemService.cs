using DTOs.Results;

namespace Api.ServicesInterface
{
    public interface IFoodItemService
    {
        Task<List<FoodItemResponse>> GetFoodItemList();
      
    }
}
