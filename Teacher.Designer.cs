namespace Database
{
    partial class Teacher
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
            System.Windows.Forms.Label academicDegreeLabel;
            System.Windows.Forms.Label academicTitleLabel;
            System.Windows.Forms.Label jobTitleLabel;
            System.Windows.Forms.Label lNameLabel;
            System.Windows.Forms.Label fNameLabel;
            System.Windows.Forms.Label sNameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label sexLabel;
            this.dataSet1 = new Database.DataSet1();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new Database.DataSet1TableAdapters.TeacherTableAdapter();
            this.tableAdapterManager = new Database.DataSet1TableAdapters.TableAdapterManager();
            this.teacherDataGridView = new System.Windows.Forms.DataGridView();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.sNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.teacherDisciplineTableAdapter = new Database.DataSet1TableAdapters.TeacherDisciplineTableAdapter();
            this.academicDegreeTextBox = new System.Windows.Forms.TextBox();
            this.academicTitleTextBox = new System.Windows.Forms.TextBox();
            this.jobTitleTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.fkIdTeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            academicDegreeLabel = new System.Windows.Forms.Label();
            academicTitleLabel = new System.Windows.Forms.Label();
            jobTitleLabel = new System.Windows.Forms.Label();
            lNameLabel = new System.Windows.Forms.Label();
            fNameLabel = new System.Windows.Forms.Label();
            sNameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkIdTeacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // academicDegreeLabel
            // 
            academicDegreeLabel.AutoSize = true;
            academicDegreeLabel.Location = new System.Drawing.Point(12, 216);
            academicDegreeLabel.Name = "academicDegreeLabel";
            academicDegreeLabel.Size = new System.Drawing.Size(88, 13);
            academicDegreeLabel.TabIndex = 3;
            academicDegreeLabel.Text = "Ученая степень";
            // 
            // academicTitleLabel
            // 
            academicTitleLabel.AutoSize = true;
            academicTitleLabel.Location = new System.Drawing.Point(12, 242);
            academicTitleLabel.Name = "academicTitleLabel";
            academicTitleLabel.Size = new System.Drawing.Size(83, 13);
            academicTitleLabel.TabIndex = 5;
            academicTitleLabel.Text = "Ученое звание";
            // 
            // jobTitleLabel
            // 
            jobTitleLabel.AutoSize = true;
            jobTitleLabel.Location = new System.Drawing.Point(12, 268);
            jobTitleLabel.Name = "jobTitleLabel";
            jobTitleLabel.Size = new System.Drawing.Size(65, 13);
            jobTitleLabel.TabIndex = 7;
            jobTitleLabel.Text = "Должность";
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Location = new System.Drawing.Point(263, 213);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new System.Drawing.Size(56, 13);
            lNameLabel.TabIndex = 9;
            lNameLabel.Text = "Фамилия";
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Location = new System.Drawing.Point(263, 239);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(29, 13);
            fNameLabel.TabIndex = 11;
            fNameLabel.Text = "Имя";
            // 
            // sNameLabel
            // 
            sNameLabel.AutoSize = true;
            sNameLabel.Location = new System.Drawing.Point(263, 265);
            sNameLabel.Name = "sNameLabel";
            sNameLabel.Size = new System.Drawing.Size(54, 13);
            sNameLabel.TabIndex = 13;
            sNameLabel.Text = "Отчество";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(12, 293);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(52, 13);
            phoneLabel.TabIndex = 15;
            phoneLabel.Text = "Телефон";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(263, 293);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(30, 13);
            sexLabel.TabIndex = 17;
            sexLabel.Text = "Пол:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.TeacherWithTitleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Database.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teacherDataGridView
            // 
            this.teacherDataGridView.AutoGenerateColumns = false;
            this.teacherDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.teacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.teacherDataGridView.DataSource = this.teacherBindingSource;
            this.teacherDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.teacherDataGridView.Location = new System.Drawing.Point(0, 0);
            this.teacherDataGridView.Name = "teacherDataGridView";
            this.teacherDataGridView.Size = new System.Drawing.Size(940, 202);
            this.teacherDataGridView.TabIndex = 1;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "LName", true));
            this.lNameTextBox.Location = new System.Drawing.Point(364, 210);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(131, 20);
            this.lNameTextBox.TabIndex = 10;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "FName", true));
            this.fNameTextBox.Location = new System.Drawing.Point(364, 236);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(131, 20);
            this.fNameTextBox.TabIndex = 12;
            // 
            // sNameTextBox
            // 
            this.sNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "SName", true));
            this.sNameTextBox.Location = new System.Drawing.Point(364, 262);
            this.sNameTextBox.Name = "sNameTextBox";
            this.sNameTextBox.Size = new System.Drawing.Size(131, 20);
            this.sNameTextBox.TabIndex = 14;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(113, 290);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(131, 20);
            this.phoneTextBox.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(266, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 65);
            this.button2.TabIndex = 20;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(11, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 65);
            this.button1.TabIndex = 19;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // teacherDisciplineTableAdapter
            // 
            this.teacherDisciplineTableAdapter.ClearBeforeFill = true;
            // 
            // academicDegreeTextBox
            // 
            this.academicDegreeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "AcademicDegree", true));
            this.academicDegreeTextBox.Location = new System.Drawing.Point(113, 213);
            this.academicDegreeTextBox.Name = "academicDegreeTextBox";
            this.academicDegreeTextBox.Size = new System.Drawing.Size(131, 20);
            this.academicDegreeTextBox.TabIndex = 23;
            // 
            // academicTitleTextBox
            // 
            this.academicTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "AcademicTitle", true));
            this.academicTitleTextBox.Location = new System.Drawing.Point(113, 239);
            this.academicTitleTextBox.Name = "academicTitleTextBox";
            this.academicTitleTextBox.Size = new System.Drawing.Size(131, 20);
            this.academicTitleTextBox.TabIndex = 25;
            // 
            // jobTitleTextBox
            // 
            this.jobTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "JobTitle", true));
            this.jobTitleTextBox.Location = new System.Drawing.Point(113, 265);
            this.jobTitleTextBox.Name = "jobTitleTextBox";
            this.jobTitleTextBox.Size = new System.Drawing.Size(131, 20);
            this.jobTitleTextBox.TabIndex = 27;
            // 
            // sexTextBox
            // 
            this.sexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Sex", true));
            this.sexTextBox.Location = new System.Drawing.Point(364, 288);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(131, 20);
            this.sexTextBox.TabIndex = 37;
            // 
            // fkIdTeacherBindingSource
            // 
            this.fkIdTeacherBindingSource.DataMember = "fk_IdTeacher";
            this.fkIdTeacherBindingSource.DataSource = this.teacherBindingSource;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AcademicDegree";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ученая степень";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AcademicTitle";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ученое звание";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "JobTitle";
            this.dataGridViewTextBoxColumn4.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn8.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn9.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(940, 515);
            this.Controls.Add(this.academicDegreeTextBox);
            this.Controls.Add(this.academicTitleTextBox);
            this.Controls.Add(this.jobTitleTextBox);
            this.Controls.Add(this.sexTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(academicDegreeLabel);
            this.Controls.Add(academicTitleLabel);
            this.Controls.Add(jobTitleLabel);
            this.Controls.Add(lNameLabel);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(fNameLabel);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(sNameLabel);
            this.Controls.Add(this.sNameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.teacherDataGridView);
            this.Name = "Teacher";
            this.Text = "Учителя";
            this.Load += new System.EventHandler(this.Teacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkIdTeacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private DataSet1TableAdapters.TeacherTableAdapter teacherTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView teacherDataGridView;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox sNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource fkIdTeacherBindingSource;
        private DataSet1TableAdapters.TeacherDisciplineTableAdapter teacherDisciplineTableAdapter;
        private System.Windows.Forms.TextBox academicDegreeTextBox;
        private System.Windows.Forms.TextBox academicTitleTextBox;
        private System.Windows.Forms.TextBox jobTitleTextBox;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}