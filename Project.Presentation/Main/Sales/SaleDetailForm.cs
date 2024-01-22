using Project.Business.Services;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Project.Presentation.Main.Sales
{
    public partial class SaleDetailForm : Form
    {
        private readonly SaleService saleService;
        private readonly ProductService productService;
        private DateTime targetDate;
        private DataGridViewRow selectedRow;
        public SaleDetailForm(DateTime targetDate)
        {
            this.saleService = new SaleService();
            this.productService = new ProductService();
            this.targetDate = targetDate;
            InitializeComponent();
            LoadSalesDate();
            LoadAmounts();
            LoadDetailedProducts();
        }

        private void LoadSalesDate()
        {
            try
            {
                var sales = saleService.GetSalesForDate(targetDate);

                decimal totalSales = CalculateTotalSales(sales);

                // Actualizar el label con el total de ventas
                UpdateTotalSalesLabel(totalSales);

                int counter = 1;

                foreach (var sale in sales)
                {
                    dataGridView.Rows.Add(new object[] {
                sale.Id,
                counter++,
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

        private void LoadAmounts()
        {
            labelTotalCash.Text = saleService.GetCashSalesForDate(targetDate).ToString("C");
            labelTotalDaviplata.Text = saleService.GetDaviplataSalesForDate(targetDate).ToString("C");
            labelTotalNequi.Text = saleService.GetNequiSalesForDate(targetDate).ToString("C");
        }

        private decimal CalculateTotalSales(IEnumerable<DetailedSale> sales)
        {
            return sales.Sum(s => s.TotalAmount);
        }

        private void UpdateTotalSalesLabel(decimal totalSales)
        {
            // Asignar el total de ventas al texto del label
            totalSalesLabel.Text = $"{totalSales.ToString("C")}";
        }

        private void LoadDetailedProducts()
        {
            try
            {
                var products = saleService.GetProductSalesForDate(targetDate);

                foreach (var product in products)
                {
                    dataGridViewProducts.Rows.Add(new object[] {
                        product.ProductName,
                        product.TotalQuantity,
                        product.TotalAmount.ToString("C"),
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns.Count - 1)
            {
                e.CellStyle.Font = new Font(dataGridView.Font, FontStyle.Bold);
            }
        }

        private void dataGridViewProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewProducts.Columns.Count - 1)
            {
                e.CellStyle.Font = new Font(dataGridViewProducts.Font, FontStyle.Bold);
            }
        }

        private void btnResalt_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                selectedRow = dataGridView.SelectedRows[0];

                selectedRow.DefaultCellStyle.BackColor = Color.PaleGreen;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila antes de cambiar el color.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.DefaultCellStyle.BackColor = dataGridView.DefaultCellStyle.BackColor;
            }

            selectedRow = null;
        }
    }
}
