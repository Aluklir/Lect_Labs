using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void CreateTeacher()
        {
            Address address = new Address("Украина", "Херсонская область", "Херсон", "Университетская");
            Teacher t = new Teacher("Максим", "Павлович", 28, 400, address);
            Teacher t1 = new Teacher("Валентина", "Семёновна", 40, 401, address);


            Student p1 = new Student("Анна", "Винокурова", 18, 12, 4, address);
            Student p2 = new Student("Сергей", "Никитин", 20, 13, 3, address);
            Student p3 = new Student("Тимофей", "Михеев", 18, 14, 5, address);
            Student p4 = new Student("Михаил", "Мельников", 19, 15, 2, address);

            t_list.teachers.Add(t);
            t_list.teachers.Add(t1);

            t_list.teachers[0].Add(p1);
            t_list.teachers[1].Add(p2);
            t_list.teachers[0].Add(p3);
            t_list.teachers[1].Add(p4);


        }
        
        private void CreateDT()
        {
            List<Student> std1 = std();

            DataTable tab = new DataTable();
            tab.Columns.Add("Name");
            tab.Columns.Add("Surname");
            tab.Columns.Add("Age");
            tab.Columns.Add("ID");
            tab.Columns.Add("Grade");
            tab.Columns.Add("Country");
            tab.Columns.Add("Region");
            tab.Columns.Add("City");
            tab.Columns.Add("Street");


            foreach (Student i in std1)
            {
                tab.Rows.Add(i.Name, i.Surname, i.Age, i.ID, i.Grade , i.Adress.Country, i.Adress.Region, i.Adress.Sity, i.Adress.Street);
            }
            dataGridView1.DataSource = tab;
        }

        private void CreateDT(List<Teacher> tch)
        {
            DataTable tab = new DataTable();
            tab.Columns.Add("Name");
            tab.Columns.Add("Surname");
            tab.Columns.Add("Age");
            tab.Columns.Add("ID");
            tab.Columns.Add("Country");
            tab.Columns.Add("Region");
            tab.Columns.Add("City");
            tab.Columns.Add("Street");


            foreach (Teacher i in tch)
            {
                tab.Rows.Add(i.Name, i.Surname, i.Age, i.ID, i.Adress.Country, i.Adress.Region, i.Adress.Sity, i.Adress.Street);

            }
            dataGridView2.DataSource = tab;
        }
        private void CreateComboBox()
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < t_list.teachers.Count; i++)
            {
                comboBox1.Items.Add(t_list.teachers[i].Name + " " + t_list.teachers[i].Surname);
            }
        }
       

        private List<Student> std()
        {

            List<Student> std = new List<Student>();
            for (int i = 0; i < t_list.teachers.Count; i++)
            {
                List<Student> list = t_list.teachers[i].getList();
                for (int j = 0; j < list.Count; j++)
                {
                    std.Add(list[j]);
                }
            }
            return std;
        }
     

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateTeacher();
            CreateDT(t_list.teachers);
            CreateDT();
            CreateComboBox();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateTeach newForm = new CreateTeach();
            newForm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CreateStudent newForm = new CreateStudent();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDT();
            CreateDT(t_list.teachers);
            CreateComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            for (int i = 0; i < t_list.teachers.Count; i++)
            {

                if (comboBox1.SelectedItem.ToString() == t_list.teachers[i].Name + " " + t_list.teachers[i].Surname)
                {
                    List<Student> std1 = t_list.teachers[i].getList();
                    DataTable tab = new DataTable();
                    tab.Columns.Add("Name");
                    tab.Columns.Add("Surname");
                    tab.Columns.Add("Age");
                    tab.Columns.Add("ID");
                    tab.Columns.Add("Grade");
                    tab.Columns.Add("Country");
                    tab.Columns.Add("Region");
                    tab.Columns.Add("City");
                    tab.Columns.Add("Street");


                    foreach (Student a in std1)
                    {
                        tab.Rows.Add(a.Name, a.Surname, a.Age, a.ID, a.Grade, a.Adress.Country, a.Adress.Region, a.Adress.Sity, a.Adress.Street);
                    }
                    dataGridView3.DataSource = tab;
                }

            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
