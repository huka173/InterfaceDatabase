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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void teacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teacherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TeacherDiscipline' table. You can move, or remove it, as needed.
            this.teacherDisciplineTableAdapter.Fill(this.dataSet1.TeacherDiscipline);
            // TODO: This line of code loads data into the 'dataSet1.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.dataSet1.Teacher);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacherBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teacherBindingSource.EndEdit();
            teacherTableAdapter.Update(dataSet1);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
