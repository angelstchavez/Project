using Project.Presentation.Main.Bills;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project.Presentation.Main.Sales
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        #region Functions

        private void OpenModule(Form form, Button button)
        {
            OpenNewForm(form);
            ToggleMainButtonsState(true, button);
        }

        private void OpenNewForm(Form module)
        {
            this.panel.Controls.Clear();
            module.TopLevel = false;
            module.Dock = DockStyle.Fill;
            this.panel.Controls.Add(module);
            this.panel.Tag = module;
            module.Show();
            this.panel.BringToFront();
        }

        private void ToggleMainButtonsState(bool state, Button button)
        {
            List<Button> buttons = new List<Button> { btnNewOrder };

            if (buttons.Contains(button))
            {
                button.Enabled = !state;

                foreach (Button btn in buttons)
                {
                    if (btn != button)
                    {
                        btn.Enabled = state;
                    }
                }
            }
        }

        #endregion

        #region Events

        #endregion

        private void btnNewOrder_Click(object sender, System.EventArgs e)
        {
            OpenModule(new OrderControlForm(), btnNewOrder);
        }
    }
}
