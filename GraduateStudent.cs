using Database.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class GraduateStudent : Form
    {
        public GraduateStudent()
        {
            InitializeComponent();
        }

        private void graduateStudentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.graduateStudentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void GraduateStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.dataSet1.Teacher);
            // TODO: This line of code loads data into the 'dataSet1.TeacherWithTitle' table. You can move, or remove it, as needed.
            this.teacherWithTitleTableAdapter.Fill(this.dataSet1.TeacherWithTitle);
            // TODO: This line of code loads data into the 'dataSet1.GraduateStudent' table. You can move, or remove it, as needed.
            this.graduateStudentTableAdapter.Fill(this.dataSet1.GraduateStudent);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List list = new List();
            list.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graduateStudentBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graduateStudentBindingSource.EndEdit();
            graduateStudentTableAdapter.Update(dataSet1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < graduateStudentDataGridView.Rows.Count; i++)
            {
                graduateStudentDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < graduateStudentDataGridView.ColumnCount; j++)
                {
                    if (graduateStudentDataGridView.Rows[i].Cells[j].Value != null)
                    {
                        if (graduateStudentDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            graduateStudentDataGridView.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
