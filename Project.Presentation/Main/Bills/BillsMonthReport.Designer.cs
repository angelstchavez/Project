namespace Project.Presentation.Main.Bills
{
    partial class BillsMonthReport
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
            this.getMonthlyExpenditureByCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportMasterDataSet = new Project.Presentation.Report.Data.ReportMasterDataSet();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.btnDone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.getMonthlyExpenditureByCategoryTableAdapter = new Project.Presentation.Report.Data.ReportMasterDataSetTableAdapters.GetMonthlyExpenditureByCategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getMonthlyExpenditureByCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportMasterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.SuspendLayout();
            // 
            // getMonthlyExpenditureByCategoryBindingSource
            // 
            this.getMonthlyExpenditureByCategoryBindingSource.DataMember = "GetMonthlyExpenditureByCategory";
            this.getMonthlyExpenditureByCategoryBindingSource.DataSource = this.reportMasterDataSet;
            // 
            // reportMasterDataSet
            // 
            this.reportMasterDataSet.DataSetName = "ReportMasterDataSet";
            this.reportMasterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.comboBoxMonth.Location = new System.Drawing.Point(12, 37);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(143, 26);
            this.comboBoxMonth.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.getMonthlyExpenditureByCategoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Project.Presentation.Report.Desings.ReportGetMonthlyExpenditureByCategory.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(737, 379);
            this.reportViewer1.TabIndex = 1;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(161, 37);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(75, 26);
            this.numericUpDownYear.TabIndex = 2;
            this.numericUpDownYear.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.ForeColor = System.Drawing.Color.Black;
            this.btnDone.Location = new System.Drawing.Point(242, 16);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(97, 47);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Buscar";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mes:";
            // 
            // getMonthlyExpenditureByCategoryTableAdapter
            // 
            this.getMonthlyExpenditureByCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // BillsMonthReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.comboBoxMonth);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BillsMonthReport";
            this.Text = "BillsMonthReport";
            this.Load += new System.EventHandler(this.BillsMonthReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getMonthlyExpenditureByCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportMasterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMonth;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource getMonthlyExpenditureByCategoryBindingSource;
        private Report.Data.ReportMasterDataSet reportMasterDataSet;
        private Report.Data.ReportMasterDataSetTableAdapters.GetMonthlyExpenditureByCategoryTableAdapter getMonthlyExpenditureByCategoryTableAdapter;
    }
}