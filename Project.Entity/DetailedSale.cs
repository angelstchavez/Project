namespace Project.Entity
{
    public class DetailedSale
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string ShippingAddress { get; set; }
        public string NeighborhoodName { get; set; }
        public string TransportationCompanyName { get; set; }
        public string PaymentType { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
