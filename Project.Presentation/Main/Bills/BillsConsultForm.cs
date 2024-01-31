using Project.Business.Services;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;

namespace Project.Presentation.Main.Bills
{
    public partial class BillsConsultForm : Form
    {
        private readonly ExpeditureService expeditureService;
        private bool isSearchEnabled = true;
        private int selectedId = 0;
        private Expenditure selectedExpenditure = new Expenditure();
        private DataGridViewRow selectedRow;

        public BillsConsultForm()
        {
            InitializeComponent();
            expeditureService = new ExpeditureService();
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
                
                int count = 1;

                foreach (var item in expenditures)
                {
                    // Agrega la fila al DataGridView con el formato de moneda colombiana
                    dataGridView.Rows.Add(new object[] { item.Id, count++, item.Category, item.Description, FormatCurrency(item.Value), item.Value });

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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string category = selectedRow.Cells["Category"].Value.ToString();
                string description = selectedRow.Cells["Description"].Value.ToString();
                decimal value = Convert.ToDecimal(selectedRow.Cells["ColumnValue"].Value);
                DateTime date = Convert.ToDateTime(selectedRow.Cells["Date"].Value);

                // Asigna valores a la variable de instancia
                selectedExpenditure.Id = id;
                selectedExpenditure.Category = category;
                selectedExpenditure.Description = description;
                selectedExpenditure.Value = value;
                selectedExpenditure.Date = date;

                selectedId = id;
            }
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                BillsControlForm billsControlForm = new BillsControlForm(selectedExpenditure, true);
                billsControlForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila antes de hacer clic en 'Corregir'.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dataGridView_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns.Count - 1)
            {
                e.CellStyle.Font = new Font(dataGridView.Font, FontStyle.Bold);
                e.CellStyle.ForeColor = Color.Brown;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedId > 0)
            {
                DialogResult result = MessageBox.Show("¿Seguro que deseas eliminar este gasto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (expeditureService.Delete(selectedId))
                    {
                        MessageBox.Show("gasto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Consult(dateTimePicker.Value);
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar eliminar el gasto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un gasto antes de eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
