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
            UserControlForm userControlForm = new UserControlForm(true);
            userControlForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            UserControlForm userControlForm = new UserControlForm(false);
            userControlForm.ShowDialog();
        }

        private void button6_Click(object sender, System.EventArgs e)
        {

        }
    }
}
