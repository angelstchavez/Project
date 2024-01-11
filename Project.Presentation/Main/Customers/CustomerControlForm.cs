using Project.Business.Services;
using Project.Entity;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project.Presentation.Main.Customers
{
    public partial class CustomerControlForm : Form
    {
        private readonly CustomerService customerService;
        private readonly bool isEditMode;
        private int customerId;

        public CustomerControlForm(bool isEditMode)
        {
            this.isEditMode = isEditMode;
            customerService = new CustomerService();
            InitializeComponent();

            InitializeForm(isEditMode);
        }

        public CustomerControlForm(bool isEditMode, int customerId) : this(isEditMode)
        {
            this.customerId = customerId;
            LoadEdit();
        }

        private void InitializeForm(bool isEditMode)
        {
            labelTitle.BackColor = isEditMode ? Color.DarkOrange : Color.Green;
            txtName.BackColor = isEditMode ? SystemColors.Info : SystemColors.Window;
            txtPhone.BackColor = isEditMode ? SystemColors.Info : SystemColors.Window;
            labelTitle.Text = isEditMode ? "Actualizar cliente" : "Nuevo cliente";
        }

        private void LoadEdit()
        {
            try
            {
                Customer customer = customerService.Get(customerId);

                if (customer != null)
                {
                    txtName.Text = customer.Name;
                    txtPhone.Text = customer.Phone;
                }
                else
                {
                    ShowErrorMessage("El cliente no se encontró en la base de datos.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Error: {ex.Message}");
            }
        }

        private bool IsPhoneNumberUnique(string phoneNumber)
        {
            // Check if there is any customer with the given phone number
            return customerService.GetByPhoneNumber(phoneNumber) == null;
        }

        private void AddOrUpdateCustomer(Func<Customer, bool> action)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    ShowWarningMessage("Los campos de nombre y teléfono son obligatorios.");
                    return;
                }

                string phoneNumber = txtPhone.Text.Trim();

                if (!IsPhoneNumberUnique(phoneNumber))
                {
                    ShowWarningMessage("El número de teléfono ya está registrado. Por favor, utilice otro.");
                    return;
                }

                Customer customer = new Customer
                {
                    Name = txtName.Text,
                    Phone = phoneNumber,
                    CreatedAt = DateTime.Now
                };

                if (action(customer))
                {
                    ShowInfoMessage(isEditMode ? "Cliente actualizado exitosamente." : "Cliente registrado exitosamente.");
                    Close();
                }
                else
                {
                    ShowErrorMessage("Error al procesar la operación.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Error: {ex.Message}");
            }
        }

        private void Add()
        {
            AddOrUpdateCustomer(customerService.Create);
        }

        private void Edit()
        {
            AddOrUpdateCustomer(customerService.Update);
        }

        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowInfoMessage(string message)
        {
            MessageBox.Show(message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                Edit();
            }
            else
            {
                Add();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                txtName.Enabled = false;
                txtName.Text = "Sin nombre";
            }
            else
            {
                txtName.Enabled = true;
                txtName.Text = string.Empty;
            }
        }
    }
}