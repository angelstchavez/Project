using Project.Business.Services;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Project.Presentation.Main.Products
{
    public partial class ProductManagerForm : Form
    {
        private readonly ProductCategoryService productCategoryService;
        private readonly ProductService productService;
        private Panel selectedCategoryPanel;
        public static int productCategoryId;

        public ProductManagerForm()
        {
            productCategoryService = new ProductCategoryService();
            productService = new ProductService();
            InitializeComponent();
            DrawProductCategories();
            panelWelcome.Visible = true;
            panelWelcome.Dock = DockStyle.Fill;
        }

        #region Functions

        private void DrawProductCategories()
        {
            try
            {
                flowCategories.Controls.Clear();
                IEnumerable<ProductCategory> categories = productCategoryService.GetAll();

                foreach (var category in categories)
                {
                    CreateCategoryElements(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void CreateCategoryElements(ProductCategory category)
        {
            Label b = new Label();
            Panel p1 = new Panel();
            Panel p2 = new Panel();

            b.Text = category.Name;
            b.Name = category.Id.ToString();
            b.Size = new Size(119, 25);
            b.Font = new Font("Arial", 12);
            b.BackColor = Color.Transparent;
            b.ForeColor = Color.Black;
            b.Dock = DockStyle.Fill;
            b.TextAlign = ContentAlignment.MiddleCenter;
            b.Cursor = Cursors.Hand;

            p1.Size = new Size(155, 133);
            p1.BorderStyle = BorderStyle.FixedSingle;
            p1.Dock = DockStyle.Bottom;
            p1.BackColor = Color.FromArgb(220, 220, 220);
            p1.Name = category.Id.ToString();

            p2.Size = new Size(155, 25);
            p2.Dock = DockStyle.Top;
            p2.BackColor = Color.Transparent;
            p2.BorderStyle = BorderStyle.None;

            MenuStrip Menustrip = new MenuStrip();
            Menustrip.BackColor = Color.Transparent;
            Menustrip.AutoSize = false;
            Menustrip.Size = new Size(28, 24);
            Menustrip.Dock = DockStyle.Right;
            Menustrip.Name = category.Id.ToString();
            ToolStripMenuItem ToolStripPRINCIPAL = new ToolStripMenuItem();
            ToolStripMenuItem ToolStripEdit = new ToolStripMenuItem();
            ToolStripMenuItem ToolStripDelete = new ToolStripMenuItem();
            ToolStripMenuItem ToolStripRestart = new ToolStripMenuItem();

            ToolStripPRINCIPAL.Image = Properties.Resources._16_config;
            ToolStripPRINCIPAL.BackColor = Color.Transparent;

            ToolStripEdit.Text = "Editar";
            ToolStripEdit.Name = category.Name;
            ToolStripEdit.Tag = category.Id.ToString();

            ToolStripDelete.Text = "Eliminar";
            ToolStripDelete.Tag = category.Id.ToString();

            ToolStripRestart.Text = "Restaurar";
            ToolStripRestart.Tag = category.Id.ToString();

            Menustrip.Items.Add(ToolStripPRINCIPAL);
            ToolStripPRINCIPAL.DropDownItems.Add(ToolStripEdit);
            ToolStripPRINCIPAL.DropDownItems.Add(ToolStripDelete);
            ToolStripPRINCIPAL.DropDownItems.Add(ToolStripRestart);

            p2.Controls.Add(Menustrip);
            p1.Controls.Add(b);
            p1.Controls.Add(p2);

            b.BringToFront();
            p2.SendToBack();
            flowCategories.Controls.Add(p1);

            b.Click += new EventHandler(myLabelEvent);
        }

        private void myLabelEvent(Object sender, EventArgs e)
        {
            if (selectedCategoryPanel != null)
            {
                selectedCategoryPanel.BackColor = Color.FromArgb(220, 220, 220);
            }

            selectedCategoryPanel = ((Label)sender).Parent as Panel;

            if (selectedCategoryPanel != null)
            {
                selectedCategoryPanel.BackColor = Color.FromArgb(160, 160, 160);
            }

            productCategoryId = Convert.ToInt32(((Label)sender).Name);
            DisplayProductsByGroup(productCategoryId);
        }

        private void DisplayProductsByGroup(int categoryId)
        {
            panelWelcome.Visible = false;
            panelWelcome.Dock = DockStyle.None;
            banelBase.Visible = true;
            flowProducts.Dock = DockStyle.Fill;
            banelBase.Dock = DockStyle.Fill;
            DrawProducts(categoryId);
        }

        private void DrawProducts(int categoryId)
        {
            try
            {
                flowProducts.Controls.Clear();

                IEnumerable<Product> products = productService.GetActiveProductsByCategoryId(categoryId);

                if (!products.Any())
                {
                    MessageBox.Show("Esta categoría no tiene productos relacionados.", "Sin Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // No es necesario continuar si no hay productos
                }

                txtProductCount.Text = "Productos registrados en esta categoría: " + products.Count();

                foreach (var product in products)
                {
                    Label label = new Label();
                    Panel panel1 = new Panel();
                    Panel panel2 = new Panel();
                    Label priceLabel = new Label();
                    PictureBox pictureBox = new PictureBox();

                    label.Text = product.Name;
                    label.Name = product.Id.ToString();
                    label.Size = new System.Drawing.Size(119, 25);
                    label.Font = new System.Drawing.Font("Arial", 12);
                    label.BackColor = Color.Transparent;
                    label.ForeColor = Color.White;
                    label.Dock = DockStyle.Fill;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Cursor = Cursors.Hand;


                    // Cultura colombiana (es-CO)
                    CultureInfo culturaColombiana = new CultureInfo("es-CO");

                    priceLabel.Text = product.Price.ToString("C", culturaColombiana); priceLabel.Size = new Size(119, 25);
                    priceLabel.Font = new Font("Arial", 10);
                    priceLabel.BackColor = Color.Transparent;
                    priceLabel.ForeColor = Color.Gainsboro;
                    priceLabel.Dock = DockStyle.Bottom;
                    priceLabel.TextAlign = ContentAlignment.MiddleCenter;

                    panel1.Size = new Size(140, 133);
                    panel1.BorderStyle = BorderStyle.FixedSingle;
                    panel1.Dock = DockStyle.Bottom;
                    panel1.BackColor = Color.FromArgb(43, 43, 43);

                    panel2.Size = new Size(140, 25);
                    panel2.Dock = DockStyle.Top;
                    panel2.BackColor = Color.Transparent;
                    panel2.BorderStyle = BorderStyle.None;

                    pictureBox.Size = new Size(140, 76);
                    pictureBox.Dock = DockStyle.Top;

                    panel1.Controls.Add(label);
                    panel1.Controls.Add(priceLabel);

                    MenuStrip menuStrip = new MenuStrip();
                    menuStrip.BackColor = Color.Transparent;
                    menuStrip.AutoSize = false;
                    menuStrip.Size = new System.Drawing.Size(28, 24);
                    menuStrip.Dock = DockStyle.Right;
                    menuStrip.Name = product.Id.ToString();

                    ToolStripMenuItem toolStripPrincipal = new ToolStripMenuItem();
                    ToolStripMenuItem toolStripEditar = new ToolStripMenuItem();
                    ToolStripMenuItem toolStripEliminar = new ToolStripMenuItem();
                    ToolStripMenuItem toolStripRestaurar = new ToolStripMenuItem();

                    toolStripPrincipal.Image = Properties.Resources._16_config;
                    toolStripPrincipal.BackColor = Color.Transparent;

                    toolStripEditar.Text = "Editar";
                    toolStripEditar.Name = product.Name;
                    toolStripEditar.Tag = product.Id.ToString();

                    toolStripEliminar.Text = "Eliminar";
                    toolStripEliminar.Tag = product.Id.ToString();


                    menuStrip.Items.Add(toolStripPrincipal);
                    toolStripPrincipal.DropDownItems.Add(toolStripEditar);
                    toolStripPrincipal.DropDownItems.Add(toolStripEliminar);

                    panel2.Controls.Add(menuStrip);

                    panel1.Controls.Add(panel2);
                    label.BringToFront();
                    panel2.SendToBack();
                    flowProducts.Controls.Add(panel1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        #endregion

        #region Events
        
        private void btnReportCategory_Click(object sender, EventArgs e)
        {
            Report.Forms.ReportGetAllActiveProductsForm reportGetAllActiveProductsForm = new Report.Forms.ReportGetAllActiveProductsForm();
            reportGetAllActiveProductsForm.ShowDialog();
        }

        private void btnAllProductReport_Click(object sender, EventArgs e)
        {
            Report.Forms.ReportGetAllProductsWithCategoryForm reportGetAllProductsWithCategoryForm
                = new Report.Forms.ReportGetAllProductsWithCategoryForm();
            reportGetAllProductsWithCategoryForm.ShowDialog();
        }

        #endregion
    }
}
