/* 
 * This program validates and creates a prefered customer, applying a discount on 
 * future purchases based on their previous purchases.
 * Course:  COMP 2211
 * Date:    July 18th, 2019
 * Author:  Michael MacKay
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5 {
    public partial class ApplicationForm : Form {
        string customerTelephone = string.Empty;

        public ApplicationForm() {
            InitializeComponent();
        }

        private bool ValidateLength(string str) {
            const int VALID_LENGTH = 2;

            if (str.Length >= VALID_LENGTH) {
                return true;
            }

            return false;
        }

        private bool ValidateDouble(string str) {
            bool isValid = false;

            // Try to Parse the number
            try {
                Convert.ToDouble(str);
                isValid = true;
            } catch {
                isValid = false;
            }

            return isValid;
        }

        private bool ValidateNumber(string str) {
            bool isValid = true;
            const int VALID_LENGTH = 1;

            if (str.Length < VALID_LENGTH) {
                isValid = false;
            }

            foreach (char ch in str) {
                if (!char.IsDigit(ch)) {
                    isValid = false;
                }
            }

            return isValid;
        }

        private bool ValidatePhoneNumber(string number) {
            const int VALID_LENGTH = 10;
            string conNumber = "";
            bool isValid = false;

            // Remove any non-digits for validation
            for (int i = 0; i < number.Length; i++) {
                if (char.IsDigit(number[i])) {
                    conNumber = string.Concat(conNumber, number[i]);
                }
            }

            // Format the number
            if (conNumber.Length == VALID_LENGTH) {
                conNumber = conNumber.Insert(0, "(");
                conNumber = conNumber.Insert(4, ")");
                conNumber = conNumber.Insert(8, "-");
                isValid = true;
                textBoxTelephone.Text = conNumber;
            }

            return isValid;
        }

        private void buttonAddUpdate_Click(object sender, EventArgs e) {
            bool isValid = true;

            if (!ValidateLength(textBoxName.Text)) {
                isValid = false;
                UpdateLabel(labelName, "Customer Name (Too Short)", Color.Red);
            } else {
                UpdateLabel(labelName, "Customer Name", Color.Black);
            }

            if (!ValidateLength(textBoxAddress.Text)) {
                isValid = false;
                UpdateLabel(labelAddress, "Address (Too Short)", Color.Red);
            } else {
                UpdateLabel(labelAddress, "Address", Color.Black);
            }

            if (!ValidatePhoneNumber(textBoxTelephone.Text)) {
                isValid = false;
                UpdateLabel(labelTelephone, "Telephone Number (Enter a valid number)", Color.Red);
            } else {
                UpdateLabel(labelTelephone, "Telephone Number", Color.Black);
            }

            if (!ValidateNumber(textBoxCustomerNumber.Text)) {
                isValid = false;
                UpdateLabel(labelCustomerNumber, "Customer Number (Digits only Accepted)", Color.Red);
            } else {
                UpdateLabel(labelCustomerNumber, "Customer Number", Color.Black);
            }

            if (!ValidateDouble(textBoxPurchases.Text)) {
                isValid = false;
                UpdateLabel(labelPurchases, "Total Purchases (Digits only Accepted)", Color.Red);
            } else {
                UpdateLabel(labelPurchases, "Total Purchases", Color.Black);
            }

            if (isValid) {
                PreferredCustomer customer = new PreferredCustomer(
                        textBoxName.Text,
                        textBoxAddress.Text,
                        textBoxTelephone.Text,
                        Int32.Parse(textBoxCustomerNumber.Text),
                        checkBoxOnMailingList.Checked,
                        Double.Parse(textBoxPurchases.Text)
                    );

                listBoxOutput.Items.Clear();
                listBoxOutput.Items.Add("Name: " + customer.Name);
                listBoxOutput.Items.Add("Address: " + customer.Address);
                listBoxOutput.Items.Add("Telephone: " + customer.Telephone);
                listBoxOutput.Items.Add("Customer Number: " + customer.CustomerNum.ToString());
                listBoxOutput.Items.Add("Mailing List: " + customer.OnMailList.ToString());
                listBoxOutput.Items.Add("Total Purchases: " + customer.TotalPurchases.ToString());
                listBoxOutput.Items.Add("Discount: " + customer.Discount.ToString("P0", CultureInfo.InvariantCulture));

                MessageBox.Show("Customer Created.");
            } else {
                MessageBox.Show("There was errors in the application.");
            }
        }

        // Helper Method to Quickly Change Label Properties
        private void UpdateLabel (Label label, string text, Color color) {
            label.Text = text;
            label.ForeColor = color;
        }
    }
}
