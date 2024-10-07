using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem_13._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Initiates the data table view
        private void Form1_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);

        }

        //runs SQL SELECT method that finds minimum hourly pay rate, and outputs it in message box
        private void MinButton_Click(object sender, EventArgs e)
        {
            int? minVal = this.employeeTableAdapter.ScalarQueryMin();
            MessageBox.Show($"The highest pay rate is {minVal}");
        }

        //Same as previous, but now for max
        private void MaxButton_Click(object sender, EventArgs e)
        {
            int? maxVal = this.employeeTableAdapter.ScalarQueryMax();
            MessageBox.Show($"The highest pay rate is {maxVal}");
        }
    }
}
