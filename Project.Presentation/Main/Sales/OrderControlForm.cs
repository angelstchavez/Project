using Project.Business.Services;
using Project.Entity;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System;
using System.Windows.Forms;
using System.Linq;

namespace Project.Presentation.Main.Sales
{
    public partial class OrderControlForm : Form
    {
        private readonly ProductCategoryService productCategoryService;
        private readonly ProductService productService;
        private Button selectedCategoryButton;
        public static int productCategoryId;

        public OrderControlForm()
        {
            productCategoryService = new ProductCategoryService();
            productService = new ProductService();
            InitializeComponent();
            DrawProductCategories();
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
                    CreateCategoryButtons(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void CreateCategoryButtons(ProductCategory category)
        {
            Button btnCategory = new Button();

            btnCategory.Text = category.Name;
            btnCategory.Name = category.Id.ToString();
            btnCategory.Size = new Size(125, 125);
            btnCategory.Font = new Font("Arial", 12);
            btnCategory.ForeColor = Color.Black;
            btnCategory.Dock = DockStyle.Top;
            btnCategory.TextAlign = ContentAlignment.MiddleCenter;
            btnCategory.Cursor = Cursors.Hand;

            btnCategory.Click += new EventHandler(myButtonEvent);

            flowCategories.Controls.Add(btnCategory);
        }

        private void myButtonEvent(object sender, EventArgs e)
        {
            if (selectedCategoryButton != null)
            {
                selectedCategoryButton.Enabled = true;
                selectedCategoryButton.BackColor = Color.Transparent;
            }

            selectedCategoryButton = (Button)sender;

            if (selectedCategoryButton != null)
            {
                selectedCategoryButton.Enabled = false;
                selectedCategoryButton.BackColor = Color.FromArgb(240, 240, 240);
            }

            productCategoryId = Convert.ToInt32(selectedCategoryButton.Name);
            DisplayProductsByGroup(productCategoryId);
        }

        private void DisplayProductsByGroup(int categoryId)
        {
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
                    return;
                }

                foreach (var product in products)
                {
                    Button btnProduct = new Button();

                    btnProduct.Text = $"{product.Name}\n{product.Price:C}"; 
                    btnProduct.Name = product.Id.ToString();
                    btnProduct.Size = new Size(125, 125);
                    btnProduct.Font = new Font("Arial", 12);
                    btnProduct.ForeColor = Color.Black;
                    btnProduct.Dock = DockStyle.Bottom;
                    btnProduct.TextAlign = ContentAlignment.MiddleCenter;
                    btnProduct.Cursor = Cursors.Hand;

                    flowProducts.Controls.Add(btnProduct);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        #endregion
    }
}
