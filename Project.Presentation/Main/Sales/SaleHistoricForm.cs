using Project.Business.Services;
using System;
using System.Windows.Forms;

namespace Project.Presentation.Main.Sales
{
    public partial class SaleHistoricForm : Form
    {
        private readonly SaleService saleService;

        public SaleHistoricForm()
        {
            this.saleService = new SaleService();
            InitializeComponent();
            LoadSalesToday();
        }

        private void LoadSalesToday()
        {
            try
            {
                var sales = saleService.GetSalesForToday();

                foreach (var sale in sales)
                {
                    dataGridView.Rows.Add(new object[] {
                        sale.Id,
                        sale.CustomerName,
                        sale.ShippingAddress,
                        sale.NeighborhoodName,
                        sale.TransportationCompanyName,
                        sale.PaymentType,
                        sale.TotalAmount,
                        sale.TotalAmount.ToString("C"),
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
