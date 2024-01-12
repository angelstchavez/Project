using Project.Business.Services;
using Project.Entity;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System;
using System.Windows.Forms;
using System.Linq;
using Project.Presentation.Main.Customers;

namespace Project.Presentation.Main.Sales
{
    public partial class OrderControlForm : Form
    {
        #region Fields

        private readonly ProductCategoryService productCategoryService;
        private readonly NeighborhoodService neighborhoodService;
        private readonly ProductService productService;
        private readonly CustomerService customerService;
        private Button selectedCategoryButton;
        public static int productCategoryId;
        private List<ShoppingCartItem> shoppingCartItems = new List<ShoppingCartItem>();
        private Customer selectedCustomer;
        private int selectedNeighborhoodId;

        #endregion

        #region Constructor

        public OrderControlForm()
        {
            productCategoryService = new ProductCategoryService();
            productService = new ProductService();
            neighborhoodService = new NeighborhoodService();
            customerService = new CustomerService();
            InitializeComponent();
            DrawProductCategories();
            LoadCommunes();
            LoadTest();
            txtTotalAmount.Text = "$ 0,00";
        }

        #endregion

        #region Functions

        private void LoadCommunes()
        {
            // Obtener los números de las comunas desde el servicio
            IEnumerable<int> communes = neighborhoodService.GetDistinctCommunes();

            // Asignar la lista de números de comunas al ComboBox
            comboBoxCommune.DataSource = communes.ToList();
        }

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
            txtCustomerName.Clear();
            txtCustomerPhone.Clear();
            txtAddressCustomer.Clear();

            // Actualizar el DataGridView y la cantidad total del valor de la venta
            UpdateDataGridView();
            UpdateTotalAmount();
        }

        private string GetPaymentSale()
        {
            if (radioButtonCash.Checked)
            {
                return "Efectivo";
            }
            else if (radioButtonDaviplata.Checked)
            {
                return "Daviplata";
            }
            else if (radioButtonNequi.Checked)
            {
                return "Nequi";
            }
            else
            {
                return "No seleccionado";
            }
        }

        private Customer GetCustomer()
        {
            // Verificar si se seleccionó un cliente
            if (selectedCustomer != null)
            {
                return selectedCustomer;
            }
            else
            {
                // Crear un nuevo cliente con la información de los TextBox
                string customerName = txtCustomerName.Text.Trim();
                string customerPhone = txtCustomerPhone.Text.Trim();

                // Verificar que se haya ingresado al menos el nombre o el teléfono
                if (!string.IsNullOrEmpty(customerName) || !string.IsNullOrEmpty(customerPhone))
                {
                    // Crear un nuevo cliente con los datos ingresados
                    Customer newCustomer = new Customer
                    {
                        Name = customerName,
                        Phone = customerPhone,
                        CreatedAt = DateTime.Now
                    };

                    // Guardar el nuevo cliente en la base de datos
                    customerService.Create(newCustomer);

                    // Devolver el cliente recién creado con el ID asignado
                    return newCustomer;
                }
                else
                {
                    // No se ingresaron datos suficientes para crear un nuevo cliente
                    return null;
                }
            }
        }

        private void CreateSale()
        {
            // Obtener el cliente para la venta
            Customer saleCustomer = GetCustomer();

            // Verificar si se obtuvo un cliente válido antes de asignarlo a la venta
            if (saleCustomer != null)
            {
                // Asignar el ID del cliente recién creado a la venta
                Sale sale = new Sale()
                {
                    User = new User() { Id = 6 },
                    Customer = saleCustomer,
                    PaymentType = GetPaymentSale(),
                    Address = txtAddressCustomer.Text,
                    Neighborhood = new Neighborhood() { Id = selectedNeighborhoodId }
                    //TotalAmount = (decimal)txtTotalAmount.Text,
                };

                // Concatenar los datos de la venta para mostrar en el MessageBox
                string saleDetails = $"Venta registrada exitosamente.\n\n" +
                                     $"Cliente: {sale.Customer.Name}\n" +
                                     $"Dirección: {sale.Address}\n" +
                                     $"Barrio: {sale.Neighborhood.Id}\n" +  // Puedes cambiar esto dependiendo de cómo quieras mostrar el barrio
                                     $"Método de pago: {sale.PaymentType}";

                MessageBox.Show(saleDetails, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("Venta registrada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Mensaje de error o manejo adecuado cuando no se puede obtener un cliente válido
                MessageBox.Show("No se pudo obtener un cliente válido para la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #endregion

        #region Events
        
        private void LoadTest()
        {
            IEnumerable<Neighborhood> neighborhoods = neighborhoodService.GetByCommune(1);

            comboBoxNeighborhood.DataSource = neighborhoods.ToList();
            comboBoxNeighborhood.DisplayMember = "Name";
            comboBoxNeighborhood.ValueMember = "Id";
        }

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

        private void comboBoxNeighborhood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNeighborhood.SelectedValue != null)
            {
                //selectedNeighborhoodId = Convert.ToInt32(comboBoxNeighborhood.SelectedValue);
            }
            else
            {

            }
        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtCustomerPhone.Clear();
            txtCustomerName.Enabled = true;
            txtCustomerPhone.Enabled = true;
        }

        #endregion

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateSale();
        }


    }
}
