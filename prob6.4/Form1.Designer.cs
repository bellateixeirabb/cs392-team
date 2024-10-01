namespace prob6._4
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
            checkOil = new CheckBox();
            checkLube = new CheckBox();
            boxOil = new GroupBox();
            boxFlushes = new GroupBox();
            checkTransmission = new CheckBox();
            checkRadiator = new CheckBox();
            boxMisc = new GroupBox();
            checkTire = new CheckBox();
            checkMuffler = new CheckBox();
            checkInspection = new CheckBox();
            boxParts = new GroupBox();
            txtLabor = new TextBox();
            txtParts = new TextBox();
            lblParts = new Label();
            lblLabor = new Label();
            lblService = new Label();
            lblParts2 = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            txtService = new TextBox();
            txtParts2 = new TextBox();
            txtTax = new TextBox();
            txtTotal = new TextBox();
            boxSummary = new GroupBox();
            boxOil.SuspendLayout();
            boxFlushes.SuspendLayout();
            boxMisc.SuspendLayout();
            boxParts.SuspendLayout();
            boxSummary.SuspendLayout();
            SuspendLayout();
            // 
            // checkOil
            // 
            checkOil.AutoSize = true;
            checkOil.Location = new Point(33, 33);
            checkOil.Name = "checkOil";
            checkOil.Size = new Size(167, 29);
            checkOil.TabIndex = 0;
            checkOil.Text = "Oil change ($50)";
            checkOil.UseVisualStyleBackColor = true;
            // 
            // checkLube
            // 
            checkLube.AutoSize = true;
            checkLube.Location = new Point(33, 68);
            checkLube.Name = "checkLube";
            checkLube.Size = new Size(152, 29);
            checkLube.TabIndex = 1;
            checkLube.Text = "Lube job ($40)";
            checkLube.UseVisualStyleBackColor = true;
            // 
            // boxOil
            // 
            boxOil.Controls.Add(checkLube);
            boxOil.Controls.Add(checkOil);
            boxOil.Location = new Point(132, 12);
            boxOil.Name = "boxOil";
            boxOil.Size = new Size(238, 115);
            boxOil.TabIndex = 2;
            boxOil.TabStop = false;
            boxOil.Text = "Oil and Lube";
            // 
            // boxFlushes
            // 
            boxFlushes.Controls.Add(checkTransmission);
            boxFlushes.Controls.Add(checkRadiator);
            boxFlushes.Location = new Point(390, 12);
            boxFlushes.Name = "boxFlushes";
            boxFlushes.Size = new Size(238, 115);
            boxFlushes.TabIndex = 3;
            boxFlushes.TabStop = false;
            boxFlushes.Text = "Flushes";
            // 
            // checkTransmission
            // 
            checkTransmission.AutoSize = true;
            checkTransmission.Location = new Point(4, 68);
            checkTransmission.Name = "checkTransmission";
            checkTransmission.Size = new Size(240, 29);
            checkTransmission.TabIndex = 1;
            checkTransmission.Text = "Transmission Flush ($120)";
            checkTransmission.UseVisualStyleBackColor = true;
            // 
            // checkRadiator
            // 
            checkRadiator.AutoSize = true;
            checkRadiator.Location = new Point(21, 33);
            checkRadiator.Name = "checkRadiator";
            checkRadiator.Size = new Size(206, 29);
            checkRadiator.TabIndex = 0;
            checkRadiator.Text = "Radiator Flush ($100)";
            checkRadiator.UseVisualStyleBackColor = true;
            // 
            // boxMisc
            // 
            boxMisc.Controls.Add(checkTire);
            boxMisc.Controls.Add(checkMuffler);
            boxMisc.Controls.Add(checkInspection);
            boxMisc.Location = new Point(132, 133);
            boxMisc.Name = "boxMisc";
            boxMisc.Size = new Size(238, 116);
            boxMisc.TabIndex = 4;
            boxMisc.TabStop = false;
            boxMisc.Text = "Misc";
            // 
            // checkTire
            // 
            checkTire.AutoSize = true;
            checkTire.Location = new Point(43, 87);
            checkTire.Name = "checkTire";
            checkTire.RightToLeft = RightToLeft.No;
            checkTire.Size = new Size(179, 29);
            checkTire.TabIndex = 2;
            checkTire.Text = "Tire rotation ($25)";
            checkTire.UseVisualStyleBackColor = true;
            // 
            // checkMuffler
            // 
            checkMuffler.AutoSize = true;
            checkMuffler.Location = new Point(21, 57);
            checkMuffler.Name = "checkMuffler";
            checkMuffler.Size = new Size(215, 29);
            checkMuffler.TabIndex = 1;
            checkMuffler.Text = "Replace muffler ($150)";
            checkMuffler.UseVisualStyleBackColor = true;
            // 
            // checkInspection
            // 
            checkInspection.AutoSize = true;
            checkInspection.Location = new Point(47, 27);
            checkInspection.Name = "checkInspection";
            checkInspection.Size = new Size(165, 29);
            checkInspection.TabIndex = 0;
            checkInspection.Text = "Inspection ($35)";
            checkInspection.UseVisualStyleBackColor = true;
            // 
            // boxParts
            // 
            boxParts.Controls.Add(txtLabor);
            boxParts.Controls.Add(txtParts);
            boxParts.Controls.Add(lblParts);
            boxParts.Controls.Add(lblLabor);
            boxParts.Location = new Point(390, 133);
            boxParts.Name = "boxParts";
            boxParts.Size = new Size(238, 115);
            boxParts.TabIndex = 5;
            boxParts.TabStop = false;
            boxParts.Text = "Parts and Labor";
            // 
            // txtLabor
            // 
            txtLabor.Location = new Point(121, 76);
            txtLabor.Name = "txtLabor";
            txtLabor.Size = new Size(109, 31);
            txtLabor.TabIndex = 20;
            // 
            // txtParts
            // 
            txtParts.Location = new Point(116, 39);
            txtParts.Name = "txtParts";
            txtParts.Size = new Size(109, 31);
            txtParts.TabIndex = 19;
            // 
            // lblParts
            // 
            lblParts.AutoSize = true;
            lblParts.Location = new Point(5, 39);
            lblParts.Name = "lblParts";
            lblParts.Size = new Size(54, 25);
            lblParts.TabIndex = 17;
            lblParts.Text = "Parts:";
            // 
            // lblLabor
            // 
            lblLabor.AutoSize = true;
            lblLabor.Location = new Point(2, 79);
            lblLabor.Name = "lblLabor";
            lblLabor.Size = new Size(124, 25);
            lblLabor.TabIndex = 18;
            lblLabor.Text = "Labor (Hours):";
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Location = new Point(106, 16);
            lblService.Name = "lblService";
            lblService.Size = new Size(156, 25);
            lblService.TabIndex = 6;
            lblService.Text = "Service and Labor:";
            // 
            // lblParts2
            // 
            lblParts2.AutoSize = true;
            lblParts2.Location = new Point(106, 50);
            lblParts2.Name = "lblParts2";
            lblParts2.Size = new Size(54, 25);
            lblParts2.TabIndex = 7;
            lblParts2.Text = "Parts:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(106, 85);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(121, 25);
            lblTax.TabIndex = 8;
            lblTax.Text = "Tax (on parts):";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(106, 120);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(93, 25);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total Fees:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(201, 409);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(113, 34);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(319, 409);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(437, 409);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtService
            // 
            txtService.Location = new Point(317, 10);
            txtService.Name = "txtService";
            txtService.Size = new Size(150, 31);
            txtService.TabIndex = 13;
            // 
            // txtParts2
            // 
            txtParts2.Location = new Point(317, 44);
            txtParts2.Name = "txtParts2";
            txtParts2.Size = new Size(150, 31);
            txtParts2.TabIndex = 14;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(317, 78);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(150, 31);
            txtTax.TabIndex = 15;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(317, 114);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(150, 31);
            txtTotal.TabIndex = 16;
            // 
            // boxSummary
            // 
            boxSummary.Controls.Add(txtTotal);
            boxSummary.Controls.Add(txtTax);
            boxSummary.Controls.Add(txtParts2);
            boxSummary.Controls.Add(txtService);
            boxSummary.Controls.Add(lblTotal);
            boxSummary.Controls.Add(lblTax);
            boxSummary.Controls.Add(lblParts2);
            boxSummary.Controls.Add(lblService);
            boxSummary.Location = new Point(135, 255);
            boxSummary.Name = "boxSummary";
            boxSummary.Size = new Size(491, 158);
            boxSummary.TabIndex = 17;
            boxSummary.TabStop = false;
            boxSummary.Text = "Summary";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(boxSummary);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(boxParts);
            Controls.Add(boxMisc);
            Controls.Add(boxFlushes);
            Controls.Add(boxOil);
            Name = "Form1";
            Text = "Joe's Automotive";
            boxOil.ResumeLayout(false);
            boxOil.PerformLayout();
            boxFlushes.ResumeLayout(false);
            boxFlushes.PerformLayout();
            boxMisc.ResumeLayout(false);
            boxMisc.PerformLayout();
            boxParts.ResumeLayout(false);
            boxParts.PerformLayout();
            boxSummary.ResumeLayout(false);
            boxSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkOil;
        private CheckBox checkLube;
        private GroupBox boxOil;
        private GroupBox boxFlushes;
        private CheckBox checkTransmission;
        private CheckBox checkRadiator;
        private GroupBox boxMisc;
        private CheckBox checkMuffler;
        private CheckBox checkInspection;
        private GroupBox boxParts;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private Label lblService;
        private Label lblParts2;
        private Label lblTax;
        private Label lblTotal;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtService;
        private TextBox txtParts2;
        private TextBox txtTax;
        private TextBox txtTotal;
        private GroupBox boxSummary;
        private CheckBox checkTire;
        private TextBox txtLabor;
        private TextBox txtParts;
        private Label lblParts;
        private Label lblLabor;
    }
}
