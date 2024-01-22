using Project.Business.Services;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Project.Presentation.Main.Bills
{
    public partial class BillsByDateForm : Form
    {
        private readonly ExpeditureService expeditureService;

        public BillsByDateForm(DateTime date)
        {
            InitializeComponent();
            expeditureService = new ExpeditureService();
            LoadDataByDate(date);
            txtDate.Text = "Gastos del " + date.ToLongDateString();
        }

        private string FormatCurrency(decimal value)
        {
            // Formatea el valor como moneda colombiana
            return value.ToString("C", new CultureInfo("es-CO"));
        }

        private void LoadDataByDate(DateTime date)
        {
            IEnumerable<Expenditure> expenditures = expeditureService.GetBySpecificDate(date);

            dataGridView.Rows.Clear();

            if (expenditures.Any())
            {
                decimal total = 0;

                foreach (var item in expenditures)
                {
                    dataGridView.Rows.Add(new object[] { item.Id, item.Date.ToShortDateString(), item.Category, item.Description, FormatCurrency(item.Value) });

                    total += item.Value;
                }

                txtTotal.Text = FormatCurrency(total);
            }
            else
            {
                MessageBox.Show($"No hay gastos registrados", "Consulta de Gastos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns.Count - 1)
            {
                e.CellStyle.Font = new Font(dataGridView.Font, FontStyle.Bold);
            }
        }
    }
}
