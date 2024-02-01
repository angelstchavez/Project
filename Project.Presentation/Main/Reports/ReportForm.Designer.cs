namespace Project.Presentation.Main.Reports
{
    partial class ReportForm
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
            this.btnSales = new System.Windows.Forms.Button();
            this.btnExpenditures = new System.Windows.Forms.Button();
            this.btnInsumos = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.panelBase = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSales
            // 
            this.btnSales.Image = global::Project.Presentation.Properties.Resources._24_make_sales;
            this.btnSales.Location = new System.Drawing.Point(12, 12);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSales.Size = new System.Drawing.Size(92, 40);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "Ventas";
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnExpenditures
            // 
            this.btnExpenditures.Image = global::Project.Presentation.Properties.Resources._24_bills;
            this.btnExpenditures.Location = new System.Drawing.Point(110, 12);
            this.btnExpenditures.Name = "btnExpenditures";
            this.btnExpenditures.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnExpenditures.Size = new System.Drawing.Size(95, 40);
            this.btnExpenditures.TabIndex = 1;
            this.btnExpenditures.Text = "Gastos";
            this.btnExpenditures.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExpenditures.UseVisualStyleBackColor = true;
            this.btnExpenditures.Click += new System.EventHandler(this.btnExpenditures_Click);
            // 
            // btnInsumos
            // 
            this.btnInsumos.Image = global::Project.Presentation.Properties.Resources._24_suppliers;
            this.btnInsumos.Location = new System.Drawing.Point(211, 12);
            this.btnInsumos.Name = "btnInsumos";
            this.btnInsumos.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnInsumos.Size = new System.Drawing.Size(100, 40);
            this.btnInsumos.TabIndex = 3;
            this.btnInsumos.Text = "Insumos";
            this.btnInsumos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsumos.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.Image = global::Project.Presentation.Properties.Resources._24_products;
            this.btnProducts.Location = new System.Drawing.Point(317, 12);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnProducts.Size = new System.Drawing.Size(114, 40);
            this.btnProducts.TabIndex = 4;
            this.btnProducts.Text = "Productos";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Image = global::Project.Presentation.Properties.Resources._24_customers;
            this.btnCustomers.Location = new System.Drawing.Point(437, 12);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCustomers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCustomers.Size = new System.Drawing.Size(102, 40);
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.Text = "Clientes";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomers.UseVisualStyleBackColor = true;
            // 
            // panelBase
            // 
            this.panelBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBase.BackColor = System.Drawing.Color.White;
            this.panelBase.Location = new System.Drawing.Point(12, 58);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(990, 656);
            this.panelBase.TabIndex = 6;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 726);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnInsumos);
            this.Controls.Add(this.btnExpenditures);
            this.Controls.Add(this.btnSales);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnExpenditures;
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Panel panelBase;
    }
}