using Project.Business.Services;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Project.Presentation.Main.Sales
{
    public partial class SaleManagerForm : Form
    {
        private readonly SaleService saleService;
        private DateTime selectedDate;

        public SaleManagerForm()
        {
            this.saleService = new SaleService();
            InitializeComponent();
            LoadSalesPerDay();
        }

        private string FormatCurrency(decimal value)
        {
            return value.ToString("C", new CultureInfo("es-CO"));
        }

        private void LoadSalesPerDay()
        {
            IEnumerable<SalePerDay> totalExpensesPerDay = saleService.GetTotalSalesPerDay();

            dataGridView.Rows.Clear();

            if (totalExpensesPerDay.Any())
            {
                decimal total = 0;

                foreach (var item in totalExpensesPerDay)
                {
                    dataGridView.Rows.Add(new object[] { item.SaleDate.ToLongDateString(), $"{item.TotalSales} Pedidos", FormatCurrency(item.TotalAmount) });

                    total += item.TotalAmount;

                    txtTotal.Text = FormatCurrency(total);
                }
            }
            else
            {
                MessageBox.Show($"No hay ventas totales registradas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
