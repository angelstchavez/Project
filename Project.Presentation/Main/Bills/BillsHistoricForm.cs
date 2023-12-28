using Project.Business.Services;
using Project.Entity;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Project.Presentation.Main.Bills
{
    public partial class BillsHistoricForm : Form
    {
        private readonly ExpeditureService expeditureService;

        public BillsHistoricForm()
        {
            InitializeComponent();
            expeditureService = new ExpeditureService();
            LoadData();
        }

        private string FormatCurrency(decimal value)
        {
            // Formatea el valor como moneda colombiana
            return value.ToString("C", new CultureInfo("es-CO"));
        }

        private void LoadData()
        {
            IEnumerable<Expenditure> expenditures = expeditureService.GetAll();

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
    }
}
