namespace Project.Presentation.Main.Products
{
    partial class ProductManagerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReportCategory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnProductReport = new System.Windows.Forms.Button();
            this.banelBase = new System.Windows.Forms.Panel();
            this.flowProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtProductCount = new System.Windows.Forms.Label();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAllProductReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.banelBase.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowCategories);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 726);
            this.panel1.TabIndex = 0;
            // 
            // flowCategories
            // 
            this.flowCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.flowCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCategories.Location = new System.Drawing.Point(0, 120);
            this.flowCategories.Name = "flowCategories";
            this.flowCategories.Size = new System.Drawing.Size(170, 546);
            this.flowCategories.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel3.Controls.Add(this.btnReportCategory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 666);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 60);
            this.panel3.TabIndex = 1;
            // 
            // btnReportCategory
            // 
            this.btnReportCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportCategory.Location = new System.Drawing.Point(10, 8);
            this.btnReportCategory.Name = "btnReportCategory";
            this.btnReportCategory.Size = new System.Drawing.Size(150, 40);
            this.btnReportCategory.TabIndex = 3;
            this.btnReportCategory.Text = "Reporte de cat.";
            this.btnReportCategory.UseVisualStyleBackColor = true;
            this.btnReportCategory.Click += new System.EventHandler(this.btnReportCategory_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 120);
            this.panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(7, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(10, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar categoría";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel5.Controls.Add(this.btnAllProductReport);
            this.panel5.Controls.Add(this.btnProductReport);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(170, 666);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(644, 60);
            this.panel5.TabIndex = 4;
            // 
            // btnProductReport
            // 
            this.btnProductReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductReport.Location = new System.Drawing.Point(463, 8);
            this.btnProductReport.Name = "btnProductReport";
            this.btnProductReport.Size = new System.Drawing.Size(169, 40);
            this.btnProductReport.TabIndex = 4;
            this.btnProductReport.Text = "Reporte de productos";
            this.btnProductReport.UseVisualStyleBackColor = true;
            // 
            // banelBase
            // 
            this.banelBase.Controls.Add(this.flowProducts);
            this.banelBase.Controls.Add(this.panel4);
            this.banelBase.Controls.Add(this.panel6);
            this.banelBase.Location = new System.Drawing.Point(186, 12);
            this.banelBase.Name = "banelBase";
            this.banelBase.Size = new System.Drawing.Size(616, 340);
            this.banelBase.TabIndex = 6;
            this.banelBase.Visible = false;
            // 
            // flowProducts
            // 
            this.flowProducts.BackColor = System.Drawing.SystemColors.Control;
            this.flowProducts.Location = new System.Drawing.Point(16, 153);
            this.flowProducts.Name = "flowProducts";
            this.flowProducts.Size = new System.Drawing.Size(486, 117);
            this.flowProducts.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(616, 60);
            this.panel4.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(8, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Agregar producto";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.DimGray;
            this.textBox2.Location = new System.Drawing.Point(446, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 26);
            this.textBox2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(383, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Buscar:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel6.Controls.Add(this.txtProductCount);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(616, 30);
            this.panel6.TabIndex = 4;
            // 
            // txtProductCount
            // 
            this.txtProductCount.AutoSize = true;
            this.txtProductCount.ForeColor = System.Drawing.Color.Black;
            this.txtProductCount.Location = new System.Drawing.Point(5, 6);
            this.txtProductCount.Name = "txtProductCount";
            this.txtProductCount.Size = new System.Drawing.Size(290, 18);
            this.txtProductCount.TabIndex = 15;
            this.txtProductCount.Text = "Productos registrados en esta categoría:";
            // 
            // panelWelcome
            // 
            this.panelWelcome.Controls.Add(this.label3);
            this.panelWelcome.Location = new System.Drawing.Point(503, 558);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(299, 99);
            this.panelWelcome.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial", 16F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 99);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seleccione una categoría para empezar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAllProductReport
            // 
            this.btnAllProductReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAllProductReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllProductReport.Location = new System.Drawing.Point(288, 8);
            this.btnAllProductReport.Name = "btnAllProductReport";
            this.btnAllProductReport.Size = new System.Drawing.Size(169, 40);
            this.btnAllProductReport.TabIndex = 5;
            this.btnAllProductReport.Text = "Reporte de todos";
            this.btnAllProductReport.UseVisualStyleBackColor = true;
            // 
            // ProductManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 726);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.banelBase);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductManagerForm";
            this.Text = "ProductManagerForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.banelBase.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelWelcome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowCategories;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReportCategory;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnProductReport;
        private System.Windows.Forms.Panel banelBase;
        private System.Windows.Forms.FlowLayoutPanel flowProducts;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label txtProductCount;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAllProductReport;
    }
}