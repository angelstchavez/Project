using Project.Business.Services;
using Project.Entity;
using System;
using System.Windows.Forms;

namespace Project.Presentation.Main.Users
{
    public partial class UserControlForm : Form
    {
        private bool _option;
        private UserService userService;

        public UserControlForm(bool option)
        {
            InitializeComponent();
            userService = new UserService();
            _option = option;
            SetTitle();
        }

        private void SetTitle()
        {
            if (_option)
            {
                txtTitle.Text = "Registrar usuario";
            }
            else
            {
                txtTitle.Text = "Actualizar usuario";
            }
        }

        private bool IsValidatePassword()
        {
            return txtPassword.Text == txtConfirmPassword.Text;
        }

        private bool Create()
        {
            User user = new User();

            user.Username = txtUsername.Text;

            if (IsValidatePassword())
            {
                user.Password = txtConfirmPassword.Text;
            }

            return userService.Create(user);
        }

        private void Edit()
        {

        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (_option) { Create(); } else { Edit(); }
            this.Hide();
        }

        private void UserControlForm_Load(object sender, EventArgs e)
        {

        }
    }
}
