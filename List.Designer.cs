namespace Database
{
    partial class List
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
            this.dataSet1 = new Database.DataSet1();
            this.teacherWithTitleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherWithTitleTableAdapter = new Database.DataSet1TableAdapters.TeacherWithTitleTableAdapter();
            this.tableAdapterManager = new Database.DataSet1TableAdapters.TableAdapterManager();
            this.teacherTableAdapter = new Database.DataSet1TableAdapters.TeacherTableAdapter();
            this.teacherWithTitleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherWithTitleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherWithTitleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherWithTitleBindingSource
            // 
            this.teacherWithTitleBindingSource.DataMember = "TeacherWithTitle";
            this.teacherWithTitleBindingSource.DataSource = this.dataSet1;
            // 
            // teacherWithTitleTableAdapter
            // 
            this.teacherWithTitleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.GraduateStudentTableAdapter = null;
            this.tableAdapterManager.LectureTableAdapter = null;
            this.tableAdapterManager.LoadTableAdapter = null;
            this.tableAdapterManager.SemestrTableAdapter = null;
            this.tableAdapterManager.StreamTableAdapter = null;
            this.tableAdapterManager.TeacherDisciplineTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = this.teacherTableAdapter;
            this.tableAdapterManager.TeacherWithTitleTableAdapter = this.teacherWithTitleTableAdapter;
            this.tableAdapterManager.UpdateOrder = Database.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // teacherWithTitleDataGridView
            // 
            this.teacherWithTitleDataGridView.AutoGenerateColumns = false;
            this.teacherWithTitleDataGridView.BackgroundColor = System.Drawing.Color.Lavender;
            this.teacherWithTitleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherWithTitleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.teacherWithTitleDataGridView.DataSource = this.teacherWithTitleBindingSource;
            this.teacherWithTitleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherWithTitleDataGridView.Location = new System.Drawing.Point(0, 0);
            this.teacherWithTitleDataGridView.Name = "teacherWithTitleDataGridView";
            this.teacherWithTitleDataGridView.Size = new System.Drawing.Size(377, 393);
            this.teacherWithTitleDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdTeacherTitle";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Главного руководителя";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdTeacher";
            this.dataGridViewTextBoxColumn2.DataSource = this.teacherBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "LName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Главный руководитель";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "IdTeacher";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.dataSet1;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 393);
            this.Controls.Add(this.teacherWithTitleDataGridView);
            this.Name = "List";
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherWithTitleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherWithTitleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource teacherWithTitleBindingSource;
        private DataSet1TableAdapters.TeacherWithTitleTableAdapter teacherWithTitleTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView teacherWithTitleDataGridView;
        private DataSet1TableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
    }
}