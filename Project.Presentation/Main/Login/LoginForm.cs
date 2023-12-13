using System;
using System.Windows.Forms;

namespace Project.Presentation.Main.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            SetTitle();
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

        }

        public void SetTitle()
        {
            this.txtName.Text = $"MV Arroz al Wok © {DateTime.Now.Year}";
        }
    }   
}
