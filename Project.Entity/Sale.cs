using System;

namespace Project.Entity
{
    public class Sale
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Customer Customer { get; set; }
        public string Address { get; set; }
        public Neighborhood Neighborhood { get; set; }
        public string PaymentType { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
