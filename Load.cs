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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void loadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Load_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.dataSet1.Teacher);
            // TODO: This line of code loads data into the 'dataSet1.Load' table. You can move, or remove it, as needed.
            this.loadTableAdapter.Fill(this.dataSet1.Load);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadBindingSource.EndEdit();
            loadTableAdapter.Update(dataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < loadDataGridView.Rows.Count; i++)
            {
                loadDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < loadDataGridView.ColumnCount; j++)
                {
                    if (loadDataGridView.Rows[i].Cells[j].Value != null)
                    {
                        if (loadDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            loadDataGridView.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
