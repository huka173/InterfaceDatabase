namespace Database
{
    partial class Lecture
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
            System.Windows.Forms.Label idSemestrLabel;
            System.Windows.Forms.Label idDisciplineLabel;
            System.Windows.Forms.Label idStreamLabel;
            System.Windows.Forms.Label idTeacherTitleLabel;
            this.dataSet1 = new Database.DataSet1();
            this.lectureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectureTableAdapter = new Database.DataSet1TableAdapters.LectureTableAdapter();
            this.tableAdapterManager = new Database.DataSet1TableAdapters.TableAdapterManager();
            this.disciplineTableAdapter = new Database.DataSet1TableAdapters.DisciplineTableAdapter();
            this.semestrTableAdapter = new Database.DataSet1TableAdapters.SemestrTableAdapter();
            this.streamTableAdapter = new Database.DataSet1TableAdapters.StreamTableAdapter();
            this.lectureDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.semestrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.streamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idTeacherTitleTextBox = new System.Windows.Forms.TextBox();
            this.semestrTableAdapter1 = new Database.DataSet1TableAdapters.SemestrTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            idSemestrLabel = new System.Windows.Forms.Label();
            idDisciplineLabel = new System.Windows.Forms.Label();
            idStreamLabel = new System.Windows.Forms.Label();
            idTeacherTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idSemestrLabel
            // 
            idSemestrLabel.AutoSize = true;
            idSemestrLabel.Location = new System.Drawing.Point(19, 234);
            idSemestrLabel.Name = "idSemestrLabel";
            idSemestrLabel.Size = new System.Drawing.Size(51, 13);
            idSemestrLabel.TabIndex = 26;
            idSemestrLabel.Text = "Семестр";
            // 
            // idDisciplineLabel
            // 
            idDisciplineLabel.AutoSize = true;
            idDisciplineLabel.Location = new System.Drawing.Point(19, 258);
            idDisciplineLabel.Name = "idDisciplineLabel";
            idDisciplineLabel.Size = new System.Drawing.Size(70, 13);
            idDisciplineLabel.TabIndex = 27;
            idDisciplineLabel.Text = "Дисциплина";
            // 
            // idStreamLabel
            // 
            idStreamLabel.AutoSize = true;
            idStreamLabel.Location = new System.Drawing.Point(19, 286);
            idStreamLabel.Name = "idStreamLabel";
            idStreamLabel.Size = new System.Drawing.Size(38, 13);
            idStreamLabel.TabIndex = 28;
            idStreamLabel.Text = "Поток";
            // 
            // idTeacherTitleLabel
            // 
            idTeacherTitleLabel.AutoSize = true;
            idTeacherTitleLabel.Location = new System.Drawing.Point(19, 315);
            idTeacherTitleLabel.Name = "idTeacherTitleLabel";
            idTeacherTitleLabel.Size = new System.Drawing.Size(139, 13);
            idTeacherTitleLabel.TabIndex = 33;
            idTeacherTitleLabel.Text = "Id Главного руководителя";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lectureBindingSource
            // 
            this.lectureBindingSource.DataMember = "Lecture";
            this.lectureBindingSource.DataSource = this.dataSet1;
            // 
            // lectureTableAdapter
            // 
            this.lectureTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplineTableAdapter = this.disciplineTableAdapter;
            this.tableAdapterManager.GraduateStudentTableAdapter = null;
            this.tableAdapterManager.LectureTableAdapter = this.lectureTableAdapter;
            this.tableAdapterManager.LoadTableAdapter = null;
            this.tableAdapterManager.SemestrTableAdapter = this.semestrTableAdapter;
            this.tableAdapterManager.StreamTableAdapter = this.streamTableAdapter;
            this.tableAdapterManager.TeacherDisciplineTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.TeacherWithTitleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Database.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // disciplineTableAdapter
            // 
            this.disciplineTableAdapter.ClearBeforeFill = true;
            // 
            // semestrTableAdapter
            // 
            this.semestrTableAdapter.ClearBeforeFill = true;
            // 
            // streamTableAdapter
            // 
            this.streamTableAdapter.ClearBeforeFill = true;
            // 
            // lectureDataGridView
            // 
            this.lectureDataGridView.AutoGenerateColumns = false;
            this.lectureDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.lectureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.lectureDataGridView.DataSource = this.lectureBindingSource;
            this.lectureDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.lectureDataGridView.Location = new System.Drawing.Point(0, 0);
            this.lectureDataGridView.Name = "lectureDataGridView";
            this.lectureDataGridView.Size = new System.Drawing.Size(800, 220);
            this.lectureDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdSemestr";
            this.dataGridViewTextBoxColumn2.DataSource = this.semestrBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "NameSemestr";
            this.dataGridViewTextBoxColumn2.HeaderText = "Семестр";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "IdSemestr";
            // 
            // semestrBindingSource
            // 
            this.semestrBindingSource.DataMember = "Semestr";
            this.semestrBindingSource.DataSource = this.dataSet1;
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdStream";
            this.dataGridViewTextBoxColumn4.DataSource = this.streamBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "NameStream";
            this.dataGridViewTextBoxColumn4.HeaderText = "Поток";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IdStream";
            // 
            // streamBindingSource
            // 
            this.streamBindingSource.DataMember = "Stream";
            this.streamBindingSource.DataSource = this.dataSet1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdTeacherTitle";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id Главного руководителя";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(425, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 65);
            this.button3.TabIndex = 26;
            this.button3.Text = "Руководители";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(594, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 66);
            this.button2.TabIndex = 33;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(594, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 65);
            this.button1.TabIndex = 32;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idTeacherTitleTextBox
            // 
            this.idTeacherTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectureBindingSource, "IdTeacherTitle", true));
            this.idTeacherTitleTextBox.Location = new System.Drawing.Point(182, 315);
            this.idTeacherTitleTextBox.Name = "idTeacherTitleTextBox";
            this.idTeacherTitleTextBox.Size = new System.Drawing.Size(223, 20);
            this.idTeacherTitleTextBox.TabIndex = 34;
            // 
            // semestrTableAdapter1
            // 
            this.semestrTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lectureBindingSource, "IdSemestr", true));
            this.comboBox1.DataSource = this.semestrBindingSource;
            this.comboBox1.DisplayMember = "NameSemestr";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(182, 231);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 21);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.ValueMember = "IdSemestr";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lectureBindingSource, "IdDiscipline", true));
            this.comboBox2.DataSource = this.disciplineBindingSource;
            this.comboBox2.DisplayMember = "NameDiscipline";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(182, 258);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(223, 21);
            this.comboBox2.TabIndex = 35;
            this.comboBox2.ValueMember = "IdDiscipline";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lectureBindingSource, "IdStream", true));
            this.comboBox3.DataSource = this.streamBindingSource;
            this.comboBox3.DisplayMember = "NameStream";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(182, 286);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(223, 21);
            this.comboBox3.TabIndex = 35;
            this.comboBox3.ValueMember = "IdStream";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 347);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 42;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(425, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 65);
            this.button4.TabIndex = 41;
            this.button4.Text = "Результат";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Lecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(idTeacherTitleLabel);
            this.Controls.Add(this.idTeacherTitleTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(idStreamLabel);
            this.Controls.Add(idDisciplineLabel);
            this.Controls.Add(idSemestrLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lectureDataGridView);
            this.Name = "Lecture";
            this.Text = "Лекции";
            this.Load += new System.EventHandler(this.Lecture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource lectureBindingSource;
        private DataSet1TableAdapters.LectureTableAdapter lectureTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView lectureDataGridView;
        private DataSet1TableAdapters.SemestrTableAdapter semestrTableAdapter;
        private System.Windows.Forms.BindingSource semestrBindingSource;
        private DataSet1TableAdapters.DisciplineTableAdapter disciplineTableAdapter;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private DataSet1TableAdapters.StreamTableAdapter streamTableAdapter;
        private System.Windows.Forms.BindingSource streamBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idTeacherTitleTextBox;
        private DataSet1TableAdapters.SemestrTableAdapter semestrTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
    }
}