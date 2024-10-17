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
        public hangman()
        {
            InitializeComponent();
            enableAllButtons(this);
            string projectDirectory = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
            AppDomain.CurrentDomain.SetData("DataDirectory", projectDirectory);
            mainFrame.Image = Properties.Resources.hangman1;  

        }

        private void hangman_Load(object sender, EventArgs e)
        {
            // Update the connection string to use the DataDirectory
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Words.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            this.wordChoiceTableAdapter.Fill(this.wordsDataSet.WordChoice);
        }



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

        private (string Word, string Hint) pullRandomWord()
        {
            string query = "SELECT TOP 1 Word, Hint FROM WordChoice ORDER BY NEWID()";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            string word = reader["Word"].ToString();
                            string hint = reader["Hint"].ToString();
                            return (word, hint);
                        }
                    }
                }
            }
            throw new Exception("Something went wrong.");
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string newWord;
            string tempHint;
            mainFrame.Image = Properties.Resources.hangman1;
            do
            {
                var random = pullRandomWord();

                newWord = random.Word.ToLower();
                tempHint = random.Hint.ToLower();


            } while (newWord == previousWord) ;

            lblHintText.Text = tempHint;
            currentWord = newWord;
            previousWord = newWord;
            currentGuess = new char[currentWord.Length];
            for (int i = 0; i < currentWord.Length; i++)
            {
                currentGuess[i] = '_';
            }
            UpdateWordDisplay();
            wrongCount = 0;



        }
        private void UpdateWordDisplay()
        {
            txtbWord.Text = string.Join(" ", currentGuess);
        }


        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            if (txtbWord.Text == "")
            {
                MessageBox.Show("At least generate a word first, damn!");
                return;
            }
            ShowRestartDialog();
        }

        private bool guessLetter(char input)
        {
            btnGiveUp.Focus();
            int score = 0;
            bool isCorrect = false;
            for (int i = 0; i < currentWord.Length; i++)
            {
                if (currentWord[i] == input)
                {
                    currentGuess[i] = char.ToUpper(input);
                    isCorrect = true;
                    score++;
                }

            }
            if (score > 0)
            {
                correctLetter(score);
            }
            UpdateWordDisplay();
            if (!isCorrect)
            {
                wrongLetter();
            }

            if (!currentGuess.Contains('_'))
            {
                victory();
            }
            return isCorrect;
        }

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

        private void victory()
        {
            MessageBox.Show("Congratulations! You Win!");
            ShowRestartDialog();
        }

        private void youLose()
        {
            MessageBox.Show($"Unfortunately, you lost! The word was {currentWord.ToUpper()}.");
            MessageBox.Show("The poor man hung himself.");
            MessageBox.Show("And its all your fault.");
            MessageBox.Show("Dishonor on you.");
            MessageBox.Show("Dishonor on your family.");
            MessageBox.Show("Dishonor on your house.");
            MessageBox.Show("Dishonor on your cow.");
            ShowRestartDialog();
        }

        private void ShowRestartDialog()
        {
            // Show a message box with Yes and No options
            DialogResult result = MessageBox.Show("Do you want to restart the game?", "Restart Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        public void restartGame()
        {
            txtbWord.Text = "";
            enableAllButtons(this);
            wrongCount = 0;
            mainFrame.Image = Properties.Resources.hangman1;
            lblHintText.Text = "";

        }

        private void wordChoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wordChoiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.wordsDataSet);

        }

        //public void RefreshData()
        //{
        //    string sqlstm = "SELECT * FROM WordChoice";  // Ensure correct table name

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();  // Open the connection
        //        SqlDataAdapter SDA = new SqlDataAdapter(sqlstm, conn);  // Use the connection here
        //        DataSet DS = new DataSet();
        //        SDA.Fill(DS, "WordChoice");

        //        // Update the DataGridView with the new data
        //        wordChoiceDataGridView.DataSource = DS.Tables[0];
        //    }
        //}


    }
}
