namespace SQLProject
{
    partial class Dashboard
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
            this.customerFoundListBox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstNameInsLabel = new System.Windows.Forms.Label();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.phoneNumberInsLabel = new System.Windows.Forms.Label();
            this.phoneInsText = new System.Windows.Forms.TextBox();
            this.countryInsLabel = new System.Windows.Forms.Label();
            this.countryInsText = new System.Windows.Forms.TextBox();
            this.cityInsLabel = new System.Windows.Forms.Label();
            this.cityInsText = new System.Windows.Forms.TextBox();
            this.insertRecordButton = new System.Windows.Forms.Button();
            this.lastname2InsLabel = new System.Windows.Forms.Label();
            this.lastname2InsText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // customerFoundListBox
            // 
            this.customerFoundListBox.FormattingEnabled = true;
            this.customerFoundListBox.ItemHeight = 20;
            this.customerFoundListBox.Location = new System.Drawing.Point(12, 106);
            this.customerFoundListBox.Name = "customerFoundListBox";
            this.customerFoundListBox.Size = new System.Drawing.Size(320, 324);
            this.customerFoundListBox.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(100, 59);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(138, 26);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(8, 62);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(256, 54);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(76, 36);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameInsLabel
            // 
            this.firstNameInsLabel.AutoSize = true;
            this.firstNameInsLabel.Location = new System.Drawing.Point(453, 54);
            this.firstNameInsLabel.Name = "firstNameInsLabel";
            this.firstNameInsLabel.Size = new System.Drawing.Size(86, 20);
            this.firstNameInsLabel.TabIndex = 5;
            this.firstNameInsLabel.Text = "First Name";
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.Location = new System.Drawing.Point(545, 51);
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.Size = new System.Drawing.Size(138, 26);
            this.firstNameInsText.TabIndex = 4;
            // 
            // phoneNumberInsLabel
            // 
            this.phoneNumberInsLabel.AutoSize = true;
            this.phoneNumberInsLabel.Location = new System.Drawing.Point(453, 180);
            this.phoneNumberInsLabel.Name = "phoneNumberInsLabel";
            this.phoneNumberInsLabel.Size = new System.Drawing.Size(55, 20);
            this.phoneNumberInsLabel.TabIndex = 7;
            this.phoneNumberInsLabel.Text = "Phone";
            // 
            // phoneInsText
            // 
            this.phoneInsText.Location = new System.Drawing.Point(545, 177);
            this.phoneInsText.Name = "phoneInsText";
            this.phoneInsText.Size = new System.Drawing.Size(138, 26);
            this.phoneInsText.TabIndex = 6;
            // 
            // countryInsLabel
            // 
            this.countryInsLabel.AutoSize = true;
            this.countryInsLabel.Location = new System.Drawing.Point(453, 145);
            this.countryInsLabel.Name = "countryInsLabel";
            this.countryInsLabel.Size = new System.Drawing.Size(64, 20);
            this.countryInsLabel.TabIndex = 9;
            this.countryInsLabel.Text = "Country";
            // 
            // countryInsText
            // 
            this.countryInsText.Location = new System.Drawing.Point(545, 145);
            this.countryInsText.Name = "countryInsText";
            this.countryInsText.Size = new System.Drawing.Size(138, 26);
            this.countryInsText.TabIndex = 8;
            // 
            // cityInsLabel
            // 
            this.cityInsLabel.AutoSize = true;
            this.cityInsLabel.Location = new System.Drawing.Point(453, 116);
            this.cityInsLabel.Name = "cityInsLabel";
            this.cityInsLabel.Size = new System.Drawing.Size(35, 20);
            this.cityInsLabel.TabIndex = 11;
            this.cityInsLabel.Text = "City";
            // 
            // cityInsText
            // 
            this.cityInsText.Location = new System.Drawing.Point(545, 113);
            this.cityInsText.Name = "cityInsText";
            this.cityInsText.Size = new System.Drawing.Size(138, 26);
            this.cityInsText.TabIndex = 10;
            // 
            // insertRecordButton
            // 
            this.insertRecordButton.Location = new System.Drawing.Point(486, 227);
            this.insertRecordButton.Name = "insertRecordButton";
            this.insertRecordButton.Size = new System.Drawing.Size(171, 81);
            this.insertRecordButton.TabIndex = 12;
            this.insertRecordButton.Text = "Insert";
            this.insertRecordButton.UseVisualStyleBackColor = true;
            this.insertRecordButton.Click += new System.EventHandler(this.insertRecordButton_Click);
            // 
            // lastname2InsLabel
            // 
            this.lastname2InsLabel.AutoSize = true;
            this.lastname2InsLabel.Location = new System.Drawing.Point(453, 81);
            this.lastname2InsLabel.Name = "lastname2InsLabel";
            this.lastname2InsLabel.Size = new System.Drawing.Size(84, 20);
            this.lastname2InsLabel.TabIndex = 14;
            this.lastname2InsLabel.Text = "Last name";
            // 
            // lastname2InsText
            // 
            this.lastname2InsText.Location = new System.Drawing.Point(545, 81);
            this.lastname2InsText.Name = "lastname2InsText";
            this.lastname2InsText.Size = new System.Drawing.Size(138, 26);
            this.lastname2InsText.TabIndex = 13;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(730, 503);
            this.Controls.Add(this.lastname2InsLabel);
            this.Controls.Add(this.lastname2InsText);
            this.Controls.Add(this.insertRecordButton);
            this.Controls.Add(this.cityInsLabel);
            this.Controls.Add(this.cityInsText);
            this.Controls.Add(this.countryInsLabel);
            this.Controls.Add(this.countryInsText);
            this.Controls.Add(this.phoneNumberInsLabel);
            this.Controls.Add(this.phoneInsText);
            this.Controls.Add(this.firstNameInsLabel);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.customerFoundListBox);
            this.Name = "Dashboard";
            this.Text = "SQL Data Base";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox customerFoundListBox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label firstNameInsLabel;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.Label phoneNumberInsLabel;
        private System.Windows.Forms.TextBox phoneInsText;
        private System.Windows.Forms.Label countryInsLabel;
        private System.Windows.Forms.TextBox countryInsText;
        private System.Windows.Forms.Label cityInsLabel;
        private System.Windows.Forms.TextBox cityInsText;
        private System.Windows.Forms.Button insertRecordButton;
        private System.Windows.Forms.Label lastname2InsLabel;
        private System.Windows.Forms.TextBox lastname2InsText;
    }
}

