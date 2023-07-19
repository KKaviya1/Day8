using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    public class Employee
    {
        int id;
        string name;
        public Employee()
        {
            Console.WriteLine("constructor of Employee");
            id = -1;
            name = "not given";
        }

        public void Register()
        {
            Console.WriteLine("enter id:");
            id =int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("ID " + " : " + id);
            Console.WriteLine("Name" + " : " +name);
        }

    }

}

