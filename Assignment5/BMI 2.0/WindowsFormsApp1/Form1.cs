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
        private string gender;
        private string connectionString;
        private float weight;
        private float height;
        private bool failed;
        public Form1()
        {
            InitializeComponent();
            lblEnglish.BackColor = Color.LightBlue;
            lblEnglish.ForeColor = Color.Black;
            lblMetric.BackColor = Color.LightGray;
            lblMetric.ForeColor = Color.Black;
            gender = "male";
            string projectDirectory = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));
            AppDomain.CurrentDomain.SetData("DataDirectory", projectDirectory);
            failed = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bMIDataset.EnhancedBMI' table. You can move, or remove it, as needed.
            this.enhancedBMITableAdapter.Fill(this.bMIDataset.EnhancedBMI);
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtbPounds.Text, out float weightValue))
            {
                txtbPounds.Clear();
                MessageBox.Show("Invalid input. Weight must be an integer");
                return;
            }
            weight = weightValue;
            float hFeet;
            float hInch;
            if (!float.TryParse(txtbFeet.Text, out hFeet))
            {
                txtbFeet.Clear();
                MessageBox.Show("Invalid input. Feet must be a number");
                return;
            }
            if (!float.TryParse(txtbInch.Text, out hInch))
            {
                txtbInch.Clear();
                MessageBox.Show("Invalid input. Inch must be a number");
                return;
            }
            height = hFeet * 12 + hInch;
            BMI = 703f * weight / (height * height);
            txtbBMI.Text = BMI.ToString("F2");


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
            gender = "male";


            lblEnglish.BackColor = Color.LightBlue;
            lblEnglish.ForeColor = Color.Black;
            lblMetric.BackColor = Color.LightGray;
            lblMetric.ForeColor = Color.Black;
        }

        private void lblMetric_Click(object sender, EventArgs e)
        {
            lblMetric.BackColor = Color.LightBlue;
            lblMetric.ForeColor = Color.Black;
            lblEnglish.BackColor = Color.LightGray;
            lblEnglish.ForeColor = Color.Black;

            gender = "female";
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            if (txtbFeet.Text == "" || txtbInch.Text == "" || txtbPounds.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("Please fill all of the fields");
                return;
            }
            if (txtbBMI.Text == "")
            {
                MessageBox.Show("Please calculate the BMI first");
                return;
            }
            // user input and BMI calculation from the previous button click
            button1_Click(sender, e); // Calculate BMI

            // Ensure the name is captured from a textbox or other input control
            string name = txtName.Text;
            float bmi = BMI;

            // Connection string - must be added
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EnhancedBMI.mdf;Integrated Security=True;";

            // SQL query
            string query = "INSERT INTO EnhancedBMI (Name, Gender, Weight, Height, BMI, DateTimeStamp) VALUES (@Name, @Gender, @Weight, @Height, @BMI, @DateTimeStamp)";

            // Insert data into database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue(parameterName: "@Name", name);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Weight", weight);
                command.Parameters.AddWithValue("@Height", height);
                command.Parameters.AddWithValue("@BMI", bmi);
                command.Parameters.AddWithValue("@DateTimeStamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("Data saved successfully!");
            RefreshData();
        }

        public void RefreshData()
        {
            string sqlstm = "select * from EnhancedBMI";
            SqlDataAdapter SDA = new SqlDataAdapter(sqlstm, connectionString);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS, "EnhancedBMI");
            enhancedBMIDataGridView.DataSource = DS.Tables[0];
        }
    }



}

