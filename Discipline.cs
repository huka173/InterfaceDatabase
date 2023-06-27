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
    public partial class Discipline : Form
    {
        public Discipline()
        {
            InitializeComponent();
        }

        private void disciplineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.disciplineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Discipline' table. You can move, or remove it, as needed.
            this.disciplineTableAdapter.Fill(this.dataSet1.Discipline);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            disciplineBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disciplineBindingSource.EndEdit();
            disciplineTableAdapter.Update(dataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < disciplineDataGridView.Rows.Count; i++)
            {
                disciplineDataGridView.Rows[i].Selected = false;
                for(int j = 0; j < disciplineDataGridView.ColumnCount; j++)
                {
                    if (disciplineDataGridView.Rows[i].Cells[j].Value != null)
                    {
                        if (disciplineDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            disciplineDataGridView.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
