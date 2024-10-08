namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblheight = new System.Windows.Forms.Label();
            this.LblFeet = new System.Windows.Forms.Label();
            this.LblInch = new System.Windows.Forms.Label();
            this.lblweight = new System.Windows.Forms.Label();
            this.lblpounds = new System.Windows.Forms.Label();
            this.txtbFeet = new System.Windows.Forms.TextBox();
            this.txtbInch = new System.Windows.Forms.TextBox();
            this.txtbPounds = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbBMI = new System.Windows.Forms.TextBox();
            this.txtbStatus = new System.Windows.Forms.TextBox();
            this.lblbmi = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblMetric = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbCm = new System.Windows.Forms.TextBox();
            this.lblCm = new System.Windows.Forms.Label();
            this.txtbKg = new System.Windows.Forms.TextBox();
            this.lblKg = new System.Windows.Forms.Label();
            this.btnDatabase = new System.Windows.Forms.Button();
            this.enhancedBMIDataSet = new WindowsFormsApp1.EnhancedBMIDataSet();
            this.enhancedBMIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enhancedBMITableAdapter = new WindowsFormsApp1.EnhancedBMIDataSetTableAdapters.EnhancedBMITableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.EnhancedBMIDataSetTableAdapters.TableAdapterManager();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enhancedBMIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enhancedBMIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblheight
            // 
            this.lblheight.AutoSize = true;
            this.lblheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheight.Location = new System.Drawing.Point(84, 134);
            this.lblheight.Name = "lblheight";
            this.lblheight.Size = new System.Drawing.Size(82, 20);
            this.lblheight.TabIndex = 0;
            this.lblheight.Text = "1. Height";
            // 
            // LblFeet
            // 
            this.LblFeet.AutoSize = true;
            this.LblFeet.Location = new System.Drawing.Point(103, 180);
            this.LblFeet.Name = "LblFeet";
            this.LblFeet.Size = new System.Drawing.Size(42, 20);
            this.LblFeet.TabIndex = 1;
            this.LblFeet.Text = "Feet";
            // 
            // LblInch
            // 
            this.LblInch.AutoSize = true;
            this.LblInch.Location = new System.Drawing.Point(234, 180);
            this.LblInch.Name = "LblInch";
            this.LblInch.Size = new System.Drawing.Size(57, 20);
            this.LblInch.TabIndex = 2;
            this.LblInch.Text = "Inches";
            this.LblInch.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblweight.Location = new System.Drawing.Point(84, 249);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(85, 20);
            this.lblweight.TabIndex = 3;
            this.lblweight.Text = "2. Weight";
            // 
            // lblpounds
            // 
            this.lblpounds.AutoSize = true;
            this.lblpounds.Location = new System.Drawing.Point(103, 297);
            this.lblpounds.Name = "lblpounds";
            this.lblpounds.Size = new System.Drawing.Size(63, 20);
            this.lblpounds.TabIndex = 4;
            this.lblpounds.Text = "Pounds";
            // 
            // txtbFeet
            // 
            this.txtbFeet.Location = new System.Drawing.Point(106, 203);
            this.txtbFeet.Name = "txtbFeet";
            this.txtbFeet.Size = new System.Drawing.Size(100, 26);
            this.txtbFeet.TabIndex = 6;
            // 
            // txtbInch
            // 
            this.txtbInch.Location = new System.Drawing.Point(239, 203);
            this.txtbInch.Name = "txtbInch";
            this.txtbInch.Size = new System.Drawing.Size(100, 26);
            this.txtbInch.TabIndex = 7;
            // 
            // txtbPounds
            // 
            this.txtbPounds.Location = new System.Drawing.Point(106, 320);
            this.txtbPounds.Name = "txtbPounds";
            this.txtbPounds.Size = new System.Drawing.Size(100, 26);
            this.txtbPounds.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(101, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbBMI
            // 
            this.txtbBMI.Location = new System.Drawing.Point(385, 349);
            this.txtbBMI.Name = "txtbBMI";
            this.txtbBMI.ReadOnly = true;
            this.txtbBMI.Size = new System.Drawing.Size(100, 26);
            this.txtbBMI.TabIndex = 10;
            this.txtbBMI.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtbStatus
            // 
            this.txtbStatus.Location = new System.Drawing.Point(520, 349);
            this.txtbStatus.Name = "txtbStatus";
            this.txtbStatus.ReadOnly = true;
            this.txtbStatus.Size = new System.Drawing.Size(100, 26);
            this.txtbStatus.TabIndex = 11;
            // 
            // lblbmi
            // 
            this.lblbmi.AutoSize = true;
            this.lblbmi.Location = new System.Drawing.Point(381, 317);
            this.lblbmi.Name = "lblbmi";
            this.lblbmi.Size = new System.Drawing.Size(38, 20);
            this.lblbmi.TabIndex = 12;
            this.lblbmi.Text = "BMI";
            this.lblbmi.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(517, 317);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(110, 20);
            this.lblstatus.TabIndex = 13;
            this.lblstatus.Text = "Weight Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 74);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 55);
            this.label1.TabIndex = 15;
            this.label1.Text = "Adult BMI Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(660, 108);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(61, 20);
            this.lblEnglish.TabIndex = 16;
            this.lblEnglish.Text = "English";
            this.lblEnglish.Visible = false;
            this.lblEnglish.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMetric
            // 
            this.lblMetric.AutoSize = true;
            this.lblMetric.Location = new System.Drawing.Point(736, 108);
            this.lblMetric.Name = "lblMetric";
            this.lblMetric.Size = new System.Drawing.Size(52, 20);
            this.lblMetric.TabIndex = 17;
            this.lblMetric.Text = "Metric";
            this.lblMetric.Visible = false;
            this.lblMetric.Click += new System.EventHandler(this.lblMetric_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "|";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtbCm
            // 
            this.txtbCm.Location = new System.Drawing.Point(376, 134);
            this.txtbCm.Name = "txtbCm";
            this.txtbCm.Size = new System.Drawing.Size(100, 26);
            this.txtbCm.TabIndex = 19;
            this.txtbCm.Visible = false;
            // 
            // lblCm
            // 
            this.lblCm.AutoSize = true;
            this.lblCm.Location = new System.Drawing.Point(372, 108);
            this.lblCm.Name = "lblCm";
            this.lblCm.Size = new System.Drawing.Size(95, 20);
            this.lblCm.TabIndex = 20;
            this.lblCm.Text = "Centimeters";
            this.lblCm.Visible = false;
            // 
            // txtbKg
            // 
            this.txtbKg.Location = new System.Drawing.Point(498, 134);
            this.txtbKg.Name = "txtbKg";
            this.txtbKg.Size = new System.Drawing.Size(100, 26);
            this.txtbKg.TabIndex = 21;
            this.txtbKg.Visible = false;
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(493, 108);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(78, 20);
            this.lblKg.TabIndex = 22;
            this.lblKg.Text = "Kilograms";
            this.lblKg.Visible = false;
            // 
            // btnDatabase
            // 
            this.btnDatabase.AutoSize = true;
            this.btnDatabase.Location = new System.Drawing.Point(637, 411);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(160, 35);
            this.btnDatabase.TabIndex = 23;
            this.btnDatabase.Text = "Save To Database";
            this.btnDatabase.UseVisualStyleBackColor = true;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // enhancedBMIDataSet
            // 
            this.enhancedBMIDataSet.DataSetName = "EnhancedBMIDataSet";
            this.enhancedBMIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enhancedBMIBindingSource
            // 
            this.enhancedBMIBindingSource.DataMember = "EnhancedBMI";
            this.enhancedBMIBindingSource.DataSource = this.enhancedBMIDataSet;
            // 
            // enhancedBMITableAdapter
            // 
            this.enhancedBMITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EnhancedBMITableAdapter = this.enhancedBMITableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.EnhancedBMIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(584, 203);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 24;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(494, 203);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(498, 249);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 20);
            this.lblGender.TabIndex = 26;
            this.lblGender.Text = "Gender:";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(584, 249);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 26);
            this.txtGender.TabIndex = 27;
            this.txtGender.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 469);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDatabase);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.txtbKg);
            this.Controls.Add(this.lblCm);
            this.Controls.Add(this.txtbCm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMetric);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblbmi);
            this.Controls.Add(this.txtbStatus);
            this.Controls.Add(this.txtbBMI);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbPounds);
            this.Controls.Add(this.txtbInch);
            this.Controls.Add(this.txtbFeet);
            this.Controls.Add(this.lblpounds);
            this.Controls.Add(this.lblweight);
            this.Controls.Add(this.LblInch);
            this.Controls.Add(this.LblFeet);
            this.Controls.Add(this.lblheight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enhancedBMIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enhancedBMIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheight;
        private System.Windows.Forms.Label LblFeet;
        private System.Windows.Forms.Label LblInch;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label lblpounds;
        private System.Windows.Forms.TextBox txtbFeet;
        private System.Windows.Forms.TextBox txtbInch;
        private System.Windows.Forms.TextBox txtbPounds;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbBMI;
        private System.Windows.Forms.TextBox txtbStatus;
        private System.Windows.Forms.Label lblbmi;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblMetric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbCm;
        private System.Windows.Forms.Label lblCm;
        private System.Windows.Forms.TextBox txtbKg;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Button btnDatabase;
        private EnhancedBMIDataSet enhancedBMIDataSet;
        private System.Windows.Forms.BindingSource enhancedBMIBindingSource;
        private EnhancedBMIDataSetTableAdapters.EnhancedBMITableAdapter enhancedBMITableAdapter;
        private EnhancedBMIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtGender;
    }
}

