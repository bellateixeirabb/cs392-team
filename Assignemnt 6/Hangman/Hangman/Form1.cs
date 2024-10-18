using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Text.RegularExpressions;


namespace Hangman
{
    public partial class hangman : Form
    {
        private string currentWord;
        public char[] currentGuess;
        private string output;
        private int wrongCount;
        private string connectionString;
        private string previousWord;
        private int wins;
        private int losses;

        //Main method that:
        // 1. Initializes the form
        // 2. Enables all buttons to reset previous game state
        // 3. Sets up project directory and image sources
        public hangman()
        {
            InitializeComponent();
            enableAllButtons(this);
            string projectDirectory = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
            AppDomain.CurrentDomain.SetData("DataDirectory", projectDirectory);
            mainFrame.Image = Properties.Resources.hangman1;  

        }

        //Load method that:
        // 1. Sets up SQL connection
        // 2. Calls generateWord()
        // 3. 
        private void hangman_Load(object sender, EventArgs e)
        {
            // Update the connection string to use the DataDirectory
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Words.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            this.wordChoiceTableAdapter.Fill(this.wordsDataSet.WordChoice);
            generateWord();
        }


        /// <summary>
        /// BUTTON CLICK METHODS
        /// </summary>

        //Click method for the A button. 
        //Disables the button, calls guessLetter()
        private void btnA_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnA.Enabled = false;
            guessLetter('a');
        }

        //Click method for the B button. 
        //Disables the button, calls guessLetter()
        private void btnB_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnB.Enabled = false;
            guessLetter('b');
        }

        //Click method for the C button. 
        //Disables the button, calls guessLetter()
        private void btnC_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnC.Enabled = false;
            guessLetter('c');
        }

        //Click method for the D button. 
        //Disables the button, calls guessLetter()
        private void btnD_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnD.Enabled = false;
            guessLetter('d');
        }

        //Click method for the E button. 
        //Disables the button, calls guessLetter()
        private void btnE_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnE.Enabled = false;
            guessLetter('e');
        }

        //Click method for the F button. 
        //Disables the button, calls guessLetter()
        private void btnF_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnF.Enabled = false;
            guessLetter('f');
        }

        //Click method for the G button. 
        //Disables the button, calls guessLetter()
        private void btnG_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnG.Enabled = false;
            guessLetter('g');
        }

        //Click method for the H button. 
        //Disables the button, calls guessLetter()
        private void btnH_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnH.Enabled = false;
            guessLetter('h');
        }

        //Click method for the I button. 
        //Disables the button, calls guessLetter()
        private void btnI_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnI.Enabled = false;
            guessLetter('i');
        }

        //Click method for the J button. 
        //Disables the button, calls guessLetter()
        private void btnJ_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnJ.Enabled = false;
            guessLetter('j');
        }

        //Click method for the K button. 
        //Disables the button, calls guessLetter()
        private void btnK_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnK.Enabled = false;
            guessLetter('k');
        }

        //Click method for the L button. 
        //Disables the button, calls guessLetter()
        private void btnL_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnL.Enabled = false;
            guessLetter('l');
        }

        //Click method for the M button. 
        //Disables the button, calls guessLetter()
        private void btnM_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnM.Enabled = false;
            guessLetter('m');
        }

        //Click method for the N button. 
        //Disables the button, calls guessLetter()
        private void btnN_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnN.Enabled = false;
            guessLetter('n');
        }

        //Click method for the O button. 
        //Disables the button, calls guessLetter()
        private void btnO_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnO.Enabled = false;
            guessLetter('o');
        }

        //Click method for the P button. 
        //Disables the button, calls guessLetter()
        private void btnP_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnP.Enabled = false;
            guessLetter('p');
        }

        //Click method for the Q button. 
        //Disables the button, calls guessLetter()
        private void btnQ_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnQ.Enabled = false;
            guessLetter('q');
        }

        //Click method for the R button. 
        //Disables the button, calls guessLetter()
        private void btnR_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnR.Enabled = false;
            guessLetter('r');
        }

        //Click method for the S button. 
        //Disables the button, calls guessLetter()
        private void btnS_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnS.Enabled = false;
            guessLetter('s');
        }

        //Click method for the T button. 
        //Disables the button, calls guessLetter()
        private void btnT_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnT.Enabled = false;
            guessLetter('t');
        }

        //Click method for the U button. 
        //Disables the button, calls guessLetter()
        private void btnU_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnU.Enabled = false;
            guessLetter('u');
        }

        //Click method for the V button. 
        //Disables the button, calls guessLetter()
        private void btnV_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnV.Enabled = false;
            guessLetter('v');
        }

        //Click method for the W button. 
        //Disables the button, calls guessLetter()
        private void btnW_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnW.Enabled = false;
            guessLetter('w');
        }

        //Click method for the X button. 
        //Disables the button, calls guessLetter()
        private void btnX_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnX.Enabled = false;
            guessLetter('x');
        }

        //Click method for the Y button. 
        //Disables the button, calls guessLetter()
        private void btnY_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnY.Enabled = false;
            guessLetter('y');
        }

        //Click method for the Z button. 
        //Disables the button, calls guessLetter()
        private void btnZ_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("Please generate a word first!");
                return;
            }
            btnZ.Enabled = false;
            guessLetter('z');
        }

        //Click method for the Give Up button. 
        //Disables the button, calls to restart the game
        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("At least generate a word first, damn!");
                return;
            }
            losses++;
            ShowRestartDialog();
        }

        /// <summary>
        /// GUESS OUTCOME METHODS
        /// </summary>
       
        //Method for guessing the letters, that:
        // 1. Checks for the letter inside the currentWord
        // 2. Updates the relevant letters inside the currentGuess
        // 3. Calls correctLetter() or wrongLetter() based on outcome
        // 4. Calls updateDisplay()
        // 5. Checks for winning condition, and calls victory() 
        private bool guessLetter(char input)
        {
            //Uplift player
            btnGiveUp.Focus();
            //Initialize local score
            int score = 0;
            //Initialize local bool for tracking
            bool isCorrect = false;
            //Iterate through the currentWord
            for (int i = 0; i < currentWord.Length; i++)
            {
                //check for matches
                if (currentWord[i] == input)
                {
                    //Update currentGuess
                    currentGuess[i] = char.ToUpper(input);
                    isCorrect = true;
                    score++;
                }

            }
            //Check if guess was sucessful based on local score, send score to correctLetter()
            if (score > 0)
            {
                correctLetter(score);
            }
            UpdateWordDisplay();
            if (!isCorrect)
            {
                wrongLetter();
            }

            //Check winning condition
            if (!currentGuess.Contains('_'))
            {
                victory();
            }
            return isCorrect;
        }

        //Helper method called by guessLetter() that:
        // 1. utputs the message box for a correct guess
        private void correctLetter(int score)
        {
            if (score == 1)
            {
                MessageBox.Show($"Correct! That letter appears {score} time!");
            }
            else
            {
                MessageBox.Show($"Correct! That letter appears {score} times!");
            }

        }

        //Helper method called by guessLetter() that:
        // 1. outputs the message box for the wrong guess
        // 2. Updates the wrong count
        // 3. Updates the hangman image
        // 4. Checks for losing condition, calls youLose();
        private void wrongLetter()
        {
            wrongCount++;
            MessageBox.Show("Unfortunately, thats wrong!");

            switch(wrongCount)
            {
                case 1:
                    mainFrame.Image = Properties.Resources.hangman2;
                    break;
                case 2:
                    mainFrame.Image = Properties.Resources.hangman3;
                    break;
                case 3:
                    mainFrame.Image = Properties.Resources.hangman4;
                    break;
                case 4:
                    mainFrame.Image = Properties.Resources.hangman5;
                    break;
                case 5:
                    mainFrame.Image = Properties.Resources.hangman6;
                    break;
                case 6:
                    mainFrame.Image = Properties.Resources.hangman7;
                    youLose();
                    break;

            }
        }

        //Helper method used by generateWord() that:
        // 1. Pulls a random word and hint from the DB
        private (string Word, string Hint) pullRandomWord()
        {
            //SQL query script to be executed
            string query = "SELECT TOP 1 Word, Hint FROM WordChoice ORDER BY NEWID()";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //Open the SQL connection
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    //Initialize reader object
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //Check for sucessful read
                        if (reader.Read())
                        {
                            //Assign the read values to the loca fields
                            string word = reader["Word"].ToString();
                            string hint = reader["Hint"].ToString();
                            //Return the values
                            return (word, hint);
                        }
                    }
                }
            }
            //Oopsie
            throw new Exception("Something went wrong.");
        }


        /// <summary>
        /// GAME STATE METHODS
        /// </summary>
        /// 

        //Game state method that:
        // 1. Resets the hangman image and the class counters
        // 2. Ensures the generated word is different from the previous word
        // 3. Updates the necessary fields
        // 4. Assembles the currentGuess character array
        private void generateWord()
        {
            //Temporary fields
            string newWord;
            string tempHint;
            mainFrame.Image = Properties.Resources.hangman1;
            //Run until a unique new word is pulled
            do
            {
                var random = pullRandomWord();

                newWord = random.Word.ToLower();
                tempHint = random.Hint.ToLower();


            } while (newWord == previousWord);

            //Update all displays accordingly
            lblHintText.Text = tempHint;
            currentWord = newWord;
            previousWord = newWord;
            currentGuess = new char[currentWord.Length];
            //Assemble currentGuess character array
            for (int i = 0; i < currentWord.Length; i++)
            {
                currentGuess[i] = '_';
            }
            UpdateWordDisplay();
            wrongCount = 0;



        }

        //Game state method that:
        // 1. Congratulates player
        // 2. Updates wins count
        // 3. Calls for restart dialog
        private void victory()
        {
            MessageBox.Show("Congratulations! You Win!");
            wins++;
            ShowRestartDialog();
        }

        //Game state method that:
        // 1. Uplifts the players spirits
        // 2. Calls for restart dialog
        private void youLose()
        {
            losses++;
            MessageBox.Show($"Unfortunately, you lost! The word was {currentWord.ToUpper()}.");
            MessageBox.Show("The poor man hung himself.");
            MessageBox.Show("And its all your fault.");
            MessageBox.Show("Dishonor on you.");
            MessageBox.Show("Dishonor on your family.");
            MessageBox.Show("Dishonor on your house.");
            MessageBox.Show("Dishonor on your cow.");
            ShowRestartDialog();
        }

        //Helper method used by victory() and youLose() that:
        // 1. Prompts user to restart the game
        // 2. Restarts or exits based on response
        private void ShowRestartDialog()
        {
            // Show a message box with Yes and No options
            DialogResult result = MessageBox.Show("Would you like to play again?", "Restart Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the result of the dialog
            if (result == DialogResult.Yes)
            {
                restartGame();  // Restart the game if the user clicks Yes
            }
            else
            {
                Application.Exit();
            }
        }

        //Restart method that:
        // 1. Resets all necessary fields
        // 2. Calls generateWord()
        public void restartGame()
        {
            txtbWord.Text = "";
            enableAllButtons(this);
            wrongCount = 0;
            mainFrame.Image = Properties.Resources.hangman1;
            lblHintText.Text = "";
            generateWord();

        }

        /// <summary>
        /// HELPER METHODS
        /// </summary>
      
        //Helper method to enable all buttons
        private void enableAllButtons(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                }

                if (c.HasChildren)
                {
                    enableAllButtons(c);
                }
            }
        }


        //Helper method to update all textbox displays
        private void UpdateWordDisplay()
        {
            txtbWord.Text = string.Join(" ", currentGuess);
            txtbLosses.Text = losses.ToString();
            txtbWins.Text = wins.ToString();
        }
    }
}
