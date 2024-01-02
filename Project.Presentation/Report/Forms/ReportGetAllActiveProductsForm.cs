using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Presentation.Report.Forms
{
    public partial class ReportGetAllActiveProductsForm : Form
    {
        public ReportGetAllActiveProductsForm()
        {
            InitializeComponent();
        }

        private async void ReportGetAllActiveProductsForm_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                // Cargar datos de manera asíncrona
                this.Invoke(new Action(() => this.getAllProductCategoriesTableAdapter.Fill(this.reportMasterDataSet.GetAllProductCategories)));
            });

            // Muestra el informe en formato "Diseño de impresión"
            this.reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            // Ajusta el tamaño de la página para el diseño de impresión
            this.reportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
        }
    }
}
