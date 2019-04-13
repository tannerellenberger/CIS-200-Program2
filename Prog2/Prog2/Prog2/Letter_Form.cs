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
    public partial class Letter_Form : Form
    {

        private List<Address> addressList;  // list of addresses used

        public Letter_Form(List<Address> addresses)
        {
            InitializeComponent();
            addressList = addresses;
        }
      

        internal int OrginAddress
        {
             
            get { return orgAddressBox.SelectedIndex; }

            
            set { orgAddressBox.SelectedIndex = value; }

        }

        internal int DestinationAddress
        {
            
            get { return destAddressBox.SelectedIndex; }

            
            set { destAddressBox.SelectedIndex = value; }
        }

        //Pre: User has clicked on Letter tab
        //Post: Letter form loads Names into the combo boxes using loop
        private void Letter_Form_Load(object sender, EventArgs e)
        {
            foreach (Address a in addressList)
            {
                orgAddressBox.Items.Add(a.Name);
                destAddressBox.Items.Add(a.Name);
            }
        }


        //Pre: attepmt to change from orgAddressBox
        //Post: If index is > 0 focus will change, otherwise
        //      error message will pop up focus does not change
        private void orgAddressBox_Validating(object sender, CancelEventArgs e)
        {
            if (orgAddressBox.SelectedIndex < 0)
            {
                e.Cancel = true; // Stops focus

                errorProvider1.SetError(orgAddressBox, "Please select an address");
                orgAddressBox.SelectAll();
            }
        }

        //Pre: org address validating successful 
        //Post: focus changes, error deleted
        private void orgAddressBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(orgAddressBox, "");
        }

        //Pre: attempt to change from destAddressBox
        //Post: If index is > 0 focus will change, otherwise
        //      error message will pop up focus does not change
        private void destAddressBox_Validating(object sender, CancelEventArgs e)
        {
            if (destAddressBox.SelectedIndex < 0)
            {
                e.Cancel = true; // Stops focus

                errorProvider1.SetError(destAddressBox, "Please select a state.");
                destAddressBox.SelectAll();
            }
        }

        //Pre: destAddress validating successful
        //Post: focus changes, error deleted
        private void destAddressBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(destAddressBox, "");
        }

        //Pre: attempt to change from destAddressBox
        //Post: If number is > 0 focus will change, otherwise
        //      error message will pop up focus does not change
        private void fixedCost_Validating(object sender, CancelEventArgs e)
        {
            int number;

            if (!int.TryParse(fixedCostTextBox.Text, out number))
            {
                e.Cancel = true; // Stops focus

                errorProvider1.SetError(fixedCostTextBox, "Please enter a cost.");
                destAddressBox.SelectAll();
            }
        }

        //Pre: fixedCost validating successful
        //Post: focus changes, error deleted
        private void fixedCost_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(fixedCostTextBox, "");
        }

        //Pre: user clicks on OK button
        //Post: if all items are validated it will be saved
        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        //Pre: user clicks cancel button
        //Post: will only cancel if data is valid
        private void cancelButtonDown(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
