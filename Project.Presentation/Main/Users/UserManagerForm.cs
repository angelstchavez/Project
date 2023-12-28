using Project.Business.Services;
using System.Windows.Forms;

namespace Project.Presentation.Main.Users
{
    public partial class UserManagerForm : Form
    {
        private readonly UserService userService;

        public UserManagerForm()
        {
            userService = new UserService();
            InitializeComponent();
            LoadUsers();
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

        private void LoadUsers()
        {
            foreach (var item in userService.GetAll())
            {
                dataGridView.Rows.Add(new object[] {item.Id, item.Username, item.Password});
            }
        }
    }
}
