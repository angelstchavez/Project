namespace Project.Presentation.Main.Dashboard
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panelSide = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnSupplies = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCurrentUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBase = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.Label();
            this.btnSales = new System.Windows.Forms.Button();
            this.panelSide.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelSide.Controls.Add(this.buttonsPanel);
            this.panelSide.Controls.Add(this.panel2);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 35);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(170, 726);
            this.panelSide.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonsPanel.Controls.Add(this.btnConfig);
            this.buttonsPanel.Controls.Add(this.btnUsers);
            this.buttonsPanel.Controls.Add(this.btnReports);
            this.buttonsPanel.Controls.Add(this.btnCustomers);
            this.buttonsPanel.Controls.Add(this.btnProducts);
            this.buttonsPanel.Controls.Add(this.btnSupplies);
            this.buttonsPanel.Controls.Add(this.btnBills);
            this.buttonsPanel.Controls.Add(this.btnSales);
            this.buttonsPanel.Controls.Add(this.btnMakeOrder);
            this.buttonsPanel.Controls.Add(this.btnHome);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(170, 681);
            this.buttonsPanel.TabIndex = 1;
            // 
            // btnConfig
            // 
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.ForeColor = System.Drawing.Color.Silver;
            this.btnConfig.Image = global::Project.Presentation.Properties.Resources._24_config;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 360);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnConfig.Size = new System.Drawing.Size(170, 40);
            this.btnConfig.TabIndex = 9;
            this.btnConfig.Text = " Configuración";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.ForeColor = System.Drawing.Color.Silver;
            this.btnUsers.Image = global::Project.Presentation.Properties.Resources._24_users;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 320);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(170, 40);
            this.btnUsers.TabIndex = 8;
            this.btnUsers.Text = " Usuarios";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnReports
            // 
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.Silver;
            this.btnReports.Image = global::Project.Presentation.Properties.Resources._24_report;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 280);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(170, 40);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = " Reportes";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.ForeColor = System.Drawing.Color.Silver;
            this.btnCustomers.Image = global::Project.Presentation.Properties.Resources._24_customers;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(0, 240);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCustomers.Size = new System.Drawing.Size(170, 40);
            this.btnCustomers.TabIndex = 6;
            this.btnCustomers.Text = " Clientes";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.ForeColor = System.Drawing.Color.Silver;
            this.btnProducts.Image = global::Project.Presentation.Properties.Resources._24_products;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 200);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(170, 40);
            this.btnProducts.TabIndex = 5;
            this.btnProducts.Text = " Productos";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnSupplies
            // 
            this.btnSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupplies.FlatAppearance.BorderSize = 0;
            this.btnSupplies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSupplies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplies.ForeColor = System.Drawing.Color.Silver;
            this.btnSupplies.Image = global::Project.Presentation.Properties.Resources._24_suppliers;
            this.btnSupplies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplies.Location = new System.Drawing.Point(0, 160);
            this.btnSupplies.Name = "btnSupplies";
            this.btnSupplies.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSupplies.Size = new System.Drawing.Size(170, 40);
            this.btnSupplies.TabIndex = 4;
            this.btnSupplies.Text = " Insumos";
            this.btnSupplies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplies.UseVisualStyleBackColor = true;
            // 
            // btnBills
            // 
            this.btnBills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBills.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBills.FlatAppearance.BorderSize = 0;
            this.btnBills.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBills.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.ForeColor = System.Drawing.Color.Silver;
            this.btnBills.Image = global::Project.Presentation.Properties.Resources._24_bills;
            this.btnBills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBills.Location = new System.Drawing.Point(0, 120);
            this.btnBills.Name = "btnBills";
            this.btnBills.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnBills.Size = new System.Drawing.Size(170, 40);
            this.btnBills.TabIndex = 3;
            this.btnBills.Text = " Gastos";
            this.btnBills.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBills.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBills.UseVisualStyleBackColor = true;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMakeOrder.FlatAppearance.BorderSize = 0;
            this.btnMakeOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMakeOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnMakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeOrder.ForeColor = System.Drawing.Color.Silver;
            this.btnMakeOrder.Image = global::Project.Presentation.Properties.Resources._24_make_sales;
            this.btnMakeOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMakeOrder.Location = new System.Drawing.Point(0, 40);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnMakeOrder.Size = new System.Drawing.Size(170, 40);
            this.btnMakeOrder.TabIndex = 1;
            this.btnMakeOrder.Text = " Realizar pedido";
            this.btnMakeOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMakeOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Silver;
            this.btnHome.Image = global::Project.Presentation.Properties.Resources._24_home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(170, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = " Inicio";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.txtCurrentUser);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 681);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 45);
            this.panel2.TabIndex = 2;
            // 
            // txtCurrentUser
            // 
            this.txtCurrentUser.ForeColor = System.Drawing.Color.Silver;
            this.txtCurrentUser.Location = new System.Drawing.Point(3, 22);
            this.txtCurrentUser.Name = "txtCurrentUser";
            this.txtCurrentUser.Size = new System.Drawing.Size(161, 18);
            this.txtCurrentUser.TabIndex = 1;
            this.txtCurrentUser.Text = "Cargando...";
            this.txtCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(26, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario actual";
            // 
            // panelBase
            // 
            this.panelBase.BackColor = System.Drawing.Color.Gainsboro;
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(170, 35);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(814, 726);
            this.panelBase.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 35);
            this.panel1.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(6, 8);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(97, 19);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Cargando...";
            // 
            // btnSales
            // 
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.ForeColor = System.Drawing.Color.Silver;
            this.btnSales.Image = global::Project.Presentation.Properties.Resources._24_sales;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(0, 80);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSales.Size = new System.Drawing.Size(170, 40);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = " Ventas";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project";
            this.panelSide.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnSupplies;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtCurrentUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSales;
    }
}