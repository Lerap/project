using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3семестр._2лаба_шарп_
{
    public partial class Form1 : Form
    {
        Student st;

        public Form1()
        {
            InitializeComponent();
            st = new Student();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)  //country
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)  //name
        {

        }

        private void Tsurname_TextChanged(object sender, EventArgs e) //surname
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)  //studak
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)   //average
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)  //course
        {

        }

        private void button1_Click(object sender, EventArgs e)  //save button
        {
            st.Surname = surname.Text;
            st.Name = textBox3.Text;
            st.Country = textBox1.Text;
            st.Studak = textBox2.Text;
            st.Course = Convert.ToInt32(textBox7.Text);
            st.Average = Convert.ToDouble(textBox4.Text);
            st.Writing();
        }

        private void button3_Click(object sender, EventArgs e)  //Read button
        {
            read2.Text = st.Reading();

        }

        private void Bsearch_Click(object sender, EventArgs e)
        {
            if (st.Search(surname2.Text, studak2.Text) == true)
            {
                Lresult.Text = "Student was found";

            }
            else
            {
                Lresult.Text = "Student was not found";
            }
        }

        private void Lresult_Click(object sender, EventArgs e)
        {

        }

        private void Calculation_Click(object sender, EventArgs e)
        {
            calculation2.Text = st.Counting().ToString();
        }

        private void read2_Click(object sender, EventArgs e)
        {

        }

        private void surname2_TextChanged(object sender, EventArgs e)
        {

        }

        private void studak2_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculation2_Click(object sender, EventArgs e)
        {

        }
    }

}
