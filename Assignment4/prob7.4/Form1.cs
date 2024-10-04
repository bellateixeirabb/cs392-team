namespace prob7._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Correct answers array
        private char[] correctAnswers = { 'B', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D', 'B', 'C', 'D', 'A', 'D', 'C', 'C', 'B', 'D', 'A' };

        // Event handler for the Load file button
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // Create array to hold the answers from the file
                char[] StudentAnswers = new char[20];

                // Declare a StreamReader variable
                StreamReader inputFile;

                // Open the file and get a StreamReader object
                inputFile = File.OpenText("C:\\Users\\USISTEI\\Downloads\\Assignment4\\prob7.4\\StudentAnswers.txt");

                // Read the answers from the file and into the array
                for (int i = 0; i < StudentAnswers.Length; i++)
                {
                    string? line = inputFile.ReadLine();

                    if (!string.IsNullOrEmpty(line))
                    {
                        StudentAnswers[i] = char.Parse(line);
                    }
                    else
                    {
                        throw new Exception("File does not contain enough answers.");
                    }
                }

                // Close the file
                inputFile.Close();

                // Compare the student's answers to the correct answers
                int correctCount = 0;
                int incorrectCount = 0;
                string incorrectQuestions = "";

                for (int i = 0; i < StudentAnswers.Length; i++)
                {
                    if (StudentAnswers[i] == correctAnswers[i])
                    {
                        correctCount++;
                    }
                    else
                    {
                        incorrectCount++;
                        incorrectQuestions += (i + 1).ToString() + " ";
                    }
                }

                // Determine if the student passed or failed
                if (correctCount >= 15)
                {
                    MessageBox.Show("You passed the exam!");
                }
                else
                {
                    MessageBox.Show("You failed the exam.");
                }

                // Display the results
                MessageBox.Show($"Correct Answers: {correctCount}\nIncorrect Answers: {incorrectCount}");
                MessageBox.Show($"Incorrect Questions: {incorrectQuestions}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

