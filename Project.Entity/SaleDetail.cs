using System;

namespace Project.Entity
{
    public class SaleDetail
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatetAt { get; set; }
    }
}
