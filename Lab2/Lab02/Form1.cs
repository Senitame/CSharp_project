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
                string[] lines = File.ReadAllLines(@"students.txt");
                // StLastName, StFirstName,Grade,Classroom,Bus,TLastName,TFirstName
                // COOKUS,XUAN ,3 ,107,52,FAFARD,ROCIO
                foreach (string line in lines)
                {
                    string[] data = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
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
            //int count = 0;
            foreach (var item in _list)
            {
                var stSurname = tbLastName1.Text.Trim();
                if (item.StLastName == stSurname)
                {
                    richTextBoxResult.Text += item.ToStringStudentClassTeacher();
                    //count++;
                }
                //if (count > 500)
                //{
                //    break;
                //}
            }
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "";
            int count = 0;
            foreach (var item in _list)
            {
                var stSurname = tbLastName2.Text.Trim();
                if (item.StLastName == stSurname)
                {
                    richTextBoxResult.Text += item.ToStringStudentBus();
                    count++;
                }
                if (count > 500)
                {
                    break;
                }
            }
        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "";
            int count = 0;
            foreach (var item in _list)
            {
                var tSurname = tbTeacherLastName.Text.Trim();
                if (item.TLastName == tSurname)
                {
                    richTextBoxResult.Text += item.ToStringStudentTeacher();
                    count++;
                }
                if (count > 500)
                {
                    break;
                }
            }
        }

        private void buttonTask4_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "";
            int count = 0;
            foreach (var item in _list)
            {
                var numBus = int.Parse(tbNumBus.Text.Trim());
                if (item.Bus == numBus)
                {
                    richTextBoxResult.Text += item.ToStringBusStudent();
                    count++;
                }
                if (count > 500)
                {
                    break;
                }
            }
        }

        private void buttonTask5_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "";
            int count = 0;
            foreach (var item in _list)
            {
                var Rating = int.Parse(tbGrade.Text.Trim());
                if (item.Grade == Rating)
                {
                    richTextBoxResult.Text += item.ToStringGradeStudent();
                    count++;
                }
                if (count > 500)
                {
                    break;
                }
            }
        }
    }
}