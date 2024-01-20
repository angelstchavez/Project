using Project.Business.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Project.Presentation.Main.Config
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
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

        private void GenerateBackup()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de respaldo (*.bak)|*.bak";
                saveFileDialog.FileName = $"ProjectDatabase - {DateTime.Now.ToString("dd_MM_yyyy")}.bak";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtiene la ruta seleccionada por el usuario
                    string backupFilePath = saveFileDialog.FileName;

                    // Crea una instancia de la clase Backup y llama al método Generate con la ruta proporcionada
                    BackupService backupService = new BackupService();
                    backupService.Generate(backupFilePath);

                    // Abre el explorador de archivos con la ubicación del archivo de respaldo
                    OpenFileExplorer(backupFilePath);

                    // Muestra un mensaje de copia generada exitosamente
                    MessageBox.Show("Copia generada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void OpenFileExplorer(string filePath)
        {
            try
            {
                // Utiliza Process.Start para abrir el explorador de archivos con la ubicación del archivo
                Process.Start("explorer.exe", $"/select, {filePath}");
            }
            catch (Exception ex)
            {
                // Maneja las excepciones según tus necesidades (registra, muestra mensajes, etc.)
                Console.WriteLine($"Error al abrir el explorador de archivos: {ex.Message}");
            }
        }

        private void ToggleMainButtonsState(bool state, Button button)
        {
            List<Button> buttons = new List<Button> { btnCompany, btnPrints, btnTicket, btnBackup, btnLicence };

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

        private void btnPrints_Click(object sender, System.EventArgs e)
        {
            OpenModule(new Prints.PrintForm(), btnPrints);
        }

        private void btnCompany_Click(object sender, System.EventArgs e)
        {

        }

        private void btnTicket_Click(object sender, System.EventArgs e)
        {

        }

        private void btnBackup_Click(object sender, System.EventArgs e)
        {
            GenerateBackup();
        }

        private void btnLicence_Click(object sender, System.EventArgs e)
        {

        }
    }
}
