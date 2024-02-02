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
        private readonly SaleService saleService;
        private readonly SaleDetailService saleDetailService;
        private readonly CustomerService customerService;

        //Internal fields
        public static int productCategoryId;
        private int selectedNeighborhoodId;

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
            this.saleService = new SaleService();
            this.saleDetailService = new SaleDetailService();
            this.customerService = new CustomerService();
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
            btnCategory.BackColor = Color.FromArgb(12,12,12);
            btnCategory.ForeColor = Color.Silver;
            btnCategory.TextAlign = ContentAlignment.BottomCenter;
            btnCategory.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.FlatAppearance.MouseDownBackColor = Color.FromArgb(40,40,40);
            btnCategory.FlatAppearance.MouseOverBackColor = Color.FromArgb(15,15,15);
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
                    btnProduct.BackColor = Color.FromArgb(12, 12, 12);
                    btnProduct.ForeColor = Color.Silver;
                    btnProduct.FlatAppearance.BorderSize = 0;
                    btnProduct.FlatStyle = FlatStyle.Flat;
                    btnProduct.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
                    btnProduct.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 15, 15);
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
                decimal price = item.TotalPrice / item.Quantity;

                // Agregar una nueva fila con la información del carrito
                int rowIndex = dataGridView.Rows.Add(item.ProductId, item.ProductName, price, item.Quantity, item.TotalPrice, item.TotalPrice.ToString("C"));

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

        private bool RegistrarVenta(List<ProductoVenta> productos, int userId, int customerId, string address, int neighborhoodId, string paymentType)
        {
            try
            {
                Sale venta = new Sale
                {
                    User = new User { Id = userId },
                    Customer = new Customer { Id = customerId },
                    Address = address,
                    Neighborhood = new Neighborhood { Id = neighborhoodId },
                    TransportationCompany = new TransportationCompany() { Id = Convert.ToInt32(comboBoxTransportationCompany.SelectedValue) },
                    PaymentType = paymentType,
                    TotalAmount = CalcularTotal(dataGridView),
                    CreatedAt = dateTimePicker.Value,
                };

                int saleId = saleService.Create(venta);


                foreach (var producto in productos)
                {
                    SaleDetail saleDetail = new SaleDetail
                    {
                        Sale = new Sale() { Id = saleId },
                        Product = producto.Producto,
                        //Aqui 
                        Amount = producto.Producto.Price * producto.Cantidad,
                        Quantity = producto.Cantidad,
                        CreatetAt = DateTime.Now
                    };

                    saleDetailService.Create(saleDetail);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private decimal CalcularTotal(DataGridView dataGridView)
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dataGridView.Rows)
            {
                // Obtener el precio y cantidad de las columnas específicas de tu DataGridView
                var precioStr = fila.Cells["Precio"].Value?.ToString(); // Asegúrate de ajustar el nombre de la columna según tu estructura
                var cantidadStr = fila.Cells["Cantidad"].Value?.ToString();

                // Verificar que las celdas no estén vacías
                if (!string.IsNullOrEmpty(precioStr) && !string.IsNullOrEmpty(cantidadStr))
                {
                    // Convertir los valores a decimal e int respectivamente
                    if (decimal.TryParse(precioStr, out decimal precio) && int.TryParse(cantidadStr, out int cantidad))
                    {
                        total += precio * cantidad;
                    }
                    else
                    {
                        // Manejar la conversión fallida si es necesario
                        MessageBox.Show("Error de conversión de datos en el DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return total;
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

        private List<ProductoVenta> ObtenerProductosDesdeDataGridView()
        {
            List<ProductoVenta> productos = new List<ProductoVenta>();

            foreach (DataGridViewRow fila in dataGridView.Rows)
            {
                // Obtener los datos de la fila
                var idCellValue = fila.Cells["Id"].Value;
                var nombreProductoCellValue = fila.Cells["Producto"].Value;
                var cantidadCellValue = fila.Cells["Cantidad"].Value;
                var totalCellValue = fila.Cells["Total"].Value;

                // Verificar si los valores son nulos antes de intentar convertirlos
                if (idCellValue != null && nombreProductoCellValue != null && cantidadCellValue != null && totalCellValue != null)
                {
                    // Convertir los valores a los tipos adecuados
                    int productoId = Convert.ToInt32(idCellValue);
                    string nombreProducto = nombreProductoCellValue.ToString();
                    int cantidad = Convert.ToInt32(cantidadCellValue);
                    decimal total = Convert.ToDecimal(totalCellValue);

                    // Crear una instancia de ProductoVenta y añadirla a la lista
                    productos.Add(new ProductoVenta
                    {
                        Producto = new Product { Id = productoId, Name = nombreProducto },  // Ajusta según la estructura de tu clase Product
                        Cantidad = cantidad
                    });
                }
                else
                {
                    // Manejar el caso en que algún valor sea nulo
                    MessageBox.Show("Error: Al menos uno de los valores en la fila es nulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Puedes decidir qué hacer en este caso, como omitir la fila o detener el proceso.
                }
            }

            return productos;
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
            customersConsultForm.StartPosition = FormStartPosition.CenterParent;
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

        private void btnCreateSale_Click(object sender, EventArgs e)
        {
            if (!shoppingCartItems.Any())
            {
                MessageBox.Show("Agregue por lo menos un producto a la venta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                // Obtener el cliente para la venta
                Customer saleCustomer = GetCustomer();

            // Verificar si se obtuvo un cliente válido antes de asignarlo a la venta
            if (saleCustomer != null)
            {
                // Crear una lista de productos para la venta (debes llenarla con los datos de tu DataGridView)
                List<ProductoVenta> productos = ObtenerProductosDesdeDataGridView();

                // Asignar el valor de comboBoxNeighborhood_SelectedIndexChanged directamente
                comboBoxNeighborhood_SelectedIndexChanged(comboBoxNeighborhood, EventArgs.Empty);

                bool ventaRegistrada = RegistrarVenta(productos, userId: 6, customerId: saleCustomer.Id, address: txtAddressCustomer.Text, neighborhoodId: selectedNeighborhoodId, paymentType: GetPaymentSale());

                if (ventaRegistrada)
                {
                    MessageBox.Show("Venta registrada exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                else
                {
                    // Ocurrió un error al registrar la venta
                    MessageBox.Show("Error al intentar registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxNeighborhood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNeighborhood.SelectedItem != null)
            {
                int selectedNeighborhoodId = Convert.ToInt32(comboBoxNeighborhood.SelectedValue);

                // Guardar el selectedNeighborhoodId en una variable accesible para RegistrarVenta
                this.selectedNeighborhoodId = selectedNeighborhoodId;
            }
        }
    }

    public class ProductoVenta
    {
        public Product Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
