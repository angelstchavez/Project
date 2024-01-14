using Project.Business.Services;
using Project.Entity;
using System.Drawing;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using Project.Presentation.Main.Customers;

namespace Project.Presentation.Main.Sales
{
    public partial class SaleControlForm : Form
    {
        #region Fields

        //Services
        private readonly TransportationCompanyService transportationCompanyService;
        private readonly ProductCategoryService productCategoryService;
        private readonly ProductService productService;
        private readonly NeighborhoodService neighborhoodService;

        //Internal fields
        public static int productCategoryId;

        //Objects
        private Button selectedCategoryButton;
        private Customer selectedCustomer;
        private List<ShoppingCartItem> shoppingCartItems = new List<ShoppingCartItem>();

        #endregion

        #region Constructor

        public SaleControlForm()
        {
            this.transportationCompanyService = new TransportationCompanyService();
            this.productCategoryService = new ProductCategoryService();
            this.productService = new ProductService();
            this.neighborhoodService = new NeighborhoodService();
            InitializeComponent();
            DrawProductCategories();
            LoadCommunes();
            LoadTransportationCompanies();
        }

        #endregion

        #region Private methods

        #endregion

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

        private void ButtonCategoryEvent(object sender, EventArgs e)
        {
            if (selectedCategoryButton != null)
            {
                selectedCategoryButton.Enabled = true;
            }

            selectedCategoryButton = (Button)sender;

            if (selectedCategoryButton != null)
            {
                selectedCategoryButton.Enabled = false;
            }

            productCategoryId = Convert.ToInt32(selectedCategoryButton.Name);
            DisplayProductsByGroup(productCategoryId);
        }

        private void CreateCategoryButtons(ProductCategory category)
        {
            Button btnCategory = new Button();

            btnCategory.Text = category.Name;
            btnCategory.Name = category.Id.ToString();
            btnCategory.Size = new Size(135, 135);
            btnCategory.Font = new Font("Arial", 12);
            btnCategory.Dock = DockStyle.Top;
            btnCategory.TextAlign = ContentAlignment.MiddleCenter;
            btnCategory.Cursor = Cursors.Hand;
            btnCategory.BackColor = Color.White;
            btnCategory.TextAlign = ContentAlignment.BottomCenter;
            btnCategory.TextImageRelation = TextImageRelation.ImageAboveText;

            btnCategory.Click += new EventHandler(ButtonCategoryEvent);

            // Asignar imágenes según la categoría de productos
            if (category.Name == "Bebidas")
            {
                btnCategory.Image = Properties.Resources._64_drink;
            }
            else if (category.Name == "Presentaciones")
            {
                btnCategory.Image = Properties.Resources._64_wok;
            }
            else if (category.Name == "Acompañantes")
            {
                btnCategory.Image = Properties.Resources._64_extra;
            }

            flowCategories.Controls.Add(btnCategory);
        }

        private void DisplayProductsByGroup(int categoryId)
        {
            CreateProductButton(categoryId);
        }

        private void CreateProductButton(int categoryId)
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
                    btnProduct.Font = new Font("Arial", 12);
                    btnProduct.Dock = DockStyle.Bottom;
                    btnProduct.TextAlign = ContentAlignment.MiddleCenter;
                    btnProduct.Cursor = Cursors.Hand;
                    btnProduct.BackColor = Color.White;
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

        private void UpdateTotalAmount()
        {
            decimal totalAmount = shoppingCartItems.Sum(item => item.TotalPrice);
            labelTotalAmount.Text = totalAmount.ToString("C", CultureInfo.CurrentCulture);
        }

        private void ClearCart()
        {
            if (shoppingCartItems.Any())
            {
                // Mostrar un mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cancelar el pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes)
                {
                    // Limpiar la lista de productos en el carrito
                    shoppingCartItems.Clear();
                    txtCustomerName.Clear();
                    txtCustomerPhone.Clear();
                    txtAddressCustomer.Clear();

                    // Actualizar el DataGridView y la cantidad total del valor de la venta
                    UpdateDataGridView();
                    UpdateTotalAmount();
                    LoadCommunes();
                    DrawProductCategories();
                    flowProducts.Controls.Clear();
                }
            }
            else
            {
                MessageBox.Show("El pedido ya se encuentra vacío.", "Pedido Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadCommunes()
        {
            // Obtener los números de las comunas desde el servicio
            IEnumerable<int> communes = neighborhoodService.GetDistinctCommunes();

            // Asignar la lista de números de comunas al ComboBox
            comboBoxCommune.DataSource = communes.ToList();
        }

        private void LoadTransportationCompanies()
        {
            IEnumerable<TransportationCompany> tc = transportationCompanyService.GetAll();

            comboBoxTransportationCompany.DataSource = tc.ToList();
            comboBoxTransportationCompany.DisplayMember = "Name";
            comboBoxTransportationCompany.ValueMember = "Id";
        }

        #region Events

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCart();
        }

        private void comboBoxCommune_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCommune.SelectedItem != null)
            {
                int selectedCommune = Convert.ToInt32(comboBoxCommune.SelectedItem);

                IEnumerable<Neighborhood> neighborhoods = neighborhoodService.GetByCommune(selectedCommune);

                comboBoxNeighborhood.DataSource = neighborhoods.ToList();
                comboBoxNeighborhood.DisplayMember = "Name";
                comboBoxNeighborhood.ValueMember = "Id";
            }
        }

        private void checkBoxToDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxToDiscount.Checked)
            {
                txtToDiscount.Enabled = true;
            }
            else
            {
                txtToDiscount.Enabled = false;
                txtToDiscount.Clear();
            }
        }

        private void CustomersConsultForm_CustomerSelected(object sender, CustomerSelectedEventArgs e)
        {
            // Obtén el objeto completo del cliente directamente
            selectedCustomer = e.SelectedCustomer;

            // Verifica si el cliente seleccionado no es nulo
            if (selectedCustomer != null)
            {
                // Actualiza los TextBox con la información del cliente
                txtCustomerName.Text = selectedCustomer.Name;
                txtCustomerPhone.Text = selectedCustomer.Phone;

                txtCustomerName.Enabled = false;
                txtCustomerPhone.Enabled = false;
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            CustomersConsultForm customersConsultForm = new CustomersConsultForm();
            customersConsultForm.CustomerSelected += CustomersConsultForm_CustomerSelected;
            customersConsultForm.ShowDialog();
        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtCustomerPhone.Clear();
            txtCustomerName.Enabled = true;
            txtCustomerPhone.Enabled = true;
        }

        #endregion

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en la columna "Eliminar" y en una fila válida
            if (e.ColumnIndex == dataGridView.Columns["Eliminar"].Index && e.RowIndex != -1)
            {
                // Obtener el ID del producto de la fila seleccionada
                int productId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Id"].Value);

                // Aquí puedes realizar la lógica para eliminar el producto del carrito o de la base de datos
                // Por ejemplo, si tienes una lista llamada shoppingCartItems, podrías hacer algo como:
                var itemToRemove = shoppingCartItems.FirstOrDefault(item => item.ProductId == productId);
                if (itemToRemove != null)
                {
                    shoppingCartItems.Remove(itemToRemove);
                }

                // Eliminar la fila seleccionada del DataGridView
                dataGridView.Rows.RemoveAt(e.RowIndex);

                // Después de eliminar, actualiza nuevamente el total y cualquier otra lógica necesaria
                UpdateTotalAmount();
            }
        }
    }
}
