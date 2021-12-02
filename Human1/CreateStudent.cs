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
    public partial class CreateStudent : Form
    {
        public CreateStudent()
        {
            InitializeComponent();
        }

        private void CreateStudent_Load(object sender, EventArgs e)
        {
            createCombobox();
        }
        private void createCombobox()
        {

            for (int i = 0; i < t_list.teachers.Count; i++)
            {
                comboBox1.Items.Add(t_list.teachers[i].Name + " " + t_list.teachers[i].Surname);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1Name.Text;
            string surname = textBox1Surname.Text;
            int age = int.Parse(textBox1Age.Text);
            int id = int.Parse(textBox1Grade.Text);
            int grade = int.Parse(textBox1ID.Text);
            string country = textBox1Country.Text;
            string region = textBox1Region.Text;
            string city = textBox1Sity.Text;
            string street = textBox1Street.Text;
            Address address = new Address(country, region, city, street);
            Student std = new Student(name, surname, age, id, grade, address);
            for (int i = 0; i < t_list.teachers.Count; i++)
            {

                if (comboBox1.SelectedItem.ToString() == t_list.teachers[i].Name + " " + t_list.teachers[i].Surname)
                {
                    t_list.teachers[i].Add(std);
                    MessageBox.Show("Success");
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1Name_Click(object sender, EventArgs e)
        {
            textBox1Name.Text = " ";
        }

        private void textBox1Name_Leave(object sender, EventArgs e)
        {
            if (textBox1Name.Text == " ")
            {
                textBox1Name.Text = "Name";
            }
        }
        private void textBox1Surname_Click(object sender, EventArgs e)
        {
            textBox1Surname.Text = " ";
        }
        private void textBox1Surname_Leave(object sender, EventArgs e)
        {
            if (textBox1Surname.Text == " ")
            {
                textBox1Surname.Text = "Surname";
            }
        }
        private void textBox1Age_Click(object sender, EventArgs e)
        {
            textBox1Age.Text = " ";
        }
        private void textBox1Age_Leave(object sender, EventArgs e)
        {
            if (textBox1Age.Text == " ")
            {
                textBox1Age.Text = "Age";
            }
        }

        private void textBox1ID_Leave(object sender, EventArgs e)
        {
            if (textBox1Grade.Text == " ")
            {
                textBox1Grade.Text = "ID";
            }
        }
        private void textBox1ID_Click(object sender, EventArgs e)
        {
            textBox1Grade.Text = " ";
        }
        private void textBox1Country_Leave(object sender, EventArgs e)
        {
            if (textBox1Country.Text == " ")
            {
                textBox1Country.Text = "Country";
            }
        }
        private void textBox1Country_Click(object sender, EventArgs e)
        {
            textBox1Country.Text = " ";
        }
        private void textBox1Region_Leave(object sender, EventArgs e)
        {
            if (textBox1Region.Text == " ")
            {
                textBox1Region.Text = "Region";
            }
        }
        private void textBox1Region_Click(object sender, EventArgs e)
        {
            textBox1Region.Text = " ";
        }
        private void textBox1Sity_Leave(object sender, EventArgs e)
        {
            if (textBox1Sity.Text == " ")
            {
                textBox1Sity.Text = "Sity";
            }
        }
        private void textBox1Sity_Click(object sender, EventArgs e)
        {
            textBox1Sity.Text = " ";
        }
        private void textBox1Street_Leave(object sender, EventArgs e)
        {
            if (textBox1Street.Text == " ")
            {
                textBox1Street.Text = "Street";
            }
        }
        private void textBox1Street_Click(object sender, EventArgs e)
        {
            textBox1Street.Text = " ";
        }
        private void textBox1Grade_Leave(object sender, EventArgs e)
        {
            if (textBox1Grade.Text == " ")
            {
                textBox1Grade.Text = "Grade";
            }
        }
        private void textBox1Grade_Click(object sender, EventArgs e)
        {
            textBox1Grade.Text = " ";
        }

    }
}
