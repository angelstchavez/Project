using Project.Business.Services;
using Project.Common.Security;
using Project.Entity;
using Project.Presentation.Main.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Project.Presentation.Main.Login
{
    public partial class LoginForm : Form
    {
        private readonly UserService userService;

        public LoginForm()
        {
            InitializeComponent();
            SetTitle();
            this.userService = new UserService();
        }

        public bool ValidateLoginFields()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Por favor, ingresa tu nombre de usuario.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingresa tu contraseña.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        public void ValidateCredentials()
        {
            try
            {
                if (ValidateLoginFields())
                {
                    string enteredPasswordHash = Encryptor.GetSHA256(txtPassword.Text);

                    User user = userService.GetAll().FirstOrDefault(u => u.Username == txtUsername.Text && u.Password == enteredPasswordHash);

                    if (user != null)
                    {
                        if (user.IsActive)
                        {
                            this.Hide();
                            DashboardForm dashboard = new DashboardForm(user);
                            dashboard.Show();
                        }
                        else
                        {
                            MessageBox.Show("Este usuario se encuentra Inactivo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas, verifique e inténtelo nuevamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetTitle()
        {
            this.txtName.Text = $"MV Arroz al Wok © Since 2023 - {DateTime.Now.Year}";
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            ValidateCredentials();
        }
    }   
}
