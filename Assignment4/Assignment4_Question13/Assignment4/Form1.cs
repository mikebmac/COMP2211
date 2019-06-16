/* 
 * This program creates a random int array (1 - 100) of a user specified size.
 * Course:  COMP 2211
 * Date:    June 16th, 2019
 * Author:  Michael MacKay
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // Creates and returns a random array of ints
        private int[] RandomNumber (int min, int max, int size) {
            Random random = new Random();

            int[] ar = new int[size];

            for (int i = 0; i < size; i++) {
                ar[i] = random.Next(min, max);
            }

            return ar;
        }

        private void createFile_Click(object sender, EventArgs e) {

            int numberOfEntries;
            if (!int.TryParse(inputNumber.Text, out numberOfEntries)) {
                Report("Please enter a valid whole number.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            saveFileDialog.Title = "Save Random Number File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "") {
                System.IO.StreamWriter file =
                    new StreamWriter(saveFileDialog.OpenFile());

                int[] numbers = RandomNumber(1, 100, numberOfEntries);

                foreach (int number in numbers) {
                    file.WriteLine(number);
                }

                file.Close();

                Report("File has been created.");
                inputNumber.Text = "";
            }
        }

        // Send a message to the user
        private void Report(string message) {
            MessageBox.Show(message, "", MessageBoxButtons.OK);
        }
    }
}
