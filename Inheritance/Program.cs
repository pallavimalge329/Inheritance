using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee
    {
        // member attributes
        public string EmployeeId;
        public string EmployeeName;
        public int age;
        public float weight;
        // noargs constructor
        public Employee() { }
        // parameterized constructor 

        public Employee(string EmployeeId, string name, int age, float weight)
        {
            // to resolve the conflict 
            this.EmployeeId = EmployeeId;
            EmployeeName = name;
            this.age = age;
            this.weight = weight;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor Demo!");
            // default constructor
            Employee emp = new Employee();
            Console.WriteLine(emp.EmployeeId);
            Console.WriteLine(emp.EmployeeName);
            Console.WriteLine(emp.age);
            Console.WriteLine(emp.weight);

            // calling parameterized constructor
            Employee emp1 = new Employee("E001", "Pallavi", 23, 47.5F);
            Console.WriteLine(emp1.EmployeeId);
            Console.WriteLine(emp1.EmployeeName);
            Console.WriteLine(emp1.age);
            Console.WriteLine(emp1.weight);
            Console.ReadKey();
        }
    }

    }
