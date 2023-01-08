using System;
using System.ComponentModel;
using System.Net.Http;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace IPT_project
{
    public partial class ItemUserControl : UserControl
    {
        private static ItemUserControl _instance;
        private BindingList<Items> item;
        private HttpClient client;

        public ItemUserControl()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7201/api/");
        }

        public static ItemUserControl Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new ItemUserControl();
                return _instance;
            }
        }

        private void ItemUserControl_Load(object sender, EventArgs e)
        {
            getAllRecords();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Text = "Update";
            btn.Name = "updateButton";
            btn.UseColumnTextForButtonValue = true;
            dataGridViewItems.Columns.Add(btn);

            btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Text = "Delete";
            btn.Name = "deleteButton";
            btn.UseColumnTextForButtonValue = true;
            dataGridViewItems.Columns.Add(btn);

            btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Text = "Borrow";
            btn.Name = "borrowButton";
            btn.UseColumnTextForButtonValue = true;
            dataGridViewItems.Columns.Add(btn);

        }

        private void getAllRecords()
        {
            HttpResponseMessage response = client.GetAsync("Items/GetAllItems").Result;
            item = response.Content.ReadAsAsync<BindingList<Items>>().Result;
            dataGridViewItems.DataSource = item;
            dataGridViewItems.Columns["id"].Visible = false;
        }

        private async void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.dataGridViewItems.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    Items obj = new Items() { name = textBox1.Text.ToString(), PricePerItem = Convert.ToInt32(textBox2.Text.ToString()), quantity = Convert.ToInt32(textBox3.Text.ToString()) };

                    await client.PutAsJsonAsync("Items/UpdateItemByItemId/" + id, obj);
                    getAllRecords();
                }
            }
            else if(e.ColumnIndex == 1)
            {
                DataGridViewRow row = this.dataGridViewItems.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                await client.DeleteAsync("Items/DeleteItemByItemId/" + id);
                item.RemoveAt(e.RowIndex);
            }
            else if (e.ColumnIndex == 2)
            {
                DataGridViewRow row = this.dataGridViewItems.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                var stdId = Interaction.InputBox("Enter Student Id", "Borrow Item");
                var qty = Interaction.InputBox("Enter Quantity Borrowed", "Borrow Item");
                var borrowDate = Interaction.InputBox("Enter Borrow Date", "Borrow Item");
                var returnDate = Interaction.InputBox("Enter Return Date", "Borrow Item");

                if (id != "" && stdId != "" && qty != "" && borrowDate != "" && returnDate != "")
                {
                    BorrowedItem borrowItem = new BorrowedItem() { itemId = id, studentId = stdId, quantityBorrowed = Convert.ToInt32(qty), timeBorrowed = borrowDate, timeToBeReturned = returnDate };
                    await client.PostAsJsonAsync("BorrowedItem/AddBorrowedItem", borrowItem);
                }
            }

        }

        private void searchItemButton_Click(object sender, EventArgs e)
        {
            if (searchItemTextBox.Text != "")
            {
                HttpResponseMessage response = client.GetAsync("Items/GetItemByItemName/" + searchItemTextBox.Text).Result;
                item = response.Content.ReadAsAsync<BindingList<Items>>().Result;
                dataGridViewItems.DataSource = item;
                dataGridViewItems.Columns["id"].Visible = false;
            }
        }

        private async void addItemButton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                Items obj = new Items() {name = textBox1.Text.ToString(), PricePerItem = Convert.ToInt32(textBox2.Text.ToString()), quantity = Convert.ToInt32(textBox3.Text.ToString()) };

                await client.PostAsJsonAsync("Items/AddItem", obj);
                getAllRecords();
            }
        }

        private void refreshItemButton_Click(object sender, EventArgs e)
        {
            getAllRecords();
        }
    }
}
