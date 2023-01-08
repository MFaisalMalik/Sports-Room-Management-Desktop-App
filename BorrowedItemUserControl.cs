using System;
using System.ComponentModel;
using System.Net.Http;
using System.Windows.Forms;

namespace IPT_project
{
    public partial class BorrowedItemUserControl : UserControl
    {

        private static BorrowedItemUserControl _instance;
        private BindingList<BorrowedItem> borrowedItem;
        private HttpClient client;
        public BorrowedItemUserControl()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7201/api/");
        }

        public static BorrowedItemUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BorrowedItemUserControl();
                return _instance;
            }
        }

        private void BorrowedItemUserControl_Load(object sender, EventArgs e)
        {
            getAllRecords();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Text = "Update";
            btn.Name = "updateButton";
            btn.UseColumnTextForButtonValue = true;
            dataGridViewBorrowedItems.Columns.Add(btn);

            btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Text = "Delete";
            btn.Name = "deleteButton";
            btn.UseColumnTextForButtonValue = true;
            dataGridViewBorrowedItems.Columns.Add(btn);
        }

        private void getAllRecords()
        {
            HttpResponseMessage response = client.GetAsync("BorrowedItem/GetAllBorrowedItems").Result;
            borrowedItem = response.Content.ReadAsAsync<BindingList<BorrowedItem>>().Result;
            dataGridViewBorrowedItems.DataSource = borrowedItem;
            dataGridViewBorrowedItems.Columns["itemId"].Visible = false;
        }

        private async void dataGridViewBorrowedItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.dataGridViewBorrowedItems.Rows[e.RowIndex];
                string itemId = row.Cells["itemId"].Value.ToString();
                string stdId = row.Cells["studentId"].Value.ToString();
                if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    BorrowedItem obj = new BorrowedItem() {studentId = stdId ,timeBorrowed = textBox2.Text.ToString(), quantityBorrowed = Convert.ToInt32(textBox3.Text.ToString()), timeToBeReturned = textBox4.Text.ToString() };

                    await client.PutAsJsonAsync("BorrowedItem/UpdateBorrowedItemByItemIdAndStudentID/" + itemId + "/" + stdId, obj);
                    getAllRecords();
                }
            }
            else if (e.ColumnIndex == 1)
            {
                DataGridViewRow row = this.dataGridViewBorrowedItems.Rows[e.RowIndex];
                string id = row.Cells["itemId"].Value.ToString();
                string studentId = row.Cells["studentId"].Value.ToString();
                await client.DeleteAsync("BorrowedItem/DeleteBorrowedItemByItemIdAndStudentID/" + id + "/" + studentId);
                borrowedItem.RemoveAt(e.RowIndex);
            }
        }

        private void refreshBorrowedItemButton_Click(object sender, EventArgs e)
        {
            getAllRecords();
        }

        private void searchBorrowedItemButton_Click(object sender, EventArgs e)
        {
            if (searchBorrowedItemTextBox.Text != "" )
            {
                HttpResponseMessage response = client.GetAsync("BorrowedItem/GetBorrowedItemByStudentId/" + searchBorrowedItemTextBox.Text).Result;
                borrowedItem = response.Content.ReadAsAsync<BindingList<BorrowedItem>>().Result;
                dataGridViewBorrowedItems.DataSource = borrowedItem;
                dataGridViewBorrowedItems.Columns["itemId"].Visible = false;
            }
        }
    }
}
