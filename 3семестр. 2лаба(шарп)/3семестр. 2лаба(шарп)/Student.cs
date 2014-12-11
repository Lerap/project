using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3семестр._2лаба_шарп_
{
    class Student
    {      
        public string Name, Country, Studak, Surname;
        public double Average;
        public int Course;

        public void Writing()
        {
            StreamWriter W = File.AppendText("students.txt");
            W.Write(" Name: " + Name + "\n Surname: " + Surname + "\n Course: " + Course + "\n Country: " + Country + "\n Student's ticket: " + Studak + "\n Average mark: " + Average + "\n \n");
            W.Close();
        }

        public string Reading()
        {
            string tmp = File.ReadAllText("students.txt");
            return tmp;
        }

        public bool Search(string Surname, string Studak)
        {
            bool flag = false;
            bool flag1 = false;
            StreamReader R = File.OpenText("students.txt");
            string tmp;
            while ((tmp = R.ReadLine()) != null)
            {
                if(tmp == (" Surname: " + Surname))
                {
                    flag1 = true;
                }
                if ((tmp == (" Student's ticket: " + Studak)) && (flag1 == true))
                {
                    flag = true;
                    flag1 = false;
                }
            }
            return flag;
        }

        public int Counting()
        {
            bool flag1 = false;
            bool flag2 = false;
            int count = 0;
            StreamReader R = File.OpenText("students.txt");
            string tmp;

            while ((tmp = R.ReadLine()) != null)
            {
                if (tmp == (" Country: Ukraine"))
                {
                    flag1 = true;              
                }
                if (tmp == (" Course: 1") && (flag1 == true))
                {
                    flag2 = true;
                }
                if (tmp != (" Average mark: 5") && (flag2 == true))
                {
                    count++;
                    flag1 = false;
                    flag2 = false;
                }
            }
            return count;
        }
    }
}
