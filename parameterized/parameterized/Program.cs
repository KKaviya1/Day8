using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterized
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student stud1 = new Student(12, "priya", new DateTime(day: 12, month: 9, year: 2010));
            //Student stud2 = new Student(13, "viya", new DateTime(day: 5, month: 4, year: 2001));
            //Console.WriteLine("** student one **");
            //stud1.Display();

            //Console.WriteLine("\n");

            //Console.WriteLine("** student two **");
            //stud2.Display();

            //Console.ReadKey();



            Student student = new Student();
            student.Display();

            Student stud1 = new Student(13, "viya", new DateTime(day: 5, month: 4, year: 2001));
            
            stud1.Display();

            Console.ReadKey();
        }
    }
}
