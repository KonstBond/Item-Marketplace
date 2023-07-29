using Item_Marketplace.Auction.Dal.EFCoreSettings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;

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

            string connectionString =
                Environment.GetEnvironmentVariable("MY_DB_CONNECTION")
                ?? throw new ArgumentNullException(nameof(connectionString), "Не может быть null");

            services.AddDbContext<AuctionDbContext>(options =>
                options.UseSqlServer(connectionString));
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }
}
