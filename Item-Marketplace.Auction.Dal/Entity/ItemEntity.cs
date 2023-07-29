namespace Item_Marketplace.Auction.Dal.Entity
{
    /// <summary>
    /// Предмет аукциона
    /// </summary>
    public class ItemEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Metadata { get; set; }
        /// <summary>
        /// Свойство для установление связи 1:М с таблицей аукционов
        /// </summary>
        public IEnumerable<AuctionEntity> Auctions { get; set; }
    }
}
