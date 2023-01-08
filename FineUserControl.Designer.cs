namespace IPT_project
{
    partial class FineUserControl
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
            this.searchFineTextBox = new System.Windows.Forms.TextBox();
            this.searchFineButton = new System.Windows.Forms.Button();
            this.dataGridViewFine = new System.Windows.Forms.DataGridView();
            this.refreshFineButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFine)).BeginInit();
            this.SuspendLayout();
            // 
            // searchFineTextBox
            // 
            this.searchFineTextBox.Location = new System.Drawing.Point(734, 76);
            this.searchFineTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchFineTextBox.Name = "searchFineTextBox";
            this.searchFineTextBox.Size = new System.Drawing.Size(76, 20);
            this.searchFineTextBox.TabIndex = 11;
            this.searchFineTextBox.TabStop = false;
            // 
            // searchFineButton
            // 
            this.searchFineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchFineButton.Location = new System.Drawing.Point(823, 76);
            this.searchFineButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchFineButton.Name = "searchFineButton";
            this.searchFineButton.Size = new System.Drawing.Size(56, 23);
            this.searchFineButton.TabIndex = 10;
            this.searchFineButton.Text = "Search";
            this.searchFineButton.UseVisualStyleBackColor = true;
            this.searchFineButton.Click += new System.EventHandler(this.searchFineButton_Click);
            // 
            // dataGridViewFine
            // 
            this.dataGridViewFine.AllowUserToAddRows = false;
            this.dataGridViewFine.AllowUserToDeleteRows = false;
            this.dataGridViewFine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewFine.Location = new System.Drawing.Point(0, 137);
            this.dataGridViewFine.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFine.Name = "dataGridViewFine";
            this.dataGridViewFine.ReadOnly = true;
            this.dataGridViewFine.RowHeadersWidth = 51;
            this.dataGridViewFine.RowTemplate.Height = 24;
            this.dataGridViewFine.Size = new System.Drawing.Size(938, 364);
            this.dataGridViewFine.TabIndex = 8;
            // 
            // refreshFineButton
            // 
            this.refreshFineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshFineButton.Location = new System.Drawing.Point(823, 28);
            this.refreshFineButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshFineButton.Name = "refreshFineButton";
            this.refreshFineButton.Size = new System.Drawing.Size(56, 23);
            this.refreshFineButton.TabIndex = 9;
            this.refreshFineButton.Text = "Refresh";
            this.refreshFineButton.UseVisualStyleBackColor = true;
            this.refreshFineButton.Click += new System.EventHandler(this.refreshFineButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Student Id";
            // 
            // FineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchFineTextBox);
            this.Controls.Add(this.searchFineButton);
            this.Controls.Add(this.refreshFineButton);
            this.Controls.Add(this.dataGridViewFine);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FineUserControl";
            this.Size = new System.Drawing.Size(938, 501);
            this.Load += new System.EventHandler(this.FineUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchFineTextBox;
        private System.Windows.Forms.Button searchFineButton;
        private System.Windows.Forms.DataGridView dataGridViewFine;
        private System.Windows.Forms.Button refreshFineButton;
        private System.Windows.Forms.Label label1;
    }
}
