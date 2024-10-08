using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem13._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initializes the datatable view
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);

        }

        //irrelevant
        private void TableofInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
