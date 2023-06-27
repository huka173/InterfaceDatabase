namespace Database
{
    partial class Semestr
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
            System.Windows.Forms.Label nameSemestrLabel;
            this.dataSet1 = new Database.DataSet1();
            this.semestrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.semestrTableAdapter = new Database.DataSet1TableAdapters.SemestrTableAdapter();
            this.tableAdapterManager = new Database.DataSet1TableAdapters.TableAdapterManager();
            this.semestrDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSemestrTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            nameSemestrLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestrDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameSemestrLabel
            // 
            nameSemestrLabel.AutoSize = true;
            nameSemestrLabel.Location = new System.Drawing.Point(306, 9);
            nameSemestrLabel.Name = "nameSemestrLabel";
            nameSemestrLabel.Size = new System.Drawing.Size(109, 13);
            nameSemestrLabel.TabIndex = 3;
            nameSemestrLabel.Text = "Название семестра";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // semestrBindingSource
            // 
            this.semestrBindingSource.DataMember = "Semestr";
            this.semestrBindingSource.DataSource = this.dataSet1;
            // 
            // semestrTableAdapter
            // 
            this.semestrTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.GraduateStudentTableAdapter = null;
            this.tableAdapterManager.LectureTableAdapter = null;
            this.tableAdapterManager.LoadTableAdapter = null;
            this.tableAdapterManager.SemestrTableAdapter = this.semestrTableAdapter;
            this.tableAdapterManager.StreamTableAdapter = null;
            this.tableAdapterManager.TeacherDisciplineTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.TeacherWithTitleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Database.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // semestrDataGridView
            // 
            this.semestrDataGridView.AutoGenerateColumns = false;
            this.semestrDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.semestrDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.semestrDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.semestrDataGridView.DataSource = this.semestrBindingSource;
            this.semestrDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.semestrDataGridView.Location = new System.Drawing.Point(0, 0);
            this.semestrDataGridView.Name = "semestrDataGridView";
            this.semestrDataGridView.Size = new System.Drawing.Size(300, 418);
            this.semestrDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NameSemestr";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название семестра";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // nameSemestrTextBox
            // 
            this.nameSemestrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.semestrBindingSource, "NameSemestr", true));
            this.nameSemestrTextBox.Location = new System.Drawing.Point(429, 6);
            this.nameSemestrTextBox.Name = "nameSemestrTextBox";
            this.nameSemestrTextBox.Size = new System.Drawing.Size(110, 20);
            this.nameSemestrTextBox.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(306, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 66);
            this.button2.TabIndex = 29;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(306, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 65);
            this.button1.TabIndex = 28;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 37;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(306, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 65);
            this.button3.TabIndex = 36;
            this.button3.Text = "Результат";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Semestr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(545, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameSemestrLabel);
            this.Controls.Add(this.nameSemestrTextBox);
            this.Controls.Add(this.semestrDataGridView);
            this.Name = "Semestr";
            this.Text = "Семестр";
            this.Load += new System.EventHandler(this.Semestr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestrDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource semestrBindingSource;
        private DataSet1TableAdapters.SemestrTableAdapter semestrTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView semestrDataGridView;
        private System.Windows.Forms.TextBox nameSemestrTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}