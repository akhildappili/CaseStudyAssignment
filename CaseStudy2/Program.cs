using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fetchName;
            int iid;
            int aging;
            List<EmployeePromotion> employees = new List<EmployeePromotion>();
            
            char anotherUser= 'N';
            do
            {
                EmployeePromotion emp = new EmployeePromotion();
                emp.TakeEmployeeDetailsFromUser();
                employees.Add(emp);
                Console.WriteLine("");
                //int Enter = Convert.ToInt32(Console.ReadLine());
                // string next =Console.WriteLine("Enter Y or N");
                // string next = Console.WriteLine("Do you want to add another user (type Y for yes)?");
                Console.WriteLine("Enter 'Y' or 'N'");
                anotherUser = char.ToUpper(Console.ReadKey(false).KeyChar);
            } while (anotherUser == 'Y');
            /*
            foreach(EmployeePromotion emps in employees)
            {
                Console.WriteLine($"{emps.Name}");
            }
            */

            //sort of employee based on salary
            Console.WriteLine("Sorted list of employees based on salary");
            employees.Sort();
            foreach (EmployeePromotion emp in employees)
            {
                Console.WriteLine($"ID = {emp.Id}, Name = {emp.Name},  Gender = {emp.Age}, Salary = {emp.Salary}");
              
            }



            Console.WriteLine("Enter Employee Id");
            iid = Convert.ToInt32(Console.ReadLine());
            var findEmployee = employees.Where(emp=>emp.Id==iid);
            foreach(EmployeePromotion emps in findEmployee)
            {
                Console.WriteLine($" Employee Id:{emps.Id} \nEmployee Name:{emps.Name} \n Employee Age:{emps.Age} \n Employee Salary:{emps.Salary} ");
            }


            // Console.WriteLine(findEmployee);
            //emp.TakeEmployeeDetailsFromUser();
            //multiple employee names in a list
            Console.WriteLine("enter the name to fetch :");
            fetchName = Console.ReadLine();


            var multipleNames = from s in employees
                                where s.Name == fetchName
                                select s;

            foreach(EmployeePromotion emp in multipleNames)
            {
                Console.WriteLine($"Employee Id:{emp.Id} \nEmployee Name:{emp.Name} \n Employee Age:{emp.Age} \n Employee Salary:{emp.Salary}");
            }


            //find elder age than

            Console.WriteLine("enter Age ");
            aging = Convert.ToInt32(Console.ReadLine());

            var elderAge = from s in employees
                           where s.Age > aging
                           select s;
            foreach (EmployeePromotion emp in elderAge)
            {
                Console.WriteLine($"Employee Id:{emp.Id} \nEmployee Name:{emp.Name} \n Employee Age:{emp.Age} \n Employee Salary:{emp.Salary}");
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
