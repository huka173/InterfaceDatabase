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
    public partial class TeacherWithTitle : Form
    {
        public TeacherWithTitle()
        {
            InitializeComponent();
        }

        private void teacherWithTitleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teacherWithTitleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void TeacherWithTitle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.dataSet1.Teacher);
            // TODO: This line of code loads data into the 'dataSet1.TeacherWithTitle' table. You can move, or remove it, as needed.
            this.teacherWithTitleTableAdapter.Fill(this.dataSet1.TeacherWithTitle);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacherWithTitleBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teacherWithTitleBindingSource.EndEdit();
            teacherWithTitleTableAdapter.Update(dataSet1);
        }
    }
}
