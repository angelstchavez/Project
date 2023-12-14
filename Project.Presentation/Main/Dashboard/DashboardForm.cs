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

        private Color SetColor(int r, int g, int b)
        {
            Color backgroundColor = Color.FromArgb(r, g, b);

            return backgroundColor;
        }

        private void OpenModule(Form form, Button button)
        {
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
            List<Button> buttons = new List<Button> { btnUsers, btnConfig };

            if (buttons.Contains(button))
            {
                button.Enabled = !state;
                if (button.Width == 45 && button.Height == 45)
                {
                    button.BackColor = Color.FromArgb(40, 40, 40);
                }
                else
                {
                    button.BackColor = Color.FromArgb(40, 40, 40);
                }

                foreach (Button btn in buttons)
                {
                    if (btn != button)
                    {
                        btn.Enabled = state;
                        if (btn.Width == 45 && btn.Height == 45)
                        {
                            btn.BackColor = Color.FromArgb(40, 40, 40);
                        }
                        else
                        {
                            btn.BackColor = Color.FromArgb(20, 20, 20);
                        }
                    }
                }
            }
        }

        #endregion

        #region Events

        #endregion

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenModule(new Users.UserManagerForm(), btnUsers);
        }
    }
}
