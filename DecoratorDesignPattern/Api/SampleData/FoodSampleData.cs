using Api.SampleData.Models;

namespace Api.SampleData
{
    public  class FoodSampleData
    {
        private  static readonly List<FoodItem> FoodSampleDataList = new List<FoodItem>()
            {
                new FoodItem()
                {
                    Id = 1,
                    Name ="BigMac",
                    Code ="1246Mack",
                    Number =5
                },new FoodItem()
                {
                    Id = 2,
                    Name ="BigTesty",
                    Code ="145334Testy",
                    Number =7
                }
                ,new FoodItem()
                {
                    Id = 3,
                    Name ="Pepsi",
                    Code ="1243564556Machine",
                    Number =10
                }
            };

        public static async Task<List<FoodItem>> GetFoodItemList()
        {
             return  FoodSampleDataList;
        }
    }
}
