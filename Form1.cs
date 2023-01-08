using System;
using System.Windows.Forms;

namespace IPT_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //           itemUserControl.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void itemButton_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ItemUserControl.Instance))
            {
                panel.Controls.Add(ItemUserControl.Instance);
                ItemUserControl.Instance.Dock =  DockStyle.Fill;
            }
            ItemUserControl.Instance.BringToFront();
        }

        private void borrowedItemButton_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(BorrowedItemUserControl.Instance))
            {
                panel.Controls.Add(BorrowedItemUserControl.Instance);
                BorrowedItemUserControl.Instance.Dock = DockStyle.Fill;
            }
            BorrowedItemUserControl.Instance.BringToFront();

        }

        private void fineButton_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(FineUserControl.Instance))
            {
                panel.Controls.Add(FineUserControl.Instance);
                FineUserControl.Instance.Dock = DockStyle.Fill;
            }
            FineUserControl.Instance.BringToFront();

        }

    }
}
