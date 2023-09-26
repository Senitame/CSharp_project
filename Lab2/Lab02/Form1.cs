using System.Windows.Forms;

namespace Lab02
{
    public partial class Form1 : Form
    {
        private List<Student> _list;

        public Form1()
        {
            InitializeComponent();
            _list = new List<Student>();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] linesStudent = File.ReadAllLines(@"list.txt");
                string[] linesTeacher = File.ReadAllLines(@"teachers.txt");

                IEnumerable<string> scoreQuery1 =
                from name in linesStudent
                let nameFields = name.Split(',')
                from id in linesTeacher
                let scoreFields = id.Split(',')
                where Convert.ToInt32(Convert.ToInt32(nameFields[3])) == Convert.ToInt32(scoreFields[2])
                select nameFields[0]
                       + ","
                       + nameFields[1]
                       + ","
                       + nameFields[2]
                       + ","
                       + nameFields[3]
                       + ","
                       + nameFields[4]
                       + ", "
                       + scoreFields[0]
                       + ","
                       + scoreFields[1];

                File.WriteAllLines("result.txt", scoreQuery1);

                string[] lines = File.ReadAllLines(@"result.txt");
                // StLastName, StFirstName,Grade,Classroom,Bus,TLastName,TFirstName
                // COOKUS[0], XUAN[1], 3[2], 107[3], 52[4],
                // FAFARD[0], ROCIO[1], 107[2]
                foreach (string line in lines)
                {
                    string[] data = line.Split(new char[] { ',' }, StringSplitOptions.TrimEntries);
                    Student student = new Student()
                    {
                        StLastName = data[0],
                        StFirstName = data[1],
                        Grade = int.Parse(data[2]),
                        Classroom = int.Parse(data[3]),
                        Bus = int.Parse(data[4]),
                        TLastName = data[5],
                        TFirstName = data[6]
                    };
                    _list.Add(student);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            statusStrip1.Items[1].Text = _list.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "";

            foreach (var item in _list)
            {
                var stSurname = tbLastName1.Text.Trim();
                if (item.StLastName == stSurname)
                {
                    richTextBoxResult.Text += item.ToStringStudentClassTeacher();
                    break;
                }
            }
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "";
            foreach (var item in _list)
            {
                var stSurname = tbLastName2.Text.Trim();
                if (item.StLastName == stSurname)
                {
                    richTextBoxResult.Text += item.ToStringStudentBus();
                    break;
                }
            }
        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "";

            foreach (var item in _list)
            {
                var tSurname = tbTeacherLastName.Text.Trim();
                if (item.TLastName == tSurname)
                {
                    richTextBoxResult.Text += item.ToStringStudentTeacher();
                }
            }
        }

        private void buttonTask4_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "";

            var numBus = int.Parse(tbNumBus.Text.Trim());

            var uniqueStudents = _list
            .Where(item => item.Bus == numBus)
            .GroupBy(item => $"{item.StFirstName} {item.StLastName}")
            .Select(group => group.First());

            foreach (var item in uniqueStudents)
            {
                richTextBoxResult.Text += item.ToStringBusStudent();
            }
        }

        private void buttonTask5_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "";

            var Rating = int.Parse(tbGrade.Text.Trim());

            var uniqueStudents = _list
            .Where(item => item.Grade == Rating)
            .GroupBy(item => $"{item.StFirstName} {item.StLastName}")
            .Select(group => group.First());


            foreach (var item in uniqueStudents)
            {
                richTextBoxResult.Text += item.ToStringGradeStudent();
            }
        }

        private void buttonTask6_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "";

            var Class = int.Parse(tbClass.Text.Trim());

            var uniqueStudents = _list
            .Where(item => item.Classroom == Class)
            .GroupBy(item => $"{item.StFirstName} {item.StLastName}")
            .Select(group => group.First());


            foreach (var item in uniqueStudents)
            {
                richTextBoxResult.Text += item.ToStringClassStudent();
            }
        }

        private void buttonTask7_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "";

            var Class = int.Parse(tbClass.Text.Trim());

            var uniqueTaechers = _list
            .Where(item => item.Classroom == Class)
            .GroupBy(item => $"{item.TFirstName} {item.TLastName}")
            .Select(group => group.First());


            foreach (var item in uniqueTaechers)
            {
                richTextBoxResult.Text += item.ToStringClassTaecher();
            }
        }

        private void buttonTask8_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "";

            var Rating = int.Parse(tbRating.Text.Trim());

            var uniqueStudents = _list
            .Where(item => item.Grade == Rating)
            .GroupBy(item => $"{item.TFirstName} {item.TLastName}")
            .Select(group => group.First());


            foreach (var item in uniqueStudents)
            {
                richTextBoxResult.Text += item.ToStringGradeTaecher();
            }

        }
    }
}