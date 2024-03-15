namespace WinFormsAddressBook
{
    partial class AddressBookForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameTextBox = new TextBox();
            FirstNameLabel = new Label();
            lastNameTextBox = new TextBox();
            label1 = new Label();
            AddNameBtn = new Button();
            NameAddressBox = new ListBox();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(131, 55);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(272, 35);
            firstNameTextBox.TabIndex = 0;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(12, 58);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(113, 30);
            FirstNameLabel.TabIndex = 1;
            FirstNameLabel.Text = "First Name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(131, 113);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(272, 35);
            lastNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 116);
            label1.Name = "label1";
            label1.Size = new Size(112, 30);
            label1.TabIndex = 3;
            label1.Text = "Last Name";
            // 
            // AddNameBtn
            // 
            AddNameBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddNameBtn.Location = new Point(328, 169);
            AddNameBtn.Name = "AddNameBtn";
            AddNameBtn.Size = new Size(75, 32);
            AddNameBtn.TabIndex = 5;
            AddNameBtn.Text = "Add";
            AddNameBtn.UseVisualStyleBackColor = true;
            AddNameBtn.Click += AddNameBtn_Click;
            // 
            // NameAddressBox
            // 
            NameAddressBox.FormattingEnabled = true;
            NameAddressBox.ItemHeight = 30;
            NameAddressBox.Location = new Point(12, 207);
            NameAddressBox.Name = "NameAddressBox";
            NameAddressBox.Size = new Size(391, 304);
            NameAddressBox.TabIndex = 6;
            NameAddressBox.SelectedIndexChanged += NameAddressBox_SelectedIndexChanged;
            // 
            // AddressBookForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(NameAddressBox);
            Controls.Add(AddNameBtn);
            Controls.Add(label1);
            Controls.Add(lastNameTextBox);
            Controls.Add(FirstNameLabel);
            Controls.Add(firstNameTextBox);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "AddressBookForm";
            Text = "Address Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextBox;
        private Label FirstNameLabel;
        private TextBox lastNameTextBox;
        private Label label1;
        private Button AddNameBtn;
        private ListBox NameAddressBox;
    }
}
