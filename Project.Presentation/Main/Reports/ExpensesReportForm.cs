using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Project.Business.Services;
using Project.Entity;

namespace Project.Presentation.Main.Reports
{
    public partial class ExpensesReportForm : Form
    {
        private readonly ExpeditureService expeditureService;
        private int colorIndex = 0;
        private Color[] colors = new Color[]
        {
            Color.FromArgb(255, 0, 47),
            Color.FromArgb(0, 91, 183),
            Color.FromArgb(255, 201, 0),
            Color.FromArgb(217, 61, 4),
            Color.FromArgb(171, 17, 3),
            Color.FromArgb(161, 0, 160),
            Color.Brown,
            Color.Gray,
            Color.Pink,
            Color.Teal
        };

        public ExpensesReportForm()
        {
            this.expeditureService = new ExpeditureService();
            InitializeComponent();

            ConfigureDonutChart();
            ConfigureExpenseChart();
        }

        private void ConfigureExpenseChart()
        {
            IEnumerable<SpendingByCategory> spendingData = expeditureService.GetTotalExpenditureByCategory();
            chart1.Series.Clear();

            Series series = new Series("Gastos por Categoría");
            series.ChartType = SeriesChartType.Column;

            foreach (var dataPoint in spendingData)
            {
                DataPoint point = new DataPoint();
                point.SetValueY((double)dataPoint.TotalExpenditure);
                point.AxisLabel = dataPoint.Category;
                point.Color = GetNextColor();
                series.Points.Add(point);
            }

            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.Title = "Categoría";
            chart1.ChartAreas[0].AxisY.Title = "Total Gastado";
            chart1.ChartAreas[0].RecalculateAxesScale();
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0]["PixelPointWidth"] = "30";
            chart1.Series[0].Points[0].LabelAngle = 90;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            foreach (var dataPoint in spendingData)
            {
                DataPoint matchingPoint = chart1.Series[0].Points.FirstOrDefault(p =>
                {
                    return Math.Abs(p.YValues[0] - (double)dataPoint.TotalExpenditure) < 0.001; // Comparación con tolerancia
                });

                if (matchingPoint != null)
                {
                    CustomLabel customLabel = new CustomLabel();
                    customLabel.FromPosition = matchingPoint.XValue - 0.5;
                    customLabel.ToPosition = matchingPoint.XValue + 0.5;
                    customLabel.Text = dataPoint.Category;
                    chart1.ChartAreas[0].AxisX.CustomLabels.Add(customLabel);
                }
            }
        }

        private void ConfigureDonutChart()
        {
            IEnumerable<SpendingByCategory> spendingData = expeditureService.GetTotalExpenditureByCategory();
            chart2.Series.Clear();

            Series series = new Series("Gastos por Categoría");
            series.ChartType = SeriesChartType.Doughnut;

            foreach (var dataPoint in spendingData)
            {
                decimal percentage = (dataPoint.TotalExpenditure / TotalExpenditure) * 100;

                DataPoint point = new DataPoint();
                point.SetValueY((double)percentage);
                point.AxisLabel = $"{dataPoint.Category}\n{percentage:F2}%";
                point.Color = GetNextColor();
                series.Points.Add(point);
            }

            chart2.Series.Add(series);

            chart2.Legends.Add("Legend");
            chart2.Legends["Legend"].Docking = Docking.Right;
            chart2.Series[0].IsValueShownAsLabel = true;
            chart2.Series[0]["PieLabelStyle"] = "Outside";
            chart2.Series[0]["DoughnutRadius"] = "60";

            colorIndex = 0;
        }

        private decimal TotalExpenditure
        {
            get
            {
                IEnumerable<SpendingByCategory> spendingData = expeditureService.GetTotalExpenditureByCategory();
                return spendingData.Sum(dataPoint => dataPoint.TotalExpenditure);
            }
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
