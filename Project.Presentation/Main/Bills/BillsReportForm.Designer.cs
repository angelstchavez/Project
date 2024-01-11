namespace Project.Presentation.Main.Bills
{
    partial class BillsReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillsReportForm));
            this.btnGeneralReport = new System.Windows.Forms.Button();
            this.btnMonthReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBase = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnGeneralReport
            // 
            this.btnGeneralReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneralReport.FlatAppearance.BorderSize = 0;
            this.btnGeneralReport.Image = global::Project.Presentation.Properties.Resources._24_report;
            this.btnGeneralReport.Location = new System.Drawing.Point(11, 43);
            this.btnGeneralReport.Name = "btnGeneralReport";
            this.btnGeneralReport.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnGeneralReport.Size = new System.Drawing.Size(156, 40);
            this.btnGeneralReport.TabIndex = 12;
            this.btnGeneralReport.Text = "Reporte general";
            this.btnGeneralReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeneralReport.UseVisualStyleBackColor = true;
            this.btnGeneralReport.Click += new System.EventHandler(this.btnGeneralReport_Click);
            // 
            // btnMonthReport
            // 
            this.btnMonthReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonthReport.FlatAppearance.BorderSize = 0;
            this.btnMonthReport.Image = global::Project.Presentation.Properties.Resources._24_report;
            this.btnMonthReport.Location = new System.Drawing.Point(173, 43);
            this.btnMonthReport.Name = "btnMonthReport";
            this.btnMonthReport.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnMonthReport.Size = new System.Drawing.Size(162, 40);
            this.btnMonthReport.TabIndex = 13;
            this.btnMonthReport.Text = "Reporte mensual";
            this.btnMonthReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonthReport.UseVisualStyleBackColor = true;
            this.btnMonthReport.Click += new System.EventHandler(this.btnMonthReport_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Reporte de gastos por categoría";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBase
            // 
            this.panelBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBase.BackColor = System.Drawing.Color.White;
            this.panelBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBase.Location = new System.Drawing.Point(11, 89);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(761, 460);
            this.panelBase.TabIndex = 15;
            // 
            // BillsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMonthReport);
            this.Controls.Add(this.btnGeneralReport);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "BillsReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeneralReport;
        private System.Windows.Forms.Button btnMonthReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBase;
    }
}