using Project.Business.Services;
using System.Windows.Forms;

namespace Project.Presentation.Main.Home
{
    public partial class HomeForm : Form
    {
        private readonly CustomerService customerService;
        private readonly ExpeditureService expeditureService;
        private readonly SaleService saleService;

        public HomeForm()
        {
            this.customerService = new CustomerService();
            this.expeditureService = new ExpeditureService();
            this.saleService = new SaleService();

            InitializeComponent();
            LoadQuantities();
        }

        private void LoadQuantities()
        {
            labelCustomers.Text = customerService.GetTotalCustomerCount().ToString();
            labelSales.Text = saleService.GetTotalSalesAmount().ToString("C");
            labelExpeditures.Text = expeditureService.GetTotalExpenditureAmount().ToString("C");
            labelOrders.Text = saleService.GetSaleCount().ToString();
        }
    }
}
