using Project.Business.Services;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Project.Presentation.Main.Customers
{
    public partial class CustomersConsultForm : Form
    {
        #region Fields

        private readonly CustomerService customerService;
        private int pageSize = 15;
        private int currentPage = 1;
        private int totalPageCount;

        #endregion

        #region Events

        public event EventHandler<CustomerSelectedEventArgs> CustomerSelected;

        #endregion

        #region Constructor

        public CustomersConsultForm()
        {
            customerService = new CustomerService();
            InitializeComponent();
            LoadCustomers();
        }

        #endregion

        #region Private Methods

        private void LoadCustomers()
        {
            // Obtener la lista de clientes directamente del servicio
            IEnumerable<Customer> customers = customerService.GetPagedCustomers(pageSize, currentPage);

            totalPageCount = (int)Math.Ceiling((double)customerService.GetTotalCustomerCount() / pageSize);

            btnPreviousPage.Enabled = currentPage > 1;
            btnNextPage.Enabled = currentPage < totalPageCount;

            labelPage.Text = $"Página {currentPage} de {totalPageCount}";

            dataGridView.Rows.Clear();

            foreach (var customer in customers)
            {
                dataGridView.Rows.Add(new object[] { customer.Id, customer.Name, customer.Phone });
            }
        }

        private void FormatCellIfNoName(int rowIndex, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Rows[rowIndex].Cells["Nombre"].Value != null &&
                string.Equals(dataGridView.Rows[rowIndex].Cells["Nombre"].Value.ToString(), "Sin nombre", StringComparison.OrdinalIgnoreCase))
            {
                dataGridView.Rows[rowIndex].DefaultCellStyle.BackColor = SystemColors.Info;
            }
        }

        private void SelectCustomerAndClose(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
            {
                // Obtén el objeto Customer desde la fila seleccionada
                DataGridViewRow selectedRow = dataGridView.Rows[rowIndex];
                Customer selectedCustomer = new Customer
                {
                    Id = Convert.ToInt32(selectedRow.Cells["Id"].Value),
                    Name = selectedRow.Cells["Nombre"].Value.ToString(),
                    Phone = selectedRow.Cells["Telefono"].Value.ToString(),
                };

                // Emitir el evento con la información del cliente seleccionado
                OnCustomerSelected(new CustomerSelectedEventArgs(selectedCustomer));
            }

            this.Close();
        }

        private void UpdateCustomerList(IEnumerable<Customer> customers)
        {
            dataGridView.Rows.Clear();

            foreach (var customer in customers)
            {
                dataGridView.Rows.Add(new object[] { customer.Id, customer.Name, customer.Phone });
            }
        }

        #endregion

        #region Event Handlers

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadCustomers();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPageCount)
            {
                currentPage++;
                LoadCustomers();
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            FormatCellIfNoName(e.RowIndex, e);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCustomerAndClose(e.RowIndex);
        }

        #endregion

        #region Custom Event

        protected virtual void OnCustomerSelected(CustomerSelectedEventArgs e)
        {
            CustomerSelected?.Invoke(this, e);
        }

        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtCustomer.Text.Trim();

            // Realizar la búsqueda solo si hay un término para buscar
            if (!string.IsNullOrEmpty(searchTerm))
            {
                Customer searchResult = customerService.GetByPhoneNumber(searchTerm);

                if (searchResult != null)
                {
                    // Actualizar la lista de clientes con el resultado de la búsqueda
                    UpdateCustomerList(new List<Customer> { searchResult });
                }
                else
                {
                    // Mostrar un mensaje si no se encuentra ningún resultado
                    MessageBox.Show("No se encontraron clientes con el número de teléfono proporcionado.", "Búsqueda sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtCustomer.Clear();
            LoadCustomers();
        }
    }

    public class CustomerSelectedEventArgs : EventArgs
    {
        public Customer SelectedCustomer { get; }

        public CustomerSelectedEventArgs(Customer selectedCustomer)
        {
            SelectedCustomer = selectedCustomer;
        }
    }
}
