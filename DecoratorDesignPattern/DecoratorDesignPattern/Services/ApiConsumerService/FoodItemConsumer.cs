using DTOs.Results;

namespace DecoratorDesignPattern.Services.ApiConsumerService
{
    public class FoodItemConsumer : IFoodItemConsumer
    {
        private  List<FoodItemResponse> FoodItemList = new();
        private readonly HttpClient _httpClient;
        private string _apiUrl;
        public FoodItemConsumer(HttpClient httpClientFactory)
        {
            _httpClient = httpClientFactory;
        }

        public async Task<List<FoodItemResponse>> GetFoodItemsAsync()
        {
            _apiUrl = "/api/FoodItem/GetFoodItemList"; //Temp static

            try
            {
               // var hhtpClient = _httpClientFactory.CreateClient();
                var result = await _httpClient.GetAsync(_apiUrl);
                if (result.IsSuccessStatusCode)
                {
                     var FoodItemList = await result.Content.ReadFromJsonAsync<List<FoodItemResponse>>();
                    return FoodItemList;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return FoodItemList;    
        }
    }
}
