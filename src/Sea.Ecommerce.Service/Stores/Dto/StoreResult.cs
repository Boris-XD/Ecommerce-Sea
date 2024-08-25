namespace Sea.Ecommerce.Service.Stores.Dto
{
    public class StoreResult
    {
        public Guid Id { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }
        public string OpeningHours { get; set; }
        public string ManagerName { get; set; }
    }
}
