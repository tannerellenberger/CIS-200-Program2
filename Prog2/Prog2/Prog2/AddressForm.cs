using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class AddressForm : Form
    {
        
    

        public AddressForm()
        {
            InitializeComponent();
        }


        // I think internal fields are needed here but I can't
        // get the results to populate on to the main form regardless


        //Pre: attempt to change from nameTextBox
        //Post: If string is > 0 focus will change, otherwise
        //      error message will pop up focus does not change
        private void nameValidating(object sender, CancelEventArgs e)
        {
            if (nameTextBox.TextLength == 0)
            {
                e.Cancel = true; // Stops focus

                errorProvider1.SetError(nameTextBox, "Please enter a name.");
                nameTextBox.SelectAll();

            }
        }

        //Pre: name validating was successful
        //Post: focus changes, error message deleted
        private void nameValidated(object sender, EventArgs e)
        {
            errorProvider1.SetError(nameTextBox, "");
        }

        //Pre: attempt to change from addressTextBox
        //Post: If string is > 0 focus will change, otherwise
        //      error message will pop up focus does not change
        private void addressValidating(object sender, CancelEventArgs e)
        {
            if (addressTextBox.TextLength == 0)
            {
                e.Cancel = true; // Stops focus

                errorProvider1.SetError(addressTextBox, "Please enter an address.");
                nameTextBox.SelectAll();
            }
        }

        //Pre: address validating successful
        //Post: focus changes, error deleted
        private void addressValidated(object sender, EventArgs e)
        {
            errorProvider1.SetError(addressTextBox, "");
        }

        //Pre: attempt to change from cityTextBox
        //Post: If string is > 0 focus will change, otherwise
        //      error message will pop up focus does not change
        private void cityValidating(object sender, CancelEventArgs e)
        {
            if (cityTextBox.TextLength == 0)
            {
                e.Cancel = true; // Stops focus

                errorProvider1.SetError(cityTextBox, "Please enter a city.");
                nameTextBox.SelectAll();
            }
        }

        //Pre: city validating successful
        //Post: focus changes, error deleted
        private void cityValidated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cityTextBox, "");
        }

        //Pre: attepmt to change from stateComboBox
        //Post: If string is > 0 focus will change, otherwise
        //      error message will pop up focus does not change
        private void stateValidating(object sender, CancelEventArgs e)
        {
            if (stateComboBox.SelectedIndex < 0)
            {
                e.Cancel = true; // Stops focus

                errorProvider1.SetError(stateComboBox, "Please select a state.");
                nameTextBox.SelectAll();
            }
        }

        //Pre: state validating successful
        //Post: focus changes, error deleted
        private void stateValidated(object sender, EventArgs e)
        {
            errorProvider1.SetError(stateComboBox, "");
        }

        //Pre: attepmt to change from zipTextBox
        //Post: If string is > 0 focus will change, otherwise
        //      error message will pop up focus does not change
        private void zipValidating(object sender, CancelEventArgs e)
        {
            if (zipTextBox.TextLength == 0)
            {
                e.Cancel = true; // Stops focus

                errorProvider1.SetError(zipTextBox, "Please enter a zipcode.");
                nameTextBox.SelectAll();
            }
        }

        //Pre: zipcode validating successful
        //Post: focus changes, error deleted
        private void zipValidated(object sender, EventArgs e)
        {
            errorProvider1.SetError(zipTextBox, "");
        }

        //Pre: user clicks on OK button
        //Post: if all items are validated it will be saved
        private void okButtonAdd_Click(object sender, EventArgs e)
        {
                if (this.ValidateChildren())
                    this.DialogResult = DialogResult.OK;
        }

        //Pre: user clicks cancel button
        //Post: will only cancel if data is valid
        private void cancelButtonAddDown(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
