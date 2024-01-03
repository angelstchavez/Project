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
                this.Invoke(new Action(() => this.getAllActiveProductCategoryTableAdapter.Fill(this.reportMasterDataSet.GetAllActiveProductCategory)));
            });

            // Muestra el informe en formato "Diseño de impresión"
            this.reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            // Ajusta el tamaño de la página para el diseño de impresión
            this.reportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;

            // Establece el zoom al 150%
            this.reportViewer.ZoomPercent = 150;

            // Refresca el informe después de aplicar cambios
            this.reportViewer.RefreshReport();
        }
    }
}
