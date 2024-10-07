namespace Problem13._4
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
            this.TableView = new System.Windows.Forms.DataGridView();
            this.personnelDataSet = new Problem13._4.PersonnelDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Problem13._4.PersonnelDataSetTableAdapters.EmployeeTableAdapter();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourlyPayRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSearch = new System.Windows.Forms.TextBox();
            this.PersonFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TableView
            // 
            this.TableView.AutoGenerateColumns = false;
            this.TableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.hourlyPayRateDataGridViewTextBoxColumn});
            this.TableView.DataSource = this.employeeBindingSource;
            this.TableView.Location = new System.Drawing.Point(112, 88);
            this.TableView.Name = "TableView";
            this.TableView.RowHeadersWidth = 51;
            this.TableView.RowTemplate.Height = 24;
            this.TableView.Size = new System.Drawing.Size(553, 150);
            this.TableView.TabIndex = 0;
            // 
            // personnelDataSet
            // 
            this.personnelDataSet.DataSetName = "PersonnelDataSet";
            this.personnelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.personnelDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "Employee Id";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "Employee Id";
            this.employeeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 125;
            // 
            // hourlyPayRateDataGridViewTextBoxColumn
            // 
            this.hourlyPayRateDataGridViewTextBoxColumn.DataPropertyName = "hourly pay rate";
            this.hourlyPayRateDataGridViewTextBoxColumn.HeaderText = "hourly pay rate";
            this.hourlyPayRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hourlyPayRateDataGridViewTextBoxColumn.Name = "hourlyPayRateDataGridViewTextBoxColumn";
            this.hourlyPayRateDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameSearch
            // 
            this.nameSearch.Location = new System.Drawing.Point(112, 304);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(100, 22);
            this.nameSearch.TabIndex = 1;
            // 
            // PersonFind
            // 
            this.PersonFind.Location = new System.Drawing.Point(151, 403);
            this.PersonFind.Name = "PersonFind";
            this.PersonFind.Size = new System.Drawing.Size(162, 23);
            this.PersonFind.TabIndex = 2;
            this.PersonFind.Text = "Find Person";
            this.PersonFind.UseVisualStyleBackColor = true;
            this.PersonFind.Click += new System.EventHandler(this.PersonFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.PersonFind);
            this.Controls.Add(this.nameSearch);
            this.Controls.Add(this.TableView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableView;
        private PersonnelDataSet personnelDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private PersonnelDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourlyPayRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox nameSearch;
        private System.Windows.Forms.Button PersonFind;
    }
}

