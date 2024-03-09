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
            { 1, Color.FromArgb(255, 192, 203) },    // Enero - Rosa claro
            { 2, Color.FromArgb(255, 218, 185) },    // Febrero - Melocotón
            { 3, Color.FromArgb(173, 216, 230) },    // Marzo - Azul cielo más brillante
            { 4, Color.FromArgb(255, 105, 105) },    // Abril - Rosa salmón más vivo
            { 5, Color.FromArgb(144, 238, 144) },    // Mayo - Verde claro
            { 6, Color.FromArgb(255, 215, 0) },      // Junio - Dorado
            { 7, Color.FromArgb(255, 235, 139) },    // Julio - Amarillo más vivo
            { 8, Color.FromArgb(255, 20, 147) },     // Agosto - Rosa oscuro
            { 9, Color.FromArgb(124, 252, 0) },      // Septiembre - Verde lima más brillante
            { 10, Color.FromArgb(64, 224, 208) },    // Octubre - Cian claro más vivo
            { 11, Color.FromArgb(255, 182, 193) },   // Noviembre - Rosa claro
            { 12, Color.FromArgb(255, 240, 245) }    // Diciembre - Rosa lavanda
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
            saleDetailForm.StartPosition = FormStartPosition.CenterParent;
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
                    // Formatear la fecha como "Diciembre: 1 del 2023"
                    string formattedDate = $"{date.ToString("MMMM")}: {date.Day} del {date.Year}";

                    e.Value = formattedDate;

                    // Obtener el mes de la fecha
                    int month = date.Month;

                    // Obtener el color correspondiente al mes del diccionario
                    if (monthColors.ContainsKey(month))
                    {
                        e.CellStyle.ForeColor = monthColors[month];
                    }
                }
            }

            // Verificar si la celda está en la última columna
            if (e.ColumnIndex == dataGridView.Columns.Count - 1)
            {
                // Establecer el texto en negrita
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
            }
        }
    }
}
