namespace Project.Presentation.Main.Sales
{
    partial class SaleControlForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCategories = new System.Windows.Forms.Panel();
            this.flowCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCatTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.flowProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelShoppingCart = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAmount = new System.Windows.Forms.Panel();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.panelSaleDetail = new System.Windows.Forms.Panel();
            this.checkBoxToDiscount = new System.Windows.Forms.CheckBox();
            this.txtToDiscount = new System.Windows.Forms.TextBox();
            this.comboBoxTransportationCompany = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreateSale = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.radioButtonNequi = new System.Windows.Forms.RadioButton();
            this.radioButtonDaviplata = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddressCustomer = new System.Windows.Forms.TextBox();
            this.comboBoxCommune = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxNeighborhood = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClearCustomer = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCategories.SuspendLayout();
            this.panelCatTitle.SuspendLayout();
            this.panelProducts.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelShoppingCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelAmount.SuspendLayout();
            this.panelSaleDetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCategories
            // 
            this.panelCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelCategories.BackColor = System.Drawing.Color.White;
            this.panelCategories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCategories.Controls.Add(this.flowCategories);
            this.panelCategories.Controls.Add(this.panelCatTitle);
            this.panelCategories.Location = new System.Drawing.Point(12, 436);
            this.panelCategories.Name = "panelCategories";
            this.panelCategories.Size = new System.Drawing.Size(492, 278);
            this.panelCategories.TabIndex = 0;
            // 
            // flowCategories
            // 
            this.flowCategories.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCategories.Location = new System.Drawing.Point(0, 30);
            this.flowCategories.Name = "flowCategories";
            this.flowCategories.Size = new System.Drawing.Size(488, 244);
            this.flowCategories.TabIndex = 2;
            // 
            // panelCatTitle
            // 
            this.panelCatTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelCatTitle.Controls.Add(this.label1);
            this.panelCatTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCatTitle.Location = new System.Drawing.Point(0, 0);
            this.panelCatTitle.Name = "panelCatTitle";
            this.panelCatTitle.Size = new System.Drawing.Size(488, 30);
            this.panelCatTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorias de productos disponibles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelProducts
            // 
            this.panelProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProducts.BackColor = System.Drawing.Color.White;
            this.panelProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelProducts.Controls.Add(this.flowProducts);
            this.panelProducts.Controls.Add(this.panel1);
            this.panelProducts.Location = new System.Drawing.Point(510, 436);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(492, 278);
            this.panelProducts.TabIndex = 1;
            // 
            // flowProducts
            // 
            this.flowProducts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowProducts.Location = new System.Drawing.Point(0, 30);
            this.flowProducts.Name = "flowProducts";
            this.flowProducts.Size = new System.Drawing.Size(488, 244);
            this.flowProducts.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 30);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Productos disponibles";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelShoppingCart
            // 
            this.panelShoppingCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelShoppingCart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelShoppingCart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelShoppingCart.Controls.Add(this.dataGridView);
            this.panelShoppingCart.Controls.Add(this.panel2);
            this.panelShoppingCart.Location = new System.Drawing.Point(12, 12);
            this.panelShoppingCart.Name = "panelShoppingCart";
            this.panelShoppingCart.Size = new System.Drawing.Size(579, 419);
            this.panelShoppingCart.TabIndex = 1;
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
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.Total,
            this.TotalReal,
            this.Eliminar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.Location = new System.Drawing.Point(3, 36);
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
            this.dataGridView.Size = new System.Drawing.Size(569, 374);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Producto
            // 
            this.Producto.FillWeight = 162.4365F;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.FillWeight = 85.93887F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.FillWeight = 85.93887F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // TotalReal
            // 
            this.TotalReal.HeaderText = "TotalReal";
            this.TotalReal.Name = "TotalReal";
            this.TotalReal.ReadOnly = true;
            this.TotalReal.Visible = false;
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 65.68576F;
            this.Eliminar.HeaderText = "Acción";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 30);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(575, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carrito de compras";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAmount
            // 
            this.panelAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAmount.BackColor = System.Drawing.Color.Orange;
            this.panelAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAmount.Controls.Add(this.labelTotalAmount);
            this.panelAmount.Location = new System.Drawing.Point(597, 12);
            this.panelAmount.Name = "panelAmount";
            this.panelAmount.Size = new System.Drawing.Size(405, 50);
            this.panelAmount.TabIndex = 2;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.BackColor = System.Drawing.Color.Green;
            this.labelTotalAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalAmount.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.labelTotalAmount.ForeColor = System.Drawing.Color.White;
            this.labelTotalAmount.Location = new System.Drawing.Point(0, 0);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(401, 46);
            this.labelTotalAmount.TabIndex = 0;
            this.labelTotalAmount.Text = "$ 0,00";
            this.labelTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSaleDetail
            // 
            this.panelSaleDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSaleDetail.BackColor = System.Drawing.Color.White;
            this.panelSaleDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSaleDetail.Controls.Add(this.checkBoxToDiscount);
            this.panelSaleDetail.Controls.Add(this.txtToDiscount);
            this.panelSaleDetail.Controls.Add(this.comboBoxTransportationCompany);
            this.panelSaleDetail.Controls.Add(this.btnClear);
            this.panelSaleDetail.Controls.Add(this.btnCreateSale);
            this.panelSaleDetail.Controls.Add(this.label10);
            this.panelSaleDetail.Controls.Add(this.groupBox1);
            this.panelSaleDetail.Controls.Add(this.label9);
            this.panelSaleDetail.Controls.Add(this.txtAddressCustomer);
            this.panelSaleDetail.Controls.Add(this.comboBoxCommune);
            this.panelSaleDetail.Controls.Add(this.label8);
            this.panelSaleDetail.Controls.Add(this.comboBoxNeighborhood);
            this.panelSaleDetail.Controls.Add(this.label7);
            this.panelSaleDetail.Controls.Add(this.btnClearCustomer);
            this.panelSaleDetail.Controls.Add(this.btnSearchCustomer);
            this.panelSaleDetail.Controls.Add(this.label5);
            this.panelSaleDetail.Controls.Add(this.txtCustomerPhone);
            this.panelSaleDetail.Controls.Add(this.txtCustomerName);
            this.panelSaleDetail.Controls.Add(this.label6);
            this.panelSaleDetail.Controls.Add(this.panel3);
            this.panelSaleDetail.Location = new System.Drawing.Point(597, 68);
            this.panelSaleDetail.Name = "panelSaleDetail";
            this.panelSaleDetail.Size = new System.Drawing.Size(405, 363);
            this.panelSaleDetail.TabIndex = 3;
            // 
            // checkBoxToDiscount
            // 
            this.checkBoxToDiscount.AutoSize = true;
            this.checkBoxToDiscount.Location = new System.Drawing.Point(7, 325);
            this.checkBoxToDiscount.Name = "checkBoxToDiscount";
            this.checkBoxToDiscount.Size = new System.Drawing.Size(99, 22);
            this.checkBoxToDiscount.TabIndex = 57;
            this.checkBoxToDiscount.Text = "Descontar";
            this.checkBoxToDiscount.UseVisualStyleBackColor = true;
            this.checkBoxToDiscount.CheckedChanged += new System.EventHandler(this.checkBoxToDiscount_CheckedChanged);
            // 
            // txtToDiscount
            // 
            this.txtToDiscount.Enabled = false;
            this.txtToDiscount.Location = new System.Drawing.Point(107, 322);
            this.txtToDiscount.Name = "txtToDiscount";
            this.txtToDiscount.Size = new System.Drawing.Size(90, 26);
            this.txtToDiscount.TabIndex = 56;
            // 
            // comboBoxTransportationCompany
            // 
            this.comboBoxTransportationCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransportationCompany.FormattingEnabled = true;
            this.comboBoxTransportationCompany.Location = new System.Drawing.Point(7, 289);
            this.comboBoxTransportationCompany.Name = "comboBoxTransportationCompany";
            this.comboBoxTransportationCompany.Size = new System.Drawing.Size(190, 26);
            this.comboBoxTransportationCompany.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(203, 314);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(193, 40);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Cancelar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreateSale
            // 
            this.btnCreateSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCreateSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateSale.FlatAppearance.BorderSize = 0;
            this.btnCreateSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateSale.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSale.ForeColor = System.Drawing.Color.White;
            this.btnCreateSale.Location = new System.Drawing.Point(203, 268);
            this.btnCreateSale.Name = "btnCreateSale";
            this.btnCreateSale.Size = new System.Drawing.Size(193, 40);
            this.btnCreateSale.TabIndex = 8;
            this.btnCreateSale.Text = "Registrar venta";
            this.btnCreateSale.UseVisualStyleBackColor = false;
            this.btnCreateSale.Click += new System.EventHandler(this.btnCreateSale_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label10.Location = new System.Drawing.Point(4, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 18);
            this.label10.TabIndex = 52;
            this.label10.Text = "Domicilio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCash);
            this.groupBox1.Controls.Add(this.radioButtonNequi);
            this.groupBox1.Controls.Add(this.radioButtonDaviplata);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.groupBox1.Location = new System.Drawing.Point(7, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 54);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medio de pago";
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.ForeColor = System.Drawing.Color.Black;
            this.radioButtonCash.Location = new System.Drawing.Point(68, 21);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(82, 22);
            this.radioButtonCash.TabIndex = 6;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Efectivo";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            // 
            // radioButtonNequi
            // 
            this.radioButtonNequi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonNequi.AutoSize = true;
            this.radioButtonNequi.ForeColor = System.Drawing.Color.Black;
            this.radioButtonNequi.Location = new System.Drawing.Point(254, 21);
            this.radioButtonNequi.Name = "radioButtonNequi";
            this.radioButtonNequi.Size = new System.Drawing.Size(67, 22);
            this.radioButtonNequi.TabIndex = 49;
            this.radioButtonNequi.TabStop = true;
            this.radioButtonNequi.Text = "Nequi";
            this.radioButtonNequi.UseVisualStyleBackColor = true;
            // 
            // radioButtonDaviplata
            // 
            this.radioButtonDaviplata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDaviplata.AutoSize = true;
            this.radioButtonDaviplata.ForeColor = System.Drawing.Color.Black;
            this.radioButtonDaviplata.Location = new System.Drawing.Point(156, 21);
            this.radioButtonDaviplata.Name = "radioButtonDaviplata";
            this.radioButtonDaviplata.Size = new System.Drawing.Size(92, 22);
            this.radioButtonDaviplata.TabIndex = 48;
            this.radioButtonDaviplata.TabStop = true;
            this.radioButtonDaviplata.Text = "Daviplata";
            this.radioButtonDaviplata.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(4, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 44;
            this.label9.Text = "Dirección:";
            // 
            // txtAddressCustomer
            // 
            this.txtAddressCustomer.Location = new System.Drawing.Point(7, 172);
            this.txtAddressCustomer.Name = "txtAddressCustomer";
            this.txtAddressCustomer.Size = new System.Drawing.Size(389, 26);
            this.txtAddressCustomer.TabIndex = 5;
            // 
            // comboBoxCommune
            // 
            this.comboBoxCommune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCommune.FormattingEnabled = true;
            this.comboBoxCommune.Location = new System.Drawing.Point(7, 116);
            this.comboBoxCommune.Name = "comboBoxCommune";
            this.comboBoxCommune.Size = new System.Drawing.Size(67, 26);
            this.comboBoxCommune.TabIndex = 3;
            this.comboBoxCommune.SelectedIndexChanged += new System.EventHandler(this.comboBoxCommune_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(4, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 41;
            this.label8.Text = "Comuna:";
            // 
            // comboBoxNeighborhood
            // 
            this.comboBoxNeighborhood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNeighborhood.FormattingEnabled = true;
            this.comboBoxNeighborhood.Location = new System.Drawing.Point(80, 116);
            this.comboBoxNeighborhood.Name = "comboBoxNeighborhood";
            this.comboBoxNeighborhood.Size = new System.Drawing.Size(316, 26);
            this.comboBoxNeighborhood.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(77, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "Barrio:";
            // 
            // btnClearCustomer
            // 
            this.btnClearCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearCustomer.Image = global::Project.Presentation.Properties.Resources._16_basura;
            this.btnClearCustomer.Location = new System.Drawing.Point(366, 58);
            this.btnClearCustomer.Name = "btnClearCustomer";
            this.btnClearCustomer.Size = new System.Drawing.Size(30, 30);
            this.btnClearCustomer.TabIndex = 30;
            this.btnClearCustomer.UseVisualStyleBackColor = true;
            this.btnClearCustomer.Click += new System.EventHandler(this.btnClearCustomer_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCustomer.Image = global::Project.Presentation.Properties.Resources._16_lupa;
            this.btnSearchCustomer.Location = new System.Drawing.Point(333, 58);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(30, 30);
            this.btnSearchCustomer.TabIndex = 29;
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(200, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Teléfono:";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(203, 60);
            this.txtCustomerPhone.MaxLength = 10;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(125, 26);
            this.txtCustomerPhone.TabIndex = 2;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(7, 60);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(190, 26);
            this.txtCustomerName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(6, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nombre del cliente:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 30);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Detalles de la venta";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaleControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 726);
            this.Controls.Add(this.panelSaleDetail);
            this.Controls.Add(this.panelAmount);
            this.Controls.Add(this.panelShoppingCart);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panelCategories);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaleControlForm";
            this.Text = "SaleControlForm";
            this.panelCategories.ResumeLayout(false);
            this.panelCatTitle.ResumeLayout(false);
            this.panelProducts.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelShoppingCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelAmount.ResumeLayout(false);
            this.panelSaleDetail.ResumeLayout(false);
            this.panelSaleDetail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCategories;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Panel panelShoppingCart;
        private System.Windows.Forms.Panel panelAmount;
        private System.Windows.Forms.Panel panelSaleDetail;
        private System.Windows.Forms.Panel panelCatTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCommune;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxNeighborhood;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddressCustomer;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.RadioButton radioButtonDaviplata;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNequi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreateSale;
        private System.Windows.Forms.ComboBox comboBoxTransportationCompany;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.TextBox txtToDiscount;
        private System.Windows.Forms.CheckBox checkBoxToDiscount;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.FlowLayoutPanel flowCategories;
        private System.Windows.Forms.FlowLayoutPanel flowProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalReal;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}