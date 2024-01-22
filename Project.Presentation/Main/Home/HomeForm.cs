using Project.Business.Services;
using Project.Entity;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project.Presentation.Main.Home
{
    public partial class HomeForm : Form
    {
        private readonly CustomerService customerService;
        private readonly ExpeditureService expenditureService;
        private readonly SaleService saleService;
        private int colorIndex = 0;

        // Colores diferentes para cada barra
        private Color[] colors = new Color[]
        {
            Color.FromArgb(255, 0, 47),
            Color.FromArgb(0, 91, 183),
            Color.FromArgb(255, 201 ,0),
            Color.FromArgb(217, 61, 4),
            Color.FromArgb(171, 17, 3),
            Color.FromArgb(161, 0, 160),
            Color.Brown,
            Color.Gray,
            Color.Pink,
            Color.Teal
        };

        public HomeForm()
        {
            this.customerService = new CustomerService();
            this.expenditureService = new ExpeditureService();
            this.saleService = new SaleService();

            InitializeComponent();
            LoadQuantities();
            LoadChart();
        }

        private void LoadQuantities()
        {
            labelCustomers.Text = customerService.GetTotalCustomerCount().ToString();
            labelSales.Text = saleService.GetTotalSalesAmount().ToString("C");
            labelExpeditures.Text = expenditureService.GetTotalExpenditureAmount().ToString("C");
            labelOrders.Text = saleService.GetSaleCount().ToString();
            labelTotalSalesToday.Text = saleService.GetTotalSalesAmountForToday().ToString("C");
            labelCustomerCountToday.Text = customerService.GetCustomerCountForToday().ToString();
            labelSalesCountToday.Text = saleService.GetSalesCountForToday().ToString();
            labelTotalExpensesToday.Text = expenditureService.GetTotalExpendituresForToday().ToString("C");
        }

        private void LoadChart()
        {
            var productService = new ProductService();
            var chartData = productService.GetProductSales();

            ConfigureChart(productsChart, "SalesData");
            ConfigureChart(donutChart, "PercentageData");

            var chartDataList = chartData.ToList();

            foreach (var dataPoint in chartDataList)
            {
                var point = CreateDataPoint(dataPoint);
                productsChart.Series["SalesData"].Points.Add(point);
            }

            colorIndex = 0;

            var percentages = CalculatePercentages(chartDataList);

            var labels = new List<string>();  // Lista para almacenar las etiquetas

            for (int i = 0; i < chartDataList.Count; i++)
            {
                var dataPoint = chartDataList[i];
                var percentage = percentages[i];

                var point = new DataPoint
                {
                    AxisLabel = dataPoint.ProductName,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Color = GetNextColor(),
                    Label = $"{percentage:F2}%",  // Mostrar porcentaje en el formato adecuado
                    IsValueShownAsLabel = true,
                };

                labels.Add(dataPoint.ProductName);  // Agregar etiqueta a la lista

                point.SetValueY(percentage);
                donutChart.Series["PercentageData"].Points.Add(point);
            }

            // Agregar etiquetas a las leyendas
            for (int i = 0; i < labels.Count; i++)
            {
                donutChart.Series["PercentageData"].Points[i].LegendText = labels[i];
            }

            colorIndex = 0;
        }

        private List<double> CalculatePercentages(List<ProductSale> chartData)
        {
            double totalQuantitySold = chartData.Sum(d => d.QuantitySold);
            return chartData.Select(dataPoint => (dataPoint.QuantitySold / totalQuantitySold) * 100).ToList();
        }


        private void ConfigureChart(Chart chart, string seriesName)
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();

            chart.ChartAreas.Add("ChartArea");
            chart.Series.Add(seriesName);

            // Configuración adicional para quitar la cuadrícula de fondo
            chart.ChartAreas["ChartArea"].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas["ChartArea"].AxisY.MajorGrid.Enabled = false;

            // Configuración para el estilo de las etiquetas del eje X e Y
            chart.ChartAreas["ChartArea"].AxisX.Title = "Productos vendidos";
            chart.ChartAreas["ChartArea"].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            chart.ChartAreas["ChartArea"].AxisY.Title = "Cantidad Vendida";
            chart.ChartAreas["ChartArea"].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            chart.ChartAreas["ChartArea"].AxisX.LabelStyle.Font = new Font("Arial", 12);
            chart.ChartAreas["ChartArea"].AxisY.LabelStyle.Font = new Font("Arial", 12);

            // Configuración específica para el Chart de dona (doughnut)
            if (seriesName == "PercentageData")
            {
                chart.Series["PercentageData"].ChartType = SeriesChartType.Doughnut;
                chart.Series["PercentageData"].IsValueShownAsLabel = true;
                chart.Series["PercentageData"]["DoughnutRadius"] = "70"; // Ajusta según tus necesidades
                chart.Series["PercentageData"]["DoughnutInnerRadius"] = "40"; // Ajusta según tus necesidades
            }
            else
            {
                chart.Series[seriesName].ChartType = SeriesChartType.Column;
            }

            chart.Series[seriesName]["PointWidth"] = "1.0"; // Ajusta el ancho de la barra
            chart.Series[seriesName]["PixelPointWidth"] = "80"; // Ajusta el espaciado entre barras
        }

        private DataPoint CreateDataPoint(ProductSale dataPoint)
        {
            var point = new DataPoint
            {
                AxisLabel = dataPoint.ProductName,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Color = GetNextColor(),
                Label = $"{dataPoint.QuantitySold}",
                IsValueShownAsLabel = true,
            };

            // Asignar valor Y al punto
            point.SetValueY(dataPoint.QuantitySold);

            return point;
        }

        private Color GetNextColor()
        {
            if (colorIndex >= colors.Length)
            {
                colorIndex = 0;
            }
            return colors[colorIndex++];
        }
    }
}
