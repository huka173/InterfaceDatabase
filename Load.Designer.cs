namespace Database
{
    partial class Load
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
            System.Windows.Forms.Label loadTypeLabel;
            System.Windows.Forms.Label loadVolumeLabel;
            System.Windows.Forms.Label loadYearLabel;
            this.dataSet1 = new Database.DataSet1();
            this.loadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadTableAdapter = new Database.DataSet1TableAdapters.LoadTableAdapter();
            this.tableAdapterManager = new Database.DataSet1TableAdapters.TableAdapterManager();
            this.teacherTableAdapter = new Database.DataSet1TableAdapters.TeacherTableAdapter();
            this.loadDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadVolumeTextBox = new System.Windows.Forms.TextBox();
            this.loadYearDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.loadTypeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            idTeacherLabel = new System.Windows.Forms.Label();
            loadTypeLabel = new System.Windows.Forms.Label();
            loadVolumeLabel = new System.Windows.Forms.Label();
            loadYearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idTeacherLabel
            // 
            idTeacherLabel.AutoSize = true;
            idTeacherLabel.Location = new System.Drawing.Point(12, 238);
            idTeacherLabel.Name = "idTeacherLabel";
            idTeacherLabel.Size = new System.Drawing.Size(49, 13);
            idTeacherLabel.TabIndex = 3;
            idTeacherLabel.Text = "Учитель";
            // 
            // loadTypeLabel
            // 
            loadTypeLabel.AutoSize = true;
            loadTypeLabel.Location = new System.Drawing.Point(12, 264);
            loadTypeLabel.Name = "loadTypeLabel";
            loadTypeLabel.Size = new System.Drawing.Size(75, 13);
            loadTypeLabel.TabIndex = 5;
            loadTypeLabel.Text = "Тип нагрузки";
            // 
            // loadVolumeLabel
            // 
            loadVolumeLabel.AutoSize = true;
            loadVolumeLabel.Location = new System.Drawing.Point(12, 290);
            loadVolumeLabel.Name = "loadVolumeLabel";
            loadVolumeLabel.Size = new System.Drawing.Size(91, 13);
            loadVolumeLabel.TabIndex = 7;
            loadVolumeLabel.Text = "Объем нагрузки";
            // 
            // loadYearLabel
            // 
            loadYearLabel.AutoSize = true;
            loadYearLabel.Location = new System.Drawing.Point(12, 317);
            loadYearLabel.Name = "loadYearLabel";
            loadYearLabel.Size = new System.Drawing.Size(25, 13);
            loadYearLabel.TabIndex = 9;
            loadYearLabel.Text = "Год";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loadBindingSource
            // 
            this.loadBindingSource.DataMember = "Load";
            this.loadBindingSource.DataSource = this.dataSet1;
            // 
            // loadTableAdapter
            // 
            this.loadTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.GraduateStudentTableAdapter = null;
            this.tableAdapterManager.LectureTableAdapter = null;
            this.tableAdapterManager.LoadTableAdapter = this.loadTableAdapter;
            this.tableAdapterManager.SemestrTableAdapter = null;
            this.tableAdapterManager.StreamTableAdapter = null;
            this.tableAdapterManager.TeacherDisciplineTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = this.teacherTableAdapter;
            this.tableAdapterManager.TeacherWithTitleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Database.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // loadDataGridView
            // 
            this.loadDataGridView.AutoGenerateColumns = false;
            this.loadDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.loadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.loadDataGridView.DataSource = this.loadBindingSource;
            this.loadDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.loadDataGridView.Location = new System.Drawing.Point(0, 0);
            this.loadDataGridView.Name = "loadDataGridView";
            this.loadDataGridView.Size = new System.Drawing.Size(800, 224);
            this.loadDataGridView.TabIndex = 1;
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
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LoadType";
            this.dataGridViewTextBoxColumn3.HeaderText = "Тип нагрузки";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LoadVolume";
            this.dataGridViewTextBoxColumn4.HeaderText = "Объем нагрузки";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LoadYear";
            this.dataGridViewTextBoxColumn5.HeaderText = "Год";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // loadVolumeTextBox
            // 
            this.loadVolumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadBindingSource, "LoadVolume", true));
            this.loadVolumeTextBox.Location = new System.Drawing.Point(111, 287);
            this.loadVolumeTextBox.Name = "loadVolumeTextBox";
            this.loadVolumeTextBox.Size = new System.Drawing.Size(200, 20);
            this.loadVolumeTextBox.TabIndex = 8;
            // 
            // loadYearDateTimePicker
            // 
            this.loadYearDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.loadBindingSource, "LoadYear", true));
            this.loadYearDateTimePicker.Location = new System.Drawing.Point(111, 313);
            this.loadYearDateTimePicker.Name = "loadYearDateTimePicker";
            this.loadYearDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.loadYearDateTimePicker.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.loadBindingSource, "IdTeacher", true));
            this.comboBox1.DataSource = this.teacherBindingSource;
            this.comboBox1.DisplayMember = "LName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 234);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "IdTeacher";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(264, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 66);
            this.button2.TabIndex = 31;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 65);
            this.button1.TabIndex = 30;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadTypeTextBox
            // 
            this.loadTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadBindingSource, "LoadType", true));
            this.loadTypeTextBox.Location = new System.Drawing.Point(111, 261);
            this.loadTypeTextBox.Name = "loadTypeTextBox";
            this.loadTypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.loadTypeTextBox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(562, 310);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 34;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(520, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 65);
            this.button3.TabIndex = 33;
            this.button3.Text = "Результат";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.loadTypeTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(idTeacherLabel);
            this.Controls.Add(loadTypeLabel);
            this.Controls.Add(loadVolumeLabel);
            this.Controls.Add(this.loadVolumeTextBox);
            this.Controls.Add(loadYearLabel);
            this.Controls.Add(this.loadYearDateTimePicker);
            this.Controls.Add(this.loadDataGridView);
            this.Name = "Load";
            this.Text = "Нагрузка";
            this.Load += new System.EventHandler(this.Load_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource loadBindingSource;
        private DataSet1TableAdapters.LoadTableAdapter loadTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView loadDataGridView;
        private DataSet1TableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox loadVolumeTextBox;
        private System.Windows.Forms.DateTimePicker loadYearDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox loadTypeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}