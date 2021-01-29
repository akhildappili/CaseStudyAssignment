using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            Employee[] emp = new Employee[n] ;

            List<Employee> employeeList = new List<Employee>();

            for(int i = 0; i < emp.Length; i++)
            {
               emp[i] = new Employee();
                emp[i].TakeEmployeeDetailsFromUser();
                //emp[i].ToString();
                employeeList.Add(emp[i]);
            }

            foreach(var r in employeeList)
            {
                Console.WriteLine($"Employee names are {r.Name}");
            }

            //employeeList.IndexOf(ab => ab.Name);

            //list for employee on sorted order


            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.



            //indexof() //edited one
            Console.WriteLine("hello siri");
            
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 

        }
    }
}
