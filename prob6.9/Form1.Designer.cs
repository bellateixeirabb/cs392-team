namespace prob6._9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            btnPlayAgain = new Button();
            lblComputerChoice = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.Location = new Point(202, 232);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(112, 34);
            btnRock.TabIndex = 0;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(331, 232);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(112, 34);
            btnPaper.TabIndex = 1;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Location = new Point(462, 232);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(112, 34);
            btnScissors.TabIndex = 2;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.Location = new Point(331, 312);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(112, 34);
            btnPlayAgain.TabIndex = 3;
            btnPlayAgain.Text = "Play Again";
            btnPlayAgain.UseVisualStyleBackColor = true;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // lblComputerChoice
            // 
            lblComputerChoice.AutoSize = true;
            lblComputerChoice.Location = new Point(312, 168);
            lblComputerChoice.Name = "lblComputerChoice";
            lblComputerChoice.Size = new Size(150, 25);
            lblComputerChoice.TabIndex = 4;
            lblComputerChoice.Text = "Computer Choice";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(353, 387);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(59, 25);
            lblResult.TabIndex = 5;
            lblResult.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(lblComputerChoice);
            Controls.Add(btnPlayAgain);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Name = "Form1";
            Text = "RockPaperScissors";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Button btnPlayAgain;
        private Label lblComputerChoice;
        private Label lblResult;
    }
}
