using System;

namespace Project.Entity
{
    public class SalePerDay
    {
        public DateTime SaleDate { get; set; }
        public int TotalSales { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
