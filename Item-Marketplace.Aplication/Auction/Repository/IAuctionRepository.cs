using Item_Marketplace.Aplication.Auction.Model.AuctionModel;

namespace Item_Marketplace.Aplication.Auction.Repository
{
    public interface IAuctionRepository
    {
        public Task<IEnumerable<AuctionModel>> GetAuctionModelsAsync();
        public Task<IEnumerable<AuctionModel>> GetAuctionModelsAsync(int id);
        public Task InsertAuctionModel(AuctionModel auctionModel);
        public Task<bool> SaveChanges();
    }
}
