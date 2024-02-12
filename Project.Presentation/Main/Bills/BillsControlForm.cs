using Project.Business.Services;
using Project.Entity;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Project.Presentation.Main.Bills
{
    public partial class BillsControlForm : Form
    {
        private readonly ExpeditureService expeditureService;
        private Expenditure expenditure;
        private bool option;

        public BillsControlForm(Expenditure expenditure, bool option)
        {
            InitializeComponent();
            this.expenditure = expenditure;
            this.option = option;
            InitializeFormWithExpenditure();
        }

        private void InitializeFormWithExpenditure()
        {

            if (option)
            {
                comboBoxCategory.Text = expenditure.Category;
                txtDescription.Text = expenditure.Description;
                numericUpDownValue.Value = expenditure.Value;

                btnAction.Text = "Actualizar";
                txtTitle.Text = "Corregir gasto";
                txtTitle.BackColor = Color.DarkOrange;
                MessageBox.Show($"{expenditure.Date}");
                pickDate.Enabled = false;
            }
            else
            {
                btnAction.Text = "Registrar";
                txtTitle.Text = "Registrar gasto";
                txtTitle.BackColor = Color.Brown;
            }

        }

        public BillsControlForm()
        {
            InitializeComponent();
            expeditureService = new ExpeditureService();

            // Configura los eventos TextChanged para cada control que quieres validar en tiempo real
            pickDate.TextChanged += Control_TextChanged;
            comboBoxCategory.TextChanged += Control_TextChanged;
            txtDescription.TextChanged += Control_TextChanged;
            numericUpDownValue.TextChanged += Control_TextChanged;

            // Registra el evento Load
            this.Load += BillsControlForm_Load;

            // Llama al método ValidateControl al cargar el formulario.
            ValidateControl(pickDate);
            ValidateControl(comboBoxCategory);
            ValidateControl(txtDescription);
            ValidateControl(numericUpDownValue);
        }

        private void BillsControlForm_Load(object sender, EventArgs e)
        {
            // Llama al método ValidateControl al cargar el formulario.
            ValidateControl(pickDate);
            ValidateControl(comboBoxCategory);
            ValidateControl(txtDescription);
            ValidateControl(numericUpDownValue);
        }

        private void Control_TextChanged(object sender, EventArgs e)
        {
            ValidateControl((Control)sender);
        }

        private void ValidateControl(Control control)
        {
            // Restablece el color de fondo del control a blanco.
            control.BackColor = SystemColors.Window;

            bool isValid = true;

            // Realiza validaciones específicas para cada control.
            if (control == pickDate)
            {
                // Validar la fecha
                DateTime selectedDate;
                if (!DateTime.TryParse(pickDate.Text, out selectedDate) || selectedDate > DateTime.Now)
                {
                    isValid = false;
                }
            }
            else if (control == comboBoxCategory)
            {
                // Validar la categoría
                if (string.IsNullOrWhiteSpace(comboBoxCategory.Text))
                {
                    isValid = false;
                }
            }
            else if (control == txtDescription)
            {
                // Validar la descripción
                if (string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    isValid = false;
                }
            }
            else if (control == numericUpDownValue)
            {
                // Validar el valor
                if (numericUpDownValue.Value <= 0)
                {
                    isValid = false;
                }
            }

            // Si el valor no es válido, resalta el fondo en rojo.
            if (!isValid)
            {
                control.BackColor = SystemColors.Info;
            }

            // Habilita o deshabilita el botón de acción según la validez global.
            btnAction.Enabled = IsValidForm();
        }

        private bool IsValidForm()
        {
            // Verifica la validez de todos los controles.
            return pickDate.BackColor == SystemColors.Window &&
                   !string.IsNullOrWhiteSpace(comboBoxCategory.Text) && // Verificación adicional para el ComboBox.
                   txtDescription.BackColor == SystemColors.Window &&
                   numericUpDownValue.BackColor == SystemColors.Window &&
                   numericUpDownValue.Value > 0;
        }

        private Expenditure CaptureData()
        {
            // Captura los datos del formulario y crea un objeto Expenditure.
            return new Expenditure
            {
                Date = pickDate.Value,
                Category = comboBoxCategory.Text,
                Description = txtDescription.Text.ToUpper(),
                Value = numericUpDownValue.Value,
                CreatedAt = DateTime.Now
            };
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (option)
                {
                    ExpeditureService expeditureService = new ExpeditureService();
                    if (expeditureService.Update(expenditure))
                    {
                        MessageBox.Show("Gasto actualizado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide(); // Limpia el formulario después de un registro exitoso.
                    };
                }
                else
                {
                    // Captura los datos y trata de crear un nuevo gasto.
                    if (expeditureService.Create(CaptureData()))
                    {
                        MessageBox.Show("Gasto registrado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm(); // Limpia el formulario después de un registro exitoso.
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el gasto. Por favor, verifica la información.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            pickDate.Value = DateTime.Now;
            comboBoxCategory.SelectedIndex = -1;
            txtDescription.Clear();
            numericUpDownValue.Value = 0;

            // Restablece el color de fondo de todos los controles a blanco.
            ResetControlColors();
        }

        private void ResetControlColors()
        {
            pickDate.BackColor = SystemColors.Window;
            comboBoxCategory.BackColor = SystemColors.Window;
            txtDescription.BackColor = SystemColors.Window;
            numericUpDownValue.BackColor = Color.FromArgb(20,20,20);

            btnAction.Enabled = false; // Deshabilita el botón después de un registro exitoso.
        }

        private void BillsControlForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
