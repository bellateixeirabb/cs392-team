using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem13._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            // initiates the table as a 
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);

        }

        private void PersonFind_Click(object sender, EventArgs e)
        {
            //Runs the SQL SELECT method that will only show lines containing names that contain the string fragment the user input
            this.employeeTableAdapter.FillByName
                (this.personnelDataSet.Employee, nameSearch.Text);
        }
    }
}
