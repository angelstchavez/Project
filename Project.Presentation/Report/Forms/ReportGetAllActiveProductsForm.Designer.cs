namespace Project.Presentation.Report.Forms
{
    partial class ReportGetAllActiveProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportGetAllActiveProductsForm));
            this.getAllProductCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportMasterDataSet = new Project.Presentation.Report.Data.ReportMasterDataSet();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getAllProductCategoriesTableAdapter = new Project.Presentation.Report.Data.ReportMasterDataSetTableAdapters.GetAllProductCategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getAllProductCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportMasterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // getAllProductCategoriesBindingSource
            // 
            this.getAllProductCategoriesBindingSource.DataMember = "GetAllProductCategories";
            this.getAllProductCategoriesBindingSource.DataSource = this.reportMasterDataSet;
            // 
            // reportMasterDataSet
            // 
            this.reportMasterDataSet.DataSetName = "ReportMasterDataSet";
            this.reportMasterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            this.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.getAllProductCategoriesBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Project.Presentation.Report.Desings.ReportGetAllActiveProducts.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(784, 561);
            this.reportViewer.TabIndex = 0;
            // 
            // getAllProductCategoriesTableAdapter
            // 
            this.getAllProductCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // ReportGetAllActiveProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewer);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ReportGetAllActiveProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportGetAllActiveProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getAllProductCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportMasterDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Data.ReportMasterDataSet reportMasterDataSet;
        private System.Windows.Forms.BindingSource getAllProductCategoriesBindingSource;
        private Data.ReportMasterDataSetTableAdapters.GetAllProductCategoriesTableAdapter getAllProductCategoriesTableAdapter;
    }
}