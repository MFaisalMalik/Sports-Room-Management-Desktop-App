namespace IPT_project
{
    partial class BorrowedItemUserControl
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
            this.searchBorrowedItemTextBox = new System.Windows.Forms.TextBox();
            this.searchBorrowedItemButton = new System.Windows.Forms.Button();
            this.refreshBorrowedItemButton = new System.Windows.Forms.Button();
            this.dataGridViewBorrowedItems = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowedItems)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBorrowedItemTextBox
            // 
            this.searchBorrowedItemTextBox.Location = new System.Drawing.Point(734, 76);
            this.searchBorrowedItemTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBorrowedItemTextBox.Name = "searchBorrowedItemTextBox";
            this.searchBorrowedItemTextBox.Size = new System.Drawing.Size(76, 20);
            this.searchBorrowedItemTextBox.TabIndex = 7;
            this.searchBorrowedItemTextBox.TabStop = false;
            // 
            // searchBorrowedItemButton
            // 
            this.searchBorrowedItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBorrowedItemButton.Location = new System.Drawing.Point(823, 76);
            this.searchBorrowedItemButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBorrowedItemButton.Name = "searchBorrowedItemButton";
            this.searchBorrowedItemButton.Size = new System.Drawing.Size(56, 23);
            this.searchBorrowedItemButton.TabIndex = 6;
            this.searchBorrowedItemButton.Text = "Search";
            this.searchBorrowedItemButton.UseVisualStyleBackColor = true;
            this.searchBorrowedItemButton.Click += new System.EventHandler(this.searchBorrowedItemButton_Click);
            // 
            // refreshBorrowedItemButton
            // 
            this.refreshBorrowedItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBorrowedItemButton.Location = new System.Drawing.Point(823, 28);
            this.refreshBorrowedItemButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refreshBorrowedItemButton.Name = "refreshBorrowedItemButton";
            this.refreshBorrowedItemButton.Size = new System.Drawing.Size(56, 23);
            this.refreshBorrowedItemButton.TabIndex = 5;
            this.refreshBorrowedItemButton.Text = "Refresh";
            this.refreshBorrowedItemButton.UseVisualStyleBackColor = true;
            this.refreshBorrowedItemButton.Click += new System.EventHandler(this.refreshBorrowedItemButton_Click);
            // 
            // dataGridViewBorrowedItems
            // 
            this.dataGridViewBorrowedItems.AllowUserToAddRows = false;
            this.dataGridViewBorrowedItems.AllowUserToDeleteRows = false;
            this.dataGridViewBorrowedItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBorrowedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrowedItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewBorrowedItems.Location = new System.Drawing.Point(0, 137);
            this.dataGridViewBorrowedItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewBorrowedItems.Name = "dataGridViewBorrowedItems";
            this.dataGridViewBorrowedItems.ReadOnly = true;
            this.dataGridViewBorrowedItems.RowHeadersWidth = 51;
            this.dataGridViewBorrowedItems.RowTemplate.Height = 24;
            this.dataGridViewBorrowedItems.Size = new System.Drawing.Size(938, 364);
            this.dataGridViewBorrowedItems.TabIndex = 4;
            this.dataGridViewBorrowedItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBorrowedItems_CellContentClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(436, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(436, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quantity Borrowed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Borrowed Time  ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(436, 95);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Return Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Student Id";
            // 
            // BorrowedItemUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBorrowedItemTextBox);
            this.Controls.Add(this.searchBorrowedItemButton);
            this.Controls.Add(this.refreshBorrowedItemButton);
            this.Controls.Add(this.dataGridViewBorrowedItems);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BorrowedItemUserControl";
            this.Size = new System.Drawing.Size(938, 501);
            this.Load += new System.EventHandler(this.BorrowedItemUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowedItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBorrowedItemTextBox;
        private System.Windows.Forms.Button searchBorrowedItemButton;
        private System.Windows.Forms.Button refreshBorrowedItemButton;
        private System.Windows.Forms.DataGridView dataGridViewBorrowedItems;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
