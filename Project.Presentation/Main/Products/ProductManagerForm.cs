using Project.Business.Services;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project.Presentation.Main.Products
{
    public partial class ProductManagerForm : Form
    {
        private readonly ProductCategoryService productCategoryService;
        private Panel selectedCategoryPanel;
        public static int productCategoryId;

        public ProductManagerForm()
        {
            productCategoryService = new ProductCategoryService();
            InitializeComponent();
            DrawProductCategories();
        }

        #region Functions

        private void DrawProductCategories()
        {
            try
            {
                flowCategories.Controls.Clear();
                IEnumerable<ProductCategory> categories = productCategoryService.GetAll();

                foreach (var category in categories)
                {
                    CreateCategoryElements(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void CreateCategoryElements(ProductCategory category)
        {
            Label b = new Label();
            Panel p1 = new Panel();
            Panel p2 = new Panel();

            b.Text = category.Name;
            b.Name = category.Id.ToString();
            b.Size = new Size(119, 25);
            b.Font = new Font("Arial", 12);
            b.BackColor = Color.Transparent;
            b.ForeColor = Color.Black;
            b.Dock = DockStyle.Fill;
            b.TextAlign = ContentAlignment.MiddleCenter;
            b.Cursor = Cursors.Hand;

            p1.Size = new Size(155, 133);
            p1.BorderStyle = BorderStyle.FixedSingle;
            p1.Dock = DockStyle.Bottom;
            p1.BackColor = Color.FromArgb(220, 220, 220);
            p1.Name = category.Id.ToString();

            p2.Size = new Size(155, 25);
            p2.Dock = DockStyle.Top;
            p2.BackColor = Color.Transparent;
            p2.BorderStyle = BorderStyle.None;

            MenuStrip Menustrip = new MenuStrip();
            Menustrip.BackColor = Color.Transparent;
            Menustrip.AutoSize = false;
            Menustrip.Size = new Size(28, 24);
            Menustrip.Dock = DockStyle.Right;
            Menustrip.Name = category.Id.ToString();
            ToolStripMenuItem ToolStripPRINCIPAL = new ToolStripMenuItem();
            ToolStripMenuItem ToolStripEdit = new ToolStripMenuItem();
            ToolStripMenuItem ToolStripDelete = new ToolStripMenuItem();
            ToolStripMenuItem ToolStripRestart = new ToolStripMenuItem();

            //ToolStripPRINCIPAL.Image = Properties.Resources._16_config;
            ToolStripPRINCIPAL.BackColor = Color.Transparent;

            ToolStripEdit.Text = "Editar";
            ToolStripEdit.Name = category.Name;
            ToolStripEdit.Tag = category.Id.ToString();

            ToolStripDelete.Text = "Eliminar";
            ToolStripDelete.Tag = category.Id.ToString();

            ToolStripRestart.Text = "Restaurar";
            ToolStripRestart.Tag = category.Id.ToString();

            Menustrip.Items.Add(ToolStripPRINCIPAL);
            ToolStripPRINCIPAL.DropDownItems.Add(ToolStripEdit);
            ToolStripPRINCIPAL.DropDownItems.Add(ToolStripDelete);
            ToolStripPRINCIPAL.DropDownItems.Add(ToolStripRestart);

            p2.Controls.Add(Menustrip);
            p1.Controls.Add(b);
            p1.Controls.Add(p2);

            b.BringToFront();
            p2.SendToBack();
            flowCategories.Controls.Add(p1);

            b.Click += new EventHandler(myLabelEvent);
        }

        private void myLabelEvent(Object sender, EventArgs e)
        {
            if (selectedCategoryPanel != null)
            {
                selectedCategoryPanel.BackColor = Color.FromArgb(220, 220, 220);
            }

            selectedCategoryPanel = ((Label)sender).Parent as Panel;

            if (selectedCategoryPanel != null)
            {
                selectedCategoryPanel.BackColor = Color.FromArgb(160, 160, 160);
            }

            productCategoryId = Convert.ToInt32(((Label)sender).Name);
            //DisplayProductsByGroup(productCategoryId);
        }

        #endregion

        #region Events

        #endregion
    }
}
