using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Discipline discipline = new Discipline();
            discipline.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GraduateStudent gs = new GraduateStudent();
            gs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lecture lecture = new Lecture();
            lecture.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Load load = new Load();
            load.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Semestr sem = new Semestr();
            sem.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Stream stream = new Stream();
            stream.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TeacherDiscipline td = new TeacherDiscipline();
            td.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TeacherWithTitle tw = new TeacherWithTitle();
            tw.Show();
        }
    }
}
