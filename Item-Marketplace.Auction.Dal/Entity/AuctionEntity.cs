using Item_Marketplace.Aplication.Auction.Model.AuctionModel;

namespace Item_Marketplace.Auction.Dal.Entity
{
    public class AuctionEntity
    {
        public int Id { get; set; }
        /// <summary>
        /// Внешний ключ, ссылающийся на предмет ауциона
        /// </summary>
        public int ItemId { get; set; }
        public ItemEntity Item { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime? FinishedDt { get; set;}
        public decimal Price { get; set; }
        public MarketStatus MarketStatus { get; set; }
        public string Seller { get; set; }
        public string Buyer { get; set; }
    }
}
