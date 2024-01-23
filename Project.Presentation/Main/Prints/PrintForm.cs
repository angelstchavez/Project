using Project.Business.Services;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project.Presentation.Main.Prints
{
    public partial class PrintForm : Form
    {
        private readonly PrintingAreaService printingAreaService;

        public PrintForm()
        {
            this.printingAreaService = new PrintingAreaService();
            InitializeComponent();
            DrawPrintingAreas();
        }

        private void DrawPrintingAreas()
        {
            try
            {
                flowPrintingAreas.Controls.Clear();
                IEnumerable<PrintingArea> printingAreas = printingAreaService.GetAll();

                foreach (var printingArea in printingAreas)
                {
                    CreatePrintingAreaElements(printingArea);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void CreatePrintingAreaElements(PrintingArea printingArea)
        {
            Label b = new Label();

            b.Text = printingArea.Name;
            b.Name = printingArea.Id.ToString();
            b.Size = new Size(190, 50);
            b.Font = new Font("Arial", 12);
            b.ForeColor = Color.White;
            b.BackColor = Color.FromArgb(20,20,20);
            b.Dock = DockStyle.Top;
            b.TextAlign = ContentAlignment.MiddleCenter;
            b.Cursor = Cursors.Hand;

            flowPrintingAreas.Controls.Add(b);

            //b.Click += new EventHandler(myLabelEvent); // Ajustar el evento según sea necesario
        }


    }
}
