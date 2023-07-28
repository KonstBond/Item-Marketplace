using Microsoft.AspNetCore;

namespace Item_Marketplace.Api
{
    class Program
    {
        public static void Main(string[] args)
        {
            CreateHost(args).Run();
        }

        public static IWebHost CreateHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<ItemMarketplaceStartup>()
            .Build();
    }
}