namespace Database
{
    partial class GraduateStudent
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
            System.Windows.Forms.Label idTeacherTitleLabel;
            System.Windows.Forms.Label lNameLabel;
            System.Windows.Forms.Label fNameLabel;
            System.Windows.Forms.Label sNameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label sexLabel;
            this.dataSet1 = new Database.DataSet1();
            this.graduateStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graduateStudentTableAdapter = new Database.DataSet1TableAdapters.GraduateStudentTableAdapter();
            this.tableAdapterManager = new Database.DataSet1TableAdapters.TableAdapterManager();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.sNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.teacherWithTitleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherWithTitleTableAdapter = new Database.DataSet1TableAdapters.TeacherWithTitleTableAdapter();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new Database.DataSet1TableAdapters.TeacherTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.graduateStudentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idTeacherTitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            idTeacherTitleLabel = new System.Windows.Forms.Label();
            lNameLabel = new System.Windows.Forms.Label();
            fNameLabel = new System.Windows.Forms.Label();
            sNameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graduateStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherWithTitleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graduateStudentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idTeacherTitleLabel
            // 
            idTeacherTitleLabel.AutoSize = true;
            idTeacherTitleLabel.Location = new System.Drawing.Point(12, 230);
            idTeacherTitleLabel.Name = "idTeacherTitleLabel";
            idTeacherTitleLabel.Size = new System.Drawing.Size(139, 13);
            idTeacherTitleLabel.TabIndex = 3;
            idTeacherTitleLabel.Text = "Id Главного руководителя";
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Location = new System.Drawing.Point(12, 256);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new System.Drawing.Size(56, 13);
            lNameLabel.TabIndex = 5;
            lNameLabel.Text = "Фамилия";
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Location = new System.Drawing.Point(12, 282);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(29, 13);
            fNameLabel.TabIndex = 7;
            fNameLabel.Text = "Имя";
            // 
            // sNameLabel
            // 
            sNameLabel.AutoSize = true;
            sNameLabel.Location = new System.Drawing.Point(12, 308);
            sNameLabel.Name = "sNameLabel";
            sNameLabel.Size = new System.Drawing.Size(54, 13);
            sNameLabel.TabIndex = 9;
            sNameLabel.Text = "Отчество";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(12, 334);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(52, 13);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Телефон";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(12, 360);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(27, 13);
            sexLabel.TabIndex = 13;
            sexLabel.Text = "Пол";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // graduateStudentBindingSource
            // 
            this.graduateStudentBindingSource.DataMember = "GraduateStudent";
            this.graduateStudentBindingSource.DataSource = this.dataSet1;
            // 
            // graduateStudentTableAdapter
            // 
            this.graduateStudentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.GraduateStudentTableAdapter = this.graduateStudentTableAdapter;
            this.tableAdapterManager.LectureTableAdapter = null;
            this.tableAdapterManager.LoadTableAdapter = null;
            this.tableAdapterManager.SemestrTableAdapter = null;
            this.tableAdapterManager.StreamTableAdapter = null;
            this.tableAdapterManager.TeacherDisciplineTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.TeacherWithTitleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Database.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.graduateStudentBindingSource, "LName", true));
            this.lNameTextBox.Location = new System.Drawing.Point(157, 253);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lNameTextBox.TabIndex = 6;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.graduateStudentBindingSource, "FName", true));
            this.fNameTextBox.Location = new System.Drawing.Point(157, 279);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fNameTextBox.TabIndex = 8;
            // 
            // sNameTextBox
            // 
            this.sNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.graduateStudentBindingSource, "SName", true));
            this.sNameTextBox.Location = new System.Drawing.Point(157, 305);
            this.sNameTextBox.Name = "sNameTextBox";
            this.sNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.sNameTextBox.TabIndex = 10;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.graduateStudentBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(157, 331);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 12;
            // 
            // sexTextBox
            // 
            this.sexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.graduateStudentBindingSource, "Sex", true));
            this.sexTextBox.Location = new System.Drawing.Point(157, 357);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(100, 20);
            this.sexTextBox.TabIndex = 14;
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
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.dataSet1;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(537, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 65);
            this.button3.TabIndex = 25;
            this.button3.Text = "Руководители аспирантов";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // graduateStudentDataGridView
            // 
            this.graduateStudentDataGridView.AutoGenerateColumns = false;
            this.graduateStudentDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.graduateStudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.graduateStudentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.graduateStudentDataGridView.DataSource = this.graduateStudentBindingSource;
            this.graduateStudentDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.graduateStudentDataGridView.Location = new System.Drawing.Point(0, 0);
            this.graduateStudentDataGridView.Name = "graduateStudentDataGridView";
            this.graduateStudentDataGridView.Size = new System.Drawing.Size(800, 220);
            this.graduateStudentDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdTeacherTitle";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id Главного руководителя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn7.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(288, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 66);
            this.button2.TabIndex = 27;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(288, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 65);
            this.button1.TabIndex = 26;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idTeacherTitleTextBox
            // 
            this.idTeacherTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.graduateStudentBindingSource, "IdTeacherTitle", true));
            this.idTeacherTitleTextBox.Location = new System.Drawing.Point(157, 227);
            this.idTeacherTitleTextBox.Name = "idTeacherTitleTextBox";
            this.idTeacherTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTeacherTitleTextBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 385);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 42;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(537, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 65);
            this.button4.TabIndex = 41;
            this.button4.Text = "Результат";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // GraduateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.idTeacherTitleTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(idTeacherTitleLabel);
            this.Controls.Add(lNameLabel);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(fNameLabel);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(sNameLabel);
            this.Controls.Add(this.sNameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexTextBox);
            this.Controls.Add(this.graduateStudentDataGridView);
            this.Name = "GraduateStudent";
            this.Text = "Аспиранты";
            this.Load += new System.EventHandler(this.GraduateStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graduateStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherWithTitleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graduateStudentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource graduateStudentBindingSource;
        private DataSet1TableAdapters.GraduateStudentTableAdapter graduateStudentTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox sNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.BindingSource teacherWithTitleBindingSource;
        private DataSet1TableAdapters.TeacherWithTitleTableAdapter teacherWithTitleTableAdapter;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private DataSet1TableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView graduateStudentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idTeacherTitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
    }
}