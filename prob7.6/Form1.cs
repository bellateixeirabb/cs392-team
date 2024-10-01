namespace prob7._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // List to store popular names
        private List<string> popularNames = new List<string>();

        // Method to load popular names from a file 
        private void LoadNames()
        {
            try
            {
                // Read names from file and add to list
                using (StreamReader inputFile = new StreamReader("popular_names.txt"))
                {
                    string? line; // Nullable reference type
                    while ((line = inputFile.ReadLine()) != null) // Read until end of file
                    {
                        string trimmedLine = line.Trim().ToLower();
                        popularNames.Add(trimmedLine); // Add name to list, trimmed and in lowercase
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading names: " + ex.Message); // Display error message
            }
        }

        // Method to check if a name is popular
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim().ToLower(); // Get name from textbox

            if (popularNames.Contains(name)) // Check if name is in list
            {
                MessageBox.Show(name + " is a popular name!"); // Display message
            }
            else
            {
                MessageBox.Show(name + " is not a popular name."); // Display message
            }
        }
    }
}
