using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddressBookLibrary.Models;

namespace WinFormsAddressBook
{
    public partial class ShowAddressForm : Form
    {
        private PersonModel _personModel;
        public ShowAddressForm(string nameTitle, PersonModel person)
        {
            InitializeComponent();

            addressTitleText.Text = $"{nameTitle}'s Addresses";
            _personModel = person;
            paintListBox(_personModel, AddressListBox);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddAddressBtn_Click(object sender, EventArgs e)
        {
            AddressModel newAddress = new(StreetAddressTextBox.Text, StateTextBox.Text, ZipCodeTextBox.Text);

            _personModel.Addresses.Add(newAddress);

            paintListBox(_personModel, AddressListBox);

            StreetAddressTextBox.Text = "";
            StateTextBox.Text = "";
            ZipCodeTextBox.Text = "";
        }

        private void AddressListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void paintListBox(PersonModel person, ListBox listBox)
        {
            listBox.BeginUpdate();

            listBox.Items.Clear();

            foreach (AddressModel address in person.Addresses)
            {
                listBox.Items.Add(address.FullAddress);
            }

            listBox.EndUpdate();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
