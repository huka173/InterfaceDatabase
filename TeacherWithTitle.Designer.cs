namespace Database
{
    partial class TeacherWithTitle
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
            System.Windows.Forms.Label idTeacherLabel;
            this.dataSet1 = new Database.DataSet1();
            this.teacherWithTitleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherWithTitleTableAdapter = new Database.DataSet1TableAdapters.TeacherWithTitleTableAdapter();
            this.tableAdapterManager = new Database.DataSet1TableAdapters.TableAdapterManager();
            this.teacherWithTitleDataGridView = new System.Windows.Forms.DataGridView();
            this.idTeacherTextBox = new System.Windows.Forms.TextBox();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new Database.DataSet1TableAdapters.TeacherTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            idTeacherLabel = new System.Windows.Forms.Label();
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
            // teacherWithTitleDataGridView
            // 
            this.teacherWithTitleDataGridView.AutoGenerateColumns = false;
            this.teacherWithTitleDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.teacherWithTitleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherWithTitleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.teacherWithTitleDataGridView.DataSource = this.teacherWithTitleBindingSource;
            this.teacherWithTitleDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.teacherWithTitleDataGridView.Location = new System.Drawing.Point(0, 0);
            this.teacherWithTitleDataGridView.Name = "teacherWithTitleDataGridView";
            this.teacherWithTitleDataGridView.Size = new System.Drawing.Size(300, 450);
            this.teacherWithTitleDataGridView.TabIndex = 1;
            // 
            // idTeacherLabel
            // 
            idTeacherLabel.AutoSize = true;
            idTeacherLabel.Location = new System.Drawing.Point(326, 9);
            idTeacherLabel.Name = "idTeacherLabel";
            idTeacherLabel.Size = new System.Drawing.Size(61, 13);
            idTeacherLabel.TabIndex = 3;
            idTeacherLabel.Text = "Id Учителя";
            // 
            // idTeacherTextBox
            // 
            this.idTeacherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherWithTitleBindingSource, "IdTeacher", true));
            this.idTeacherTextBox.Location = new System.Drawing.Point(417, 6);
            this.idTeacherTextBox.Name = "idTeacherTextBox";
            this.idTeacherTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTeacherTextBox.TabIndex = 4;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.dataSet1;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdTeacher";
            this.dataGridViewTextBoxColumn2.DataSource = this.teacherBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "LName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Учитель";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "IdTeacher";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(329, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 63);
            this.button2.TabIndex = 22;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(329, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 65);
            this.button1.TabIndex = 21;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeacherWithTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(idTeacherLabel);
            this.Controls.Add(this.idTeacherTextBox);
            this.Controls.Add(this.teacherWithTitleDataGridView);
            this.Name = "TeacherWithTitle";
            this.Text = "Учителя с должностью(выше ассистент)";
            this.Load += new System.EventHandler(this.TeacherWithTitle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherWithTitleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherWithTitleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource teacherWithTitleBindingSource;
        private DataSet1TableAdapters.TeacherWithTitleTableAdapter teacherWithTitleTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView teacherWithTitleDataGridView;
        private System.Windows.Forms.TextBox idTeacherTextBox;
        private DataSet1TableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}