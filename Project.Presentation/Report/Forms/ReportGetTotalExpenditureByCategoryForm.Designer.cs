﻿namespace Project.Presentation.Report.Forms
{
    partial class ReportGetTotalExpenditureByCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportGetTotalExpenditureByCategoryForm));
            this.getTotalExpenditureByCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportMasterDataSet = new Project.Presentation.Report.Data.ReportMasterDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getTotalExpenditureByCategoryTableAdapter = new Project.Presentation.Report.Data.ReportMasterDataSetTableAdapters.GetTotalExpenditureByCategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getTotalExpenditureByCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportMasterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // getTotalExpenditureByCategoryBindingSource
            // 
            this.getTotalExpenditureByCategoryBindingSource.DataMember = "GetTotalExpenditureByCategory";
            this.getTotalExpenditureByCategoryBindingSource.DataSource = this.reportMasterDataSet;
            // 
            // reportMasterDataSet
            // 
            this.reportMasterDataSet.DataSetName = "ReportMasterDataSet";
            this.reportMasterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.getTotalExpenditureByCategoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Project.Presentation.Report.Desings.ReportGetTotalExpenditureByCategory.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(761, 460);
            this.reportViewer1.TabIndex = 0;
            // 
            // getTotalExpenditureByCategoryTableAdapter
            // 
            this.getTotalExpenditureByCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // ReportGetTotalExpenditureByCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 460);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(761, 460);
            this.Name = "ReportGetTotalExpenditureByCategoryForm";
            this.Load += new System.EventHandler(this.ReportGetTotalExpenditureByCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getTotalExpenditureByCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportMasterDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Data.ReportMasterDataSet reportMasterDataSet;
        private System.Windows.Forms.BindingSource getTotalExpenditureByCategoryBindingSource;
        private Data.ReportMasterDataSetTableAdapters.GetTotalExpenditureByCategoryTableAdapter getTotalExpenditureByCategoryTableAdapter;
    }
}