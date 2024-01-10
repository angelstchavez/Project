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
        private List<ShoppingCartItem> shoppingCartItems = new List<ShoppingCartItem>();


        public OrderControlForm()
        {
            productCategoryService = new ProductCategoryService();
            productService = new ProductService();
            InitializeComponent();
            DrawProductCategories();
            txtTotalAmount.Text = "$ 0,00";
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
            btnCategory.Size = new Size(135, 135);
            btnCategory.Font = new Font("Arial", 12);
            btnCategory.ForeColor = Color.White;
            btnCategory.BackColor = Color.FromArgb(2, 97, 170);
            btnCategory.Dock = DockStyle.Top;
            btnCategory.TextAlign = ContentAlignment.MiddleCenter;
            btnCategory.Cursor = Cursors.Hand;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 97, 170);
            btnCategory.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 97, 170);

            btnCategory.Click += new EventHandler(myButtonEvent);

            flowCategories.Controls.Add(btnCategory);
        }

        private void myButtonEvent(object sender, EventArgs e)
        {
            if (selectedCategoryButton != null)
            {
                selectedCategoryButton.BackColor = Color.FromArgb(2, 97, 170);
            }

            selectedCategoryButton = (Button)sender;

            if (selectedCategoryButton != null)
            {
                selectedCategoryButton.BackColor = Color.FromArgb(0, 48, 85);
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

                    btnProduct.Text = $"{product.Name}\n\n{product.Price:C}";
                    btnProduct.Name = product.Id.ToString();
                    btnProduct.Size = new Size(135, 135);
                    btnProduct.Font = new Font("Arial", 12, FontStyle.Bold);
                    btnProduct.ForeColor = Color.White;
                    btnProduct.BackColor = Color.FromArgb(2, 97, 170);
                    btnProduct.Dock = DockStyle.Bottom;
                    btnProduct.TextAlign = ContentAlignment.MiddleCenter;
                    btnProduct.Cursor = Cursors.Hand;
                    btnProduct.FlatStyle = FlatStyle.Flat;
                    btnProduct.FlatAppearance.BorderSize = 0;
                    btnProduct.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 67, 118);
                    btnProduct.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 48, 85);

                    flowProducts.Controls.Add(btnProduct);

                    // Manejar el evento de clic para los botones de productos
                    btnProduct.Click += new EventHandler(ProductButtonClick);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void ProductButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int productId = Convert.ToInt32(clickedButton.Name);
            Product selectedProduct = productService.Get(productId);

            // Verificar si el producto ya está en el carrito
            ShoppingCartItem existingItem = shoppingCartItems.FirstOrDefault(item => item.ProductName == selectedProduct.Name);

            if (existingItem != null)
            {
                // Incrementar la cantidad si el producto ya está en el carrito
                existingItem.Quantity++;
                existingItem.TotalPrice = existingItem.Quantity * selectedProduct.Price;
            }
            else
            {
                // Agregar un nuevo elemento al carrito si el producto no está en el carrito
                ShoppingCartItem newItem = new ShoppingCartItem
                {
                    ProductId = selectedProduct.Id,
                    ProductName = selectedProduct.Name,
                    Quantity = 1,
                    TotalPrice = selectedProduct.Price
                };

                shoppingCartItems.Add(newItem);
            }

            // Actualizar el DataGridView con la información del carrito de compras
            UpdateDataGridView();
        }

        private void UpdateTotalAmount()
        {
            decimal totalAmount = shoppingCartItems.Sum(item => item.TotalPrice);
            txtTotalAmount.Text = totalAmount.ToString("C", CultureInfo.CurrentCulture);
        }

        private void UpdateDataGridView()
        {
            // Limpiar las filas existentes en el DataGridView
            dataGridView.Rows.Clear();

            // Agregar las filas actualizadas
            foreach (var item in shoppingCartItems)
            {
                // Agregar una nueva fila con la información del carrito
                int rowIndex = dataGridView.Rows.Add(item.ProductId, item.ProductName, item.Quantity, item.TotalPrice.ToString("C"));

                // Configurar el botón eliminar en la última columna
                dataGridView.Rows[rowIndex].Cells["Eliminar"].Value = "Eliminar";
            }

            UpdateTotalAmount();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;

                if (rowIndex < shoppingCartItems.Count)
                {
                    ShoppingCartItem selectedItem = shoppingCartItems[rowIndex];

                    // Reducir la cantidad o eliminar el producto según sea necesario
                    if (selectedItem.Quantity > 1)
                    {
                        selectedItem.Quantity--;
                        selectedItem.TotalPrice = selectedItem.Quantity * productService.Get(selectedItem.ProductId).Price;
                    }
                    else
                    {
                        // Eliminar completamente el producto cuando la cantidad llega a cero
                        shoppingCartItems.RemoveAt(rowIndex);
                    }

                    // Actualizar el DataGridView y el total
                    UpdateDataGridView();
                }
            }
        }


        private void ClearCart()
        {
            // Limpiar la lista de productos en el carrito
            shoppingCartItems.Clear();
            txtCustomer.Clear();
            txtPhoneCustomer.Clear();
            txtAddressCustomer.Clear();

            // Actualizar el DataGridView y la cantidad total del valor de la venta
            UpdateDataGridView();
            UpdateTotalAmount();
        }

        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (shoppingCartItems.Any())
            {
                // Mostrar un mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas limpiar el pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes)
                {
                    // Limpiar la tabla (o realizar cualquier acción adicional)
                    ClearCart();
                }
            }
            else
            {
                MessageBox.Show("El pedido ya se encuentra vacío.", "Pedido Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (shoppingCartItems.Any())
            {
                // Mostrar un mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cancelar el pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes)
                {
                    // Limpiar la tabla (o realizar cualquier acción adicional)
                    ClearCart();
                }
            }
            else
            {
                MessageBox.Show("El pedido ya se encuentra vacío.", "Pedido Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            Customers.CustomersConsultForm customersConsultForm = new Customers.CustomersConsultForm();
            customersConsultForm.ShowDialog();
        }
    }
}
