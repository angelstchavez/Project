using Project.Presentation.Main.Bills;
using System.Collections.Generic;
using System.Drawing;
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
            this.panelBase.Controls.Clear();
            module.TopLevel = false;
            module.Dock = DockStyle.Fill;
            this.panelBase.Controls.Add(module);
            this.panelBase.Tag = module;
            module.Show();
            this.panelBase.BringToFront();
        }

        private void ToggleMainButtonsState(bool state, Button button)
        {
            List<Button> buttons = new List<Button> { btnNewOrder, btnSaleHistoricDay };

            if (buttons.Contains(button))
            {
                button.Enabled = !state;
                button.BackColor = Color.FromArgb(30, 30, 30);

                foreach (Button btn in buttons)
                {
                    if (btn != button)
                    {
                        btn.Enabled = state;
                        btn.BackColor = Color.FromArgb(12, 12, 12);
                    }
                }
            }
        }

        #endregion

        #region Events

        private void btnNewOrder_Click(object sender, System.EventArgs e)
        {
            OpenModule(new SaleControlForm(), btnNewOrder);
        }

        private void btnSaleHistoricDay_Click(object sender, System.EventArgs e)
        {
            OpenModule(new SaleHistoricForm(), btnSaleHistoricDay);
        }

        #endregion
    }
}
