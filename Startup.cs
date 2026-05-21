using Shop.Data.Interfaces;
using Shop.Data.Mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Shop
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // объединяем интерфейс и реализующий класс
            services.AddTransient<ICategories, MockCategories>();
            services.AddTransient<IItems, MockItems>();

            // включаем поддержку MVC
            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}