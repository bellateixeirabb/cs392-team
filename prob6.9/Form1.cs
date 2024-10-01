namespace prob6._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Play again button
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            lblComputerChoice.Text = ""; // Clear the computer choice label
            lblResult.Text = ""; // Clear the result label
        }

        // Rock, paper, scissors buttons
        private void btnRock_Click(object sender, EventArgs e)
        {
            PlayGame("Rock"); // Call the PlayGame method with the user's choice
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            PlayGame("Paper"); // Call the PlayGame method with the user's choice
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            PlayGame("Scissors"); // Call the PlayGame method with the user's choice
        }

        // Play the game method
        private void PlayGame(string userChoice)
        {
            string computerChoice = GetComputerChoice(); // Get the computer's choice
            lblComputerChoice.Text = $"Computer chose: {computerChoice}"; // Display the computer's choice
            string result = DetermineWinner(userChoice, computerChoice); // Determine the winner
            lblResult.Text = result; // Display the result
        }

        // Get the computer's choice method
        private string GetComputerChoice()
        {
            Random random = new Random(); // Create a new random object
            int choice = random.Next(1, 4); // Generate a random number between 1 and 3

            // Return the computer's choice based on the random number
            switch (choice)
            {
                case 1:
                    return "Rock";
                case 2:
                    return "Paper";
                case 3:
                    return "Scissors";
                default:
                    return "Default";
            }
        }

        // Determine the winner method
        private string DetermineWinner(string userChoice, string computerChoice)
        {
            // Determine the winner based on the user's choice and the computer's choice
            if (userChoice == computerChoice)
            {
                return "It's a tie! Play again."; // Return a tie message
            }
            else if (userChoice == "Rock" && computerChoice == "Scissors" ||
                     userChoice == "Paper" && computerChoice == "Rock" ||
                     userChoice == "Scissors" && computerChoice == "Paper") // User wins
            {
                return "You win!";
            }
            else
            {
                return "Computer wins!";
            }
        }
    }
}
