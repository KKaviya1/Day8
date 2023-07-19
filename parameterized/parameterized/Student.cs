using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterized
{
    public class Student
    {
        //readonly int id;    
        //readonly string name;
        //readonly DateTime dob;
        //public Student(int id, string name, DateTime dob)
        //{ 
        //    Console.WriteLine("parameterized constructor of student\n");
        //    this.id = id;
        //    this.name = name;
        //    this.dob = dob;
        //}
        //public void Display() 
        //{
        //    Console.WriteLine("student details as follows !!");
        //    Console.WriteLine("ID:->" + id + "\t Name:->" + name + "\t Date of Birth:->" + dob);



        int id;
        string name;
        DateTime dob;

        public Student()
        {
            Console.WriteLine("parameterized constructor of student\n");
            id = -1;
            name = "not given";
            dob = DateTime.Now;
        }

        public Student(int id, string name, DateTime dob)
        {
            Console.WriteLine("parameterized constructor of student\n");
            this.id = id;
            this.name = name;
            this.dob = dob;
        }

        public void Display()
        {
            Console.WriteLine("student details as follows !!");
            Console.WriteLine("ID:->" + id + "\t Name:->" + name + "\t Date of Birth:->" + dob);

        }

    }
}
