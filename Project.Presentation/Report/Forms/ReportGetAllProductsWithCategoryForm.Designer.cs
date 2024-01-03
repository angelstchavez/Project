namespace Project.Presentation.Report.Forms
{
    partial class ReportGetAllProductsWithCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportGetAllProductsWithCategoryForm));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportMasterDataSet = new Project.Presentation.Report.Data.ReportMasterDataSet();
            this.getAllProductsWithCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAllProductsWithCategoryTableAdapter = new Project.Presentation.Report.Data.ReportMasterDataSetTableAdapters.GetAllProductsWithCategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportMasterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllProductsWithCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getAllProductsWithCategoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Project.Presentation.Report.Desings.ReportGetAllProductsWithCategory.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(784, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportMasterDataSet
            // 
            this.reportMasterDataSet.DataSetName = "ReportMasterDataSet";
            this.reportMasterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getAllProductsWithCategoryBindingSource
            // 
            this.getAllProductsWithCategoryBindingSource.DataMember = "GetAllProductsWithCategory";
            this.getAllProductsWithCategoryBindingSource.DataSource = this.reportMasterDataSet;
            // 
            // getAllProductsWithCategoryTableAdapter
            // 
            this.getAllProductsWithCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // ReportGetAllProductsWithCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportGetAllProductsWithCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportGetAllProductsWithCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportMasterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllProductsWithCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Data.ReportMasterDataSet reportMasterDataSet;
        private System.Windows.Forms.BindingSource getAllProductsWithCategoryBindingSource;
        private Data.ReportMasterDataSetTableAdapters.GetAllProductsWithCategoryTableAdapter getAllProductsWithCategoryTableAdapter;
    }
}