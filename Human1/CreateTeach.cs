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
    public partial class CreateTeach : Form
    {
        public CreateTeach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            int age = int.Parse(textBoxAge.Text);
            int id = int.Parse(textBoxID.Text);
            string country = textBoxCountry.Text;
            string region = textBoxRegion.Text;
            string city = textBoxCity.Text;
            string street = textBoxStreet.Text;
            Address address = new Address(country, region, city, street);
            Teacher tcher = new Teacher(name, surname, age, id, address);

            t_list.teachers.Add(tcher);
            MessageBox.Show("Success");
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "Name";
            }
        }
        private void textBoxSurname_Click(object sender, EventArgs e)
        {
            textBoxSurname.Text = "";
        }
        private void textBoxSurname_Leave(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == "")
            {
                textBoxSurname.Text = "Surname";
            }
        }
        private void textBoxAge_Click(object sender, EventArgs e)
        {
            textBoxAge.Text = "";
        }
        private void textBoxAge_Leave(object sender, EventArgs e)
        {
            if (textBoxAge.Text == "")
            {
                textBoxAge.Text = "Age";
            }
        }

        private void textBoxID_Leave(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                textBoxID.Text = "ID";
            }
        }
        private void textBoxID_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
        }
        private void textBoxCountry_Leave(object sender, EventArgs e)
        {
            if (textBoxCountry.Text == "")
            {
                textBoxCountry.Text = "Country";
            }
        }
        private void textBoxCountry_Click(object sender, EventArgs e)
        {
            textBoxCountry.Text = "";
        }
        private void textBoxRegion_Leave(object sender, EventArgs e)
        {
            if (textBoxRegion.Text == "")
            {
                textBoxRegion.Text = "Region";
            }
        }
        private void textBoxRegion_Click(object sender, EventArgs e)
        {
            textBoxRegion.Text = "";
        }
        private void textBoxSity_Leave(object sender, EventArgs e)
        {
            if (textBoxCity.Text == "")
            {
                textBoxCity.Text = "Sity";
            }
        }
        private void textBoxSity_Click(object sender, EventArgs e)
        {
            textBoxCity.Text = "";
        }
        private void textBoxStreet_Leave(object sender, EventArgs e)
        {
            if (textBoxStreet.Text == "")
            {
                textBoxStreet.Text = "Street";
            }
        }
        private void textBoxStreet_Click(object sender, EventArgs e)
        {
            textBoxStreet.Text = "";
        }

        private void CreateTeach_Load(object sender, EventArgs e)
        {

        }
    }
}
