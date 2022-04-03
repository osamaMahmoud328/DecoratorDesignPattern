# DecoratorDesignPattern
  Apply Decorator Design Pattern on a Logging and Cashing FoodConsumer Api
# Project Structure:
  - Api:Core Dot Net 6 ( Sample Data , Mapper , Food Service(Api) ).
  - DTOs: Class Library Core Dot Net 6 (Contains Data Transfer Obkects between Api and MVC Client).
  - DecoratorDesignPattern: MVC Core 6 (Mvc Client consuming Food Api Service){FoodItemConumer , FoodItemDecoratorLoggerService}.
# Project Details:
  - Adding Logging and Cashing Implementaion to the Original FoodService Consumer Implementaion to provide multible Implementation without Editing the Original
    Implementation.
