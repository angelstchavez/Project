using Project.Business.Services;
using Project.Entity;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace Project.Presentation.Main.Customers
{
    public partial class CustomersConsultForm : Form
    {
        private readonly CustomerService customerService;
        private int pageSize = 15;
        private int currentPage = 1;
        private int totalPageCount;

        public CustomersConsultForm()
        {
            customerService = new CustomerService();
            InitializeComponent();
            LoadCustomers();
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
        }

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
    }
}
