using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> dictionaryEmployees = new Dictionary<int, Employee>();

            char anotherUser = 'N';
            do
            {
                Employee emp = new Employee();
                emp.TakeEmployeeDetailsFromUser();
                dictionaryEmployees.Add(emp.Id,emp);
                
                Console.WriteLine("");
                //int Enter = Convert.ToInt32(Console.ReadLine());
                // string next =Console.WriteLine("Enter Y or N");
                // string next = Console.WriteLine("Do you want to add another user (type Y for yes)?");
                Console.WriteLine("Enter 'Y' or 'N'");
                anotherUser = char.ToUpper(Console.ReadKey(false).KeyChar);
            } while (anotherUser == 'Y');

            /*
           // Console.WriteLine("All Employees keys and values in employee dictionary");
            foreach (KeyValuePair<int, Employee> employeeKeyValuePair in dictionaryEmployees)
            {
                Console.WriteLine("Key = " + employeeKeyValuePair.Key);
                Employee emp1 = employeeKeyValuePair.Value;
                Console.WriteLine($"ID = {emp1.Id}, Name = {emp1.Name}, Age ={emp1.Age}, Salary = {emp1.Salary}");
                               
            }
            */
            Console.WriteLine("please enter Employee id ");
            int findId = Convert.ToInt32(Console.ReadLine());         
            Employee emp1 = dictionaryEmployees[findId];
            Console.WriteLine($"Employee Id:{emp1.Id} \n Employee Name:{emp1.Name} \n Employee Age:{emp1.Age} \n Employee Salary:{emp1.Salary}");
            


            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
