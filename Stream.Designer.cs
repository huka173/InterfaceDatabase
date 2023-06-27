namespace Database
{
    partial class Stream
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
            System.Windows.Forms.Label nameStreamLabel;
            this.dataSet1 = new Database.DataSet1();
            this.streamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.streamTableAdapter = new Database.DataSet1TableAdapters.StreamTableAdapter();
            this.tableAdapterManager = new Database.DataSet1TableAdapters.TableAdapterManager();
            this.streamDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStreamTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            nameStreamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameStreamLabel
            // 
            nameStreamLabel.AutoSize = true;
            nameStreamLabel.Location = new System.Drawing.Point(246, 6);
            nameStreamLabel.Name = "nameStreamLabel";
            nameStreamLabel.Size = new System.Drawing.Size(95, 13);
            nameStreamLabel.TabIndex = 3;
            nameStreamLabel.Text = "Название потока";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // streamBindingSource
            // 
            this.streamBindingSource.DataMember = "Stream";
            this.streamBindingSource.DataSource = this.dataSet1;
            // 
            // streamTableAdapter
            // 
            this.streamTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.GraduateStudentTableAdapter = null;
            this.tableAdapterManager.LectureTableAdapter = null;
            this.tableAdapterManager.LoadTableAdapter = null;
            this.tableAdapterManager.SemestrTableAdapter = null;
            this.tableAdapterManager.StreamTableAdapter = this.streamTableAdapter;
            this.tableAdapterManager.TeacherDisciplineTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.TeacherWithTitleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Database.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // streamDataGridView
            // 
            this.streamDataGridView.AutoGenerateColumns = false;
            this.streamDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.streamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.streamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.streamDataGridView.DataSource = this.streamBindingSource;
            this.streamDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.streamDataGridView.Location = new System.Drawing.Point(0, 0);
            this.streamDataGridView.Name = "streamDataGridView";
            this.streamDataGridView.Size = new System.Drawing.Size(243, 403);
            this.streamDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NameStream";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название потока";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // nameStreamTextBox
            // 
            this.nameStreamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.streamBindingSource, "NameStream", true));
            this.nameStreamTextBox.Location = new System.Drawing.Point(346, 3);
            this.nameStreamTextBox.Name = "nameStreamTextBox";
            this.nameStreamTextBox.Size = new System.Drawing.Size(136, 20);
            this.nameStreamTextBox.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(249, 121);
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
            this.button1.Location = new System.Drawing.Point(249, 40);
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
            this.label1.Location = new System.Drawing.Point(249, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(291, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 37;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(249, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 65);
            this.button3.TabIndex = 36;
            this.button3.Text = "Результат";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Stream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(502, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameStreamLabel);
            this.Controls.Add(this.nameStreamTextBox);
            this.Controls.Add(this.streamDataGridView);
            this.Name = "Stream";
            this.Text = "Поток";
            this.Load += new System.EventHandler(this.Stream_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource streamBindingSource;
        private DataSet1TableAdapters.StreamTableAdapter streamTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView streamDataGridView;
        private System.Windows.Forms.TextBox nameStreamTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}