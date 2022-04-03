using Api.SampleData;
using Api.SampleData.Models;
using Api.ServicesInterface;
using AutoMapper;
using DTOs.Results;

namespace Api.Services
{
    public class FoodItemService : IFoodItemService
    {
        private  List<FoodItem> _foodSampleDataList;
        private readonly IMapper _mapper;
        public FoodItemService(IMapper mapper)
        {
            _mapper = mapper;
        }   
        public async Task<List<FoodItemResponse>> GetFoodItemList()
        {
            try
            {
                _foodSampleDataList = await FoodSampleData.GetFoodItemList();
                var foodItemDtoList = _mapper.Map<List<FoodItem>,List<FoodItemResponse>>(_foodSampleDataList);    
                return foodItemDtoList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
