using Project.Business.Services;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Project.Presentation.Main.Customers
{
    public partial class CustomersForm : Form
    {
        private readonly CustomerService customerService;
        private int pageSize = 15;
        private int currentPage = 1;
        private int totalPageCount;

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

        private void LoadCustomers()
        {
            IEnumerable<Customer> customers = customerService.GetPagedCustomers(pageSize, currentPage);


            // Calcular el total de páginas
            totalPageCount = (int)Math.Ceiling((double)customerService.GetTotalCustomerCount() / pageSize);

            // Deshabilitar o habilitar los botones según la página actual
            btnPreviousPage.Enabled = currentPage > 1;
            btnNextPage.Enabled = currentPage < totalPageCount;

            // Actualizar el texto del labelPage
            labelPage.Text = $"Página {currentPage} de {totalPageCount}";

            dataGridView.DataSource = new BindingSource { DataSource = customers };
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
    }
}
