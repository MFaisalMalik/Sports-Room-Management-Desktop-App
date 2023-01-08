namespace IPT_project
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.itemButton = new System.Windows.Forms.Button();
            this.borrowedItemButton = new System.Windows.Forms.Button();
            this.fineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(-9, 125);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1251, 617);
            this.panel.TabIndex = 0;
            // 
            // itemButton
            // 
            this.itemButton.Location = new System.Drawing.Point(12, 12);
            this.itemButton.Name = "itemButton";
            this.itemButton.Size = new System.Drawing.Size(123, 71);
            this.itemButton.TabIndex = 2;
            this.itemButton.Text = "Items";
            this.itemButton.UseVisualStyleBackColor = true;
            this.itemButton.Click += new System.EventHandler(this.itemButton_Click);
            // 
            // borrowedItemButton
            // 
            this.borrowedItemButton.Location = new System.Drawing.Point(167, 12);
            this.borrowedItemButton.Name = "borrowedItemButton";
            this.borrowedItemButton.Size = new System.Drawing.Size(123, 71);
            this.borrowedItemButton.TabIndex = 3;
            this.borrowedItemButton.Text = "Borrowed Items";
            this.borrowedItemButton.UseVisualStyleBackColor = true;
            this.borrowedItemButton.Click += new System.EventHandler(this.borrowedItemButton_Click);
            // 
            // fineButton
            // 
            this.fineButton.Location = new System.Drawing.Point(323, 12);
            this.fineButton.Name = "fineButton";
            this.fineButton.Size = new System.Drawing.Size(123, 71);
            this.fineButton.TabIndex = 4;
            this.fineButton.Text = "Fine";
            this.fineButton.UseVisualStyleBackColor = true;
            this.fineButton.Click += new System.EventHandler(this.fineButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 738);
            this.Controls.Add(this.fineButton);
            this.Controls.Add(this.borrowedItemButton);
            this.Controls.Add(this.itemButton);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button itemButton;
        private System.Windows.Forms.Button borrowedItemButton;
        private System.Windows.Forms.Button fineButton;
    }
}

