using Project.Presentation.Report.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project.Presentation.Main.Bills
{
    public partial class BillsReportForm : Form
    {
        public BillsReportForm()
        {
            InitializeComponent();
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
            List<Button> buttons = new List<Button> { btnGeneralReport, btnMonthReport };

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

        private void btnGeneralReport_Click(object sender, System.EventArgs e)
        {
            OpenModule(new ReportGetTotalExpenditureByCategoryForm(), btnGeneralReport);
        }

        private void btnMonthReport_Click(object sender, System.EventArgs e)
        {
            OpenModule(new BillsMonthReport(), btnMonthReport);
        }
    }
}
