//D3894
//Program 2
//CIS 200-01
//10-25-18
//Program creates a GUI form updates addresses and parcels
//also has address and letter forms that can hold data 
//on the main form.
                

using Prog2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        private UserParcelView upv;


        public Prog2Form()
        {
            InitializeComponent();

            upv = new UserParcelView();

            // Test Data - Magic Numbers OK
            upv.AddAddress("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            upv.AddAddress("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            upv.AddAddress("Lester Joy", "156 Hunters Place",
                "Benton", "KY", 40114);  // Test Address 5
            upv.AddAddress("Ben Polly", "67 Young Street",
                "Danville", "CA", 92108);  // Test Address 6
            upv.AddAddress("Hillary Mont", "791 Prog Ave",
                "Polar", "AL", 56123);     // Test Address 7
            upv.AddAddress("Monica Key", "091 Mice Ave",
                "Welro", "MI", 40981);     // Test Address 8


            upv.AddLetter(upv.AddressAt(0), upv.AddressAt(1), 3.95M);       // Letter test object
            upv.AddLetter(upv.AddressAt(3), upv.AddressAt(5), 8.67M);
            upv.AddGroundPackage(upv.AddressAt(6), upv.AddressAt(7), 14, 10, 5, 12.5);        // Ground test object
            upv.AddGroundPackage(upv.AddressAt(2), upv.AddressAt(4), 65, 43, 87, 115);
            upv.AddNextDayAirPackage(upv.AddressAt(3), upv.AddressAt(1), 25, 15, 15,    // Next Day test object
                85, 7.50M);
            upv.AddNextDayAirPackage(upv.AddressAt(7), upv.AddressAt(0), 34, 23, 56,
                180, 9.80M);
            upv.AddTwoDayAirPackage(upv.AddressAt(2), upv.AddressAt(6), 46.5, 39.5, 28.0, // Two Day test object
                300, TwoDayAirPackage.Delivery.Saver);
            upv.AddTwoDayAirPackage(upv.AddressAt(4), upv.AddressAt(5), 40.5, 45.3, 82.5,
                400, TwoDayAirPackage.Delivery.Early);


        }

        private void Prog2Form_Load(object sender, EventArgs e)
        {

        }

        //Pre: user clicks on about tab
        //Post: Creates a message box that displays grade ID, section #, etc
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("D3894 \nProgram 2 \nCIS-200-01 \nOctober 24th 2018 \nProgram creates a GUI form" +
                " to display address and parcel information");
        }

        //Pre: user clicks on exit button
        //Post: Exit button exits out of form
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Pre: user clicks List Addresses
        //Post: Address will load into display text box
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach(Address a in upv.AddressList)
            {
                
                displayTextBox.AppendText(a.ToString());
                displayTextBox.AppendText(System.Environment.NewLine);
                displayTextBox.AppendText("-------------------------------------");
                displayTextBox.AppendText(System.Environment.NewLine);
                

            }

        }

        //Pre: user clicks List Parcels 
        //Post: parcels will load into display text box
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Parcel p in upv.ParcelList)
            {

                displayTextBox.AppendText(p.ToString());
                displayTextBox.AppendText(Environment.NewLine);
                displayTextBox.AppendText("-------------------------------------");
                displayTextBox.AppendText(Environment.NewLine);
               
            }

        }

        //Pre: user clicks on letter tab
        //Post: LetterForm should appear and allow data to be selected/entered
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Letter_Form letterForm = new Letter_Form(upv.AddressList);
            DialogResult result;

            
            result = letterForm.ShowDialog();

        }

        //Pre: user clicks on address tab
        //Post: AddressForm should appear and allow data to be selected/entered
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();
            DialogResult result;

            result = addressForm.ShowDialog();

            //not sure how to get the info on to the main form?

        }
    }
}
