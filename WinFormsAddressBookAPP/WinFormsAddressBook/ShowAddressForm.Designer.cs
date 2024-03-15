namespace WinFormsAddressBook
{
    partial class ShowAddressForm
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
            StreetAddressTextBox = new TextBox();
            addressTitleText = new Label();
            StateAddressLabel = new Label();
            StateLabel = new Label();
            StateTextBox = new TextBox();
            ZipCodeTextBox = new TextBox();
            ZipCodeLabel = new Label();
            AddressListBox = new ListBox();
            AddAddressBtn = new Button();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // StreetAddressTextBox
            // 
            StreetAddressTextBox.Location = new Point(164, 57);
            StreetAddressTextBox.Name = "StreetAddressTextBox";
            StreetAddressTextBox.Size = new Size(352, 35);
            StreetAddressTextBox.TabIndex = 0;
            // 
            // addressTitleText
            // 
            addressTitleText.AutoSize = true;
            addressTitleText.Location = new Point(282, 13);
            addressTitleText.Name = "addressTitleText";
            addressTitleText.Size = new Size(68, 30);
            addressTitleText.TabIndex = 1;
            addressTitleText.Text = "label1";
            // 
            // StateAddressLabel
            // 
            StateAddressLabel.AutoSize = true;
            StateAddressLabel.Location = new Point(12, 60);
            StateAddressLabel.Name = "StateAddressLabel";
            StateAddressLabel.Size = new Size(146, 30);
            StateAddressLabel.TabIndex = 2;
            StateAddressLabel.Text = "Street Address";
            StateAddressLabel.Click += label1_Click;
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(99, 114);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(59, 30);
            StateLabel.TabIndex = 3;
            StateLabel.Text = "State";
            // 
            // StateTextBox
            // 
            StateTextBox.Location = new Point(164, 111);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(352, 35);
            StateTextBox.TabIndex = 4;
            // 
            // ZipCodeTextBox
            // 
            ZipCodeTextBox.Location = new Point(164, 164);
            ZipCodeTextBox.Name = "ZipCodeTextBox";
            ZipCodeTextBox.Size = new Size(352, 35);
            ZipCodeTextBox.TabIndex = 5;
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Location = new Point(62, 167);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(96, 30);
            ZipCodeLabel.TabIndex = 6;
            ZipCodeLabel.Text = "Zip Code";
            // 
            // AddressListBox
            // 
            AddressListBox.FormattingEnabled = true;
            AddressListBox.ItemHeight = 30;
            AddressListBox.Location = new Point(12, 261);
            AddressListBox.Name = "AddressListBox";
            AddressListBox.Size = new Size(624, 394);
            AddressListBox.TabIndex = 7;
            AddressListBox.SelectedIndexChanged += AddressListBox_SelectedIndexChanged;
            // 
            // AddAddressBtn
            // 
            AddAddressBtn.Location = new Point(402, 210);
            AddAddressBtn.Name = "AddAddressBtn";
            AddAddressBtn.Size = new Size(90, 45);
            AddAddressBtn.TabIndex = 8;
            AddAddressBtn.Text = "Add";
            AddAddressBtn.UseVisualStyleBackColor = true;
            AddAddressBtn.Click += AddAddressBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(546, 210);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(90, 45);
            BackBtn.TabIndex = 9;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // ShowAddressForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 687);
            Controls.Add(BackBtn);
            Controls.Add(AddAddressBtn);
            Controls.Add(AddressListBox);
            Controls.Add(ZipCodeLabel);
            Controls.Add(ZipCodeTextBox);
            Controls.Add(StateTextBox);
            Controls.Add(StateLabel);
            Controls.Add(StateAddressLabel);
            Controls.Add(addressTitleText);
            Controls.Add(StreetAddressTextBox);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ShowAddressForm";
            Text = "ShowAddressForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox StreetAddressTextBox;
        private Label addressTitleText;
        private Label StateAddressLabel;
        private Label StateLabel;
        private TextBox StateTextBox;
        private TextBox ZipCodeTextBox;
        private Label ZipCodeLabel;
        private ListBox AddressListBox;
        private Button AddAddressBtn;
        private Button BackBtn;
    }
}