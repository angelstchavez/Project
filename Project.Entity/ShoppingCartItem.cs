using System.Windows.Forms;

namespace Project.Entity
{
    public class ShoppingCartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DataGridViewButtonColumn DeleteButton { get; set; }
    }
}
