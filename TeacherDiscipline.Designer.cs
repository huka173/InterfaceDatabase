namespace Database
{
    partial class TeacherDiscipline
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
            System.Windows.Forms.Label idDisciplineLabel;
            this.dataSet1 = new Database.DataSet1();
            this.teacherDisciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherDisciplineTableAdapter = new Database.DataSet1TableAdapters.TeacherDisciplineTableAdapter();
            this.tableAdapterManager = new Database.DataSet1TableAdapters.TableAdapterManager();
            this.disciplineTableAdapter = new Database.DataSet1TableAdapters.DisciplineTableAdapter();
            this.teacherTableAdapter = new Database.DataSet1TableAdapters.TeacherTableAdapter();
            this.teacherDisciplineDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            idTeacherLabel = new System.Windows.Forms.Label();
            idDisciplineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDisciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDisciplineDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idTeacherLabel
            // 
            idTeacherLabel.AutoSize = true;
            idTeacherLabel.Location = new System.Drawing.Point(354, 15);
            idTeacherLabel.Name = "idTeacherLabel";
            idTeacherLabel.Size = new System.Drawing.Size(49, 13);
            idTeacherLabel.TabIndex = 3;
            idTeacherLabel.Text = "Учитель";
            // 
            // idDisciplineLabel
            // 
            idDisciplineLabel.AutoSize = true;
            idDisciplineLabel.Location = new System.Drawing.Point(354, 41);
            idDisciplineLabel.Name = "idDisciplineLabel";
            idDisciplineLabel.Size = new System.Drawing.Size(70, 13);
            idDisciplineLabel.TabIndex = 5;
            idDisciplineLabel.Text = "Дисциплина";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherDisciplineBindingSource
            // 
            this.teacherDisciplineBindingSource.DataMember = "TeacherDiscipline";
            this.teacherDisciplineBindingSource.DataSource = this.dataSet1;
            // 
            // teacherDisciplineTableAdapter
            // 
            this.teacherDisciplineTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplineTableAdapter = this.disciplineTableAdapter;
            this.tableAdapterManager.GraduateStudentTableAdapter = null;
            this.tableAdapterManager.LectureTableAdapter = null;
            this.tableAdapterManager.LoadTableAdapter = null;
            this.tableAdapterManager.SemestrTableAdapter = null;
            this.tableAdapterManager.StreamTableAdapter = null;
            this.tableAdapterManager.TeacherDisciplineTableAdapter = this.teacherDisciplineTableAdapter;
            this.tableAdapterManager.TeacherTableAdapter = this.teacherTableAdapter;
            this.tableAdapterManager.TeacherWithTitleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Database.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // disciplineTableAdapter
            // 
            this.disciplineTableAdapter.ClearBeforeFill = true;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // teacherDisciplineDataGridView
            // 
            this.teacherDisciplineDataGridView.AutoGenerateColumns = false;
            this.teacherDisciplineDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.teacherDisciplineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherDisciplineDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.teacherDisciplineDataGridView.DataSource = this.teacherDisciplineBindingSource;
            this.teacherDisciplineDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.teacherDisciplineDataGridView.Location = new System.Drawing.Point(0, 0);
            this.teacherDisciplineDataGridView.Name = "teacherDisciplineDataGridView";
            this.teacherDisciplineDataGridView.Size = new System.Drawing.Size(345, 450);
            this.teacherDisciplineDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdTeacher";
            this.dataGridViewTextBoxColumn2.DataSource = this.teacherBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "LName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Учителя";
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdDiscipline";
            this.dataGridViewTextBoxColumn3.DataSource = this.disciplineBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "NameDiscipline";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дисциплина";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IdDiscipline";
            // 
            // disciplineBindingSource
            // 
            this.disciplineBindingSource.DataMember = "Discipline";
            this.disciplineBindingSource.DataSource = this.dataSet1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(357, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 65);
            this.button2.TabIndex = 22;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(357, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 65);
            this.button1.TabIndex = 21;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teacherDisciplineBindingSource, "IdTeacher", true));
            this.comboBox1.DataSource = this.teacherBindingSource;
            this.comboBox1.DisplayMember = "LName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(446, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.ValueMember = "IdTeacher";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teacherDisciplineBindingSource, "IdDiscipline", true));
            this.comboBox2.DataSource = this.disciplineBindingSource;
            this.comboBox2.DisplayMember = "NameDiscipline";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(446, 38);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.ValueMember = "IdDiscipline";
            // 
            // TeacherDiscipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(idTeacherLabel);
            this.Controls.Add(idDisciplineLabel);
            this.Controls.Add(this.teacherDisciplineDataGridView);
            this.Name = "TeacherDiscipline";
            this.Text = "Учителя и дисциплины";
            this.Load += new System.EventHandler(this.TeacherDiscipline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDisciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDisciplineDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource teacherDisciplineBindingSource;
        private DataSet1TableAdapters.TeacherDisciplineTableAdapter teacherDisciplineTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView teacherDisciplineDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private DataSet1TableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private DataSet1TableAdapters.DisciplineTableAdapter disciplineTableAdapter;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
    }
}