namespace prob7._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load!);
        }

        // Call the method when the form is loaded
        private void Form1_Load(object? sender, EventArgs e)
        {
            LoadImages();
        }

        // Create a random object
        private Random random = new Random();
        // Create a list to store fruit images
        private List<Image> fruitImages = new List<Image>();
        // Variables to store the total money entered and won
        private decimal totalMoneyEntered = 0;
        private decimal totalMoneyWon = 0;

        // Load the fruit images
        private void LoadImages()
        {
            // Load the images from the folder
            fruitImages.Add(Image.FromFile("Fruit Symbols/Apple.jpg"));
            fruitImages.Add(Image.FromFile("Fruit Symbols/Banana.jpg"));
            fruitImages.Add(Image.FromFile("Fruit Symbols/Cherries.jpg"));
            fruitImages.Add(Image.FromFile("Fruit Symbols/Grapes.jpg"));
            fruitImages.Add(Image.FromFile("Fruit Symbols/Orange.jpg"));
            fruitImages.Add(Image.FromFile("Fruit Symbols/Pear.jpg"));
            fruitImages.Add(Image.FromFile("Fruit Symbols/Watermelon.jpg"));
            fruitImages.Add(Image.FromFile("Fruit Symbols/Strawberry.jpg"));

        }

        // Method for the spin button
        private void btnSpin_Click(object sender, EventArgs e)
        {
            // Check if money has been entered
            if (decimal.TryParse(txtAmount.Text, out decimal amount) && amount > 0)
            {
                totalMoneyEntered += amount; // Add the amount to the total money entered

                // Error check for images load
                if (fruitImages.Count == 0)
                {
                    MessageBox.Show("No fruit images available.");
                    return;
                }

                // Generate random numbers for the fruit images
                int fruit1 = random.Next(fruitImages.Count);
                int fruit2 = random.Next(fruitImages.Count);
                int fruit3 = random.Next(fruitImages.Count);

                // Display the fruit images
                picBox1.Image = fruitImages[fruit1];
                picBox2.Image = fruitImages[fruit2];
                picBox3.Image = fruitImages[fruit3];

                // Determine the result 
                if (fruit1 == fruit2 && fruit2 == fruit3)
                {
                    // If all fruits are the same, the player wins 3 times the amount entered
                    totalMoneyWon += amount * 3;
                    MessageBox.Show("Congratulations! You won 3 times the amount entered.");
                }
                else if (fruit1 == fruit2 || fruit2 == fruit3 || fruit1 == fruit3)
                {
                    // If two fruits are the same, the player wins 2 times the amount entered
                    totalMoneyWon += amount * 2;
                    MessageBox.Show("Congratulations! You won 2 times the amount entered.");
                }
                else
                {
                    // If no fruits are the same, the player loses the amount entered
                    MessageBox.Show("Sorry, you lost the amount entered.");
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total money entered: " + totalMoneyEntered.ToString("c") + "\nTotal money won: " + totalMoneyWon.ToString("c"));
            this.Close();
        }
    }
}
