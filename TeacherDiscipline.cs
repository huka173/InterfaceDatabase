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
    public partial class TeacherDiscipline : Form
    {
        public TeacherDiscipline()
        {
            InitializeComponent();
        }

        private void teacherDisciplineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teacherDisciplineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void TeacherDiscipline_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Discipline' table. You can move, or remove it, as needed.
            this.disciplineTableAdapter.Fill(this.dataSet1.Discipline);
            // TODO: This line of code loads data into the 'dataSet1.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.dataSet1.Teacher);
            // TODO: This line of code loads data into the 'dataSet1.TeacherDiscipline' table. You can move, or remove it, as needed.
            this.teacherDisciplineTableAdapter.Fill(this.dataSet1.TeacherDiscipline);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacherDisciplineBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teacherDisciplineBindingSource.EndEdit();
            teacherDisciplineTableAdapter.Update(dataSet1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
