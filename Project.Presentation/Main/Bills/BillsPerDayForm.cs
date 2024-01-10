using Project.Business.Services;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Project.Presentation.Main.Bills
{
    public partial class BillsPerDayForm : Form
    {
        private readonly ExpeditureService expeditureService;
        private DateTime selectedDate;

        public BillsPerDayForm()
        {
            InitializeComponent();
            expeditureService = new ExpeditureService();
            LoadDataTotalExpensesPerDay();
        }

        private string FormatCurrency(decimal value)
        {
            // Formatea el valor como moneda colombiana
            return value.ToString("C", new CultureInfo("es-CO"));
        }

        private void LoadDataTotalExpensesPerDay()
        {
            IEnumerable<ExpenditureDay> totalExpensesPerDay = expeditureService.GetTotalExpensesPerDay();

            dataGridView.Rows.Clear();

            if (totalExpensesPerDay.Any())
            {
                decimal total = 0;

                foreach (var item in totalExpensesPerDay)
                {
                    dataGridView.Rows.Add(new object[] { item.Date.ToLongDateString(), FormatCurrency(item.TotalExpenses) });

                    total += item.TotalExpenses;

                    txtTotal.Text = FormatCurrency(total);
                }
            }
            else
            {
                MessageBox.Show($"No hay gastos totales registrados", "Consulta de Gastos Totales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (selectedDate != DateTime.MinValue)
            {
                BillsByDateForm childForm = new BillsByDateForm(selectedDate);
                childForm.StartPosition = FormStartPosition.CenterParent;
                childForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona un registro antes de ver los detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report.Forms.ReportGetTotalExpensesPerDayForm reportGetTotalExpensesPerDayForm = new Report.Forms.ReportGetTotalExpensesPerDayForm();
            reportGetTotalExpensesPerDayForm.ShowDialog();
        }

        private void btnReportByCategory_Click(object sender, EventArgs e)
        {
            BillsReportForm billsReportForm = new BillsReportForm();
            billsReportForm.ShowDialog();
        }
    }
}