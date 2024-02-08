using Project.Business.Services;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Project.Presentation.Main.Sales
{
    public partial class SaleManagerForm : Form
    {
        private readonly SaleService saleService;
        private DateTime selectedDate;

        private Dictionary<int, Color> monthColors = new Dictionary<int, Color>
        {
            { 1, Color.FromArgb(255, 255, 255) },   // Enero - Blanco
            { 3, Color.FromArgb(144, 238, 144) },   // Marzo - Verde claro
            { 4, Color.FromArgb(255, 127, 80) },    // Abril - Coral
            { 5, Color.FromArgb(173, 216, 230) },   // Mayo - Azul claro
            { 6, Color.FromArgb(255, 182, 193) },   // Junio - Rosa claro
            { 7, Color.FromArgb(255, 99, 71) },     // Julio - Rojo tomate
            { 8, Color.FromArgb(0, 255, 255) },     // Agosto - Cian
            { 9, Color.FromArgb(255, 255, 0) },     // Septiembre - Amarillo
            { 10, Color.FromArgb(218, 112, 214) },  // Octubre - Orquídea
            { 11, Color.FromArgb(0, 255, 127) },    // Noviembre - Verde esmeralda
            { 12, Color.FromArgb(255, 140, 0) }     // Diciembre - Naranja oscuro
        };

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

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificar si la celda es de la columna "DateColumn"
            if (dataGridView.Columns[e.ColumnIndex].Name == "DateColumn")
            {
                // Convertir la cadena de la celda a DateTime
                if (DateTime.TryParse(e.Value.ToString(), out DateTime date))
                {
                    // Obtener el mes de la fecha
                    int month = date.Month;

                    // Obtener el color correspondiente al mes del diccionario
                    if (monthColors.ContainsKey(month))
                    {
                        e.CellStyle.ForeColor = monthColors[month];
                    }
                }
            }
        }
    }
}
