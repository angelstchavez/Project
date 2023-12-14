using System.Windows.Forms;

namespace Project.Presentation.Main.Users
{
    public partial class UserManagerForm : Form
    {
        public UserManagerForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            UserControlForm userControlForm = new UserControlForm();
            userControlForm.ShowDialog();
        }
    }
}
