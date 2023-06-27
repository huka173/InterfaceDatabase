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
    public partial class Semestr : Form
    {
        public Semestr()
        {
            InitializeComponent();
        }

        private void semestrBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.semestrBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Semestr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Semestr' table. You can move, or remove it, as needed.
            this.semestrTableAdapter.Fill(this.dataSet1.Semestr);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            semestrBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            semestrBindingSource.EndEdit();
            semestrTableAdapter.Update(dataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < semestrDataGridView.Rows.Count; i++)
            {
                semestrDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < semestrDataGridView.ColumnCount; j++)
                {
                    if (semestrDataGridView.Rows[i].Cells[j].Value != null)
                    {
                        if (semestrDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            semestrDataGridView.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
