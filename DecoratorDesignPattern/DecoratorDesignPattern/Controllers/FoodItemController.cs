using DecoratorDesignPattern.Services.ApiConsumerService;
using DecoratorDesignPattern.Services.Decorators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DecoratorDesignPattern.Controllers
{
    public class FoodItemController : Controller
    {
        //private readonly FoodItemConsumer _foodItemConsumer;
        private readonly IFoodItemConsumer _foodItemConsumer;
        // private readonly ILogger<FoodItemController> _logger;
        private readonly ILoggerFactory _loggerFactory;


        public FoodItemController(ILoggerFactory loggerFactory, IFoodItemConsumer foodItemConsumer)
        {
            _loggerFactory = loggerFactory;
            _foodItemConsumer = foodItemConsumer;
            //_logger= loggerFactory.CreateLogger<FoodItemController>();
            //_foodItemConsumer = new FoodItemDecoratorLoggerService(_foodItemConsumerInjectable, _loggerFactory.CreateLogger<FoodItemDecoratorLoggerService>());
        }
        // GET: FoodItemController
        public async Task<IActionResult> Index()
        {
            var foodItemList = await _foodItemConsumer.GetFoodItemsAsync();
            return View(foodItemList);
        }

        // GET: FoodItemController/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: FoodItemController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: FoodItemController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FoodItemController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FoodItemController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FoodItemController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FoodItemController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}