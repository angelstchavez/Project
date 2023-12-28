using Project.Business.Services;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace Project.Presentation.Main.Bills
{
    public partial class BillsConsultForm : Form
    {
        private readonly ExpeditureService expeditureService;
        private bool isSearchEnabled = true; // Variable para rastrear el estado del botón de búsqueda

        public BillsConsultForm()
        {
            InitializeComponent();
            expeditureService = new ExpeditureService();
            Consult(DateTime.Now);

            // Suscribir al evento ValueChanged del DateTimePicker para habilitar el botón de búsqueda cuando cambia la fecha
            dateTimePicker.ValueChanged += (sender, e) => EnableSearchButton();
        }

        private void Consult(DateTime date)
        {
            if (!isSearchEnabled)
                return;

            DisableSearchButton(); // Deshabilita el botón de búsqueda al iniciar la consulta

            IEnumerable<Expenditure> expenditures = expeditureService.GetBySpecificDate(date);

            dataGridView.Rows.Clear();

            if (expenditures.Any())
            {
                txtDate.Text = date.ToLongDateString();

                decimal total = 0;

                foreach (var item in expenditures)
                {
                    // Agrega la fila al DataGridView con el formato de moneda colombiana
                    dataGridView.Rows.Add(new object[] { item.Id, item.Category, item.Description, FormatCurrency(item.Value) });

                    // Suma el valor al total
                    total += item.Value;
                }

                // Muestra el total en el TextBox con formato de moneda colombiana
                txtTotal.Text = FormatCurrency(total);

                DisableSearchButton(); // Deshabilita el botón de búsqueda después de la consulta exitosa
            }
            else
            {
                txtDate.Text = $"Registros no encontrados...";
                MessageBox.Show($"No hay gastos registrados el día {date.ToShortDateString()}.", "Consulta de Gastos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string FormatCurrency(decimal value)
        {
            // Formatea el valor como moneda colombiana
            return value.ToString("C", new CultureInfo("es-CO"));
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            Consult(dateTimePicker.Value);
        }

        private void DisableSearchButton()
        {
            isSearchEnabled = false;
            btnConsult.Enabled = false;
        }

        private void EnableSearchButton()
        {
            isSearchEnabled = true;
            btnConsult.Enabled = true;
        }
    }
}
