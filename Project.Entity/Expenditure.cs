using System;

namespace Project.Entity
{
    public class Expenditure
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
