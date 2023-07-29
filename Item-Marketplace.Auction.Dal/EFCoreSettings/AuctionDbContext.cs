using Item_Marketplace.Auction.Dal.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Item_Marketplace.Auction.Dal.EFCoreSettings
{
    public class AuctionDbContext : DbContext
    {
        public DbSet<ItemEntity> ItemEntities { get; set; }
        public DbSet<AuctionEntity> AuctionEntities { get; set; }

        public AuctionDbContext(DbContextOptions<AuctionDbContext> options) : base(options) { }
    }
}
