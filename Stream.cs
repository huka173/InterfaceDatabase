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
    public partial class Stream : Form
    {
        public Stream()
        {
            InitializeComponent();
        }

        private void streamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.streamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Stream_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Stream' table. You can move, or remove it, as needed.
            this.streamTableAdapter.Fill(this.dataSet1.Stream);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            streamBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            streamBindingSource.EndEdit();
            streamTableAdapter.Update(dataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < streamDataGridView.Rows.Count; i++)
            {
                streamDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < streamDataGridView.ColumnCount; j++)
                {
                    if (streamDataGridView.Rows[i].Cells[j].Value != null)
                    {
                        if (streamDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            streamDataGridView.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
