﻿using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Presentation.Report.Forms
{
    public partial class ReportGetTotalExpenditureByCategoryForm : Form
    {
        public ReportGetTotalExpenditureByCategoryForm()
        {
            InitializeComponent();
        }

        private async  void ReportGetTotalExpenditureByCategoryForm_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                // Cargar datos de manera asíncrona
                this.Invoke(new Action(() => this.getTotalExpenditureByCategoryTableAdapter.Fill(this.reportMasterDataSet.GetTotalExpenditureByCategory)));
            });

            // Muestra el informe en formato "Diseño de impresión"
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            // Ajusta el tamaño de la página para el diseño de impresión
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;

            // Establece el zoom al 150%
            this.reportViewer1.ZoomPercent = 100;

            // Refresca el informe después de aplicar cambios
            this.reportViewer1.RefreshReport();
        }
    }
}
