namespace prob7._10
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
            btnSpin = new Button();
            btnExit = new Button();
            lblResult = new Label();
            txtAmount = new TextBox();
            picBox1 = new PictureBox();
            picBox2 = new PictureBox();
            picBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox3).BeginInit();
            SuspendLayout();
            // 
            // btnSpin
            // 
            btnSpin.Location = new Point(276, 382);
            btnSpin.Name = "btnSpin";
            btnSpin.Size = new Size(112, 34);
            btnSpin.TabIndex = 0;
            btnSpin.Text = "Spin";
            btnSpin.UseVisualStyleBackColor = true;
            btnSpin.Click += btnSpin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(394, 382);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(186, 329);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(164, 25);
            lblResult.TabIndex = 2;
            lblResult.Text = "Amount inserted: $";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(356, 326);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(150, 31);
            txtAmount.TabIndex = 3;
            // 
            // picBox1
            // 
            picBox1.Location = new Point(128, 81);
            picBox1.Name = "picBox1";
            picBox1.Size = new Size(168, 205);
            picBox1.TabIndex = 4;
            picBox1.TabStop = false;
            picBox1.Click += Form1_Load;
            // 
            // picBox2
            // 
            picBox2.Location = new Point(320, 81);
            picBox2.Name = "picBox2";
            picBox2.Size = new Size(168, 205);
            picBox2.TabIndex = 5;
            picBox2.TabStop = false;
            picBox2.Click += Form1_Load;
            // 
            // picBox3
            // 
            picBox3.Location = new Point(513, 81);
            picBox3.Name = "picBox3";
            picBox3.Size = new Size(168, 205);
            picBox3.TabIndex = 6;
            picBox3.TabStop = false;
            picBox3.Click += Form1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picBox3);
            Controls.Add(picBox2);
            Controls.Add(picBox1);
            Controls.Add(txtAmount);
            Controls.Add(lblResult);
            Controls.Add(btnExit);
            Controls.Add(btnSpin);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSpin;
        private Button btnExit;
        private Label lblResult;
        private TextBox txtAmount;
        private PictureBox picBox1;
        private PictureBox picBox2;
        private PictureBox picBox3;
    }
}
