using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //concepts of OOP 


            List<Course> CourseList = new List<Course>(); //array list of course class

            for (int i = 1; i <= 3; i++)
            {
                //code will execute three times, due to parameters defined in for loop
                Console.WriteLine("Please enter the class ID:");
                string cid = Console.ReadLine();

                Console.WriteLine("Please enter the class name:");
                string cname = Console.ReadLine();

                Console.WriteLine("Please enter the number of credit hours:");
                int ch = int.Parse(Console.ReadLine());

                Course temp = new Course(cid, cname, ch); //this would create a new object from the Course class with the user input as variables.

                CourseList.Add(temp); //c1 can be repeated because it is just getting added to the CourseList array list. 
                //once you add an object to an array list(collection), it now has an index, which itself posesses three variables.
                
                //can also be written as one line like: CourseList.Add(new Course(cid, cname, ch)); (this just has the arguments, no need for name, as this is negatable)

                // **if an object is a part of another object, itis called AGGREGATION or COMPOSITION (or Has-a). **
            }

            foreach (Course Element in CourseList)
            {
                Console.WriteLine(Element.CID.PadRight(8, ' ')+"\t"+Element.Name.PadRight(8, ' ')+"\t"+Element.CreditHours);
                //here, we are printing the properties for each Element (Course temp) in CourseList. The constructors are no longer relevant. 
            }

            // Course Math101 = new Course("M101", "Intro to Math", 3);

            //new object created from Course class with variables (2 strings and 1 int, as declared in Course class).

            //instead of having fixed variables, you can also ask for the user's input:


        }
    }
}
