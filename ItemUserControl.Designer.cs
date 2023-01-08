namespace IPT_project
{
    partial class ItemUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.addItemButton = new System.Windows.Forms.Button();
            this.searchItemButton = new System.Windows.Forms.Button();
            this.searchItemTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.refreshItemButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewItems.Location = new System.Drawing.Point(0, 137);
            this.dataGridViewItems.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.RowHeadersWidth = 51;
            this.dataGridViewItems.RowTemplate.Height = 24;
            this.dataGridViewItems.Size = new System.Drawing.Size(938, 364);
            this.dataGridViewItems.TabIndex = 0;
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellContentClick);
            // 
            // addItemButton
            // 
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemButton.Location = new System.Drawing.Point(824, 54);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(56, 23);
            this.addItemButton.TabIndex = 1;
            this.addItemButton.Text = "Add";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // searchItemButton
            // 
            this.searchItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchItemButton.Location = new System.Drawing.Point(824, 94);
            this.searchItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchItemButton.Name = "searchItemButton";
            this.searchItemButton.Size = new System.Drawing.Size(56, 23);
            this.searchItemButton.TabIndex = 2;
            this.searchItemButton.Text = "Search";
            this.searchItemButton.UseVisualStyleBackColor = true;
            this.searchItemButton.Click += new System.EventHandler(this.searchItemButton_Click);
            // 
            // searchItemTextBox
            // 
            this.searchItemTextBox.Location = new System.Drawing.Point(735, 94);
            this.searchItemTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchItemTextBox.Name = "searchItemTextBox";
            this.searchItemTextBox.Size = new System.Drawing.Size(76, 20);
            this.searchItemTextBox.TabIndex = 3;
            this.searchItemTextBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price Per Item  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(416, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(416, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(416, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Item Name";
            // 
            // refreshItemButton
            // 
            this.refreshItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshItemButton.Location = new System.Drawing.Point(824, 15);
            this.refreshItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshItemButton.Name = "refreshItemButton";
            this.refreshItemButton.Size = new System.Drawing.Size(56, 23);
            this.refreshItemButton.TabIndex = 13;
            this.refreshItemButton.Text = "Refresh";
            this.refreshItemButton.UseVisualStyleBackColor = true;
            this.refreshItemButton.Click += new System.EventHandler(this.refreshItemButton_Click);
            // 
            // ItemUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshItemButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchItemTextBox);
            this.Controls.Add(this.searchItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.dataGridViewItems);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ItemUserControl";
            this.Size = new System.Drawing.Size(938, 501);
            this.Load += new System.EventHandler(this.ItemUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button searchItemButton;
        private System.Windows.Forms.TextBox searchItemTextBox;
        public System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button refreshItemButton;
    }
}
