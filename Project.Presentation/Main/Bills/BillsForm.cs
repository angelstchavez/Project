using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project.Presentation.Main.Bills
{
    public partial class BillsForm : Form
    {
        public BillsForm()
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
            List<Button> buttons = new List<Button> { btnConsult, btnHistoric };

            if (buttons.Contains(button))
            {
                button.Enabled = !state;

                button.BackColor = Color.FromArgb(220, 220, 220);

                foreach (Button btn in buttons)
                {
                    if (btn != button)
                    {
                        btn.Enabled = state;

                        btn.BackColor = Color.White;
                    }
                }
            }
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            BillsControlForm billsControlForm = new BillsControlForm();
            billsControlForm.ShowDialog();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            OpenModule(new BillsConsultForm(), btnConsult);
        }

        private void btnHistoric_Click(object sender, EventArgs e)
        {
            OpenModule(new BillsHistoricForm(), btnHistoric);
        }
    }
}
