using Project.Business.Services;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            LoadChart();
        }

        private void LoadQuantities()
        {
            labelCustomers.Text = customerService.GetTotalCustomerCount().ToString();
            labelSales.Text = saleService.GetTotalSalesAmount().ToString("C");
            labelExpeditures.Text = expeditureService.GetTotalExpenditureAmount().ToString("C");
            labelOrders.Text = saleService.GetSaleCount().ToString();
        }

        private void LoadChart()
        {
            // Obtener datos para el gráfico
            var productService = new ProductService(/* aquí pasa la referencia a tu repositorio si es necesario */);
            var chartData = productService.GetProductSales();

            // Configurar el Chart
            productsChart.Series.Clear();
            productsChart.ChartAreas.Clear();

            productsChart.ChartAreas.Add("ChartArea");
            productsChart.Series.Add("SalesData");

            // Configuración adicional para quitar la cuadrícula de fondo
            productsChart.ChartAreas["ChartArea"].AxisX.MajorGrid.Enabled = false;
            productsChart.ChartAreas["ChartArea"].AxisY.MajorGrid.Enabled = false;

            // Configuración para el estilo de las etiquetas del eje X e Y
            productsChart.ChartAreas["ChartArea"].AxisX.Title = "Productos vendidos";
            productsChart.ChartAreas["ChartArea"].AxisX.TitleFont = new System.Drawing.Font("Arial", 12, FontStyle.Bold);

            productsChart.ChartAreas["ChartArea"].AxisY.Title = "Cantidad Vendida";
            productsChart.ChartAreas["ChartArea"].AxisY.TitleFont = new System.Drawing.Font("Arial", 12, FontStyle.Bold);

            productsChart.ChartAreas["ChartArea"].AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 12);
            productsChart.ChartAreas["ChartArea"].AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 12);

            productsChart.Series["SalesData"].ChartType = SeriesChartType.Column;

            // Colores diferentes para cada barra
            Color[] colors = new Color[] { Color.Brown, Color.DodgerBlue, Color.Green, Color.Yellow, Color.Orange, Color.Purple, Color.Brown, Color.Gray, Color.Pink, Color.Teal };

            productsChart.Series["SalesData"]["PointWidth"] = "1.0"; // Ajusta el ancho de la barra
            productsChart.Series["SalesData"]["PixelPointWidth"] = "80"; // Ajusta el espaciado entre barras

            // Agregar datos al Chart
            foreach (var dataPoint in chartData)
            {
                var point = new DataPoint();
                point.SetValueY(dataPoint.QuantitySold);
                point.AxisLabel = dataPoint.ProductName;

                // Configuración para hacer negrita el texto de las etiquetas
                point.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);

                // Asignar color diferente a cada barra
                var colorIndex = chartData.ToList().IndexOf(dataPoint) % colors.Length;
                point.Color = colors[colorIndex];

                // Configuración para mostrar la cantidad encima de cada barra
                point.Label = $"{dataPoint.QuantitySold}";
                point.IsValueShownAsLabel = true;

                productsChart.Series["SalesData"].Points.Add(point);
            }
        }
    }
}
