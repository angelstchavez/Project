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

        private void btnDetails_Click(object sender, EventArgs e)
        {
            SaleDetailForm saleDetailForm = new SaleDetailForm(selectedDate);
            saleDetailForm.ShowDialog();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                string selectedDateString = selectedRow.Cells["DateColumn"].Value.ToString();

                if (DateTime.TryParse(selectedDateString, out selectedDate))
                {
                    // Puedes realizar cualquier acción adicional que desees aquí
                }
                else
                {
                    MessageBox.Show("La fecha seleccionada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
