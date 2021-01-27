using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationHard
{
    class Employee
    {
        int id, age;
        string name;
        double salary;

        public Employee()
        {
        }

        public Employee(int id, int age, string name, double salary)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.salary = salary;
        }

        public void TakeEmployeeDetailsFromUser()
        {
            Console.WriteLine("Please enter the employee ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the employee age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee salary");
            salary = Convert.ToDouble(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Employee ID : " + id + "\nName : " + name + "\nAge : " + age + "\nSalary : " + salary;
        }

        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }

        private static List<Employee> employees = new List<Employee>(); 

        /*
        public void DisplayMenu()
        {
            Console.WriteLine("1.Add Employee \n 2.MOdify \n 3.All Employee \n 4.Employee Details \n5.Exit ");
           int  ap = Convert.ToInt32(Console.Read());
            switch (ap)
            {
                case 1:
                    //Employee emp = new Employee();
                    employees.Add(emp);
                    break;
            }
        }
        */

    }
}
