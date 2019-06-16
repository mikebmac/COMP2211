/* 
 * This program reads a text file for ints, counts the number and finds the sum of
 * all the numbers.
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

namespace Assignment4_Question14 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            openFileDialog.RestoreDirectory = true;

            try {

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    string filePath = openFileDialog.FileName;
                    // Update the user of the pathway of the file to ensure the right file is open
                    textBox1.Text = filePath;

                    // Clear the listbox with each new file
                    listBox1.Items.Clear();

                    StreamReader readStream = 
                        new StreamReader(openFileDialog.OpenFile());

                    string curLine;
                    int counter = 0;
                    int invalid = 0;
                    int sum = 0;

                    // Read each line, skip and record lines that are not integers
                    while ((curLine = readStream.ReadLine()) != null) {
                        int n;
                        if (int.TryParse(curLine, out n)) {
                            counter++;
                            sum += n;
                            listBox1.Items.Add(n);
                        } else {
                            invalid++;
                        }
                    }

                    // Update user of sum and total
                    label2.Text = "Sum of Numbers: " + sum.ToString();
                    label3.Text = "Total Numbers: " + counter.ToString();
                    // Tell the user if there is any invalid lines
                    if (invalid > 0) {
                        label4.Text = "Invalid Lines: " + invalid.ToString();
                    } else {
                        label4.Text = "";
                    }

                    readStream.Close();

                }

            } catch (IOException ex) {
                Report(ex.ToString());
            } catch {
                Report("An Error has occured.");
            }

        }

        // Send a message to the user
        private void Report (string message) {
            MessageBox.Show(message, "", MessageBoxButtons.OK);
        }
    }
}
