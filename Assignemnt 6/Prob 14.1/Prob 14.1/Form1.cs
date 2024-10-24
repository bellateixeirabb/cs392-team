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


namespace Prob_14._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Step 1: Read numbers from the file into a List
            List<int> numbers = ReadNumbersFromFile("random.txt");

            // Step 2: Remove all negative numbers
            numbers.RemoveAll(n => n < 0);

            // Step 3: Find all numbers between 1 and 10
            List<int> rangeNumbers = numbers.FindAll(n => n >= 1 && n <= 10);

            // Step 4: Display the results in a ListBox
            foreach (int number in rangeNumbers)
            {
                displayBox.Items.Add(number);
            }
        }

        private List<int> ReadNumbersFromFile(string filePath)
        {
            List<int> numbers = new List<int>();

            // Read all lines from the file and add to list
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                numbers.Add(int.Parse(line)); // Directly parsing the integers
            }

            return numbers;
        }

        private void displayBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
