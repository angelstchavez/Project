namespace Project.Presentation.Main.Sales
{
    partial class SaleDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleDetailForm));
            this.btnResalt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTotalNequi = new System.Windows.Forms.Label();
            this.labelTotalDaviplata = new System.Windows.Forms.Label();
            this.labelTotalCash = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDate = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResalt
            // 
            this.btnResalt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResalt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResalt.FlatAppearance.BorderSize = 0;
            this.btnResalt.Image = global::Project.Presentation.Properties.Resources._24_correct;
            this.btnResalt.Location = new System.Drawing.Point(900, 12);
            this.btnResalt.Name = "btnResalt";
            this.btnResalt.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnResalt.Size = new System.Drawing.Size(40, 40);
            this.btnResalt.TabIndex = 39;
            this.btnResalt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResalt.UseVisualStyleBackColor = true;
            this.btnResalt.Click += new System.EventHandler(this.btnResalt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Image = global::Project.Presentation.Properties.Resources._24_clear;
            this.btnClear.Location = new System.Drawing.Point(946, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 38;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelTotalNequi);
            this.panel1.Controls.Add(this.labelTotalDaviplata);
            this.panel1.Controls.Add(this.labelTotalCash);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(654, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 204);
            this.panel1.TabIndex = 37;
            // 
            // labelTotalNequi
            // 
            this.labelTotalNequi.Font = new System.Drawing.Font("Arial", 14F);
            this.labelTotalNequi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTotalNequi.Location = new System.Drawing.Point(62, 174);
            this.labelTotalNequi.Name = "labelTotalNequi";
            this.labelTotalNequi.Size = new System.Drawing.Size(263, 22);
            this.labelTotalNequi.TabIndex = 38;
            this.labelTotalNequi.Text = "Efectivo:";
            this.labelTotalNequi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalDaviplata
            // 
            this.labelTotalDaviplata.Font = new System.Drawing.Font("Arial", 14F);
            this.labelTotalDaviplata.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTotalDaviplata.Location = new System.Drawing.Point(81, 130);
            this.labelTotalDaviplata.Name = "labelTotalDaviplata";
            this.labelTotalDaviplata.Size = new System.Drawing.Size(244, 22);
            this.labelTotalDaviplata.TabIndex = 37;
            this.labelTotalDaviplata.Text = "Efectivo:";
            this.labelTotalDaviplata.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalCash
            // 
            this.labelTotalCash.Font = new System.Drawing.Font("Arial", 14F);
            this.labelTotalCash.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTotalCash.Location = new System.Drawing.Point(77, 89);
            this.labelTotalCash.Name = "labelTotalCash";
            this.labelTotalCash.Size = new System.Drawing.Size(248, 22);
            this.labelTotalCash.TabIndex = 36;
            this.labelTotalCash.Text = "Efectivo:";
            this.labelTotalCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Nequi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Daviplata:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Efectivo:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.totalSalesLabel);
            this.panel3.Location = new System.Drawing.Point(4, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 46);
            this.panel3.TabIndex = 32;
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.BackColor = System.Drawing.Color.Green;
            this.totalSalesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalSalesLabel.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.totalSalesLabel.ForeColor = System.Drawing.Color.White;
            this.totalSalesLabel.Location = new System.Drawing.Point(0, 0);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(319, 42);
            this.totalSalesLabel.TabIndex = 30;
            this.totalSalesLabel.Text = "...";
            this.totalSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 30);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalles del día";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(6, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 40);
            this.label2.TabIndex = 36;
            this.label2.Text = "Productos vendidos en el día";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.dataGridViewTextBoxColumn8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 392);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProducts.RowHeadersWidth = 25;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(636, 161);
            this.dataGridViewProducts.TabIndex = 35;
            this.dataGridViewProducts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewProducts_CellFormatting);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad vendida";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Total";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.labelDate.Location = new System.Drawing.Point(6, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(822, 40);
            this.labelDate.TabIndex = 34;
            this.labelDate.Text = "Ventas del día";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.Image = global::Project.Presentation.Properties.Resources._24_report;
            this.btnReport.Location = new System.Drawing.Point(828, 559);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(158, 40);
            this.btnReport.TabIndex = 33;
            this.btnReport.Text = "Generar reporte";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Contador,
            this.Cliente,
            this.Direccion,
            this.Barrio,
            this.Domicilio,
            this.Pago,
            this.TotalAmount,
            this.Total});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.Location = new System.Drawing.Point(12, 58);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.RowHeadersWidth = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(974, 285);
            this.dataGridView.TabIndex = 31;
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Contador
            // 
            this.Contador.FillWeight = 35.53299F;
            this.Contador.HeaderText = "N°";
            this.Contador.Name = "Contador";
            this.Contador.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.FillWeight = 110.7445F;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.FillWeight = 110.7445F;
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Barrio
            // 
            this.Barrio.FillWeight = 110.7445F;
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            // 
            // Domicilio
            // 
            this.Domicilio.FillWeight = 110.7445F;
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            // 
            // Pago
            // 
            this.Pago.FillWeight = 110.7445F;
            this.Pago.HeaderText = "Medio de pago";
            this.Pago.Name = "Pago";
            this.Pago.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "TotalAmount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.Visible = false;
            // 
            // Total
            // 
            this.Total.FillWeight = 110.7445F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // SaleDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 611);
            this.Controls.Add(this.btnResalt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1014, 650);
            this.Name = "SaleDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de venta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResalt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTotalNequi;
        private System.Windows.Forms.Label labelTotalDaviplata;
        private System.Windows.Forms.Label labelTotalCash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}