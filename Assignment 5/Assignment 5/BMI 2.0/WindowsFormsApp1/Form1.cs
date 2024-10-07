using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Boolean metric = false;
        private float BMI = 0f;
        public Form1()
        {
            InitializeComponent();
            lblEnglish.BackColor = Color.LightBlue;
            lblEnglish.ForeColor = Color.Black;
            lblMetric.BackColor = Color.LightGray;
            lblMetric.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!metric)
            {
                float weight = float.Parse(txtbPounds.Text);
                float hFeet = float.Parse(txtbFeet.Text);
                float hInch = float.Parse(txtbInch.Text);
                float height = hFeet * 12 + hInch;
                BMI = 703f * weight / (height * height);
                txtbBMI.Text = BMI.ToString("F2");
            }
            else if (metric)
            {
                float weight = float.Parse(txtbKg.Text);
                float height = float.Parse(txtbCm.Text) / 100;
                BMI = weight / (height * height);
                txtbBMI.Text = BMI.ToString("F2");
            }

            if (BMI < 5)
            {
                txtbStatus.Text = "Dead";
            }
            else if (BMI < 18.5)
            {
                txtbStatus.Text = "Underweight";
            }
            else if (BMI < 25)
            {
                txtbStatus.Text = "Healthy Weight";
            }
            else if (BMI < 30)
            {
                txtbStatus.Text = "Overweight";
            }
            else if (BMI < 200)
            {
                txtbStatus.Text = "Obese";
            }
            else
            {
                txtbStatus.Text = "Dead";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            metric = false;
            txtbFeet.Visible = true;
            txtbInch.Visible = true;
            LblFeet.Visible = true;
            LblInch.Visible = true;
            lblpounds.Visible = true;
            txtbPounds.Visible = true;

            txtbCm.Visible = false;
            lblCm.Visible = false;
            txtbKg.Visible = false;
            lblKg.Visible = false;

            lblEnglish.BackColor = Color.LightBlue;
            lblEnglish.ForeColor = Color.Black;
            lblMetric.BackColor = Color.LightGray;
            lblMetric.ForeColor = Color.Black;

            txtbBMI.Clear();
            txtbStatus.Clear();
        }

        private void lblMetric_Click(object sender, EventArgs e)
        {
            lblMetric.BackColor = Color.LightBlue;
            lblMetric.ForeColor = Color.Black;
            lblEnglish.BackColor = Color.LightGray;
            lblEnglish.ForeColor = Color.Black;
            metric = true;
            txtbFeet.Visible = false;
            txtbInch.Visible = false;
            LblFeet.Visible = false;
            LblInch.Visible = false;

            txtbCm.Visible = true;
            lblCm.Visible = true;
            txtbKg.Visible = true;
            lblKg.Visible = true;

            txtbCm.Location = txtbFeet.Location;
            lblCm.Location = LblFeet.Location;
            txtbKg.Location = txtbPounds.Location;
            lblKg.Location = lblpounds.Location;

            txtbBMI.Clear();
            txtbStatus.Clear();
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            // user input and BMI calculation from the previous button click
            button1_Click(sender, e); // Calculate BMI

            // Ensure the name is captured from a textbox or other input control
            string name = txtName.Text;
            float weight = metric ? float.Parse(txtbKg.Text) : float.Parse(txtbPounds.Text);
            float height = metric ? float.Parse(txtbCm.Text) / 100 : (float.Parse(txtbFeet.Text) * 12 + float.Parse(txtbInch.Text));
            float bmi = BMI;

            // Connection string - must be added
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USISTEI\source\repos\cs392-team\Assignment 5\Assignment 5\BMI 2.0\WindowsFormsApp1\EnhancedBMI.mdf"";Integrated Security=True";

            // SQL query
            string query = "INSERT INTO EnhancedBMI (Name, Weight, Height, BMI, DateTimeStamp) VALUES (@Name, @Weight, @Height, @BMI, @DateTimeStamp)";

            // Insert data into database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Weight", weight);
                command.Parameters.AddWithValue("@Height", height);
                command.Parameters.AddWithValue("@BMI", bmi);
                command.Parameters.AddWithValue("@DateTimeStamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("Data saved successfully!");
        }
    }
}

