 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationHard
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            int iid;
            int updateEmployee;
            List<Employee> employees = new List<Employee>();
            do
            {
                Console.WriteLine("1.Add Employee \n 2.MOdify \n 3.All Employee \n 4.Employee Details \n5.Exit ");

                

                    choice = Convert.ToInt32(Console.ReadLine());




                    switch (choice)
                    {
                        case 1:
                            char anotherUser = 'N';
                            do
                            {
                                Employee emp = new Employee();
                                emp.TakeEmployeeDetailsFromUser();

                                employees.Add(emp);
                                Console.WriteLine("");
                                //int Enter = Convert.ToInt32(Console.ReadLine());
                                // string next =Console.WriteLine("Enter Y or N");
                                // string next = Console.WriteLine("Do you want to add another user (type Y for yes)?");
                                Console.WriteLine("Enter 'Y' or 'N'");
                                anotherUser = char.ToUpper(Console.ReadKey(false).KeyChar);
                            } while (anotherUser == 'Y');
                            break;
                        case 2:
                            //update 
                            try
                            {
                                Console.WriteLine("Enter an Id of employee to update");
                                updateEmployee = Convert.ToInt32(Console.ReadLine());


                                Employee emp1 = employees.Find(s => s.Id == updateEmployee);

                                Console.WriteLine("Enter  new Id");
                                int newId = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("new Age");
                                int newAge = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("new name");
                                string newName = Console.ReadLine();
                                Console.WriteLine("new Salary");
                                int newSalary = Convert.ToInt32(Console.ReadLine());

                                emp1.Id = newId;
                                emp1.Name = newName;
                                emp1.Age = newAge;
                                emp1.Salary = newSalary;

                                throw new IdNotFoundEx("enter ID is not available ..plese try different id");
                            }
                            catch (IdNotFoundEx ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;
                        case 3:
                            //get all Employee details
                            foreach (Employee emps in employees)
                            {
                                Console.WriteLine($"ID = {emps.Id} \n Name = {emps.Name} \n  Gender = {emps.Age}  \n Salary = {emps.Salary}");
                            }
                            break;
                        case 4:
                            Console.WriteLine("enter id of employee");

                            try
                            {
                                iid = Convert.ToInt32(Console.ReadLine());
                                var findEmployee = employees.Where(emp2 => emp2.Id == iid);

                                foreach (Employee emps in findEmployee)
                                {
                                    Console.WriteLine($"Employee Id:{emps.Id} \nEmployee Name:{emps.Name} \n Employee Age:{emps.Age} \n Employee Salary:{emps.Salary}");
                                }

                                throw new IdNotFoundEx("enter ID is not available ..plese try different id");
                            }
                            catch (IdNotFoundEx ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;

                        case 5:
                            Console.WriteLine("Exit the Appilication");
                             Environment.Exit(1);
                            break;
                    }
                    Console.WriteLine("return here");
                Console.WriteLine("Enter valid input");
                
                } while (choice < 6) ;
             

            


                // The code provided will print ‘Hello World’ to the console.
                // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.


                // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 



                Console.WriteLine("Hello World!");
                Console.ReadKey();
        }
    }
}
