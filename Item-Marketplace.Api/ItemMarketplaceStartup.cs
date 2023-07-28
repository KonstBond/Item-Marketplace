namespace Item_Marketplace.Api
{
    public class ItemMarketplaceStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
            services.AddControllers();
            services.AddApiVersioning();
            
            //swagger
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "api",
                    pattern: "api/v{version:apiVersion}/[controller]/[action]");
            });
        }
    }
}
