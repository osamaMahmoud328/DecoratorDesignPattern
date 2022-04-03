using DecoratorDesignPattern.Services.ApiConsumerService;
using DecoratorDesignPattern.Services.Decorators;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddScoped<FoodItemConsumer>();

builder.Services.AddSingleton<FoodItemConsumer>();
builder.Services.AddHttpClient<FoodItemConsumer>(client =>
         client.BaseAddress = new Uri("https://localhost:7082/") //Temp Static
    );
var services = new ServiceCollection();
ServiceProvider serviceProvider = services.BuildServiceProvider();

//var logger = serviceProvider.GetService<ILogger<FoodItemDecoratorLoggerService>>();
//var originalFoodItemConsumer = serviceProvider.GetRequiredService<FoodItemConsumer>();
builder.Services.AddSingleton<IFoodItemConsumer>(sp =>
    new FoodItemDecoratorLoggerService
        (
            sp.GetRequiredService<FoodItemConsumer>(),
            sp.GetService<ILogger<FoodItemDecoratorLoggerService>>()
        )
);;
//var foodItemDecoratorLoggerService = new FoodItemDecoratorLoggerService(originalFoodItemConsumer, logger);

//builder.Services.AddSingleton(foodItemDecoratorLoggerService);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add services to the container.
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
