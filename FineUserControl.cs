using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPT_project
{
    public partial class FineUserControl : UserControl
    {
        private static FineUserControl _instance;
        private BindingList<Fine> fine;
        private HttpClient client;

        public FineUserControl()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7201/api/");
        }

        public static FineUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FineUserControl();
                return _instance;
            }
        }


        private void FineUserControl_Load(object sender, EventArgs e)
        {
            getAllRecords();
        }

        private void getAllRecords()
        {
            HttpResponseMessage response = client.GetAsync("Fine/GetAllFines").Result;
            fine = response.Content.ReadAsAsync<BindingList<Fine>>().Result;
            dataGridViewFine.DataSource = fine;
            dataGridViewFine.Columns["itemId"].Visible = false;
        }

        private void searchFineButton_Click(object sender, EventArgs e)
        {
            if (searchFineTextBox.Text != "")
            {
                HttpResponseMessage response = client.GetAsync("Fine/GetFineByStudentId/" + searchFineTextBox.Text).Result;
                fine = response.Content.ReadAsAsync<BindingList<Fine>>().Result;
                dataGridViewFine.DataSource = fine;
                dataGridViewFine.Columns["itemId"].Visible = false;
            }
        }

        private void refreshFineButton_Click(object sender, EventArgs e)
        {
            getAllRecords();
        }
    }
}
