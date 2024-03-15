using AddressBookLibrary.Models;
using System.Runtime.InteropServices;

namespace WinFormsAddressBook
{
    public partial class AddressBookForm : Form
    {
        public List<PersonModel> NameList = [];
        public AddressBookForm()
        {
            InitializeComponent();
        }

        private void AddNameBtn_Click(object sender, EventArgs e)
        {
            PersonModel person = new(firstNameTextBox.Text, lastNameTextBox.Text);
            NameList.Add(person);
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";

            paintListBox(NameList, NameAddressBox);
        }

        private void NameAddressBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox? item = sender as ListBox;  
            ShowAddressForm showAddressForm = new(item.Items[item.SelectedIndex].ToString(), NameList[item.SelectedIndex]);
            showAddressForm.Show();
        }


        private void paintListBox(List<PersonModel> personList, ListBox listBox)
        {
            listBox.BeginUpdate();

            listBox.Items.Clear();

            foreach (PersonModel person in personList)
            {
                listBox.Items.Add(person.FullName);
            }

            listBox.EndUpdate();
        }
    }
}
