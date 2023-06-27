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
    public partial class Lecture : Form
    {
        public Lecture()
        {
            InitializeComponent();
        }

        private void lectureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lectureBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Lecture_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Stream' table. You can move, or remove it, as needed.
            this.streamTableAdapter.Fill(this.dataSet1.Stream);
            // TODO: This line of code loads data into the 'dataSet1.Discipline' table. You can move, or remove it, as needed.
            this.disciplineTableAdapter.Fill(this.dataSet1.Discipline);
            // TODO: This line of code loads data into the 'dataSet1.Semestr' table. You can move, or remove it, as needed.
            this.semestrTableAdapter.Fill(this.dataSet1.Semestr);
            // TODO: This line of code loads data into the 'dataSet1.Lecture' table. You can move, or remove it, as needed.
            this.lectureTableAdapter.Fill(this.dataSet1.Lecture);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List list = new List();
            list.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lectureBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lectureBindingSource.EndEdit();
            lectureTableAdapter.Update(dataSet1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lectureDataGridView.Rows.Count; i++)
            {
                lectureDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < lectureDataGridView.ColumnCount; j++)
                {
                    if (lectureDataGridView.Rows[i].Cells[j].Value != null)
                    {
                        if (lectureDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            lectureDataGridView.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
