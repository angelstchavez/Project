using System;
using System.Data.SqlTypes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Presentation.Main.Bills
{
    public partial class BillsMonthReport : Form
    {
        public BillsMonthReport()
        {
            InitializeComponent();
        }

        private void BillsMonthReport_Load(object sender, EventArgs e)
        {
            // No es necesario cargar datos aquí, ya que solo deseas cargarlos cuando se hace clic en el botón.
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            int selectedMonth = comboBoxMonth.SelectedIndex + 1;
            int selectedYear = (int)numericUpDownYear.Value;

            LoadReportData(selectedMonth, selectedYear);
        }

        private async void LoadReportData(int selectedMonth, int selectedYear)
        {
            try
            {
                DateTime selectedDate = new DateTime(selectedYear, selectedMonth, 1);

                // Validar que la fecha sea válida
                if (selectedDate < SqlDateTime.MinValue.Value || selectedDate > SqlDateTime.MaxValue.Value)
                {
                    MessageBox.Show("Fecha fuera del rango válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cargar datos de manera asíncrona
                await Task.Run(() =>
                {
                    this.Invoke(new Action(() =>
                    {
                        getMonthlyExpenditureByCategoryTableAdapter.Fill(
                            reportMasterDataSet.GetMonthlyExpenditureByCategory,
                            selectedMonth,
                            selectedYear
                        );
                    }));
                });

                // Verifica si se encontraron registros
                if (reportMasterDataSet.GetMonthlyExpenditureByCategory.Rows.Count == 0)
                {
                    MessageBox.Show("No hay registros para la fecha seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;  // No muestra el informe si no hay registros
                }

                // Muestra el informe en formato "Diseño de impresión"
                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

                // Ajusta el tamaño de la página para el diseño de impresión
                this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;

                // Establece el zoom al 150%
                this.reportViewer1.ZoomPercent = 100;

                // Refresca el informe después de aplicar cambios
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el informe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
