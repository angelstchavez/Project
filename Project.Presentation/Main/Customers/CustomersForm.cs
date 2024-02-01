using Project.Business.Services;
using Project.Entity;
using Project.Presentation.Main.Bills;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Project.Presentation.Main.Customers
{
    public partial class CustomersForm : Form
    {
        private readonly CustomerService customerService;
        private int pageSize = 24;
        private int currentPage = 1;
        private int totalPageCount;
        private int customerId;
        public CustomersForm()
        {
            this.customerService = new CustomerService();
            InitializeComponent();
            LoadCustomers();
            LoadCustomerCounts();
        }

        private void LoadCustomerCounts()
        {
            IEnumerable<Customer> customers = customerService.GetAll();
            labelCount.Text = $"Clientes registrados: {customers.Count()}";
        }

        private void UpdateCustomerList(IEnumerable<Customer> customers)
        {
            dataGridView.Rows.Clear();

            foreach (var customer in customers)
            {
                dataGridView.Rows.Add(new object[] { customer.Id, customer.Name, customer.Phone });
            }
        }

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
                dataGridView.Rows.Add(new object[] { customer.Id, customer.Name, customer.Phone, });
            }

            LoadCustomerCounts();
        }

        private void btnPreviousPage_Click(object sender, System.EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadCustomers();
            }
        }

        private void btnNextPage_Click(object sender, System.EventArgs e)
        {
            if (currentPage < totalPageCount)
            {
                currentPage++;
                LoadCustomers();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CustomerControlForm customerControlForm = new CustomerControlForm(false);
            customerControlForm.ShowDialog();
            LoadCustomers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerControlForm customerControlForm = new CustomerControlForm(false);
            customerControlForm.StartPosition = FormStartPosition.CenterParent;
            customerControlForm.ShowDialog();
            LoadCustomers();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (customerId > 0)
            {
                DialogResult result = MessageBox.Show("¿Seguro que deseas eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (customerService.Delete(customerId))
                    {
                        MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCustomers();
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un cliente antes de eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                customerId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Id"].Value);
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificar si la celda en la columna "Nombre" tiene el valor "Sin nombre"
            if (dataGridView.Rows[e.RowIndex].Cells["Nombre"].Value != null &&
                string.Equals(dataGridView.Rows[e.RowIndex].Cells["Nombre"].Value.ToString(), "Sin nombre", StringComparison.OrdinalIgnoreCase))
            {
                dataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Orange;
            }

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Obtener el número de teléfono de la columna "Ptelefono" en la fila seleccionada
                string phoneNumber = dataGridView.SelectedRows[0].Cells["Telefono"].Value.ToString();

                // Construir el enlace de WhatsApp con el número de teléfono
                string whatsappLink = $"https://api.whatsapp.com/send?phone={phoneNumber}";

                // Abrir el enlace en el navegador predeterminado
                System.Diagnostics.Process.Start(whatsappLink);
            }
            else
            {
                MessageBox.Show("Selecciona un registro antes de abrir WhatsApp.");
            }
        }

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomer.Clear();
            LoadCustomers();
        }
    }
}
