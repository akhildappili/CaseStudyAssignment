using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyAssignment1
{


    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> listofstrings = new List<string>();
            string input = null;

            while ((input = Console.ReadLine()) != string.Empty)
            {
                listofstrings.Add(input);
            }


            //find index position
            Console.WriteLine("enter name");
            string name1 = Console.ReadLine();

             int pos=listofstrings.IndexOf(name1);
            Console.WriteLine($"index of {name1} is{pos} ");


            //3rd capacity and count in list
            Console.WriteLine($"current size of collection  is {listofstrings.Capacity}");
            Console.WriteLine($"size after removing those extra space is  {listofstrings.Count}");



            //4th place the list in ascending order
            Console.WriteLine("Before sorting");
            foreach(string emp in listofstrings)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("After Sorting");
            listofstrings.Sort();
            foreach(string emp in listofstrings)
            {
                Console.WriteLine(emp);
            }


            Console.ReadLine();

        }
    }
}

