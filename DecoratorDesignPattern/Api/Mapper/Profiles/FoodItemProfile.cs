using Api.SampleData.Models;
using AutoMapper;
using DTOs.Results;

namespace Api.Mapper.Profiles
{
    public class FoodItemProfile : Profile
    {
        public FoodItemProfile()
        {
            CreateMap<FoodItem,FoodItemResponse>();
        }
    }
}
