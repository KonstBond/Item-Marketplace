using Item_Marketplace.Aplication.Auction.Model.AuctionModel;
using Item_Marketplace.Aplication.Auction.Repository;

namespace Item_Marketplace.Auction.Dal.Auction
{
    public class AuctionRepository : IAuctionRepository
    {
        public Task<IEnumerable<AuctionModel>> GetAuctionModelsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AuctionModel>> GetAuctionModelsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAuctionModel(AuctionModel auctionModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
