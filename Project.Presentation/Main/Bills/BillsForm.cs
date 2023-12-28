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
            List<Button> buttons = new List<Button> { btnConsult, btnPerDay };

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

        private void btnControl_Click(object sender, EventArgs e)
        {
            BillsControlForm billsControlForm = new BillsControlForm();

            // Utilizar la propiedad CenterScreen para centrar el formulario en la pantalla
            billsControlForm.StartPosition = FormStartPosition.CenterParent;

            billsControlForm.ShowDialog();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            OpenModule(new BillsConsultForm(), btnConsult);
        }

        private void btnHistoric_Click(object sender, EventArgs e)
        {
            OpenModule(new BillsPerDayForm(), btnPerDay);
        }
    }
}
