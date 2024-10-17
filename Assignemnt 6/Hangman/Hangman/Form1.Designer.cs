namespace Hangman
{
    partial class hangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hangman));
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.txtbWord = new System.Windows.Forms.TextBox();
            this.wordsDataSet = new Hangman.WordsDataSet();
            this.wordChoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wordChoiceTableAdapter = new Hangman.WordsDataSetTableAdapters.WordChoiceTableAdapter();
            this.tableAdapterManager = new Hangman.WordsDataSetTableAdapters.TableAdapterManager();
            this.wordChoiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.wordChoiceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lblHintText = new System.Windows.Forms.Label();
            this.lblHintTitle = new System.Windows.Forms.Label();
            this.mainFrame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordChoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordChoiceBindingNavigator)).BeginInit();
            this.wordChoiceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.AutoSize = true;
            this.btnA.Location = new System.Drawing.Point(46, 124);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 30);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.AutoSize = true;
            this.btnB.Location = new System.Drawing.Point(139, 124);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(75, 30);
            this.btnB.TabIndex = 1;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.AutoSize = true;
            this.btnC.Location = new System.Drawing.Point(232, 124);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 30);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.AutoSize = true;
            this.btnD.Location = new System.Drawing.Point(325, 124);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 30);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnE
            // 
            this.btnE.AutoSize = true;
            this.btnE.Location = new System.Drawing.Point(418, 124);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(75, 30);
            this.btnE.TabIndex = 4;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnF
            // 
            this.btnF.AutoSize = true;
            this.btnF.Location = new System.Drawing.Point(46, 182);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(75, 30);
            this.btnF.TabIndex = 5;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnG
            // 
            this.btnG.AutoSize = true;
            this.btnG.Location = new System.Drawing.Point(139, 182);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(75, 30);
            this.btnG.TabIndex = 6;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnH
            // 
            this.btnH.AutoSize = true;
            this.btnH.Location = new System.Drawing.Point(232, 182);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(75, 30);
            this.btnH.TabIndex = 7;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnI
            // 
            this.btnI.AutoSize = true;
            this.btnI.Location = new System.Drawing.Point(325, 182);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(75, 30);
            this.btnI.TabIndex = 8;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnJ
            // 
            this.btnJ.AutoSize = true;
            this.btnJ.Location = new System.Drawing.Point(418, 182);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(75, 30);
            this.btnJ.TabIndex = 9;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = true;
            this.btnJ.Click += new System.EventHandler(this.btnJ_Click);
            // 
            // btnK
            // 
            this.btnK.AutoSize = true;
            this.btnK.Location = new System.Drawing.Point(46, 240);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(75, 30);
            this.btnK.TabIndex = 10;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.btnK_Click);
            // 
            // btnL
            // 
            this.btnL.AutoSize = true;
            this.btnL.Location = new System.Drawing.Point(139, 240);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(75, 30);
            this.btnL.TabIndex = 11;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnM
            // 
            this.btnM.AutoSize = true;
            this.btnM.Location = new System.Drawing.Point(232, 240);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(75, 30);
            this.btnM.TabIndex = 12;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnN
            // 
            this.btnN.AutoSize = true;
            this.btnN.Location = new System.Drawing.Point(325, 240);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(75, 30);
            this.btnN.TabIndex = 13;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnO
            // 
            this.btnO.AutoSize = true;
            this.btnO.Location = new System.Drawing.Point(418, 240);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(75, 30);
            this.btnO.TabIndex = 14;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // btnP
            // 
            this.btnP.AutoSize = true;
            this.btnP.Location = new System.Drawing.Point(46, 298);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 30);
            this.btnP.TabIndex = 15;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnQ
            // 
            this.btnQ.AutoSize = true;
            this.btnQ.Location = new System.Drawing.Point(139, 298);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(75, 30);
            this.btnQ.TabIndex = 16;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = true;
            this.btnQ.Click += new System.EventHandler(this.btnQ_Click);
            // 
            // btnR
            // 
            this.btnR.AutoSize = true;
            this.btnR.Location = new System.Drawing.Point(232, 298);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(75, 30);
            this.btnR.TabIndex = 17;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnS
            // 
            this.btnS.AutoSize = true;
            this.btnS.Location = new System.Drawing.Point(325, 298);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 30);
            this.btnS.TabIndex = 18;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnT
            // 
            this.btnT.AutoSize = true;
            this.btnT.Location = new System.Drawing.Point(418, 298);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(75, 30);
            this.btnT.TabIndex = 19;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnU
            // 
            this.btnU.AutoSize = true;
            this.btnU.Location = new System.Drawing.Point(46, 356);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(75, 30);
            this.btnU.TabIndex = 20;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnV
            // 
            this.btnV.AutoSize = true;
            this.btnV.Location = new System.Drawing.Point(139, 356);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(75, 30);
            this.btnV.TabIndex = 21;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // btnW
            // 
            this.btnW.AutoSize = true;
            this.btnW.Location = new System.Drawing.Point(232, 356);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(75, 30);
            this.btnW.TabIndex = 22;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // btnX
            // 
            this.btnX.AutoSize = true;
            this.btnX.Location = new System.Drawing.Point(325, 356);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 30);
            this.btnX.TabIndex = 23;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnY
            // 
            this.btnY.AutoSize = true;
            this.btnY.Location = new System.Drawing.Point(418, 356);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(75, 30);
            this.btnY.TabIndex = 24;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a Letter";
            // 
            // btnZ
            // 
            this.btnZ.AutoSize = true;
            this.btnZ.Location = new System.Drawing.Point(46, 414);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(75, 30);
            this.btnZ.TabIndex = 25;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            this.btnZ.Click += new System.EventHandler(this.btnZ_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSize = true;
            this.btnGenerate.Location = new System.Drawing.Point(160, 414);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(129, 30);
            this.btnGenerate.TabIndex = 26;
            this.btnGenerate.Text = "Generate Word";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.AutoSize = true;
            this.btnGiveUp.Location = new System.Drawing.Point(360, 414);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(76, 30);
            this.btnGiveUp.TabIndex = 27;
            this.btnGiveUp.Text = "Give Up";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // txtbWord
            // 
            this.txtbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbWord.Location = new System.Drawing.Point(46, 496);
            this.txtbWord.Name = "txtbWord";
            this.txtbWord.Size = new System.Drawing.Size(447, 62);
            this.txtbWord.TabIndex = 5;
            this.txtbWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wordsDataSet
            // 
            this.wordsDataSet.DataSetName = "WordsDataSet";
            this.wordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wordChoiceBindingSource
            // 
            this.wordChoiceBindingSource.DataMember = "WordChoice";
            this.wordChoiceBindingSource.DataSource = this.wordsDataSet;
            // 
            // wordChoiceTableAdapter
            // 
            this.wordChoiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Hangman.WordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WordChoiceTableAdapter = this.wordChoiceTableAdapter;
            // 
            // wordChoiceBindingNavigator
            // 
            this.wordChoiceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.wordChoiceBindingNavigator.BindingSource = this.wordChoiceBindingSource;
            this.wordChoiceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.wordChoiceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.wordChoiceBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.wordChoiceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.wordChoiceBindingNavigatorSaveItem});
            this.wordChoiceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.wordChoiceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.wordChoiceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.wordChoiceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.wordChoiceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.wordChoiceBindingNavigator.Name = "wordChoiceBindingNavigator";
            this.wordChoiceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.wordChoiceBindingNavigator.Size = new System.Drawing.Size(1030, 38);
            this.wordChoiceBindingNavigator.TabIndex = 28;
            this.wordChoiceBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // wordChoiceBindingNavigatorSaveItem
            // 
            this.wordChoiceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wordChoiceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("wordChoiceBindingNavigatorSaveItem.Image")));
            this.wordChoiceBindingNavigatorSaveItem.Name = "wordChoiceBindingNavigatorSaveItem";
            this.wordChoiceBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.wordChoiceBindingNavigatorSaveItem.Text = "Save Data";
            this.wordChoiceBindingNavigatorSaveItem.Click += new System.EventHandler(this.wordChoiceBindingNavigatorSaveItem_Click);
            // 
            // lblHintText
            // 
            this.lblHintText.AutoSize = true;
            this.lblHintText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHintText.Location = new System.Drawing.Point(623, 538);
            this.lblHintText.MaximumSize = new System.Drawing.Size(250, 200);
            this.lblHintText.Name = "lblHintText";
            this.lblHintText.Size = new System.Drawing.Size(0, 29);
            this.lblHintText.TabIndex = 32;
            // 
            // lblHintTitle
            // 
            this.lblHintTitle.AutoSize = true;
            this.lblHintTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHintTitle.Location = new System.Drawing.Point(701, 450);
            this.lblHintTitle.Name = "lblHintTitle";
            this.lblHintTitle.Size = new System.Drawing.Size(88, 37);
            this.lblHintTitle.TabIndex = 32;
            this.lblHintTitle.Text = "Hint:";
            // 
            // mainFrame
            // 
            this.mainFrame.Location = new System.Drawing.Point(590, 62);
            this.mainFrame.Name = "mainFrame";
            this.mainFrame.Size = new System.Drawing.Size(366, 382);
            this.mainFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainFrame.TabIndex = 33;
            this.mainFrame.TabStop = false;
            // 
            // hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 741);
            this.Controls.Add(this.mainFrame);
            this.Controls.Add(this.lblHintTitle);
            this.Controls.Add(this.lblHintText);
            this.Controls.Add(this.wordChoiceBindingNavigator);
            this.Controls.Add(this.txtbWord);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnA);
            this.Name = "hangman";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.hangman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordChoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordChoiceBindingNavigator)).EndInit();
            this.wordChoiceBindingNavigator.ResumeLayout(false);
            this.wordChoiceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.TextBox txtbWord;
        private WordsDataSet wordsDataSet;
        private System.Windows.Forms.BindingSource wordChoiceBindingSource;
        private WordsDataSetTableAdapters.WordChoiceTableAdapter wordChoiceTableAdapter;
        private WordsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator wordChoiceBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton wordChoiceBindingNavigatorSaveItem;
        private System.Windows.Forms.Label lblHintText;
        private System.Windows.Forms.Label lblHintTitle;
        private System.Windows.Forms.PictureBox mainFrame;
    }
}

