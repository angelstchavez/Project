using Project.Business.Services;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Project.Presentation.Main.Dashboard
{
    public partial class DashboardForm : Form
    {
        private User currentUser;

        public DashboardForm(User user)
        {
            this.currentUser = user;
            InitializeComponent();
            ValidateControls();
            txtCurrentUser.Text = user.Username;
            OpenModule(new Home.HomeForm(), btnHome, "Bandeja principal");
        }

        #region Functions

        private void ValidateControls()
        {
            ModuleService moduleService = new ModuleService();
            IEnumerable<Module> modules = moduleService.GetModulesByUserId(currentUser.Id);

            //Recorremos los elementos del menú lateral
            foreach (var element in buttonsPanel.Controls)
            {
                //Si el elemento del menú lateral es un botón entonces ejecuta el bloque de codigo
                if (element is Button button)
                {
                    bool encontrado = modules.Any(m => m.Name == button.Name);
                    if (encontrado) { button.Visible = true; }
                    else { button.Visible = false; }
                }
            }
        }

        private void OpenModule(Form form, Button button, string title)
        {
            txtTitle.Text = title;
            OpenNewForm(form);
            ToggleMainButtonsState(true, button);
        }

        private void OpenNewForm(Form module)
        {
            panelBase.Controls.Clear();
            module.TopLevel = false;
            module.Dock = DockStyle.Fill;
            panelBase.Controls.Add(module);
            panelBase.Tag = module;
            module.Show();
            panelBase.BringToFront();
        }

        private void ToggleMainButtonsState(bool state, Button button)
        {
            List<Button> buttons = new List<Button> { btnHome, btnMakeOrder, btnSales, btnBills, btnSupplies, btnProducts, btnCustomers, btnReports, btnUsers, btnConfig };

            if (buttons.Contains(button))
            {
                button.Enabled = !state;

                button.BackColor = Color.FromArgb(50,50,50);
                
                foreach (Button btn in buttons)
                {
                    if (btn != button)
                    {
                        btn.Enabled = state;

                        btn.BackColor = Color.FromArgb(40,40,40);
                    }
                }
            }
        }

        #endregion

        #region Events

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenModule(new Users.UserManagerForm(), btnUsers, "Gestor de usuarios");
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            OpenModule(new Config.ConfigForm(), btnConfig, "Configuración del sistema");
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenModule(new Products.ProductManagerForm(), btnProducts, "Gestor de productos");
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenModule(new Customers.CustomersForm(), btnCustomers, "Gestor de clientes");
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            OpenModule(new Sales.SaleManagerForm(), btnSales, "Registro de ventas");
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            OpenModule(new Bills.BillsForm(), btnBills, "Gestor de gastos");
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            OpenModule(new Sales.SalesForm(), btnMakeOrder, "Gestor de ventas");
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenModule(new Home.HomeForm(), btnHome, "Bandeja principal");
        }

        #endregion
    }
}